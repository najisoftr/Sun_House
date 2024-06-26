﻿using AntdUI;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;

namespace Sun_House
{
    public partial class FrmHouses : AntdUI.BaseForm
    {
        //fill the cmbHouses 
        private DataTable DsHouses()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = "select * from houses order by desHouse";
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            dt.Clear();
            try
            {
                adapt.Fill(dt);
                cmd.Dispose();
                adapt.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("can't read houses table\n" + ex.Message, "DataBase error");
                cmd.Dispose();
                adapt.Dispose();
                dt.Dispose();
                this.Close();
            }
            return dt;
        }
        //initialise the map
        private void InitiatMap(GMapControl myMap)
        {
            //initialise the gmap control
            myMap.MapProvider = GMapProviders.GoogleHybridMap;
            myMap.ShowCenter = false;
            myMap.MinZoom = 1;
            myMap.MaxZoom = 40;
            myMap.Zoom = 5;
            myMap.DragButton = MouseButtons.Left;
        }

        public FrmHouses()
        {
            InitializeComponent();
        }

        private void FrmHouses_Load(object sender, EventArgs e)
        {
            //initiate the maps
            InitiatMap(GmapHousePosition);
            InitiatMap(gMapEditHouseLocation);
            //fill the combo of houses
            cmbHouse.DataSource = null;
            bsHouses.DataSource = null;
            bsHouses.DataSource = DsHouses();
            cmbHouse.DataSource = bsHouses;
            cmbHouse.DisplayMember = "desHouse";
            cmbHouse.ValueMember = "houseId";
            //event for changing current of the binding source of the combo of houses
            bsHouses.CurrentChanged += BsHouses_CurrentChanged;
            BsHouses_CurrentChanged(null, null);
            gMapEditHouseLocation.Zoom = 15;
        }



        private void BsHouses_CurrentChanged(object sender, EventArgs e)
        {
            //if the combo is empty clear all fields and reset the map
            if(bsHouses.Current==null)
            {
                clearFields();
                gMapEditHouseLocation.Overlays.Clear();
                InitiatMap(gMapEditHouseLocation);
                return;
            }

            //display house data from binding source
            txtDesHouse.Text = ((DataRowView)bsHouses.Current)["desHouse"].ToString();
            txtAddress.Text= ((DataRowView)bsHouses.Current)["houseAdress"].ToString();
            txtPanelAngle.Text= ((DataRowView)bsHouses.Current)["panelAngle"].ToString();
            txtPosX.Text= ((DataRowView)bsHouses.Current)["xPos"].ToString();
            txtPosY.Text= ((DataRowView)bsHouses.Current)["yPos"].ToString();
            txtRotAngle.Text= ((DataRowView)bsHouses.Current)["houseAngle"].ToString();
            //show location in the mapEdit
            //get the decimal separator to convert decimal to double
            var decSep = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string posY = null, posX = null;
            posX = txtPosX.Text.Replace(",", decSep);
            posX = txtPosX.Text.Replace(".", decSep);
            posY = txtPosY.Text.Replace(",", decSep);
            posY = txtPosY.Text.Replace(".", decSep);
            gMapEditHouseLocation.Position= new PointLatLng(Convert.ToDouble(posY), Convert.ToDouble(posX));
            GMapOverlay markersOverlay = new GMapOverlay("My House");
            GMarkerGoogle marker = new GMarkerGoogle(gMapEditHouseLocation.Position, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_pushpin);
            markersOverlay.Markers.Clear();
            markersOverlay.Markers.Add(marker);
            gMapEditHouseLocation.Overlays.Clear();
            gMapEditHouseLocation.Overlays.Add(markersOverlay);
            //refresh the map (zoom in and zoom out)
            double z = gMapEditHouseLocation.Zoom;
            gMapEditHouseLocation.Zoom = z + 0.5;
            gMapEditHouseLocation.Zoom = z;
            gMapEditHouseLocation.Update();
            gMapEditHouseLocation.Refresh();

        }

        private void clearFields()
        {
            txtAddress.Text = "";
            txtDesHouse.Text = "";
            txtPanelAngle.Text = "";
            txtPosX.Text = "";
            txtPosY.Text = "";
            txtRotAngle.Text = "";
        }

