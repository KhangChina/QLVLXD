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
    public partial class usDatVatLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static usDatVatLieu _instance;
        public static usDatVatLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usDatVatLieu();
                return _instance;
            }
        }
        public usDatVatLieu()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter data = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
        private void btnTaoPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyDatVatLieu frm = new frmModifyDatVatLieu();
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }
        private void usDatVatLieu_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiDatHang();
            grc.DataSource = data.GetAll();
        }

        private void btnChiTietPhieuDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmChiTietPhieuDat frm = new frmChiTietPhieuDat(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }

        private void btnDuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            data.UpdateQueryDuyetNhanVien(1,ID);
            grc.DataSource = data.GetAll();
        }
    }
}
