using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class frmChiTietKhoHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietKhoHangHoa()
        {
            InitializeComponent();
        }
        int IDHH;
        public frmChiTietKhoHangHoa(int IDHH)
        {
            InitializeComponent();
            this.IDHH = IDHH;
        }
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKhoHangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();

        private void frmChiTietKhoHangHoa_Load(object sender, EventArgs e)
        {
            lookHH.DisplayMember = "TenHH";
            lookHH.ValueMember = "ID";
            lookHH.DataSource = dataHangHoa.GetAll();
            colHH.ColumnEdit = lookHH;

            lookKho.DisplayMember = "TenKho";
            lookKho.ValueMember = "ID";
            lookKho.DataSource = dataKho.GetAll();
            colKho.ColumnEdit = lookKho;

            grc.DataSource = dataKhoHangHoa.GetDataByIDHH(IDHH);
        }

        

        private void btnCapNhatKhoHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyKhoHangHoa frm = new frmModifyKhoHangHoa(ID);
            frm.ShowDialog();
            grc.DataSource = dataKhoHangHoa.GetDataByIDHH(IDHH);
        }

        private void btnXoaKhoHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            dataKhoHangHoa.DeleteQuery(ID);
            grc.DataSource = dataKhoHangHoa.GetDataByIDHH(IDHH);
        }
    }
}