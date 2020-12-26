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


    public partial class usPhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        private static usPhanQuyen _instance;
        public static usPhanQuyen Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usPhanQuyen();
                return _instance;
            }
        }
        public usPhanQuyen()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter data = new dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter();
        private void usPhanQuyen_Load(object sender, EventArgs e)
        {
            grc.DataSource = data.GetData();
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyPhanQuyen frm = new frmModifyPhanQuyen(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetData();
        }
    }
}
