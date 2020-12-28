namespace QLVLXD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acDatHangNhap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhapVatLieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acBanVatLieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acLoaiVatLieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acDonViTinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acVatLieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acGiamGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhaCungCap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acPhanQuyen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acTonKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement15 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement16 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement17 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.txtNhanVienSession = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(231, 31);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(816, 778);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement5,
            this.accordionControlElement12,
            this.accordionControlElement15});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(231, 778);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement9,
            this.acDatHangNhap,
            this.acNhapVatLieu});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Hóa Đơn Nhập";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Danh Sách Hóa Đơn";
            this.accordionControlElement9.Click += new System.EventHandler(this.accordionControlElement9_Click);
            // 
            // acDatHangNhap
            // 
            this.acDatHangNhap.Name = "acDatHangNhap";
            this.acDatHangNhap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDatHangNhap.Text = "Đặt Vật Liệu";
            this.acDatHangNhap.Click += new System.EventHandler(this.acDatHangNhap_Click);
            // 
            // acNhapVatLieu
            // 
            this.acNhapVatLieu.Name = "acNhapVatLieu";
            this.acNhapVatLieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhapVatLieu.Text = "Nhập Vật Liệu";
            this.acNhapVatLieu.Click += new System.EventHandler(this.acNhapVatLieu_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acBanVatLieu,
            this.accordionControlElement7});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Hóa Đơn Xuất";
            // 
            // acBanVatLieu
            // 
            this.acBanVatLieu.Name = "acBanVatLieu";
            this.acBanVatLieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acBanVatLieu.Text = "Bán Vật Liệu";
            this.acBanVatLieu.Click += new System.EventHandler(this.acBanVatLieu_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Xuất Vật Liệu";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acKho,
            this.acLoaiVatLieu,
            this.acDonViTinh,
            this.acVatLieu,
            this.acGiamGia,
            this.acNhaCungCap,
            this.acKhachHang,
            this.accordionControlElement8});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Danh Mục";
            // 
            // acKho
            // 
            this.acKho.Name = "acKho";
            this.acKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acKho.Text = "Kho";
            this.acKho.Click += new System.EventHandler(this.acKho_Click);
            // 
            // acLoaiVatLieu
            // 
            this.acLoaiVatLieu.Name = "acLoaiVatLieu";
            this.acLoaiVatLieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acLoaiVatLieu.Text = "Loại Vật Liệu";
            this.acLoaiVatLieu.Click += new System.EventHandler(this.acLoaiVatLieu_Click);
            // 
            // acDonViTinh
            // 
            this.acDonViTinh.Name = "acDonViTinh";
            this.acDonViTinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDonViTinh.Text = "Đơn Vị Tính";
            this.acDonViTinh.Click += new System.EventHandler(this.acDonViTinh_Click);
            // 
            // acVatLieu
            // 
            this.acVatLieu.Name = "acVatLieu";
            this.acVatLieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acVatLieu.Text = "Vật Liệu";
            this.acVatLieu.Click += new System.EventHandler(this.acVatLieu_Click);
            // 
            // acGiamGia
            // 
            this.acGiamGia.Name = "acGiamGia";
            this.acGiamGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acGiamGia.Text = "Giảm giá";
            this.acGiamGia.Click += new System.EventHandler(this.acGiamGia_Click);
            // 
            // acNhaCungCap
            // 
            this.acNhaCungCap.Name = "acNhaCungCap";
            this.acNhaCungCap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhaCungCap.Text = "Nhà cung cấp";
            this.acNhaCungCap.Click += new System.EventHandler(this.acNhaCungCap_Click);
            // 
            // acKhachHang
            // 
            this.acKhachHang.Name = "acKhachHang";
            this.acKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acKhachHang.Text = "Khách hàng";
            this.acKhachHang.Click += new System.EventHandler(this.acKhachHang_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acPhanQuyen,
            this.acNhanVien});
            this.accordionControlElement8.Expanded = true;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Text = "Hệ thống";
            // 
            // acPhanQuyen
            // 
            this.acPhanQuyen.Name = "acPhanQuyen";
            this.acPhanQuyen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acPhanQuyen.Text = "Phân Quyền";
            this.acPhanQuyen.Click += new System.EventHandler(this.acPhanQuyen_Click);
            // 
            // acNhanVien
            // 
            this.acNhanVien.Name = "acNhanVien";
            this.acNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhanVien.Text = "Nhân Viên";
            this.acNhanVien.Click += new System.EventHandler(this.acNhanVien_Click);
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement13,
            this.acTonKho});
            this.accordionControlElement12.Expanded = true;
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Text = "Thống Kê";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Bán Chạy";
            // 
            // acTonKho
            // 
            this.acTonKho.Name = "acTonKho";
            this.acTonKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acTonKho.Text = "Tồn Kho";
            this.acTonKho.Click += new System.EventHandler(this.acTonKho_Click);
            // 
            // accordionControlElement15
            // 
            this.accordionControlElement15.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement16,
            this.accordionControlElement17});
            this.accordionControlElement15.Expanded = true;
            this.accordionControlElement15.Name = "accordionControlElement15";
            this.accordionControlElement15.Text = "Cài đặt";
            // 
            // accordionControlElement16
            // 
            this.accordionControlElement16.Name = "accordionControlElement16";
            this.accordionControlElement16.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement16.Text = "Cơ sở dữ liệu";
            // 
            // accordionControlElement17
            // 
            this.accordionControlElement17.Name = "accordionControlElement17";
            this.accordionControlElement17.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement17.Text = "Giao diện";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtNhanVienSession,
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1047, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txtNhanVienSession);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            // 
            // txtNhanVienSession
            // 
            this.txtNhanVienSession.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtNhanVienSession.Caption = "Admin";
            this.txtNhanVienSession.Id = 0;
            this.txtNhanVienSession.Name = "txtNhanVienSession";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 809);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Vật Liệu Xây Dựng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDatHangNhap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhapVatLieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acBanVatLieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDonViTinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acVatLieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGiamGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acTonKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acLoaiVatLieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhaCungCap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acPhanQuyen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement15;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement16;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement17;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.BarStaticItem txtNhanVienSession;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

