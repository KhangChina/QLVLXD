namespace QLVLXD
{
    partial class frmModifyNhaCungCap
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtNCC = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.separatorControl1);
            this.layoutControl1.Controls.Add(this.txtSDT);
            this.layoutControl1.Controls.Add(this.txtDC);
            this.layoutControl1.Controls.Add(this.txtNCC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(423, 104);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(343, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 22);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 74);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(337, 28);
            this.separatorControl1.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(95, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(326, 20);
            this.txtSDT.StyleController = this.layoutControl1;
            this.txtSDT.TabIndex = 6;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(95, 26);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(326, 20);
            this.txtDC.StyleController = this.layoutControl1;
            this.txtDC.TabIndex = 5;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(95, 2);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(326, 20);
            this.txtNCC.StyleController = this.layoutControl1;
            this.txtNCC.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(423, 104);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNCC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem1.Text = "Tên Nhà Cung Cấp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDC;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem2.Text = "Địa chỉ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSDT;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem3.Text = "Số điện thoại";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.separatorControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(341, 32);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnThem;
            this.layoutControlItem5.Location = new System.Drawing.Point(341, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(82, 32);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmModifyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 104);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmModifyNhaCungCap";
            this.Text = "Modify Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtNCC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}