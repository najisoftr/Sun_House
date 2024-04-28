namespace Sun_House
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
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            this.MenuHorizontal = new AntdUI.Segmented();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tag1 = new AntdUI.Tag();
            this.panelV = new System.Windows.Forms.Panel();
            this.MenuLeft = new AntdUI.Menu();
            this.btnCollapsVPanel = new System.Windows.Forms.Button();
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.PanelMain.SuspendLayout();
            this.panelV.SuspendLayout();
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
            this.PanelMain.Location = new System.Drawing.Point(265, 90);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(817, 658);
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
            this.tag1.Size = new System.Drawing.Size(816, 52);
            this.tag1.TabIndex = 0;
            this.tag1.Text = "Key Solutions Sun House";
            this.tag1.Type = AntdUI.TTypeMini.Primary;
            // 
            // panelV
            // 
            this.panelV.AutoScroll = true;
            this.panelV.Controls.Add(this.MenuLeft);
            this.panelV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelV.Location = new System.Drawing.Point(0, 90);
            this.panelV.Name = "panelV";
            this.panelV.Size = new System.Drawing.Size(265, 658);
            this.panelV.TabIndex = 1;
            // 
            // MenuLeft
            // 
            this.MenuLeft.BackColor = System.Drawing.Color.Gold;
            this.MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            menuItem7.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem7.Icon")));
            menuItem7.IconSvg = "0";
            menuItem7.Text = "My Houses";
            menuItem8.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem8.Icon")));
            menuItem8.IconSvg = "1";
            menuItem8.Text = "My Equipements";
            menuItem9.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem9.Icon")));
            menuItem9.IconSvg = "2";
            menuItem9.Text = "My Calculations";
            this.MenuLeft.Items.AddRange(new AntdUI.MenuItem[] {
            menuItem7,
            menuItem8,
            menuItem9});
            this.MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.MenuLeft.Name = "MenuLeft";
            this.MenuLeft.Size = new System.Drawing.Size(264, 658);
            this.MenuLeft.TabIndex = 1;
            this.MenuLeft.Text = "menu1";
            this.MenuLeft.SelectChanged += new AntdUI.Menu.SelectEventHandler(this.MenuLeft_SelectChanged);
            // 
            // btnCollapsVPanel
            // 
            this.btnCollapsVPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapsVPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapsVPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapsVPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapsVPanel.Image")));
            this.btnCollapsVPanel.Location = new System.Drawing.Point(214, 40);
            this.btnCollapsVPanel.Name = "btnCollapsVPanel";
            this.btnCollapsVPanel.Size = new System.Drawing.Size(50, 50);
            this.btnCollapsVPanel.TabIndex = 3;
            this.tooltipComponent1.SetTip(this.btnCollapsVPanel, "Collapse / Expand");
            this.btnCollapsVPanel.UseVisualStyleBackColor = false;
            this.btnCollapsVPanel.Click += new System.EventHandler(this.btnCollapsVPanel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 748);
            this.Controls.Add(this.btnCollapsVPanel);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelV);
            this.Controls.Add(this.MenuHorizontal);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Solutions Sun House";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelMain.ResumeLayout(false);
            this.panelV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Segmented MenuHorizontal;
        private System.Windows.Forms.Panel PanelMain;
        private AntdUI.Tag tag1;
        private System.Windows.Forms.Panel panelV;
        private AntdUI.Menu MenuLeft;
        private System.Windows.Forms.Button btnCollapsVPanel;
        private AntdUI.TooltipComponent tooltipComponent1;
    }
}