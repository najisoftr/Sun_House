using AntdUI;
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

namespace Sun_House
{
    public partial class FrmEquip : AntdUI.BaseForm
    {
        //datasource for the grid of equipements
        private DataTable DsEquip()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = "select * from machines";
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            DataTable tbl = new DataTable();
            tbl.Clear();
            try
            {
                adapt.Fill(tbl);
                cmd.Dispose();
                adapt.Dispose();
                return tbl;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible to read the table of equipements\n" + ex.Message,
                    "DataBase Error");
                cmd.Dispose();
                adapt.Dispose();
                tbl.Dispose();
                this.Close();
                return null;
            }
        }

        public FrmEquip()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //first validate the form
            bool ok = true;
            errProv1.Clear();

            if (txtNewCapacity.Text.Replace(" ","")==""  || txtNewCapacity.Text=="0")
            {
                ok = false;
                errProv1.SetError(txtNewCapacity, "Required!");
            }

            if (txtNewDailyUse.Text.Replace(" ", "") == "" || txtNewDailyUse.Text == "0" || Convert.ToDouble(myProcs.ReplaceDecimalSep(txtNewDailyUse.Text))>24)
            {
                ok = false;
                errProv1.SetError(txtNewDailyUse, "Required!");
            }

            if (txtNewDesEquip.Text.Replace(" ", "") == "")
            {
                ok = false;
                errProv1.SetError(txtNewDesEquip, "Required!");
            }

            if (txtNewWattPeak.Text.Replace(" ", "") == "")
            {
                ok = false;
                errProv1.SetError(txtNewWattPeak, "Required!");
            }

            if (!ok)
                return;

            //now check for double in desMachine
            SQLiteCommand cmdCount= new SQLiteCommand();
            cmdCount.Connection = myProcs.cn;
            cmdCount.CommandText = "select count(machineId) from machines where upper(replace(desMachine, ' ',''))=@paramDesMachine";
            cmdCount.Parameters.Clear();
            cmdCount.Parameters.AddWithValue("@paramDesMachine", txtNewDesEquip.Text.Replace(" ","").ToUpper());
            int count = 0;
            try
            {
                count=Convert.ToInt32(cmdCount.ExecuteScalar());
                cmdCount.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't check double for machine's name\n" + ex.Message, "DataBase Error");
                cmdCount.Dispose();
                this.Close();
            }
            if(count>=1)
            {
                Notification.warn(this, "Double value", "A machine already exist with the selected name");
                errProv1.SetError(txtNewDesEquip, "Double value!");
                return;
            }
            //now add the new equipement
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = @"
insert into machines(desMachine, electrCapacity, maxWat, dailyHoursWork)
values (@paramDesMachine, @paramElectrCapacity, @paramMaxWat, @paramDailyHoursWork)
";
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramDesMachine", txtNewDesEquip.Text.Trim());
            cmd.Parameters.AddWithValue("@paramElectrCapacity", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtNewCapacity.Text)));
            cmd.Parameters.AddWithValue("@paramMaxWat", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtNewWattPeak.Text)));
            cmd.Parameters.AddWithValue("@paramDailyHoursWork", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtNewDailyUse.Text)));
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible to add the new equipement\n" + ex.Message,
                    "DataBase Error");
                cmd.Dispose();
                this.Close();
            }
            //update the grid of equipements
            bsEquip.DataSource = DsEquip();
            Notification.success(this, "New equipement added", "succes");
            //clear values
            clearValues();
            txtNewDesEquip.Focus();

        }

        //clear new values
        private void clearValues()
        {
            txtNewCapacity.Clear();
            txtNewDailyUse.Clear();
            txtNewDesEquip.Clear();
            txtNewWattPeak.Clear();
        }

        private void FrmEquip_Load(object sender, EventArgs e)
        {
            //fill the grid of equipements
            grdEquip.AutoGenerateColumns = false;
            bsEquip.DataSource = null;
            bsEquip.DataSource = DsEquip();
            grdEquip.DataSource = null;
            grdEquip.DataSource = bsEquip;
            //set the event of currentchanged for the binding source of the grid
            bsEquip.CurrentChanged += BsEquip_CurrentChanged;
            BsEquip_CurrentChanged(null, null);
        }

        private void BsEquip_CurrentChanged(object sender, EventArgs e)
        {
            //if the selection is empty clear all fields
            if(bsEquip.Current==null)
            {
                txtCapacity.Clear();
                txtDailyUse.Clear();
                txtDesEquip.Clear();
                txtWattPeak.Clear();
                return;
            }
            //display values in specified fields
            //txtCapacity.Value = Convert.ToDecimal(((DataRowView)bsEquip.Current)["electrCapacity"].ToString());
            txtCapacity.Text = ((DataRowView)bsEquip.Current)["electrCapacity"].ToString();
            txtDailyUse.Text= ((DataRowView)bsEquip.Current)["dailyHoursWork"].ToString();
            txtDesEquip.Text= ((DataRowView)bsEquip.Current)["desMachine"].ToString();
            txtWattPeak.Text = ((DataRowView)bsEquip.Current)["maxWat"].ToString();
        }

        private void txtFindEquip_TextChanged(object sender, EventArgs e)
        {
            bsEquip.Filter=string.Format("desMachine like '%{0}%'", txtFindEquip.Text);
        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            txtFindEquip.Clear();
            bsEquip.RemoveFilter();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if the selection is empty do nothing
            if (bsEquip.Current == null)
                return;
            //validate the form
            bool ok = true;
            errProv2.Clear();

            if (txtCapacity.Text.Replace(" ", "") == "" || txtCapacity.Text == "0")
            {
                ok = false;
                errProv2.SetError(txtCapacity, "Required!");
            }

            if (txtDailyUse.Text.Replace(" ", "") == "" || txtDailyUse.Text == "0" || Convert.ToDouble(myProcs.ReplaceDecimalSep(txtDailyUse.Text)) > 24)
            {
                ok = false;
                errProv2.SetError(txtDailyUse, "Required!");
            }

            if (txtDesEquip.Text.Replace(" ", "") == "")
            {
                ok = false;
                errProv2.SetError(txtDesEquip, "Required!");
            }

            if (txtWattPeak.Text.Replace(" ", "") == "")
            {
                ok = false;
                errProv2.SetError(txtWattPeak, "Required!");
            }

            if (!ok)
                return;
            //get the id of the current equip
            string id = ((DataRowView)bsEquip.Current)["machineId"].ToString();
            //now check for double in desMachine
            SQLiteCommand cmdCount = new SQLiteCommand();
            cmdCount.Connection = myProcs.cn;
            cmdCount.CommandText = "select count(machineId) from machines where upper(replace(desMachine, ' ',''))=@paramDesMachine " +
                "and machineId <> @paramMachineId";
            cmdCount.Parameters.Clear();
            cmdCount.Parameters.AddWithValue("@paramDesMachine", txtDesEquip.Text.Replace(" ", "").ToUpper());
            cmdCount.Parameters.AddWithValue("@paramMachineId", id);
            int count = 0;
            try
            {
                count = Convert.ToInt32(cmdCount.ExecuteScalar());
                cmdCount.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't check double for machine's name\n" + ex.Message, "DataBase Error");
                cmdCount.Dispose();
                this.Close();
            }
            if (count >= 1)
            {
                Notification.warn(this, "Double value", "A machine already exist with the entered name");
                txtDesEquip.Focus();
                txtDesEquip.SelectAll();
                errProv2.SetError(txtDesEquip, "Double value!");
                return;
            }

            //now update the selected equipement
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = @"
update machines set 
desMachine=@paramDesMachine,
electrCapacity=@paramElectrCapacity,
maxWat=@paramMaxWat,
dailyHoursWork=@paramDailyHoursWork
where
machineId=@paramHouseId
";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramDesMachine", txtDesEquip.Text.Trim());
            cmd.Parameters.AddWithValue("@paramElectrCapacity", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtCapacity.Text)));
            cmd.Parameters.AddWithValue("@paramMaxWat", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtWattPeak.Text)));
            cmd.Parameters.AddWithValue("@paramDailyHoursWork", Convert.ToDouble(myProcs.ReplaceDecimalSep(txtDailyUse.Text)));
            cmd.Parameters.AddWithValue("@paramHouseId", id);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible to update the selected equipement\n" + ex.Message,
                    "DataBase Error");
                cmd.Dispose();
                this.Close();
            }
            //update the datasource and the grid
            bsEquip.DataSource = DsEquip();
            bsEquip.Position = bsEquip.Find("machineId", id);
            Notification.success(this, "Equipement updated", "succes");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if the slelection is empty, do nothing
            if (bsEquip.Current == null)
                return;

            //double confirmation
            if (MessageBox.Show("Do you realy want to remove that equipement?\nAll Data correspond that equipement will be deleted!!!",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (MessageBox.Show("Do you realy realy realy want to remove that equipement?",
                "Second Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            //remove the equipement
            //get the id of the selected equipement
            //get the id of the current equip
            string id = ((DataRowView)bsEquip.Current)["machineId"].ToString();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myProcs.cn;
            cmd.CommandText = "delete from machines where machineId=@paramMachineId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@paramMachineId", id);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible to remove the selected equipement!!!\n" + ex.Message,
                    "dataBase Error");
                cmd.Dispose();
                this.Close();
            }
            //update the equipement grid
            bsEquip.DataSource = DsEquip();
            Notification.success(this, "Equipement Removed", "Succes");
        }

        private void bsEquip_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            string bsCount = bsEquip.List.Count.ToString();
            lblBadge.Badge = bsCount;
        }

        private void bsEquip_ListChanged(object sender, ListChangedEventArgs e)
        {
            string bsCount = bsEquip.List.Count.ToString();
            lblBadge.Badge = bsCount;
        }
    }
}
