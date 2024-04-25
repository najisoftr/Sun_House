﻿namespace Sun_House
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            this.MenuHorizontal = new AntdUI.Segmented();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tag1 = new AntdUI.Tag();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuLeft = new AntdUI.Menu();
            this.PanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.BackColor = System.Drawing.Color.Gold;
            this.MenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(1082, 90);
            this.MenuHorizontal.TabIndex = 1;
            this.MenuHorizontal.Text = "segmented1";
            // 
            // PanelMain
            // 
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.tag1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(220, 90);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(862, 658);
            this.PanelMain.TabIndex = 2;
            // 
            // tag1
            // 
            this.tag1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tag1.Badge = "Community Edition";
            this.tag1.Location = new System.Drawing.Point(0, 0);
            this.tag1.Margin = new System.Windows.Forms.Padding(10);
            this.tag1.Name = "tag1";
            this.tag1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.tag1.Size = new System.Drawing.Size(861, 52);
            this.tag1.TabIndex = 0;
            this.tag1.Text = "Key Solutions Sun House";
            this.tag1.Type = AntdUI.TTypeMini.Primary;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.MenuLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 658);
            this.panel1.TabIndex = 1;
            // 
            // MenuLeft
            // 
            this.MenuLeft.BackColor = System.Drawing.Color.Gold;
            this.MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            menuItem1.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem1.Icon")));
            menuItem1.IconSvg = "0";
            menuItem1.Text = "My Houses";
            menuItem2.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem2.Icon")));
            menuItem2.IconSvg = "1";
            menuItem2.Text = "My Equipements";
            this.MenuLeft.Items.AddRange(new AntdUI.MenuItem[] {
            menuItem1,
            menuItem2});
            this.MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.MenuLeft.Name = "MenuLeft";
            this.MenuLeft.Size = new System.Drawing.Size(303, 641);
            this.MenuLeft.TabIndex = 1;
            this.MenuLeft.Text = "menu1";
            this.MenuLeft.SelectChanged += new AntdUI.Menu.SelectEventHandler(this.MenuLeft_SelectChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 748);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuHorizontal);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Solutions Sun House";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Segmented MenuHorizontal;
        private System.Windows.Forms.Panel PanelMain;
        private AntdUI.Tag tag1;
        private System.Windows.Forms.Panel panel1;
        private AntdUI.Menu MenuLeft;
    }
}