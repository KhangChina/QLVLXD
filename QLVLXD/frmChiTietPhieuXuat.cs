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
    public partial class frmChiTietPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        int IDHDX;
        public frmChiTietPhieuXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;
            DataTable dt = new DataTable();
            dt = dataHDX.GetDataByID(IDHDX);
            txtTenHD.Text = dt.Rows[0]["TenHD"].ToString();

            lookKH.Properties.DisplayMember = "TenKhachHang";
            lookKH.Properties.ValueMember = "ID";
            lookKH.Properties.DataSource = dataKhachHang.GetData();
            lookKH.EditValue = int.Parse(dt.Rows[0]["IDKH"].ToString());

            dateNgayLap.EditValue = DateTime.Parse(dt.Rows[0]["NgayLapXuat"].ToString());


        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHDX = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblKhachHangTableAdapter dataKhachHang = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKhoHangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadData();


        }
        void LoadData()
        {
            grc.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);

            lookHangHoa.DisplayMember = "TenHH";
            lookHangHoa.ValueMember = "ID";
            lookHangHoa.DataSource = dataHangHoa.GetAll();
            colHH.ColumnEdit = lookHangHoa;

            lookGiamGia.DisplayMember = "PhanTram";
            lookGiamGia.ValueMember = "ID";
            lookGiamGia.DataSource = dataGiamGia.GetAll();
            colGiamGia.ColumnEdit = lookGiamGia;

            lookKho.DisplayMember = "TenKho";
            lookKho.ValueMember = "ID";
            lookKho.DataSource = dataKho.GetAll();
            colKho.ColumnEdit = lookKho;

        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {           
            frmModifyChiTietHoaDonXuat frm = new frmModifyChiTietHoaDonXuat(IDHDX);
            frm.ShowDialog();
            LoadData();
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int IDHDX = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            int IDKhoHangHoa = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "IDKhoHangHoa").ToString());
            int SLXuat = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "SoLuongXuat").ToString());

            int SoLuongTon  = int.Parse(dataKhoHangHoa.GetSLTonByID(IDKhoHangHoa).Rows[0]["SoLuongTon"].ToString());
          

            dataKhoHangHoa.UpdateSoLuong(SoLuongTon + SLXuat, IDKhoHangHoa);
            dataCTHDX.DeleteQuery(IDHDX);

            LoadData();
           

        }

        private void frmChiTietPhieuXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            decimal TongGia = decimal.Parse(colDonGia.SummaryItem.SummaryValue.ToString());
            dataHDX.UpdateTongGia(TongGia,IDHDX);
        }
    }
}