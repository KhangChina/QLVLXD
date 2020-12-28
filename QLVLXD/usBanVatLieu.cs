using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class usBanVatLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static usBanVatLieu _instance;
        public static usBanVatLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usBanVatLieu();
                return _instance;
            }
        }
        public usBanVatLieu()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHDXuat = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();

        dbQLVLXDTableAdapters.tblKhachHangTableAdapter dataKhachHang = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();

        dbQLVLXDTableAdapters.tblNhanVienTableAdapter dataNhanVien = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();
        private void btnThemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyHoaDonXuat frm = new frmModifyHoaDonXuat();
            frm.ShowDialog();
            grc.DataSource = dataHDXuat.GetData();
        }

        private void usBanVatLieu_Load(object sender, EventArgs e)
        {


            lookKH.DisplayMember = "TenKhachHang";
            lookKH.ValueMember = "ID";
            lookKH.DataSource = dataKhachHang.GetData();
            colKH.ColumnEdit = lookKH;

            lookNV.DisplayMember = "TenNV";
            lookNV.ValueMember = "ID";
            lookNV.DataSource = dataNhanVien.GetData();
            colNV.ColumnEdit = lookNV;

            lookTrangThai.DisplayMember = "Ten";
            lookTrangThai.ValueMember = "ID";
            lookTrangThai.DataSource = Session.KhoiTaoTrangThaiXuatHoaDon();
            colTrangThai.ColumnEdit = lookTrangThai;

            grc.DataSource = dataHDXuat.GetData();

        }

        private void btnCapNhatHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyHoaDonXuat frm = new frmModifyHoaDonXuat(ID);
            frm.ShowDialog();
            grc.DataSource = dataHDXuat.GetData();
        }

        private void btnChiTietHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmChiTietPhieuXuat frm = new frmChiTietPhieuXuat(ID);
            frm.ShowDialog();
        }
    }
}
