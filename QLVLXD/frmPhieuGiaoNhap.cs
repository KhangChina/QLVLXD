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
    public partial class frmPhieuGiaoNhap : DevExpress.XtraEditors.XtraForm
    {
        //show tat ca chi tiet hoa don nhap
        public frmPhieuGiaoNhap()
        {
            InitializeComponent();
        }
        int IDHD;
        public frmPhieuGiaoNhap(int IDHD)
        {
            InitializeComponent();
            this.IDHD = IDHD;
            
        }

        dbQLVLXDTableAdapters.tblPhieuGiaoNhapTableAdapter dataPhieuGiaoNhap = new dbQLVLXDTableAdapters.tblPhieuGiaoNhapTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter data = new dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        dbQLVLXDTableAdapters.tblNCCTableAdapter dataNCC = new dbQLVLXDTableAdapters.tblNCCTableAdapter();
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter dataHoaDonNhap = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
       
        private void frmPhieuGiaoNhap_Load(object sender, EventArgs e)
        {
            grcCTHD.DataSource = data.GetDataByIDHDNhap(IDHD);

            loopGiamGia.DisplayMember = "PhanTram";
            loopGiamGia.ValueMember = "ID";
            loopGiamGia.DataSource = dataGiamGia.GetAll();
            colIDGiamGia.ColumnEdit = loopGiamGia;

            loopNCC.DisplayMember = "TenNCC";
            loopNCC.ValueMember = "ID";
            loopNCC.DataSource = dataNCC.GetData();
            colNCC.ColumnEdit = loopNCC;

            loopVatLieu.DisplayMember = "TenHH";
            loopVatLieu.ValueMember = "ID";
            loopVatLieu.DataSource = dataHangHoa.GetAll();
            colIDVatLieu.ColumnEdit = loopVatLieu;
        }

        private void btnTaoPhieuGiaoNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvCTHD.FocusedRowHandle < 0)
                return;
            int ID_CTHD =int.Parse(grvCTHD.GetRowCellValue(grvCTHD.FocusedRowHandle, "ID").ToString());
            int ID_HH = int.Parse(grvCTHD.GetRowCellValue(grvCTHD.FocusedRowHandle, "IDHH").ToString());
            //Check SoLuong
            int SLMax = int.Parse(grvCTHD.GetRowCellValue(grvCTHD.FocusedRowHandle, "SoLuongNhap").ToString()) - int.Parse(colSoLuong.SummaryItem.SummaryValue.ToString());
            frmModifyPhieuGiaoNhap frm = new frmModifyPhieuGiaoNhap(ID_CTHD, ID_HH, SLMax);
            frm.ShowDialog();    
            grcPhieuNhap.DataSource = dataPhieuGiaoNhap.GetDataByIDCTHD(ID_CTHD);

            CheckSL();



        }

        private void grvCTHD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (grvCTHD.FocusedRowHandle < 0)
                return;
            int ID_CTHD = int.Parse(grvCTHD.GetRowCellValue(grvCTHD.FocusedRowHandle, "ID").ToString());
            grcPhieuNhap.DataSource = dataPhieuGiaoNhap.GetDataByIDCTHD(ID_CTHD);
            CheckSL();
        }
        void CheckSL()
        {
            //Check SoLuong
            int SoLuongVatTuHD = int.Parse(grvCTHD.GetRowCellValue(grvCTHD.FocusedRowHandle, "SoLuongNhap").ToString());
            if (int.Parse(colSoLuong.SummaryItem.SummaryValue.ToString()) == SoLuongVatTuHD)
            {
                btnTaoPhieuGiaoNhap.Enabled = false;
            }
            else if (int.Parse(colSoLuong.SummaryItem.SummaryValue.ToString()) > SoLuongVatTuHD)
            {
                XtraMessageBox.Show("Số lượng vật tư phiếu nhập sai");
                btnTaoPhieuGiaoNhap.Enabled = false;
            }
            else
            {
                btnTaoPhieuGiaoNhap.Enabled = true;
            }
        }
        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //dataHoaDonNhap.UpdateQueryDuyetNhanVien(2, IDHD);
            //this.Close();
        }

        private void frmPhieuGiaoNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable(); 
            dt = data.GetDataByIDHDNhap(IDHD);
            int checkSL = 0;
            foreach (DataRow item in dt.Rows)
            {
                DataTable dataItem = new DataTable();
                dataItem = dataPhieuGiaoNhap.GetSumByIDChiTietHoaDonNhap(int.Parse(item["ID"].ToString()));

                if (item["SoLuongNhap"].ToString() != dataItem.Rows[0]["Tong"].ToString())
                {
                    checkSL = 1;
                }
                   
            }
            if(checkSL == 0)
            {
                dataHoaDonNhap.UpdateQueryDuyetNhanVien(2, IDHD);
                XtraMessageBox.Show("Đã Cập Nhật Trạng Thái Hóa Đơn");
            }
        }
    }
}