        private void FrmHouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            //unload the maps and cancel cache
            GmapHousePosition.Manager.CancelTileCaching();
            GmapHousePosition.Dispose();
            gMapEditHouseLocation.Manager.CancelTileCaching();
            gMapEditHouseLocation.Dispose();
        }

        private void GmapHousePosition_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            //get tje lang and the lat
            txtNewPosX.Text = pointClick.Lng.ToString();
            txtNewPosY.Text = pointClick.Lat.ToString();

            //set the marker
            var markOverlay = new GMapOverlay("MY House");
            GMarkerGoogle mark = new GMarkerGoogle(pointClick, GMarkerGoogleType.yellow_pushpin);
            markOverlay.Markers.Clear();
            markOverlay.Markers.Add(mark);
            GmapHousePosition.Overlays.Clear();
            GmapHousePosition.Overlays.Add(markOverlay);
            //refresh the map (zoom in and zoom out)
            double z = GmapHousePosition.Zoom;
            GmapHousePosition.Zoom = z + 0.5;
            GmapHousePosition.Zoom = z;
            //get the address if possible
            GeoCoderStatusCode status;
            Placemark? address = GMapProviders.GoogleMap.GetPlacemark(pointClick, out status);
            if (status == GeoCoderStatusCode.OK && address.HasValue)
            {
                txtNewAddress.Text = address.Value.Address;
            }
            
        }

        private void btnAddNewHouse_Click(object sender, EventArgs e)
        {
            //validate the form
            bool ok = true;
            errProv.Clear();
            if(txtNewDesHouse.Text.Replace(" ","")=="")
            {
                ok = false;
                errProv.SetError(txtNewDesHouse, "Required!");
            }

            if ((txtNewPosX.Text.Replace(" ", "") == "") || (txtNewPosX.Text=="0"))
            {
                ok = false;
                errProv.SetError(txtNewPosX, "Required!");
            }

            if (txtNewPosY.Text.Replace(" ", "") == "" || txtNewPosY.Text == "0")
            {
                ok = false;
                errProv.SetError(txtNewPosY, "Required!");
            }

            if (txtNewRotAngle.Text.Replace(" ", "") == "" || txtNewRotAngle.Text == "0")
            {
                ok = false;
                errProv.SetError(txtNewRotAngle, "Required!");
            }

            if (txtNewPanlAngle.Text.Replace(" ", "") == "" || txtNewPanlAngle.Text == "0")
            {
                ok = false;
                errProv.SetError(txtNewPanlAngle, "Required!");
            }

            if (!ok)
                return;
            //check for double
            SQLiteCommand cmdCount = new SQLiteCommand();
            cmdCount.Connection = myProcs.cn;
            cmdCount.CommandText = "select count(houseid) from houses where upper(replace(deshouse, ' ',''))=@paramDesHouse";
            cmdCount.Parameters.Clear();
            cmdCount.Parameters.AddWithValue("@paramDesHouse", txtNewDesHouse.Text.Replace(" ", "").ToUpper());
            int count = 0;
            try
            {
                count = Convert.ToInt32(cmdCount.ExecuteScalar());
            }
            catch(Exception ex)
            {
                Notification.error(this, "Database error", "Impossible to check double in house table" +
                    "\n" + ex.Message);
                cmdCount.Dispose();
                this.Close();
            }

            if(count>0)
            {
                cmdCount.Dispose();
                Notification.error(this, "Double house", "a house already exist with that name");
                txtNewDesHouse.Focus();
                txtNewDesHouse.SelectAll();
                return;
            }
            cmdCount.Dispose();
            //now add the new house
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection=myProcs.cn;
            cmd.CommandText = @"
insert into houses(desHouse,xPos, yPos, panelAngle, houseAngle, houseAdress) values
(@paramDesHouse, @paramXPose, @paramYPose, @paramPanelAngle, @paramHouseAngle, @paramHouseAdress)
";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramDesHouse", txtNewDesHouse.Text.Trim());
            cmd.Parameters.AddWithValue("@paramXPose", txtNewPosX.Text);
            cmd.Parameters.AddWithValue("@paramYPose", txtNewPosY.Text);
            cmd.Parameters.AddWithValue("@paramPanelAngle", txtNewPanlAngle.Text);
            cmd.Parameters.AddWithValue("@paramHouseAngle", txtNewRotAngle.Text);
            cmd.Parameters.AddWithValue("@paramHouseAdress", txtNewAddress.Text.Trim());
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex )
            {
                Notification.error(this, "Database error", "Impossible to add the new house" +
                    "\n" + ex.Message);
                cmd.Dispose();
                this.Close();
            }
            //update the combo of houses
            updateComboDs();
            //clear values and show success notification
            GmapHousePosition.Overlays.Clear();
            txtNewAddress.Text = "";
            txtNewDesHouse.Text = "";
            txtNewPanlAngle.Text = "";
            txtNewPosX.Text = "";
            txtNewPosY.Text = "";
            txtNewRotAngle.Text = "";
            Notification.success(this, "Success", "New house saved");
        }

        private void updateComboDs()
        {
            if (bsHouses.Count > 0)
            {
                string oldSelection = ((DataRowView)bsHouses.Current)["houseId"].ToString();
                cmbHouse.DataSource = null;
                bsHouses.DataSource = DsHouses();
                cmbHouse.DataSource = bsHouses;
                cmbHouse.DisplayMember = "desHouse";
                cmbHouse.ValueMember = "houseId";
                bsHouses.Position = bsHouses.Find("houseId", oldSelection);
            }
            else
            {
                cmbHouse.DataSource = null;
                bsHouses.DataSource = DsHouses();
                cmbHouse.DataSource = bsHouses;
                cmbHouse.DisplayMember = "desHouse";
                cmbHouse.ValueMember = "houseId";
            }
            
        }

        private void gMapEditHouseLocation_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            //get tje lang and the lat
            txtPosX.Text = pointClick.Lng.ToString();
            txtPosY.Text = pointClick.Lat.ToString();

            //set the marker
            var markOverlay = new GMapOverlay("MY House");
            GMarkerGoogle mark = new GMarkerGoogle(pointClick, GMarkerGoogleType.yellow_pushpin);
            markOverlay.Markers.Clear();
            markOverlay.Markers.Add(mark);
            gMapEditHouseLocation.Overlays.Clear();
            gMapEditHouseLocation.Overlays.Add(markOverlay);
            //refresh the map (zoom in and zoom out)
            double z = gMapEditHouseLocation.Zoom;
            gMapEditHouseLocation.Zoom = z + 0.5;
            gMapEditHouseLocation.Zoom = z;
            //get the address if possible
            GeoCoderStatusCode status;
            Placemark? address = GMapProviders.GoogleMap.GetPlacemark(pointClick, out status);
            if (status == GeoCoderStatusCode.OK && address.HasValue)
            {
                txtAddress.Text = address.Value.Address;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if the selection is empty
            if (bsHouses.Current == null)
            {
                Notification.warn(this, "Empty selection", "Please select a house in the list");
                cmbHouse.DroppedDown = true;
                return;
            }
            //validate values
            //validate the form
            bool ok = true;
            errProv2.Clear();
            if (txtDesHouse.Text.Replace(" ", "") == "")
            {
                ok = false;
                errProv2.SetError(txtDesHouse, "Required!");
            }

            if ((txtPosX.Text.Replace(" ", "") == "") || (txtPosX.Text == "0"))
            {
                ok = false;
                errProv2.SetError(txtPosX, "Required!");
            }

            if (txtPosY.Text.Replace(" ", "") == "" || txtPosY.Text == "0")
            {
                ok = false;
                errProv2.SetError(txtPosY, "Required!");
            }

            if (txtRotAngle.Text.Replace(" ", "") == "" || txtRotAngle.Text == "0")
            {
                ok = false;
                errProv2.SetError(txtRotAngle, "Required!");
            }

            if (txtPanelAngle.Text.Replace(" ", "") == "" || txtPanelAngle.Text == "0")
            {
                ok = false;
                errProv2.SetError(txtPanelAngle, "Required!");
            }

            if (!ok)
                return;

            //now check for double
            string selectedHouseId = null;
            selectedHouseId = ((DataRowView)bsHouses.Current)["houseId"].ToString();
            SQLiteCommand cmdCount = new SQLiteCommand();
            cmdCount.Connection = myProcs.cn;
            cmdCount.CommandText = @"select count(houseid) from houses where 
upper(replace(deshouse, ' ',''))=@paramDesHouse and houseId <> @paramHouseId";
            cmdCount.Parameters.Clear();
            cmdCount.Parameters.AddWithValue("@paramDesHouse", txtDesHouse.Text.Replace(" ", "").ToUpper());
            cmdCount.Parameters.AddWithValue("@paramHouseId", selectedHouseId);
            int count = 0;
            try
            {
                count = Convert.ToInt32(cmdCount.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Notification.error(this, "Database error", "Impossible to check double in house table" +
                    "\n" + ex.Message);
                cmdCount.Dispose();
                this.Close();
            }

            if (count > 0)
            {
                cmdCount.Dispose();
                Notification.error(this, "Double house", "a house already exist with that name");
                txtDesHouse.Focus();
                txtDesHouse.SelectAll();
                return;
            }
            cmdCount.Dispose();

            //now update the selected house
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = @"
update houses set desHouse = @paramDesHouse,
xPos = @paramXPose,
yPos = @paramYPose,
panelAngle = @paramPanelAngle,
houseAngle = @paramHouseAngle,
houseAdress = @paramHouseAdress
where houseId= @paramHouseId
";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramDesHouse", txtDesHouse.Text.Trim());
            cmd.Parameters.AddWithValue("@paramXPose", txtPosX.Text);
            cmd.Parameters.AddWithValue("@paramYPose", txtPosY.Text);
            cmd.Parameters.AddWithValue("@paramPanelAngle", txtPanelAngle.Text);
            cmd.Parameters.AddWithValue("@paramHouseAngle", txtRotAngle.Text);
            cmd.Parameters.AddWithValue("@paramHouseAdress", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@paramHouseId", selectedHouseId);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Notification.error(this, "Database error", "Impossible to update the selected house" +
                    "\n" + ex.Message);
                cmd.Dispose();
                this.Close();
            }
            //update the combo
            updateComboDs();
            ////show location in the mapEdit
            ////get the decimal separator to convert decimal to double
            //var decSep = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //string posY = null, posX = null;
            //posX = txtPosX.Text.Replace(",", decSep);
            //posX = txtPosX.Text.Replace(".", decSep);
            //posY = txtPosY.Text.Replace(",", decSep);
            //posY = txtPosY.Text.Replace(".", decSep);
            //gMapEditHouseLocation.Position = new PointLatLng(Convert.ToDouble(posY), Convert.ToDouble(posX));
            //GMapOverlay markersOverlay = new GMapOverlay("My House");
            //GMarkerGoogle marker = new GMarkerGoogle(gMapEditHouseLocation.Position, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_pushpin);
            //markersOverlay.Markers.Clear();
            //markersOverlay.Markers.Add(marker);
            //gMapEditHouseLocation.Overlays.Clear();
            //gMapEditHouseLocation.Overlays.Add(markersOverlay);
            ////refresh the map (zoom in and zoom out)
            //double z = gMapEditHouseLocation.Zoom;
            //gMapEditHouseLocation.Zoom = z + 0.5;
            //gMapEditHouseLocation.Zoom = z;
            //gMapEditHouseLocation.Update();
            //gMapEditHouseLocation.Refresh();
            //show success notification
            Notification.success(this, "Success", "Changes saved");

        }

        private void btnDelHouse_Click(object sender, EventArgs e)
        {
            //check for empty selection
            if (bsHouses.Current == null)
                return;
            //get the desHouse of the current house
            string currentHouse = ((DataRowView)bsHouses.Current)["desHouse"].ToString();
            if (MessageBox.Show("Do you really Want to remove # " + currentHouse + " ?\nWarning: All data of that " +
                "house will be deleted", "Confirmation required", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (MessageBox.Show("Really Really ???\nTHIS IS AN IRRIVERSIBLE OPERATION", "Confirmation OF CONFIRMATION", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            //get the current houseId
            string idCurrentHouse = ((DataRowView)bsHouses.Current)["houseId"].ToString();
            //delete the current house
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = "delete from houses where houseId=@paramHouseId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramHouseId", idCurrentHouse);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                cmd.Dispose();
                Notification.error(this, "DataBase Error", "can't delete the house\n" + ex.Message);
                this.Close();
            }
            updateComboDs();
        }
    }
}
