﻿namespace QLVLXD
{
    partial class frmModifyChiTietHoaDonXuat
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
            this.spSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.lookGiamGia = new DevExpress.XtraEditors.LookUpEdit();
            this.lookKho = new DevExpress.XtraEditors.LookUpEdit();
            this.lookVatLieu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookVatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.spSoLuong);
            this.layoutControl1.Controls.Add(this.lookGiamGia);
            this.layoutControl1.Controls.Add(this.lookKho);
            this.layoutControl1.Controls.Add(this.lookVatLieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(513, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(437, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 22);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 74);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(431, 24);
            this.separatorControl1.TabIndex = 8;
            // 
            // spSoLuong
            // 
            this.spSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoLuong.Location = new System.Drawing.Point(347, 50);
            this.spSoLuong.Name = "spSoLuong";
            this.spSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoLuong.Size = new System.Drawing.Size(164, 20);
            this.spSoLuong.StyleController = this.layoutControl1;
            this.spSoLuong.TabIndex = 7;
            // 
            // lookGiamGia
            // 
            this.lookGiamGia.Location = new System.Drawing.Point(75, 50);
            this.lookGiamGia.Name = "lookGiamGia";
            this.lookGiamGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookGiamGia.Size = new System.Drawing.Size(195, 20);
            this.lookGiamGia.StyleController = this.layoutControl1;
            this.lookGiamGia.TabIndex = 6;
            // 
            // lookKho
            // 
            this.lookKho.Location = new System.Drawing.Point(75, 2);
            this.lookKho.Name = "lookKho";
            this.lookKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKho.Size = new System.Drawing.Size(436, 20);
            this.lookKho.StyleController = this.layoutControl1;
            this.lookKho.TabIndex = 4;
            this.lookKho.EditValueChanged += new System.EventHandler(this.lookKho_EditValueChanged);
            // 
            // lookVatLieu
            // 
            this.lookVatLieu.Location = new System.Drawing.Point(75, 26);
            this.lookVatLieu.Name = "lookVatLieu";
            this.lookVatLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookVatLieu.Properties.PopupView = this.gridLookUpEdit1View;
            this.lookVatLieu.Size = new System.Drawing.Size(436, 20);
            this.lookVatLieu.StyleController = this.layoutControl1;
            this.lookVatLieu.TabIndex = 5;
            this.lookVatLieu.EditValueChanged += new System.EventHandler(this.lookVatLieu_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHH,
            this.gridColumn1,
            this.colSoLuong});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID Kho Vật Liệu";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colIDHH
            // 
            this.colIDHH.Caption = "ID Vật Liệu";
            this.colIDHH.FieldName = "IDHH";
            this.colIDHH.Name = "colIDHH";
            this.colIDHH.Visible = true;
            this.colIDHH.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Vật Liệu";
            this.gridColumn1.FieldName = "TenHH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng Tồn";
            this.colSoLuong.FieldName = "SoLuongTon";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
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
            this.Root.Size = new System.Drawing.Size(513, 100);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookKho;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(513, 24);
            this.layoutControlItem1.Text = "Kho";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookVatLieu;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(513, 24);
            this.layoutControlItem2.Text = "Vật Liệu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookGiamGia;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(272, 24);
            this.layoutControlItem3.Text = "Giảm Giá";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spSoLuong;
            this.layoutControlItem4.Location = new System.Drawing.Point(272, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(241, 24);
            this.layoutControlItem4.Text = "Số Lượng Xuất";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.separatorControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(435, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnThem;
            this.layoutControlItem6.Location = new System.Drawing.Point(435, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(78, 28);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmModifyChiTietHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 100);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmModifyChiTietHoaDonXuat";
            this.Text = "Modify  Chi Tiết Hoá Đơn Xuất";
            this.Load += new System.EventHandler(this.frmModifyChiTietHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookGiamGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookVatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit lookKho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lookGiamGia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit spSoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.GridLookUpEdit lookVatLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}