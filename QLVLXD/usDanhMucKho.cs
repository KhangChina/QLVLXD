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
    public partial class usDanhMucKho : DevExpress.XtraEditors.XtraUserControl
    {
        private static usDanhMucKho _instance;
        public static usDanhMucKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usDanhMucKho();
                return _instance;
            }
        }
        public usDanhMucKho()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblKhoTableAdapter data = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
       
        private void usDanhMucKho_Load(object sender, EventArgs e)
        {
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiKho();
            grcKho.DataSource = data.GetAll();
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            colTrangThai.ColumnEdit = loopTrangThai;


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyKho frm = new frmModifyKho();
            frm.ShowDialog();
            grcKho.DataSource = data.GetAll();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvKho.FocusedRowHandle < 0)
                return;
            int id = int.Parse(grvKho.GetRowCellValue(grvKho.FocusedRowHandle, "ID").ToString());
            frmModifyKho frm = new frmModifyKho(id);
            frm.ShowDialog();
            grcKho.DataSource = data.GetAll();
        }
    }
}
