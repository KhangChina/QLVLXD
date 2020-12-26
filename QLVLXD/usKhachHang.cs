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
    public partial class usKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static usKhachHang _instance;
        public static usKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usKhachHang();
                return _instance;
            }
        }
        public usKhachHang()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblKhachHangTableAdapter data = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();
        private void usKhachHang_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiKhachHang();
            grc.DataSource = data.GetData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            frmModifyKhachHang frm = new frmModifyKhachHang();
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc muốn xóa","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (grv.FocusedRowHandle < 0)
                    return;
                int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
                data.DeleteQuery(ID);
                grc.DataSource = data.GetData();
            }
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyKhachHang frm = new frmModifyKhachHang(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }
    }
}
