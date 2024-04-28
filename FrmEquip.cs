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

            if (txtNewDailyUse.Text.Replace(" ", "") == "" || txtNewDailyUse.Text == "0")
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
    }
}
