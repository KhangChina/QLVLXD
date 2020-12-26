namespace QLVLXD
{
    partial class usTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usTonKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXemChiTietHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grc = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopIDKho = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopIDHH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopIDDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnThemVatLieuVaoKho = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDDVT)).BeginInit();
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
            this.btnXemChiTietHangHoa,
            this.btnLamMoi,
            this.btnThemVatLieuVaoKho});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemVatLieuVaoKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemChiTietHangHoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXemChiTietHangHoa
            // 
            this.btnXemChiTietHangHoa.Caption = "Xem Chi Tiết Vật Liệu";
            this.btnXemChiTietHangHoa.Id = 0;
            this.btnXemChiTietHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTietHangHoa.ImageOptions.Image")));
            this.btnXemChiTietHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemChiTietHangHoa.ImageOptions.LargeImage")));
            this.btnXemChiTietHangHoa.Name = "btnXemChiTietHangHoa";
            this.btnXemChiTietHangHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXemChiTietHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemChiTietHangHoa_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(748, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 583);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 583);
            // 
            // grc
            // 
            this.grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc.Location = new System.Drawing.Point(0, 24);
            this.grc.MainView = this.grv;
            this.grc.MenuManager = this.barManager1;
            this.grc.Name = "grc";
            this.grc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.loopIDHH,
            this.loopIDKho,
            this.loopIDDVT});
            this.grc.Size = new System.Drawing.Size(748, 583);
            this.grc.TabIndex = 4;
            this.grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKho,
            this.colIDHH,
            this.gridColumn4,
            this.colIDDVT});
            this.grv.GridControl = this.grc;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colIDKho
            // 
            this.colIDKho.ColumnEdit = this.loopIDKho;
            this.colIDKho.FieldName = "IDKho";
            this.colIDKho.Name = "colIDKho";
            this.colIDKho.Visible = true;
            this.colIDKho.VisibleIndex = 1;
            // 
            // loopIDKho
            // 
            this.loopIDKho.AutoHeight = false;
            this.loopIDKho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopIDKho.Name = "loopIDKho";
            // 
            // colIDHH
            // 
            this.colIDHH.ColumnEdit = this.loopIDHH;
            this.colIDHH.FieldName = "IDHH";
            this.colIDHH.Name = "colIDHH";
            this.colIDHH.Visible = true;
            this.colIDHH.VisibleIndex = 0;
            // 
            // loopIDHH
            // 
            this.loopIDHH.AutoHeight = false;
            this.loopIDHH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopIDHH.Name = "loopIDHH";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Tong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // colIDDVT
            // 
            this.colIDDVT.ColumnEdit = this.loopIDDVT;
            this.colIDDVT.FieldName = "IDDVT";
            this.colIDDVT.Name = "colIDDVT";
            this.colIDDVT.Visible = true;
            this.colIDDVT.VisibleIndex = 3;
            // 
            // loopIDDVT
            // 
            this.loopIDDVT.AutoHeight = false;
            this.loopIDDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopIDDVT.Name = "loopIDDVT";
            // 
            // btnThemVatLieuVaoKho
            // 
            this.btnThemVatLieuVaoKho.Caption = "Thêm Vật Liệu Vào Kho";
            this.btnThemVatLieuVaoKho.Id = 2;
            this.btnThemVatLieuVaoKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnThemVatLieuVaoKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnThemVatLieuVaoKho.Name = "btnThemVatLieuVaoKho";
            this.btnThemVatLieuVaoKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemVatLieuVaoKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVatLieuVaoKho_ItemClick);
            // 
            // usTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "usTonKho";
            this.Size = new System.Drawing.Size(748, 607);
            this.Load += new System.EventHandler(this.usTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopIDDVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXemChiTietHangHoa;
        private DevExpress.XtraGrid.GridControl grc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKho;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDVT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopIDKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopIDHH;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopIDDVT;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThemVatLieuVaoKho;
    }
}
