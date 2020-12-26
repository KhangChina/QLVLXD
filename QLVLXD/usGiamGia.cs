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
    public partial class usGiamGia : DevExpress.XtraEditors.XtraUserControl
    {
        private static usGiamGia _instance;
        public static usGiamGia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usGiamGia();
                return _instance;
            }
        }
        public usGiamGia()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter data = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        private void usGiamGia_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiGiamGia();
            grc.DataSource = data.GetAll();          
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyGiamGia frm = new frmModifyGiamGia();
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyGiamGia frm = new frmModifyGiamGia(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc muốn xóa","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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
