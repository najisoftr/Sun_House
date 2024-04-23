using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sun_House
{
    public partial class FrmMain : AntdUI.BaseForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //check if the database exist, or else create it
            if (!myProcs.CheckDb())
                Application.Exit();
        }
    }
}
