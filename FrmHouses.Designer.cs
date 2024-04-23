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
            this.input1 = new AntdUI.Input();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.inputNumber2 = new AntdUI.InputNumber();
            this.inputNumber3 = new AntdUI.InputNumber();
            this.inputNumber4 = new AntdUI.InputNumber();
            this.input2 = new AntdUI.Input();
            this.btnAddNewHouse = new AntdUI.Button();
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
            this.tabPage2.Controls.Add(this.btnAddNewHouse);
            this.tabPage2.Controls.Add(this.input2);
            this.tabPage2.Controls.Add(this.inputNumber4);
            this.tabPage2.Controls.Add(this.inputNumber3);
            this.tabPage2.Controls.Add(this.inputNumber2);
            this.tabPage2.Controls.Add(this.inputNumber1);
            this.tabPage2.Controls.Add(this.input1);
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
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "House Name *";
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Location = new System.Drawing.Point(51, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gps Position ( X )";
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Location = new System.Drawing.Point(51, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gps Position ( Y )";
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Location = new System.Drawing.Point(51, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rotation Angle ° *";
            // 
            // label5
            // 
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Location = new System.Drawing.Point(51, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Panel Angle ° *";
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Location = new System.Drawing.Point(51, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Location = new System.Drawing.Point(203, 118);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(578, 41);
            this.input1.TabIndex = 7;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(203, 175);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(163, 41);
            this.inputNumber1.TabIndex = 8;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Location = new System.Drawing.Point(203, 232);
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(163, 41);
            this.inputNumber2.TabIndex = 9;
            // 
            // inputNumber3
            // 
            this.inputNumber3.Location = new System.Drawing.Point(203, 289);
            this.inputNumber3.Name = "inputNumber3";
            this.inputNumber3.Size = new System.Drawing.Size(163, 41);
            this.inputNumber3.TabIndex = 10;
            // 
            // inputNumber4
            // 
            this.inputNumber4.Location = new System.Drawing.Point(203, 346);
            this.inputNumber4.Name = "inputNumber4";
            this.inputNumber4.Size = new System.Drawing.Size(163, 41);
            this.inputNumber4.TabIndex = 11;
            // 
            // input2
            // 
            this.input2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input2.Location = new System.Drawing.Point(203, 403);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(578, 41);
            this.input2.TabIndex = 12;
            // 
            // btnAddNewHouse
            // 
            this.btnAddNewHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewHouse.Image")));
            this.btnAddNewHouse.Location = new System.Drawing.Point(203, 466);
            this.btnAddNewHouse.Name = "btnAddNewHouse";
            this.btnAddNewHouse.Size = new System.Drawing.Size(243, 42);
            this.btnAddNewHouse.TabIndex = 13;
            this.btnAddNewHouse.Text = "Save New House";
            this.btnAddNewHouse.Type = AntdUI.TTypeMini.Success;
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
        private AntdUI.Input input2;
        private AntdUI.InputNumber inputNumber4;
        private AntdUI.InputNumber inputNumber3;
        private AntdUI.InputNumber inputNumber2;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Input input1;
        private AntdUI.Label label6;
        private AntdUI.Button btnAddNewHouse;
    }
}