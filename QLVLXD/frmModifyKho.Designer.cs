namespace QLVLXD
{
    partial class frmModifyKho
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
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.separatorControl1);
            this.layoutControl1.Controls.Add(this.loopTrangThai);
            this.layoutControl1.Controls.Add(this.txtTenKho);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(540, 67);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(457, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 22);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 26);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(451, 22);
            this.separatorControl1.TabIndex = 7;
            // 
            // loopTrangThai
            // 
            this.loopTrangThai.Location = new System.Drawing.Point(320, 2);
            this.loopTrangThai.Name = "loopTrangThai";
            this.loopTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopTrangThai.Properties.NullText = "";
            this.loopTrangThai.Size = new System.Drawing.Size(218, 20);
            this.loopTrangThai.StyleController = this.layoutControl1;
            this.loopTrangThai.TabIndex = 6;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(54, 2);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(210, 20);
            this.txtTenKho.StyleController = this.layoutControl1;
            this.txtTenKho.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(540, 67);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenKho;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem1.Text = "Tên Kho";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(540, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.loopTrangThai;
            this.layoutControlItem3.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(274, 24);
            this.layoutControlItem3.Text = "Trạng thái";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.separatorControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(455, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThem;
            this.layoutControlItem4.Location = new System.Drawing.Point(455, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // frmModifyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 67);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmModifyKho";
            this.Text = "Modify Kho";
            this.Load += new System.EventHandler(this.frmModifyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LookUpEdit loopTrangThai;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}