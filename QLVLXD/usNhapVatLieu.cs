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
    public partial class usNhapVatLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static usNhapVatLieu _instance;
        public static usNhapVatLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usNhapVatLieu();
                return _instance;
            }
        }
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter data = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
        
        public usNhapVatLieu()
        {
            InitializeComponent();
        }

        private void btnTaoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ID =int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmPhieuGiaoNhap frm = new frmPhieuGiaoNhap(ID); //ID Hóa Đơn Nhập
            frm.ShowDialog();
            grc.DataSource = data.GetDataByTrangThai(1);
        }
        private void usNhapVatLieu_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiDatHang();
            grc.DataSource = data.GetDataByTrangThai(1);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grc.DataSource = data.GetDataByTrangThai(1);
        }

        private void btnXuatHoaDonNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IDHDN = int.Parse(grv.GetFocusedRowCellValue(colID).ToString());
            frmReportXuatHoaDonNhap frm = new frmReportXuatHoaDonNhap(IDHDN);
            frm.ShowDialog();
        }
    }
}
