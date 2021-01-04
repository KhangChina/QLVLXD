using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class frmModifyPhieuGiaoXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmModifyPhieuGiaoXuat()
        {
            InitializeComponent();
        }
        int IDCTHDX;
        int SLMax = 0;
        int SLDaGiao = 0;
        public frmModifyPhieuGiaoXuat(int IDCTHDX,int SLDaGiao)
        {
            InitializeComponent();
            this.IDCTHDX = IDCTHDX;
            DataTable dt = dataCTHDX.GetDataByID(IDCTHDX);
            lookVatLieu.EditValue = int.Parse(dt.Rows[0]["IDHH"].ToString());
            lookKho.EditValue = int.Parse(dt.Rows[0]["IDKho"].ToString());
            SLMax = int.Parse(dt.Rows[0]["SoLuongXuat"].ToString());
            this.SLDaGiao = SLDaGiao;
            spLanXuat.Properties.MinValue = 0;
        }

        dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter dataPhieuGiaoXuat = new dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataVatLieu = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();


        private void btnThem_Click(object sender, EventArgs e)
        {
            int SoLuongNhap = int.Parse(spSoLuong.EditValue.ToString());
            if (SoLuongNhap<=(SLMax - SLDaGiao))
            {
                dataPhieuGiaoXuat.InsertQuery(IDCTHDX, SoLuongNhap, int.Parse(spLanXuat.EditValue.ToString()));
                Close();
            }
            else
            {
                XtraMessageBox.Show("Số Lượng tối đa là: " + (SLMax - SLDaGiao));
            }
           
        }
        
        private void frmModifyPhieuGiaoXuat_Load(object sender, EventArgs e)
        {
            lookKho.Properties.DisplayMember = "TenKho";
            lookKho.Properties.ValueMember = "ID";
            lookKho.Properties.DataSource = dataKho.GetData();

            lookVatLieu.Properties.DisplayMember = "TenHH";
            lookVatLieu.Properties.ValueMember = "ID";
            lookVatLieu.Properties.DataSource = dataVatLieu.GetAll(); 

        }
    }
}