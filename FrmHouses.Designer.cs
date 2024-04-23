namespace Sun_House
{
    partial class FrmHouses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHouses));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabMainHouse = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tag1 = new AntdUI.Tag();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.txtNewDesHouse = new AntdUI.Input();
            this.txtNewPosX = new AntdUI.InputNumber();
            this.txtNewPosY = new AntdUI.InputNumber();
            this.txtNewRotAngle = new AntdUI.InputNumber();
            this.txtNewPanlAngle = new AntdUI.InputNumber();
            this.txtNewAddress = new AntdUI.Input();
            this.btnAddNewHouse = new AntdUI.Button();
            this.GmapHousePosition = new GMap.NET.WindowsForms.GMapControl();
            this.tooltip1 = new AntdUI.Tooltip();
            this.TabMainHouse.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eco-house64.png");
            this.imageList1.Images.SetKeyName(1, "add house64.png");
            // 
            // TabMainHouse
            // 
            this.TabMainHouse.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabMainHouse.Controls.Add(this.tabPage1);
            this.TabMainHouse.Controls.Add(this.tabPage2);
            this.TabMainHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMainHouse.ImageList = this.imageList1;
            this.TabMainHouse.ItemSize = new System.Drawing.Size(200, 45);
            this.TabMainHouse.Location = new System.Drawing.Point(0, 0);
            this.TabMainHouse.Name = "TabMainHouse";
            this.TabMainHouse.SelectedIndex = 0;
            this.TabMainHouse.Size = new System.Drawing.Size(829, 589);
            this.TabMainHouse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabMainHouse.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Houses";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tooltip1);
            this.tabPage2.Controls.Add(this.GmapHousePosition);
            this.tabPage2.Controls.Add(this.btnAddNewHouse);
            this.tabPage2.Controls.Add(this.txtNewAddress);
            this.tabPage2.Controls.Add(this.txtNewPanlAngle);
            this.tabPage2.Controls.Add(this.txtNewRotAngle);
            this.tabPage2.Controls.Add(this.txtNewPosY);
            this.tabPage2.Controls.Add(this.txtNewPosX);
            this.tabPage2.Controls.Add(this.txtNewDesHouse);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tag1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New House";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Location = new System.Drawing.Point(3, 3);
            this.tag1.Name = "tag1";
            this.tag1.Padding = new System.Windows.Forms.Padding(20);
            this.tag1.Size = new System.Drawing.Size(815, 92);
            this.tag1.TabIndex = 0;
            this.tag1.Text = "Please enter your new house informations (* required)\r\n";
            this.tag1.Type = AntdUI.TTypeMini.Info;
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "House Name *";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Location = new System.Drawing.Point(51, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gps Position ( X )";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Location = new System.Drawing.Point(51, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gps Position ( Y )";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Location = new System.Drawing.Point(51, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rotation Angle ° *";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Location = new System.Drawing.Point(51, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Panel Angle ° *";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Location = new System.Drawing.Point(51, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // txtNewDesHouse
            // 
            this.txtNewDesHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewDesHouse.Location = new System.Drawing.Point(203, 99);
            this.txtNewDesHouse.Name = "txtNewDesHouse";
            this.txtNewDesHouse.Size = new System.Drawing.Size(578, 41);
            this.txtNewDesHouse.TabIndex = 7;
            // 
            // txtNewPosX
            // 
            this.txtNewPosX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPosX.Location = new System.Drawing.Point(203, 190);
            this.txtNewPosX.Name = "txtNewPosX";
            this.txtNewPosX.Size = new System.Drawing.Size(163, 41);
            this.txtNewPosX.TabIndex = 8;
            // 
            // txtNewPosY
            // 
            this.txtNewPosY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPosY.Location = new System.Drawing.Point(203, 247);
            this.txtNewPosY.Name = "txtNewPosY";
            this.txtNewPosY.Size = new System.Drawing.Size(163, 41);
            this.txtNewPosY.TabIndex = 9;
            // 
            // txtNewRotAngle
            // 
            this.txtNewRotAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewRotAngle.Location = new System.Drawing.Point(203, 304);
            this.txtNewRotAngle.Name = "txtNewRotAngle";
            this.txtNewRotAngle.Size = new System.Drawing.Size(163, 41);
            this.txtNewRotAngle.TabIndex = 10;
            // 
            // txtNewPanlAngle
            // 
            this.txtNewPanlAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPanlAngle.Location = new System.Drawing.Point(203, 361);
            this.txtNewPanlAngle.Name = "txtNewPanlAngle";
            this.txtNewPanlAngle.Size = new System.Drawing.Size(163, 41);
            this.txtNewPanlAngle.TabIndex = 11;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewAddress.Location = new System.Drawing.Point(203, 418);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(578, 41);
            this.txtNewAddress.TabIndex = 12;
            // 
            // btnAddNewHouse
            // 
            this.btnAddNewHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewHouse.Image")));
            this.btnAddNewHouse.Location = new System.Drawing.Point(203, 480);
            this.btnAddNewHouse.Name = "btnAddNewHouse";
            this.btnAddNewHouse.Size = new System.Drawing.Size(243, 42);
            this.btnAddNewHouse.TabIndex = 13;
            this.btnAddNewHouse.Text = "Save New House";
            this.btnAddNewHouse.Type = AntdUI.TTypeMini.Success;
            // 
            // GmapHousePosition
            // 
            this.GmapHousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GmapHousePosition.Bearing = 0F;
            this.GmapHousePosition.CanDragMap = true;
            this.GmapHousePosition.EmptyTileColor = System.Drawing.Color.Navy;
            this.GmapHousePosition.GrayScaleMode = false;
            this.GmapHousePosition.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GmapHousePosition.LevelsKeepInMemory = 5;
            this.GmapHousePosition.Location = new System.Drawing.Point(384, 193);
            this.GmapHousePosition.MarkersEnabled = true;
            this.GmapHousePosition.MaxZoom = 2;
            this.GmapHousePosition.MinZoom = 2;
            this.GmapHousePosition.MouseWheelZoomEnabled = true;
            this.GmapHousePosition.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GmapHousePosition.Name = "GmapHousePosition";
            this.GmapHousePosition.NegativeMode = false;
            this.GmapHousePosition.PolygonsEnabled = true;
            this.GmapHousePosition.RetryLoadTile = 0;
            this.GmapHousePosition.RoutesEnabled = true;
            this.GmapHousePosition.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GmapHousePosition.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GmapHousePosition.ShowTileGridLines = false;
            this.GmapHousePosition.Size = new System.Drawing.Size(396, 208);
            this.GmapHousePosition.TabIndex = 14;
            this.GmapHousePosition.Zoom = 0D;
            this.GmapHousePosition.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.GmapHousePosition_OnMapClick);
            // 
            // tooltip1
            // 
            this.tooltip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tooltip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltip1.Location = new System.Drawing.Point(291, 140);
            this.tooltip1.MaximumSize = new System.Drawing.Size(494, 50);
            this.tooltip1.MinimumSize = new System.Drawing.Size(494, 50);
            this.tooltip1.Name = "tooltip1";
            this.tooltip1.Size = new System.Drawing.Size(494, 50);
            this.tooltip1.TabIndex = 15;
            this.tooltip1.Text = "You can manually enter house values or choose location from the map ";
            // 
            // FrmHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 589);
            this.Controls.Add(this.TabMainHouse);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHouses";
            this.Text = "House Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHouses_FormClosing);
            this.Load += new System.EventHandler(this.FrmHouses_Load);
            this.TabMainHouse.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl TabMainHouse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AntdUI.Tag tag1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Input txtNewAddress;
        private AntdUI.InputNumber txtNewPanlAngle;
        private AntdUI.InputNumber txtNewRotAngle;
        private AntdUI.InputNumber txtNewPosY;
        private AntdUI.InputNumber txtNewPosX;
        private AntdUI.Input txtNewDesHouse;
        private AntdUI.Label label6;
        private AntdUI.Button btnAddNewHouse;
        private GMap.NET.WindowsForms.GMapControl GmapHousePosition;
        private AntdUI.Tooltip tooltip1;
    }
}