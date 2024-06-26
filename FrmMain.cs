﻿using System;
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

        private void MenuLeft_SelectChanged(object sender, AntdUI.MenuItem item)
        {
            if(item.IconSvg=="0")
            {
                FrmHouses f2 = new FrmHouses();
                myProcs.openWindow(PanelMain, f2);
                return;
            }

            if (item.IconSvg == "1")
            {
                FrmEquip f2 = new FrmEquip();
                myProcs.openWindow(PanelMain, f2);
                return;
            }

            if (item.IconSvg == "2")
            {
                FrmCalcul f2 = new FrmCalcul();
                myProcs.openWindow(PanelMain, f2);
                return;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcs.cn.Close();
        }

        private void btnCollapsVPanel_Click(object sender, EventArgs e)
        {
            if(MenuLeft.Collapsed==false)
            {
                MenuLeft.Collapsed = true;
                panelV.Width = MenuLeft.Width;
                btnCollapsVPanel.Left = 3;
            }
            else
            {
                MenuLeft.Collapsed = false;
                panelV.Width = MenuLeft.Width;
                btnCollapsVPanel.Left = panelV.Width - btnCollapsVPanel.Width;
            }
        }
        }
    }
