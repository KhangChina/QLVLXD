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
    public partial class usNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        private static usNhaCungCap _instance;
        public static usNhaCungCap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usNhaCungCap();
                return _instance;
            }
        }
        public usNhaCungCap()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblNCCTableAdapter data = new dbQLVLXDTableAdapters.tblNCCTableAdapter();
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyNhaCungCap frm = new frmModifyNhaCungCap();
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grv.FocusedRowHandle < 0)
                    return;
                int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
                data.DeleteQuery(ID);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID =  int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyNhaCungCap frm = new frmModifyNhaCungCap(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }

        private void usNhaCungCap_Load(object sender, EventArgs e)
        {
            grc.DataSource = data.GetData();
        }
    }
}
