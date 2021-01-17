namespace QLVLXD
{
    partial class usXuatKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usXuatKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTaoPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnListPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatHoaDonXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.grc = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookKH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKH)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoPhieuXuat,
            this.btnListPhieuXuat,
            this.barButtonItem3,
            this.btnLamMoi,
            this.btnXuatHoaDonXuat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoPhieuXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnListPhieuXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatHoaDonXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTaoPhieuXuat
            // 
            this.btnTaoPhieuXuat.Caption = "Tạo Phiếu Xuất";
            this.btnTaoPhieuXuat.Id = 0;
            this.btnTaoPhieuXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuXuat.ImageOptions.Image")));
            this.btnTaoPhieuXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuXuat.ImageOptions.LargeImage")));
            this.btnTaoPhieuXuat.Name = "btnTaoPhieuXuat";
            this.btnTaoPhieuXuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoPhieuXuat_ItemClick);
            // 
            // btnListPhieuXuat
            // 
            this.btnListPhieuXuat.Caption = "Danh Sách Phiếu Xuất";
            this.btnListPhieuXuat.Id = 1;
            this.btnListPhieuXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListPhieuXuat.ImageOptions.Image")));
            this.btnListPhieuXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnListPhieuXuat.ImageOptions.LargeImage")));
            this.btnListPhieuXuat.Name = "btnListPhieuXuat";
            this.btnListPhieuXuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXuatHoaDonXuat
            // 
            this.btnXuatHoaDonXuat.Caption = "Xuất Hóa Đơn Xuất";
            this.btnXuatHoaDonXuat.Id = 4;
            this.btnXuatHoaDonXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHoaDonXuat.ImageOptions.Image")));
            this.btnXuatHoaDonXuat.Name = "btnXuatHoaDonXuat";
            this.btnXuatHoaDonXuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatHoaDonXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatHoaDonXuat_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1115, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1115, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 702);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1115, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 702);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // grc
            // 
            this.grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc.Location = new System.Drawing.Point(0, 24);
            this.grc.MainView = this.grv;
            this.grc.MenuManager = this.barManager1;
            this.grc.Name = "grc";
            this.grc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookKH,
            this.lookNV,
            this.lookTrangThai});
            this.grc.Size = new System.Drawing.Size(1115, 702);
            this.grc.TabIndex = 5;
            this.grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv.Appearance.HeaderPanel.Options.UseFont = true;
            this.grv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKH,
            this.colNV,
            this.gridColumn4,
            this.gridColumn5,
            this.colTrangThai,
            this.gridColumn2,
            this.colTongGia});
            this.grv.GridControl = this.grc;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colKH
            // 
            this.colKH.Caption = "Khách Hàng";
            this.colKH.FieldName = "IDKH";
            this.colKH.Name = "colKH";
            this.colKH.Visible = true;
            this.colKH.VisibleIndex = 2;
            // 
            // colNV
            // 
            this.colNV.Caption = "Nhân Viên";
            this.colNV.ColumnEdit = this.lookNV;
            this.colNV.FieldName = "IDNV";
            this.colNV.Name = "colNV";
            this.colNV.Visible = true;
            this.colNV.VisibleIndex = 3;
            // 
            // lookNV
            // 
            this.lookNV.AutoHeight = false;
            this.lookNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookNV.Name = "lookNV";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "IDNguoiDuyet";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày Lập Xuất";
            this.gridColumn5.FieldName = "NgayLapXuat";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái Xuất";
            this.colTrangThai.ColumnEdit = this.lookTrangThai;
            this.colTrangThai.FieldName = "TrangThaiXuat";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 6;
            // 
            // lookTrangThai
            // 
            this.lookTrangThai.AutoHeight = false;
            this.lookTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookTrangThai.Name = "lookTrangThai";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Hóa Đơn";
            this.gridColumn2.FieldName = "TenHD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colTongGia
            // 
            this.colTongGia.Caption = "Tổng Giá";
            this.colTongGia.FieldName = "TongGia";
            this.colTongGia.Name = "colTongGia";
            this.colTongGia.Visible = true;
            this.colTongGia.VisibleIndex = 4;
            // 
            // lookKH
            // 
            this.lookKH.AutoHeight = false;
            this.lookKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKH.Name = "lookKH";
            // 
            // usXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "usXuatKho";
            this.Size = new System.Drawing.Size(1115, 726);
            this.Load += new System.EventHandler(this.usXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTaoPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem btnListPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colTongGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookKH;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnXuatHoaDonXuat;
    }
}
