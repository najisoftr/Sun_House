using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using AntdUI;
using System.Windows.Forms;
using System.Threading;

namespace Sun_House
{
    public static class myProcs
    {
        //global database
        public static SQLiteConnection cn = new SQLiteConnection();
        public static string dbName = "sunHouseDb.sqlite";

        //eneregy wast
        public static double wast = 1.3;//30%

        //get voltiya of the installation
        public static double Voltiya(double capacity)
        {
            if (capacity < 1200)
                return 12;

            if (capacity >=1200 && capacity<2400)
                return 24;

            if (capacity >= 2400 && capacity<4800)
                return 48;
            return 0;
        }
        //db creation and check
        public static bool CheckDb()
        {
            //the returned value
            bool ok = true;
            //check if the db file exist
            if(!File.Exists(dbName))
            {
                File.Create(dbName);
            }
            //connect to the database
            cn.ConnectionString= string.Format("Data Source={0};Version=3;", dbName);
            try
            {
                cn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error accessing database\n" + ex.Message, "Error");
                return false;
            }

            //create house + machines table
            using(SQLiteTransaction trans = cn.BeginTransaction())
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS houses (
    houseId  INTEGER    PRIMARY KEY AUTOINCREMENT,
    desHouse TEXT (256) UNIQUE,
    xPos     TEXT,
    yPos     TEXT,
    panelAngle INTEGER,
    houseAngle INTEGER,
    houseAdress TEXT
);
CREATE TABLE IF NOT EXISTS machines (
    machineId      INTEGER PRIMARY KEY AUTOINCREMENT,
    desMachine     TEXT    UNIQUE,
    electrCapacity REAL    NOT NULL,
    maxWat         REAL    NOT NULL,
    dailyHoursWork  REAL,
    iconMachine    BLOB
);
;";
                try
                {
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    cmd.Dispose();
                }
                catch(Exception ex)
                {
                    trans.Rollback();
                    cmd.Dispose();
                    MessageBox.Show("Error updating database schema\n" + ex.Message, "Database error");
                    return false;
                }
            }

            return ok;

        }

        //open a window in the main panel
        public static void openWindow(System.Windows.Forms.Panel pnl, BaseForm frm)
        {
            //close all forms
            int x = 0;
            foreach (BaseForm form in pnl.Controls.OfType<BaseForm>().ToArray())
            {
                if (form.Name != frm.Name)
                    form.Close();
                else
                    x = x + 1;
            }


            //*******************************
            if (x < 1)
            {
                frm.TopLevel = false;
                pnl.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
                frm.Show();
                
                
            }
        }

        //replace the decimal separator
        public static string ReplaceDecimalSep(string value)
        {
            string decSep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string correctValue= value.Replace(",", decSep);
            correctValue = value.Replace(".", decSep);
            return correctValue;
        }

    }
}
