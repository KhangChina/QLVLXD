namespace QLVLXD
{
    partial class usVatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usVatLieu));
            this.grc = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiVatLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopLoaiVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopLoaiVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grc
            // 
            this.grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc.Location = new System.Drawing.Point(0, 24);
            this.grc.MainView = this.grv;
            this.grc.Name = "grc";
            this.grc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.loopLoaiVatTu,
            this.loopDVT,
            this.loopTrangThai});
            this.grc.Size = new System.Drawing.Size(821, 574);
            this.grc.TabIndex = 0;
            this.grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colLoaiVatLieu,
            this.gridColumn3,
            this.gridColumn4,
            this.colDVT,
            this.gridColumn6,
            this.colTrangThai,
            this.gridColumn8});
            this.grv.GridControl = this.grc;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colLoaiVatLieu
            // 
            this.colLoaiVatLieu.Caption = "Loại";
            this.colLoaiVatLieu.ColumnEdit = this.loopLoaiVatTu;
            this.colLoaiVatLieu.FieldName = "IDMaLoai";
            this.colLoaiVatLieu.Name = "colLoaiVatLieu";
            this.colLoaiVatLieu.Visible = true;
            this.colLoaiVatLieu.VisibleIndex = 1;
            // 
            // loopLoaiVatTu
            // 
            this.loopLoaiVatTu.AutoHeight = false;
            this.loopLoaiVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopLoaiVatTu.Name = "loopLoaiVatTu";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vật Liệu";
            this.gridColumn3.FieldName = "TenHH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hình";
            this.gridColumn4.FieldName = "URLHinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn Vị";
            this.colDVT.ColumnEdit = this.loopDVT;
            this.colDVT.FieldName = "IDDVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 4;
            // 
            // loopDVT
            // 
            this.loopDVT.AutoHeight = false;
            this.loopDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopDVT.Name = "loopDVT";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Xuất Xứ";
            this.gridColumn6.FieldName = "XuatXu";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.ColumnEdit = this.loopTrangThai;
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 6;
            // 
            // loopTrangThai
            // 
            this.loopTrangThai.AutoHeight = false;
            this.loopTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopTrangThai.Name = "loopTrangThai";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Giá";
            this.gridColumn8.FieldName = "Gia";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
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
            this.btnThem,
            this.btnXoa,
            this.btnCapNhat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCapNhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập Nhật";
            this.btnCapNhat.Id = 2;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.LargeImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(821, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(821, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 574);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(821, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 574);
            // 
            // usVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "usVatLieu";
            this.Size = new System.Drawing.Size(821, 598);
            this.Load += new System.EventHandler(this.usVatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopLoaiVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiVatLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopLoaiVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopDVT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopTrangThai;
    }
}
