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
    public partial class usXuatKho : DevExpress.XtraEditors.XtraUserControl
    {
        private static usXuatKho _instance;
        public static usXuatKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usXuatKho();
                return _instance;
            }
        }
        public usXuatKho()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHDXuat = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();

        dbQLVLXDTableAdapters.tblKhachHangTableAdapter dataKhachHang = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();

        dbQLVLXDTableAdapters.tblNhanVienTableAdapter dataNhanVien = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();
        private void usXuatKho_Load(object sender, EventArgs e)
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

        private void btnTaoPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IDHDX = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmPhieuGiaoXuat frm = new frmPhieuGiaoXuat(IDHDX);
            frm.ShowDialog();
            grc.DataSource = dataHDXuat.GetData();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
