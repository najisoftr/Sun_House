namespace Sun_House
{
    partial class FrmEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquip));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDel = new AntdUI.Button();
            this.btnSave = new AntdUI.Button();
            this.txtDailyUse = new AntdUI.InputNumber();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWattPeak = new AntdUI.InputNumber();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCapacity = new AntdUI.InputNumber();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesEquip = new AntdUI.Input();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelFind = new AntdUI.Icon.IconError();
            this.grdEquip = new System.Windows.Forms.DataGridView();
            this.machineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electrCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyHoursWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindEquip = new AntdUI.Input();
            this.lblBadge = new AntdUI.Label();
            this.tag2 = new AntdUI.Tag();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new AntdUI.Button();
            this.txtNewDailyUse = new AntdUI.InputNumber();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewWattPeak = new AntdUI.InputNumber();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewCapacity = new AntdUI.InputNumber();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewDesEquip = new AntdUI.Input();
            this.label2 = new System.Windows.Forms.Label();
            this.tag1 = new AntdUI.Tag();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsEquip = new System.Windows.Forms.BindingSource(this.components);
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.errProv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquip)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 45);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tag2);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Equipements";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.txtDailyUse);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtWattPeak);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCapacity);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDesEquip);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 243);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Equipement details";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(584, 79);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(193, 42);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Remove";
            this.tooltipComponent1.SetTip(this.btnDel, "Remove selected Equipement");
            this.btnDel.Type = AntdUI.TTypeMini.Error;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(584, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 42);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save Changes";
            this.btnSave.Type = AntdUI.TTypeMini.Primary;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDailyUse
            // 
            this.txtDailyUse.Location = new System.Drawing.Point(250, 179);
            this.txtDailyUse.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtDailyUse.Name = "txtDailyUse";
            this.txtDailyUse.Size = new System.Drawing.Size(169, 40);
            this.txtDailyUse.TabIndex = 12;
            this.txtDailyUse.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Daily Uses (Hours/Day) *";
            // 
            // txtWattPeak
            // 
            this.txtWattPeak.Location = new System.Drawing.Point(250, 129);
            this.txtWattPeak.Name = "txtWattPeak";
            this.txtWattPeak.Size = new System.Drawing.Size(169, 40);
            this.txtWattPeak.TabIndex = 10;
            this.txtWattPeak.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Watt-Peak ";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(250, 79);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(169, 40);
            this.txtCapacity.TabIndex = 8;
            this.txtCapacity.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Electrical Capacity (Watt) *";
            // 
            // txtDesEquip
            // 
            this.txtDesEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesEquip.Location = new System.Drawing.Point(250, 29);
            this.txtDesEquip.Name = "txtDesEquip";
            this.txtDesEquip.Size = new System.Drawing.Size(527, 40);
            this.txtDesEquip.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipement name *";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCancelFind);
            this.groupBox1.Controls.Add(this.grdEquip);
            this.groupBox1.Controls.Add(this.txtFindEquip);
            this.groupBox1.Controls.Add(this.lblBadge);
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Equipements";
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelFind.Location = new System.Drawing.Point(781, 41);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(31, 29);
            this.btnCancelFind.TabIndex = 2;
            this.btnCancelFind.Text = "Cancel Filter";
            this.tooltipComponent1.SetTip(this.btnCancelFind, "Cancel Filter");
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // grdEquip
            // 
            this.grdEquip.AllowUserToAddRows = false;
            this.grdEquip.AllowUserToDeleteRows = false;
            this.grdEquip.AllowUserToOrderColumns = true;
            this.grdEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEquip.ColumnHeadersHeight = 42;
            this.grdEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineId,
            this.desMachine,
            this.electrCapacity,
            this.maxWat,
            this.dailyHoursWork});
            this.grdEquip.EnableHeadersVisualStyles = false;
            this.grdEquip.Location = new System.Drawing.Point(6, 76);
            this.grdEquip.MultiSelect = false;
            this.grdEquip.Name = "grdEquip";
            this.grdEquip.ReadOnly = true;
            this.grdEquip.RowHeadersVisible = false;
            this.grdEquip.RowTemplate.Height = 30;
            this.grdEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEquip.Size = new System.Drawing.Size(810, 203);
            this.grdEquip.TabIndex = 1;
            // 
            // machineId
            // 
            this.machineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.machineId.DataPropertyName = "machineId";
            this.machineId.HeaderText = "Machine ID";
            this.machineId.Name = "machineId";
            this.machineId.ReadOnly = true;
            this.machineId.Width = 122;
            // 
            // desMachine
            // 
            this.desMachine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desMachine.DataPropertyName = "desMachine";
            this.desMachine.HeaderText = "Name";
            this.desMachine.Name = "desMachine";
            this.desMachine.ReadOnly = true;
            // 
            // electrCapacity
            // 
            this.electrCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.electrCapacity.DataPropertyName = "electrCapacity";
            this.electrCapacity.HeaderText = "Capacity (Watt)";
            this.electrCapacity.Name = "electrCapacity";
            this.electrCapacity.ReadOnly = true;
            this.electrCapacity.Width = 151;
            // 
            // maxWat
            // 
            this.maxWat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maxWat.DataPropertyName = "maxWat";
            this.maxWat.HeaderText = "Watt-Peak";
            this.maxWat.Name = "maxWat";
            this.maxWat.ReadOnly = true;
            this.maxWat.Width = 113;
            // 
            // dailyHoursWork
            // 
            this.dailyHoursWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dailyHoursWork.DataPropertyName = "dailyHoursWork";
            this.dailyHoursWork.HeaderText = "Daily use(Hours/Day)";
            this.dailyHoursWork.Name = "dailyHoursWork";
            this.dailyHoursWork.ReadOnly = true;
            this.dailyHoursWork.Width = 194;
            // 
            // txtFindEquip
            // 
            this.txtFindEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindEquip.Back = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.txtFindEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(171)))));
            this.txtFindEquip.Badge = "";
            this.txtFindEquip.Image = ((System.Drawing.Image)(resources.GetObject("txtFindEquip.Image")));
            this.txtFindEquip.Location = new System.Drawing.Point(604, 38);
            this.txtFindEquip.Name = "txtFindEquip";
            this.txtFindEquip.PlaceholderText = "find by name";
            this.txtFindEquip.Size = new System.Drawing.Size(173, 35);
            this.txtFindEquip.Status = AntdUI.TType.Error;
            this.txtFindEquip.TabIndex = 0;
            this.txtFindEquip.TextChanged += new System.EventHandler(this.txtFindEquip_TextChanged);
            // 
            // lblBadge
            // 
            this.lblBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblBadge.Badge = "";
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadge.Fore = System.Drawing.Color.Gray;
            this.lblBadge.ForeColor = System.Drawing.Color.Gray;
            this.lblBadge.Location = new System.Drawing.Point(690, 16);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(87, 23);
            this.lblBadge.TabIndex = 3;
            this.lblBadge.Text = "";
            // 
            // tag2
            // 
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Location = new System.Drawing.Point(3, 3);
            this.tag2.Name = "tag2";
            this.tag2.Padding = new System.Windows.Forms.Padding(10);
            this.tag2.Size = new System.Drawing.Size(852, 59);
            this.tag2.TabIndex = 2;
            this.tag2.Text = "My equipements";
            this.tag2.Type = AntdUI.TTypeMini.Warn;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.tag1);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Equip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.txtNewDailyUse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNewWattPeak);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNewCapacity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNewDesEquip);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 534);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipement informations";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(309, 351);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(269, 42);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "Add New Equipement";
            this.btnAddNew.Type = AntdUI.TTypeMini.Success;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtNewDailyUse
            // 
            this.txtNewDailyUse.Location = new System.Drawing.Point(309, 258);
            this.txtNewDailyUse.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtNewDailyUse.Name = "txtNewDailyUse";
            this.txtNewDailyUse.Size = new System.Drawing.Size(169, 40);
            this.txtNewDailyUse.TabIndex = 8;
            this.txtNewDailyUse.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Daily Uses (Hours/Day) *";
            // 
            // txtNewWattPeak
            // 
            this.txtNewWattPeak.Location = new System.Drawing.Point(309, 185);
            this.txtNewWattPeak.Name = "txtNewWattPeak";
            this.txtNewWattPeak.Size = new System.Drawing.Size(169, 40);
            this.txtNewWattPeak.TabIndex = 6;
            this.txtNewWattPeak.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Watt-Peak ";
            // 
            // txtNewCapacity
            // 
            this.txtNewCapacity.Location = new System.Drawing.Point(309, 112);
            this.txtNewCapacity.Name = "txtNewCapacity";
            this.txtNewCapacity.Size = new System.Drawing.Size(169, 40);
            this.txtNewCapacity.TabIndex = 4;
            this.txtNewCapacity.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Electrical Capacity (Watt) *";
            // 
            // txtNewDesEquip
            // 
            this.txtNewDesEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewDesEquip.Location = new System.Drawing.Point(309, 39);
            this.txtNewDesEquip.Name = "txtNewDesEquip";
            this.txtNewDesEquip.Size = new System.Drawing.Size(485, 40);
            this.txtNewDesEquip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipement name *";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Location = new System.Drawing.Point(3, 3);
            this.tag1.Name = "tag1";
            this.tag1.Padding = new System.Windows.Forms.Padding(10);
            this.tag1.Size = new System.Drawing.Size(852, 59);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "Please enter the new equipement data (*) required";
            this.tag1.Type = AntdUI.TTypeMini.Primary;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "innovation64.png");
            this.imageList1.Images.SetKeyName(1, "electric-appliance64.png");
            // 
            // errProv1
            // 
            this.errProv1.ContainerControl = this;
            this.errProv1.Icon = ((System.Drawing.Icon)(resources.GetObject("errProv1.Icon")));
            // 
            // bsEquip
            // 
            this.bsEquip.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsEquip_ListChanged);
            // 
            // errProv2
            // 
            this.errProv2.ContainerControl = this;
            // 
            // FrmEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Electrical Equipements";
            this.Load += new System.EventHandler(this.FrmEquip_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquip)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private AntdUI.Tag tag1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private AntdUI.Input txtNewDesEquip;
        private System.Windows.Forms.Label label3;
        private AntdUI.InputNumber txtNewCapacity;
        private AntdUI.InputNumber txtNewWattPeak;
        private System.Windows.Forms.Label label4;
        private AntdUI.InputNumber txtNewDailyUse;
        private System.Windows.Forms.Label label5;
        private AntdUI.Button btnAddNew;
        private System.Windows.Forms.ErrorProvider errProv1;
        private AntdUI.Tag tag2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private AntdUI.Input txtFindEquip;
        private System.Windows.Forms.DataGridView grdEquip;
        private System.Windows.Forms.BindingSource bsEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn desMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn electrCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyHoursWork;
        private AntdUI.Icon.IconError btnCancelFind;
        private AntdUI.TooltipComponent tooltipComponent1;
        private AntdUI.InputNumber txtDailyUse;
        private System.Windows.Forms.Label label8;
        private AntdUI.InputNumber txtWattPeak;
        private System.Windows.Forms.Label label6;
        private AntdUI.InputNumber txtCapacity;
        private System.Windows.Forms.Label label7;
        private AntdUI.Input txtDesEquip;
        private System.Windows.Forms.Label label1;
        private AntdUI.Button btnSave;
        private System.Windows.Forms.ErrorProvider errProv2;
        private AntdUI.Button btnDel;
        private AntdUI.Label lblBadge;
    }
}