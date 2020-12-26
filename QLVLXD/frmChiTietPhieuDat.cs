using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
namespace QLVLXD
{
    public partial class frmChiTietPhieuDat : DevExpress.XtraEditors.XtraForm
    {
        int IDHD;
        public frmChiTietPhieuDat(int IDHD)
        {
            InitializeComponent();
            this.IDHD = IDHD;
            DataTable dt = new DataTable();
            dt = dataHoaDonNhap.GetDataByID(IDHD);
            txtTenHD.Text = dt.Rows[0]["TenHD"].ToString();
            txtNgayLap.Text = dt.Rows[0]["NgayLapNhap"].ToString();
            txtVAT.Text = dt.Rows[0]["VAT"].ToString();
        }
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter dataHoaDonNhap = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter dataChiTietHoaDonNhap = new dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        dbQLVLXDTableAdapters.tblNCCTableAdapter dataNCC = new dbQLVLXDTableAdapters.tblNCCTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmModifyThemChiTietHoaDonNhap frm = new frmModifyThemChiTietHoaDonNhap(IDHD);
            frm.ShowDialog();
            grc.DataSource = dataChiTietHoaDonNhap.GetDataByIDHDNhap(IDHD);
        }

        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            LoadData();//load loop
        }
        void LoadData()
        {
            grc.DataSource = dataChiTietHoaDonNhap.GetDataByIDHDNhap(IDHD);
            loopVatLieu.DisplayMember = "TenHH";
            loopVatLieu.ValueMember = "ID";
            loopVatLieu.DataSource = dataHangHoa.GetAll();
            colIDHH.ColumnEdit = loopVatLieu;

            loopNCC.DisplayMember = "TenNCC";
            loopNCC.ValueMember = "ID";
            loopNCC.DataSource = dataNCC.GetData();
            colIDNCC.ColumnEdit = loopNCC;

            loopGiamGia.DisplayMember = "PhanTram";
            loopGiamGia.ValueMember = "ID";
            loopGiamGia.DataSource = dataGiamGia.GetData();
            colGiamGia.ColumnEdit = loopGiamGia;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (grv.FocusedRowHandle < 0)
                return;
            int IDChiTietHDN = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyThemChiTietHoaDonNhap frm = new frmModifyThemChiTietHoaDonNhap(IDHD, IDChiTietHDN);
            frm.ShowDialog();
            grc.DataSource = dataChiTietHoaDonNhap.GetDataByIDHDNhap(IDHD);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (grv.FocusedRowHandle < 0)
                    return;
                int IDChiTietHDN = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
                dataChiTietHoaDonNhap.DeleteQuery(IDChiTietHDN);
                grc.DataSource = dataChiTietHoaDonNhap.GetDataByIDHDNhap(IDHD);
            }
            
        }

        private void frmChiTietPhieuDat_FormClosing(object sender, FormClosingEventArgs e)
        {
            double tonggia = double.Parse(colTongGia.SummaryItem.SummaryValue.ToString());
            //update hóa đơn
            dataHoaDonNhap.UpdateQueryTongGia(tonggia, IDHD);

        }
    }
}