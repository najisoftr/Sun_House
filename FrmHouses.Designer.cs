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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl TabMainHouse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AntdUI.Tag tag1;
    }
}