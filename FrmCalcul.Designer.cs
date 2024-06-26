﻿namespace Sun_House
{
    partial class FrmCalcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalcul));
            this.btnCancelFind = new AntdUI.Icon.IconError();
            this.txtFindEquip = new AntdUI.Input();
            this.panel1 = new AntdUI.Panel();
            this.lstEquip = new Krypton.Toolkit.KryptonListBox();
            this.tag1 = new AntdUI.Tag();
            this.bsEquipement = new System.Windows.Forms.BindingSource(this.components);
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel2 = new AntdUI.Panel();
            this.lstCalculEquipements = new Krypton.Toolkit.KryptonListBox();
            this.tag2 = new AntdUI.Tag();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsCalculEquip = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new AntdUI.Label();
            this.txtDailyConsum = new AntdUI.Input();
            this.txtDailyConsumAndWast = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.txtTotalCapacity = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.txtTotalPeakWatt = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.txtDailyAmpereHour = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipement)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalculEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelFind.Location = new System.Drawing.Point(192, 46);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(31, 29);
            this.btnCancelFind.TabIndex = 4;
            this.btnCancelFind.Text = "Cancel Filter";
            this.tooltipComponent1.SetTip(this.btnCancelFind, "Reset List");
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // txtFindEquip
            // 
            this.txtFindEquip.Back = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(135)))));
            this.txtFindEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(135)))));
            this.txtFindEquip.Badge = "";
            this.txtFindEquip.Image = ((System.Drawing.Image)(resources.GetObject("txtFindEquip.Image")));
            this.txtFindEquip.Location = new System.Drawing.Point(15, 43);
            this.txtFindEquip.Name = "txtFindEquip";
            this.txtFindEquip.PlaceholderText = "find by name";
            this.txtFindEquip.Size = new System.Drawing.Size(173, 35);
            this.txtFindEquip.Status = AntdUI.TType.Error;
            this.txtFindEquip.TabIndex = 3;
            this.txtFindEquip.TextChanged += new System.EventHandler(this.txtFindEquip_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lstEquip);
            this.panel1.Controls.Add(this.tag1);
            this.panel1.Controls.Add(this.btnCancelFind);
            this.panel1.Controls.Add(this.txtFindEquip);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 3;
            this.panel1.ShadowColor = System.Drawing.Color.Coral;
            this.panel1.ShadowOffsetX = 3;
            this.panel1.ShadowOffsetY = 3;
            this.panel1.ShadowOpacity = 0.3F;
            this.panel1.ShadowOpacityHover = 0.8F;
            this.panel1.Size = new System.Drawing.Size(269, 595);
            this.panel1.TabIndex = 5;
            // 
            // lstEquip
            // 
            this.lstEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEquip.BackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.lstEquip.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonNavigatorMini;
            this.lstEquip.ItemStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.lstEquip.Location = new System.Drawing.Point(6, 84);
            this.lstEquip.Name = "lstEquip";
            this.lstEquip.Size = new System.Drawing.Size(254, 502);
            this.lstEquip.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstEquip.StateCommon.Border.Rounding = 6F;
            this.lstEquip.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstEquip.StateCommon.Item.Border.Rounding = 6F;
            this.lstEquip.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstEquip.TabIndex = 6;
            this.lstEquip.DoubleClick += new System.EventHandler(this.lstEquip_DoubleClick);
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Fore = System.Drawing.Color.Blue;
            this.tag1.ForeColor = System.Drawing.Color.Blue;
            this.tag1.Location = new System.Drawing.Point(3, 3);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(260, 28);
            this.tag1.TabIndex = 5;
            this.tag1.Text = "My equipements";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tag1.Type = AntdUI.TTypeMini.Success;
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(281, 232);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(33, 33);
            this.btnSend.TabIndex = 8;
            this.tooltipComponent1.SetTip(this.btnSend, "Add Equipement ");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(281, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 33);
            this.btnBack.TabIndex = 9;
            this.tooltipComponent1.SetTip(this.btnBack, "Remove Equipement from equipements to calcuate list");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.No;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(281, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(33, 33);
            this.btnClear.TabIndex = 10;
            this.tooltipComponent1.SetTip(this.btnClear, "Clear all equipements to calculate");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(281, 111);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.TabIndex = 21;
            this.tooltipComponent1.SetTip(this.btnInfo, "Show selected equipement details");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Back = System.Drawing.Color.DarkSalmon;
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.lstCalculEquipements);
            this.panel2.Controls.Add(this.tag2);
            this.panel2.Location = new System.Drawing.Point(314, 12);
            this.panel2.Name = "panel2";
            this.panel2.Shadow = 3;
            this.panel2.ShadowColor = System.Drawing.Color.CadetBlue;
            this.panel2.ShadowOffsetX = 3;
            this.panel2.ShadowOffsetY = 3;
            this.panel2.ShadowOpacity = 0.3F;
            this.panel2.ShadowOpacityHover = 0.8F;
            this.panel2.Size = new System.Drawing.Size(285, 595);
            this.panel2.TabIndex = 6;
            // 
            // lstCalculEquipements
            // 
            this.lstCalculEquipements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCalculEquipements.BackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonFormClose;
            this.lstCalculEquipements.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonNavigatorMini;
            this.lstCalculEquipements.ItemStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.lstCalculEquipements.Location = new System.Drawing.Point(6, 84);
            this.lstCalculEquipements.Name = "lstCalculEquipements";
            this.lstCalculEquipements.Size = new System.Drawing.Size(270, 502);
            this.lstCalculEquipements.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstCalculEquipements.StateCommon.Border.Rounding = 6F;
            this.lstCalculEquipements.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstCalculEquipements.StateCommon.Item.Border.Rounding = 6F;
            this.lstCalculEquipements.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstCalculEquipements.TabIndex = 6;
            this.lstCalculEquipements.DoubleClick += new System.EventHandler(this.lstCalculEquipements_DoubleClick);
            // 
            // tag2
            // 
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Fore = System.Drawing.Color.Red;
            this.tag2.ForeColor = System.Drawing.Color.Red;
            this.tag2.Location = new System.Drawing.Point(3, 3);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(276, 28);
            this.tag2.TabIndex = 5;
            this.tag2.Text = "Equipements to Calculate";
            this.tag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tag2.Type = AntdUI.TTypeMini.Error;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(605, 24);
            this.label1.Name = "label1";
            this.label1.Shadow = 3;
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.Suffix = "";
            this.label1.TabIndex = 11;
            this.label1.Text = "Daily consumption:";
            // 
            // txtDailyConsum
            // 
            this.txtDailyConsum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDailyConsum.Location = new System.Drawing.Point(605, 53);
            this.txtDailyConsum.Name = "txtDailyConsum";
            this.txtDailyConsum.ReadOnly = true;
            this.txtDailyConsum.Size = new System.Drawing.Size(184, 37);
            this.txtDailyConsum.SuffixText = "Wh/day";
            this.txtDailyConsum.TabIndex = 12;
            // 
            // txtDailyConsumAndWast
            // 
            this.txtDailyConsumAndWast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDailyConsumAndWast.Location = new System.Drawing.Point(605, 165);
            this.txtDailyConsumAndWast.Name = "txtDailyConsumAndWast";
            this.txtDailyConsumAndWast.ReadOnly = true;
            this.txtDailyConsumAndWast.Size = new System.Drawing.Size(184, 37);
            this.txtDailyConsumAndWast.SuffixText = "W";
            this.txtDailyConsumAndWast.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(605, 111);
            this.label2.Name = "label2";
            this.label2.Shadow = 3;
            this.label2.Size = new System.Drawing.Size(184, 48);
            this.label2.Suffix = "";
            this.label2.TabIndex = 13;
            this.label2.Text = "Daily Consumption\r\nwith waste";
            // 
            // txtTotalCapacity
            // 
            this.txtTotalCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCapacity.Location = new System.Drawing.Point(605, 258);
            this.txtTotalCapacity.Name = "txtTotalCapacity";
            this.txtTotalCapacity.ReadOnly = true;
            this.txtTotalCapacity.Size = new System.Drawing.Size(184, 37);
            this.txtTotalCapacity.SuffixText = "W";
            this.txtTotalCapacity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(605, 229);
            this.label3.Name = "label3";
            this.label3.Shadow = 3;
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.Suffix = "";
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Equip Capacity:";
            // 
            // txtTotalPeakWatt
            // 
            this.txtTotalPeakWatt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPeakWatt.Location = new System.Drawing.Point(605, 355);
            this.txtTotalPeakWatt.Name = "txtTotalPeakWatt";
            this.txtTotalPeakWatt.ReadOnly = true;
            this.txtTotalPeakWatt.Size = new System.Drawing.Size(184, 37);
            this.txtTotalPeakWatt.SuffixText = "W";
            this.txtTotalPeakWatt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(605, 326);
            this.label4.Name = "label4";
            this.label4.Shadow = 3;
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.Suffix = "";
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Peak-Watt:";
            // 
            // txtDailyAmpereHour
            // 
            this.txtDailyAmpereHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDailyAmpereHour.Back = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(173)))), ((int)(((byte)(151)))));
            this.txtDailyAmpereHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(173)))), ((int)(((byte)(151)))));
            this.txtDailyAmpereHour.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyAmpereHour.Fore = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDailyAmpereHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDailyAmpereHour.Location = new System.Drawing.Point(605, 441);
            this.txtDailyAmpereHour.Name = "txtDailyAmpereHour";
            this.txtDailyAmpereHour.ReadOnly = true;
            this.txtDailyAmpereHour.Size = new System.Drawing.Size(184, 37);
            this.txtDailyAmpereHour.SuffixText = "Ah/Day";
            this.txtDailyAmpereHour.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Fore = System.Drawing.Color.Green;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(605, 412);
            this.label5.Name = "label5";
            this.label5.Shadow = 5;
            this.label5.ShadowColor = System.Drawing.Color.Red;
            this.label5.ShadowOffsetX = 5;
            this.label5.ShadowOpacity = 0.5F;
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.Suffix = "";
            this.label5.TabIndex = 19;
            this.label5.Text = "Daily Ampere/Hour:";
            // 
            // FrmCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 619);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtDailyAmpereHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPeakWatt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDailyConsumAndWast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDailyConsum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcul";
            this.Text = "My Calculations";
            this.Load += new System.EventHandler(this.FrmCalcul_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipement)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalculEquip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Icon.IconError btnCancelFind;
        private AntdUI.Input txtFindEquip;
        private AntdUI.Panel panel1;
        private AntdUI.Tag tag1;
        private System.Windows.Forms.BindingSource bsEquipement;
        private Krypton.Toolkit.KryptonListBox lstEquip;
        private AntdUI.TooltipComponent tooltipComponent1;
        private AntdUI.Panel panel2;
        private Krypton.Toolkit.KryptonListBox lstCalculEquipements;
        private AntdUI.Tag tag2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource bsCalculEquip;
        private System.Windows.Forms.Button btnClear;
        private AntdUI.Label label1;
        private AntdUI.Input txtDailyConsum;
        private AntdUI.Input txtDailyConsumAndWast;
        private AntdUI.Label label2;
        private AntdUI.Input txtTotalCapacity;
        private AntdUI.Label label3;
        private AntdUI.Input txtTotalPeakWatt;
        private AntdUI.Label label4;
        private AntdUI.Input txtDailyAmpereHour;
        private AntdUI.Label label5;
        private System.Windows.Forms.Button btnInfo;
    }
}