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
    public partial class usDonViTinh : DevExpress.XtraEditors.XtraUserControl
    {
        private static usDonViTinh _instance;
        public static usDonViTinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usDonViTinh();
                return _instance;
            }
        }

        public usDonViTinh()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblDVTTableAdapter data = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmModifyDonViTinh frm = new frmModifyDonViTinh();
            frm.ShowDialog();
            grc.DataSource = data.GetAll();

        }
        private void usDonViTinh_Load(object sender, EventArgs e)
        {
            grc.DataSource = data.GetAll();
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyDonViTinh frm = new frmModifyDonViTinh(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Có Chắc Xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (grv.FocusedRowHandle < 0)
                    return;
                int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
                data.DeleteQuery(ID);
                grc.DataSource = data.GetAll();
            }
            
        }
    }
}
