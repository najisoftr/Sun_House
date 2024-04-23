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

namespace Sun_House
{
    public static class myProcs
    {
        //global database
        public static SQLiteConnection cn = new SQLiteConnection();
        public static string dbName = "sunHouseDb.sqlite";
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

            //create house table
            using(SQLiteTransaction trans = cn.BeginTransaction())
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS houses (
    houseId  INTEGER    PRIMARY KEY AUTOINCREMENT,
    desHouse TEXT (256) UNIQUE,
    xPos     TEXT,
    yPos     TEXT
);";
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
    }
}
