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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GmapHousePosition = new GMap.NET.WindowsForms.GMapControl();
            this.tag2 = new AntdUI.Tag();
            this.btnAddNewHouse = new AntdUI.Button();
            this.txtNewAddress = new AntdUI.Input();
            this.txtNewPanlAngle = new AntdUI.InputNumber();
            this.txtNewRotAngle = new AntdUI.InputNumber();
            this.txtNewPosY = new AntdUI.InputNumber();
            this.txtNewPosX = new AntdUI.InputNumber();
            this.txtNewDesHouse = new AntdUI.Input();
            this.label6 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.tag1 = new AntdUI.Tag();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.tag3 = new AntdUI.Tag();
            this.txtAddress = new AntdUI.Input();
            this.txtPanelAngle = new AntdUI.InputNumber();
            this.txtRotAngle = new AntdUI.InputNumber();
            this.txtPosY = new AntdUI.InputNumber();
            this.txtPosX = new AntdUI.InputNumber();
            this.txtDesHouse = new AntdUI.Input();
            this.label7 = new AntdUI.Label();
            this.label8 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.label12 = new AntdUI.Label();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.label13 = new AntdUI.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMapEditHouseLocation = new GMap.NET.WindowsForms.GMapControl();
            this.tag4 = new AntdUI.Tag();
            this.btnSave = new AntdUI.Button();
            this.TabMainHouse.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cmbHouse);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtPanelAngle);
            this.tabPage1.Controls.Add(this.txtRotAngle);
            this.tabPage1.Controls.Add(this.txtPosY);
            this.tabPage1.Controls.Add(this.txtPosX);
            this.tabPage1.Controls.Add(this.txtDesHouse);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tag3);
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
            this.tabPage2.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.GmapHousePosition);
            this.panel1.Controls.Add(this.tag2);
            this.panel1.Location = new System.Drawing.Point(336, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 296);
            this.panel1.TabIndex = 14;
            // 
            // GmapHousePosition
            // 
            this.GmapHousePosition.Bearing = 0F;
            this.GmapHousePosition.CanDragMap = true;
            this.GmapHousePosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GmapHousePosition.EmptyTileColor = System.Drawing.Color.Navy;
            this.GmapHousePosition.GrayScaleMode = false;
            this.GmapHousePosition.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GmapHousePosition.LevelsKeepInMemory = 5;
            this.GmapHousePosition.Location = new System.Drawing.Point(0, 41);
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
            this.GmapHousePosition.Size = new System.Drawing.Size(476, 255);
            this.GmapHousePosition.TabIndex = 18;
            this.GmapHousePosition.Zoom = 0D;
            this.GmapHousePosition.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.GmapHousePosition_OnMapClick);
            // 
            // tag2
            // 
            this.tag2.CloseIcon = true;
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag2.Location = new System.Drawing.Point(0, 0);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(476, 41);
            this.tag2.TabIndex = 19;
            this.tag2.Text = "You can manually enter house values \r\nor choose location from the map ";
            this.tag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tag2.Type = AntdUI.TTypeMini.Success;
            // 
            // btnAddNewHouse
            // 
            this.btnAddNewHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewHouse.Image")));
            this.btnAddNewHouse.Location = new System.Drawing.Point(19, 488);
            this.btnAddNewHouse.Name = "btnAddNewHouse";
            this.btnAddNewHouse.Size = new System.Drawing.Size(243, 42);
            this.btnAddNewHouse.TabIndex = 13;
            this.btnAddNewHouse.Text = "Save New House";
            this.btnAddNewHouse.Type = AntdUI.TTypeMini.Success;
            this.btnAddNewHouse.Click += new System.EventHandler(this.btnAddNewHouse_Click);
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewAddress.Location = new System.Drawing.Point(19, 441);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(766, 41);
            this.txtNewAddress.TabIndex = 12;
            // 
            // txtNewPanlAngle
            // 
            this.txtNewPanlAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPanlAngle.Location = new System.Drawing.Point(19, 373);
            this.txtNewPanlAngle.Name = "txtNewPanlAngle";
            this.txtNewPanlAngle.Size = new System.Drawing.Size(284, 41);
            this.txtNewPanlAngle.TabIndex = 11;
            // 
            // txtNewRotAngle
            // 
            this.txtNewRotAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewRotAngle.Location = new System.Drawing.Point(19, 305);
            this.txtNewRotAngle.Name = "txtNewRotAngle";
            this.txtNewRotAngle.Size = new System.Drawing.Size(284, 41);
            this.txtNewRotAngle.TabIndex = 10;
            // 
            // txtNewPosY
            // 
            this.txtNewPosY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPosY.Location = new System.Drawing.Point(19, 237);
            this.txtNewPosY.Name = "txtNewPosY";
            this.txtNewPosY.Size = new System.Drawing.Size(284, 41);
            this.txtNewPosY.TabIndex = 9;
            // 
            // txtNewPosX
            // 
            this.txtNewPosX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNewPosX.Location = new System.Drawing.Point(19, 169);
            this.txtNewPosX.Name = "txtNewPosX";
            this.txtNewPosX.Size = new System.Drawing.Size(284, 41);
            this.txtNewPosX.TabIndex = 8;
            // 
            // txtNewDesHouse
            // 
            this.txtNewDesHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewDesHouse.Location = new System.Drawing.Point(19, 101);
            this.txtNewDesHouse.Name = "txtNewDesHouse";
            this.txtNewDesHouse.Size = new System.Drawing.Size(766, 41);
            this.txtNewDesHouse.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Location = new System.Drawing.Point(19, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Location = new System.Drawing.Point(19, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Panel Angle ° *";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Location = new System.Drawing.Point(19, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rotation Angle ° *";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Location = new System.Drawing.Point(19, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gps Position ( Y ) *";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Location = new System.Drawing.Point(19, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gps Position ( X ) *";
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "House Name *";
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
            // errProv
            // 
            this.errProv.BlinkRate = 100;
            this.errProv.ContainerControl = this;
            this.errProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errProv.Icon")));
            // 
            // tag3
            // 
            this.tag3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag3.Location = new System.Drawing.Point(3, 3);
            this.tag3.Name = "tag3";
            this.tag3.Padding = new System.Windows.Forms.Padding(20);
            this.tag3.Size = new System.Drawing.Size(815, 87);
            this.tag3.TabIndex = 0;
            this.tag3.Text = "My Houses";
            this.tag3.Type = AntdUI.TTypeMini.Warn;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(185, 489);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(431, 41);
            this.txtAddress.TabIndex = 24;
            // 
            // txtPanelAngle
            // 
            this.txtPanelAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPanelAngle.Location = new System.Drawing.Point(185, 375);
            this.txtPanelAngle.Name = "txtPanelAngle";
            this.txtPanelAngle.Size = new System.Drawing.Size(246, 41);
            this.txtPanelAngle.TabIndex = 23;
            this.txtPanelAngle.Text = "0";
            // 
            // txtRotAngle
            // 
            this.txtRotAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRotAngle.Location = new System.Drawing.Point(185, 317);
            this.txtRotAngle.Name = "txtRotAngle";
            this.txtRotAngle.Size = new System.Drawing.Size(246, 41);
            this.txtRotAngle.TabIndex = 22;
            this.txtRotAngle.Text = "0";
            // 
            // txtPosY
            // 
            this.txtPosY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPosY.Location = new System.Drawing.Point(185, 259);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(246, 41);
            this.txtPosY.TabIndex = 21;
            this.txtPosY.Text = "0";
            // 
            // txtPosX
            // 
            this.txtPosX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPosX.Location = new System.Drawing.Point(185, 201);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(246, 41);
            this.txtPosX.TabIndex = 20;
            this.txtPosX.Text = "0";
            // 
            // txtDesHouse
            // 
            this.txtDesHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesHouse.Location = new System.Drawing.Point(185, 143);
            this.txtDesHouse.Name = "txtDesHouse";
            this.txtDesHouse.Size = new System.Drawing.Size(594, 41);
            this.txtDesHouse.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label7.Location = new System.Drawing.Point(10, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label8.Location = new System.Drawing.Point(8, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Panel Angle ° *";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label9.Location = new System.Drawing.Point(15, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rotation Angle ° *";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label10.Location = new System.Drawing.Point(10, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gps Position ( Y ) *";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label11.Location = new System.Drawing.Point(10, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gps Position ( X ) *";
            // 
            // label12
            // 
            this.label12.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label12.Location = new System.Drawing.Point(10, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "House Name *";
            // 
            // cmbHouse
            // 
            this.cmbHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHouse.BackColor = System.Drawing.Color.LightCyan;
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Location = new System.Drawing.Point(185, 95);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(594, 31);
            this.cmbHouse.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label13.BackColor = System.Drawing.Color.LightCyan;
            this.label13.Location = new System.Drawing.Point(15, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "My Houses";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gMapEditHouseLocation);
            this.panel2.Controls.Add(this.tag4);
            this.panel2.Location = new System.Drawing.Point(437, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 293);
            this.panel2.TabIndex = 27;
            // 
            // gMapEditHouseLocation
            // 
            this.gMapEditHouseLocation.Bearing = 0F;
            this.gMapEditHouseLocation.CanDragMap = true;
            this.gMapEditHouseLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapEditHouseLocation.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapEditHouseLocation.GrayScaleMode = false;
            this.gMapEditHouseLocation.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapEditHouseLocation.LevelsKeepInMemory = 5;
            this.gMapEditHouseLocation.Location = new System.Drawing.Point(0, 41);
            this.gMapEditHouseLocation.MarkersEnabled = true;
            this.gMapEditHouseLocation.MaxZoom = 2;
            this.gMapEditHouseLocation.MinZoom = 2;
            this.gMapEditHouseLocation.MouseWheelZoomEnabled = true;
            this.gMapEditHouseLocation.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapEditHouseLocation.Name = "gMapEditHouseLocation";
            this.gMapEditHouseLocation.NegativeMode = false;
            this.gMapEditHouseLocation.PolygonsEnabled = true;
            this.gMapEditHouseLocation.RetryLoadTile = 0;
            this.gMapEditHouseLocation.RoutesEnabled = true;
            this.gMapEditHouseLocation.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapEditHouseLocation.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapEditHouseLocation.ShowTileGridLines = false;
            this.gMapEditHouseLocation.Size = new System.Drawing.Size(376, 252);
            this.gMapEditHouseLocation.TabIndex = 18;
            this.gMapEditHouseLocation.Zoom = 0D;
            // 
            // tag4
            // 
            this.tag4.CloseIcon = true;
            this.tag4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag4.Location = new System.Drawing.Point(0, 0);
            this.tag4.Name = "tag4";
            this.tag4.Size = new System.Drawing.Size(376, 41);
            this.tag4.TabIndex = 19;
            this.tag4.Text = "You can manually enter house values \r\nor choose location from the map ";
            this.tag4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tag4.Type = AntdUI.TTypeMini.Success;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(622, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 42);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save Changes";
            this.btnSave.Type = AntdUI.TTypeMini.Primary;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private AntdUI.Tag tag2;
        private GMap.NET.WindowsForms.GMapControl GmapHousePosition;
        private System.Windows.Forms.ErrorProvider errProv;
        private AntdUI.Tag tag3;
        private AntdUI.Input txtAddress;
        private AntdUI.InputNumber txtPanelAngle;
        private AntdUI.InputNumber txtRotAngle;
        private AntdUI.InputNumber txtPosY;
        private AntdUI.InputNumber txtPosX;
        private AntdUI.Input txtDesHouse;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
        private AntdUI.Label label12;
        private System.Windows.Forms.ComboBox cmbHouse;
        private AntdUI.Label label13;
        private System.Windows.Forms.Panel panel2;
        private GMap.NET.WindowsForms.GMapControl gMapEditHouseLocation;
        private AntdUI.Tag tag4;
        private AntdUI.Button btnSave;
    }
}