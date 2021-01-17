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
using DevExpress.XtraGrid.Views.Grid;

namespace QLVLXD
{
    public partial class usTonKho : DevExpress.XtraEditors.XtraUserControl
    {

        private static usTonKho _instance;
        public static usTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usTonKho();
                return _instance;
            }
        }
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKho_HangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblDVTTableAdapter dataDVT = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHH = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKHo = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        public usTonKho()
        {
            InitializeComponent();
        }

        private void usTonKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {

            loopIDDVT.DisplayMember = "TenDVT";
            loopIDDVT.ValueMember = "ID";
            loopIDDVT.DataSource = dataDVT.GetAll();
            colIDDVT.ColumnEdit = loopIDDVT;

            loopIDHH.DisplayMember = "TenHH";
            loopIDHH.ValueMember = "ID";
            loopIDHH.DataSource = dataHH.GetAll();
            colIDHH.ColumnEdit = loopIDHH;

            loopIDKho.DisplayMember = "TenKho";
            loopIDKho.ValueMember = "ID";
            loopIDKho.DataSource = dataKHo.GetAll();
            colIDKho.ColumnEdit = loopIDKho;

            grc.DataSource = dataKho_HangHoa.GetAllSum();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnXemChiTietHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int IDHH = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "IDHH").ToString());
            frmChiTietKhoHangHoa frm = new frmChiTietKhoHangHoa(IDHH);
            frm.ShowDialog();
            LoadData();
        }
        private void btnThemVatLieuVaoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyKhoHangHoa frm = new frmModifyKhoHangHoa();
            frm.ShowDialog();
        }

        private void grv_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int  priority = int.Parse(View.GetRowCellDisplayText(e.RowHandle, View.Columns["Tong"]));
                if (priority <= 5)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                    e.Appearance.BackColor2 = Color.Red;
                }
            }
        }
    }
}
