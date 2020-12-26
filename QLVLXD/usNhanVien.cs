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
    public partial class usNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static usNhanVien _instance;
        public static usNhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usNhanVien();
                return _instance;
            }
        }
        public usNhanVien()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblNhanVienTableAdapter data = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();      
        private void usNhanVien_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiNhanVien();
            grc.DataSource =  data.GetData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyNhanVien frm = new frmModifyNhanVien();
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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
            frmModifyNhanVien frm = new frmModifyNhanVien(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }
    }
}
