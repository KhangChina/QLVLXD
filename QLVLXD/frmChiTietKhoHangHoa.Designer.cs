namespace QLVLXD
{
    partial class frmChiTietKhoHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietKhoHangHoa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grc = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookKho = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookHH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKhoHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhatKhoHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKhoHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1068, 727);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grc
            // 
            this.grc.Location = new System.Drawing.Point(2, 2);
            this.grc.MainView = this.grv;
            this.grc.Name = "grc";
            this.grc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookKho,
            this.lookHH});
            this.grc.Size = new System.Drawing.Size(1064, 723);
            this.grc.TabIndex = 4;
            this.grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colKho,
            this.colHH,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
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
            // colKho
            // 
            this.colKho.ColumnEdit = this.lookKho;
            this.colKho.FieldName = "IDKho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 1;
            // 
            // lookKho
            // 
            this.lookKho.AutoHeight = false;
            this.lookKho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKho.Name = "lookKho";
            // 
            // colHH
            // 
            this.colHH.ColumnEdit = this.lookHH;
            this.colHH.FieldName = "IDHH";
            this.colHH.Name = "colHH";
            this.colHH.Visible = true;
            this.colHH.VisibleIndex = 2;
            // 
            // lookHH
            // 
            this.lookHH.AutoHeight = false;
            this.lookHH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookHH.Name = "lookHH";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "SoLo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "HanSuDung";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "SoLuongTon";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1068, 727);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1068, 727);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.btnThemKhoHangHoa,
            this.btnCapNhatKhoHangHoa,
            this.btnXoaKhoHangHoa});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCapNhatKhoHangHoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaKhoHangHoa)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKhoHangHoa
            // 
            this.btnThemKhoHangHoa.Caption = "Thêm Vật Liệu Vào Kho";
            this.btnThemKhoHangHoa.Id = 0;
            this.btnThemKhoHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhoHangHoa.ImageOptions.Image")));
            this.btnThemKhoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemKhoHangHoa.ImageOptions.LargeImage")));
            this.btnThemKhoHangHoa.Name = "btnThemKhoHangHoa";
            this.btnThemKhoHangHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnCapNhatKhoHangHoa
            // 
            this.btnCapNhatKhoHangHoa.Caption = "Cập Nhật Vật Liệu";
            this.btnCapNhatKhoHangHoa.Id = 1;
            this.btnCapNhatKhoHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKhoHangHoa.ImageOptions.Image")));
            this.btnCapNhatKhoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKhoHangHoa.ImageOptions.LargeImage")));
            this.btnCapNhatKhoHangHoa.Name = "btnCapNhatKhoHangHoa";
            this.btnCapNhatKhoHangHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCapNhatKhoHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhatKhoHangHoa_ItemClick);
            // 
            // btnXoaKhoHangHoa
            // 
            this.btnXoaKhoHangHoa.Caption = "Xóa Vật Liệu Trong Kho ";
            this.btnXoaKhoHangHoa.Id = 2;
            this.btnXoaKhoHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoHangHoa.ImageOptions.Image")));
            this.btnXoaKhoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoHangHoa.ImageOptions.LargeImage")));
            this.btnXoaKhoHangHoa.Name = "btnXoaKhoHangHoa";
            this.btnXoaKhoHangHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaKhoHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKhoHangHoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1068, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 751);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1068, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 727);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1068, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 727);
            // 
            // frmChiTietKhoHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 751);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChiTietKhoHangHoa";
            this.Text = "Chi Tiết Kho Hàng Hóa";
            this.Load += new System.EventHandler(this.frmChiTietKhoHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colHH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemKhoHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhatKhoHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhoHangHoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookHH;
    }
}