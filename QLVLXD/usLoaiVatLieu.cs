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
    public partial class usLoaiVatLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static usLoaiVatLieu _instance;
        public static usLoaiVatLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usLoaiVatLieu();
                return _instance;
            }
        }
        public usLoaiVatLieu()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter data = new dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter();
        private void usLoaiVatLieu_Load(object sender, EventArgs e)
        {
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiLoaiVatLieu();
            grc.DataSource = data.GetData();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyLoaiVatLieu frm = new frmModifyLoaiVatLieu();
            frm.ShowDialog();
              grc.DataSource = data.GetData();
        }
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyLoaiVatLieu frm = new frmModifyLoaiVatLieu(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }
    }
}
