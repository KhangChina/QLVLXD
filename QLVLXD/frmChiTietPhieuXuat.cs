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
    public partial class frmChiTietPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        int IDHDX;
        public frmChiTietPhieuXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;
            DataTable dt = new DataTable();
            dt = dataHDX.GetDataByID(IDHDX);
            txtTenHD.Text = dt.Rows[0]["TenHD"].ToString();

            lookKH.Properties.DisplayMember = "TenKhachHang";
            lookKH.Properties.ValueMember = "ID";
            lookKH.Properties.DataSource = dataKhachHang.GetData();
            lookKH.EditValue = int.Parse(dt.Rows[0]["IDKH"].ToString());

            dateNgayLap.EditValue = DateTime.Parse(dt.Rows[0]["NgayLapXuat"].ToString());


        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHDX = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblKhachHangTableAdapter dataKhachHang = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();
        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            grc.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            //int IDCTHDX = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyChiTietHoaDonXuat frm = new frmModifyChiTietHoaDonXuat(IDHDX);
            frm.ShowDialog();
            grc.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);
        }
    }
}