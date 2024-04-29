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
    public partial class FrmCalcul : AntdUI.BaseForm
    {
        //equipement datasource
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
            catch (Exception ex)
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
        public FrmCalcul()
        {
            InitializeComponent();
        }

        private void FrmCalcul_Load(object sender, EventArgs e)
        {
            //set the data source for the equipement list
            bsEquipement.DataSource = null;
            lstEquip.DataSource = null;
            bsEquipement.DataSource = DsEquip();
            lstEquip.DataSource = bsEquipement;
            lstEquip.DisplayMember = "desMachine";
            lstEquip.ValueMember = "machineId";
        }

        private void txtFindEquip_TextChanged(object sender, EventArgs e)
        {
            bsEquipement.Filter = string.Format("desMachine like '%{0}%'", txtFindEquip.Text);
        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            txtFindEquip.Clear();
            bsEquipement.RemoveFilter();
        }
    }
}
