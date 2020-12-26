using System;

namespace QLVLXD
{
    public partial class frmModifyPhieuGiaoNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmModifyPhieuGiaoNhap()
        {
            InitializeComponent();
        }
        int IDChiTietHoaDonNhap;
        int IDVatLieu;
        int SoLuongMAX;
        public frmModifyPhieuGiaoNhap(int IDChiTietHoaDonNhap,int IDVatLieu,int SoLuongMAX)
        {
            InitializeComponent();
            this.IDChiTietHoaDonNhap = IDChiTietHoaDonNhap;
            this.IDVatLieu = IDVatLieu;
            this.SoLuongMAX = SoLuongMAX;
            spSoLuong.Properties.MaxValue = SoLuongMAX;
            spSoLuong.Properties.MinValue = 1;
        }
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        //dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter dataChiTietHoaDonNhap = new dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter();
        dbQLVLXDTableAdapters.tblPhieuGiaoNhapTableAdapter dataPhieuGiaoNhap = new dbQLVLXDTableAdapters.tblPhieuGiaoNhapTableAdapter();
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKhoHangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        private void frmModifyPhieuGiaoNhap_Load(object sender, EventArgs e)
        {
            loopKho.Properties.DisplayMember = "TenKho";
            loopKho.Properties.ValueMember = "ID";
            loopKho.Properties.DataSource = dataKho.GetDataByTrangThai(1);
            loopKho.ItemIndex = 0;

            loopVatLieu.Properties.DisplayMember = "TenHH";
            loopVatLieu.Properties.ValueMember = "ID";
            loopVatLieu.Properties.DataSource = dataHangHoa.GetDataByID(IDVatLieu);
            loopVatLieu.ItemIndex = 0;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Tạo Phiếu Nhập
            int ID = dataPhieuGiaoNhap.InsertQuery(IDChiTietHoaDonNhap, int.Parse(spSoLuong.EditValue.ToString()), int.Parse(spLanNhap.EditValue.ToString()));
            if (ID > 0)
            {
                //Cập nhật số lượng vào kho

                dataKhoHangHoa.InsertQuery(
                int.Parse(loopKho.EditValue.ToString()),
                IDVatLieu,
                int.Parse(numSoLo.EditValue.ToString()),
                DateTime.Parse(dateHSD.EditValue.ToString()),
                int.Parse(spSoLuong.EditValue.ToString()));
                this.Close();

            }


        }
    }
}