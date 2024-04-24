using AntdUI;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;

namespace Sun_House
{
    public partial class FrmHouses : AntdUI.BaseForm
    {
        //initialise the map
        private void InitiatMap()
        {
            //initialise the gmap control
            GmapHousePosition.MapProvider = GMapProviders.GoogleHybridMap;
            GmapHousePosition.ShowCenter = false;
            GmapHousePosition.MinZoom = 1;
            GmapHousePosition.MaxZoom = 40;
            GmapHousePosition.Zoom = 5;
            GmapHousePosition.DragButton = MouseButtons.Left;
        }

        public FrmHouses()
        {
            InitializeComponent();
        }

        private void FrmHouses_Load(object sender, EventArgs e)
        {
            InitiatMap();
        }

        private void FrmHouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            GmapHousePosition.Manager.CancelTileCaching();
            GmapHousePosition.Dispose();
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
    }
}
