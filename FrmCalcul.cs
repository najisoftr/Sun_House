using AntdUI;
using Krypton.Toolkit;
using Sun_House.Models;
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
        //data source for the added equipements (list of Machine)
        List<Machine> Machines = new List<Machine>();
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
            //update the list of calculated equipements
            updateListCalculateEquip();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            //if selection is empty do nothing
            if (bsEquipement.Current == null)
                return;
            //add equipement to calculate
            //first check for double value (machineId)
            //get the selected machineId
            DataRowView currentMachine = ((DataRowView)bsEquipement.Current);

            string currentMachineId = currentMachine["machineId"].ToString();
            int count = (from m in Machines
                         where m.machineId == Convert.ToInt32(currentMachineId)
                         select m).Count();
            if(count>0)
            {
                Notification.error(this, "Double Equipement", "Equipement already added!");
                return;
            }
            //now input the number of machine
            string machineCount = KryptonInputBox.Show("How many?", "Equipement Count","1");
            if (machineCount.Replace(" ", "") == "")
            {
                Notification.warn(this, "Empty Value", "no action!");
                return;
            }
            //check if it's a correct value
            double machineCountNumerical = 0;
            if (!double.TryParse(machineCount, out machineCountNumerical))
            {
                MessageBox.Show("How many must be numerical", "Wrong value");
                return;
            }

            if(machineCountNumerical<=0)
            {
                Notification.warn(this, "Zero Value!", "No action!");
                return;
            }

            //now add the selected equipement to the calculate equipement
            Machine tempMachine = new Machine
            {
                machineId = Convert.ToInt32(currentMachineId),
                desMachine = currentMachine["desMachine"].ToString(),
                electrCapacity = Convert.ToDouble(currentMachine["electrCapacity"].ToString()),
                maxWat = Convert.ToDouble(currentMachine["maxWat"].ToString()),
                dailyHoursWork = Convert.ToDouble(currentMachine["dailyHoursWork"].ToString())
            };
            //calcul different prop for the added item
            tempMachine.dailyConsumation = tempMachine.electrCapacity * tempMachine.dailyHoursWork * machineCountNumerical;
            tempMachine.totalMachineCapacity = tempMachine.electrCapacity * machineCountNumerical;
            tempMachine.totalPeakWatt=tempMachine.maxWat * machineCountNumerical;
            tempMachine.displayText = string.Format("{0} ({1})", tempMachine.desMachine, machineCountNumerical.ToString());
            tempMachine.countEquipped = machineCountNumerical;
            //add the final machine to calculate equipements
            Machines.Add(tempMachine);
            //update the list
            updateListCalculateEquip();



        }

        private void updateListCalculateEquip()
        {
            bsCalculEquip.DataSource = null;
            bsCalculEquip.DataSource = Machines;
            lstCalculEquipements.DataSource= null;
            lstCalculEquipements.DataSource = bsCalculEquip;
            lstCalculEquipements.DisplayMember = "displayText";
            lstCalculEquipements.ValueMember = "machineId";
            //calcul different prop
            double dailyConsumption=0, dailyConsumptionWithWast=0, totalCapacity=0, totalPeakWatt=0,
                dailyAmperePerHour=0;
            dailyConsumption = Math.Ceiling((from m in Machines
                                select m.dailyConsumation).Sum());
            dailyConsumptionWithWast = Math.Ceiling(dailyConsumption * myProcs.wast);
            totalCapacity= Math.Ceiling((from m in Machines
                            select m.totalMachineCapacity).Sum());
            totalPeakWatt = Math.Ceiling((from m in Machines
                             select m.totalPeakWatt).Sum());
            double voltoya = myProcs.Voltiya(totalCapacity);
            if(voltoya==0)
            {
                KryptonMessageBox.Show("Total Capacity out of range to calculate the voltage of the system",
                    "Capacity out of range", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                txtDailyAmpereHour.Text = "error!!!";
            }
            else
            {
                dailyAmperePerHour = Math.Ceiling(dailyConsumptionWithWast / voltoya);
            }
            //display values
            txtDailyConsum.Text = dailyConsumption.ToString();
            txtDailyConsumAndWast.Text= dailyConsumptionWithWast.ToString();
            txtTotalCapacity.Text = totalCapacity.ToString();
            txtTotalPeakWatt.Text = totalPeakWatt.ToString();
            if(voltoya!=0)
                txtDailyAmpereHour.Text=dailyAmperePerHour.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Do you realy want to reset the equipements to calculate list?",
                "Confirmation", KryptonMessageBoxButtons.OKCancel, KryptonMessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            Machines.Clear();
            updateListCalculateEquip();
        }

        private void lstEquip_DoubleClick(object sender, EventArgs e)
        {
            btnSend.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if the slection is empty do nothing
            if (bsCalculEquip.Current == null)
                return;
            //get the current selection id
            string currentId = ((Machine)bsCalculEquip.Current).machineId.ToString();
            var machineToRemove = (from m in Machines
                                  where m.machineId==Convert.ToInt32(currentId)
                                  select m).First();
            Machines.Remove(machineToRemove);
            //update the list of equipements to calculate
            updateListCalculateEquip();
        }

        private void lstCalculEquipements_DoubleClick(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }
    }
}
