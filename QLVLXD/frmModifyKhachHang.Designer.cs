namespace QLVLXD
{
    partial class frmModifyKhachHang
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
            this.loopTrangThai = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.separatorControl1);
            this.layoutControl1.Controls.Add(this.loopTrangThai);
            this.layoutControl1.Controls.Add(this.txtDienThoai);
            this.layoutControl1.Controls.Add(this.txtDiaChi);
            this.layoutControl1.Controls.Add(this.txtKhachHang);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(432, 124);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(339, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 22);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 98);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(333, 24);
            this.separatorControl1.TabIndex = 8;
            // 
            // loopTrangThai
            // 
            this.loopTrangThai.Location = new System.Drawing.Point(81, 74);
            this.loopTrangThai.Name = "loopTrangThai";
            this.loopTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopTrangThai.Size = new System.Drawing.Size(349, 20);
            this.loopTrangThai.StyleController = this.layoutControl1;
            this.loopTrangThai.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(81, 50);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(349, 20);
            this.txtDienThoai.StyleController = this.layoutControl1;
            this.txtDienThoai.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(81, 26);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(349, 20);
            this.txtDiaChi.StyleController = this.layoutControl1;
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(81, 2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(349, 20);
            this.txtKhachHang.StyleController = this.layoutControl1;
            this.txtKhachHang.TabIndex = 4;
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
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(432, 124);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtKhachHang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(432, 24);
            this.layoutControlItem1.Text = "Tên khách hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDiaChi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(432, 24);
            this.layoutControlItem2.Text = "Địa chỉ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDienThoai;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(432, 24);
            this.layoutControlItem3.Text = "Số điện thoại";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.loopTrangThai;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(432, 24);
            this.layoutControlItem4.Text = "Trạng Thái";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.separatorControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(337, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnThem;
            this.layoutControlItem6.Location = new System.Drawing.Point(337, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(95, 28);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmModifyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 124);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmModifyKhachHang";
            this.Text = "Modify Khách Hàng";
            this.Load += new System.EventHandler(this.frmModifyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtKhachHang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit loopTrangThai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}