using System;
using System.Data;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class frmPhieuGiaoXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuGiaoXuat()
        {
            InitializeComponent();
        }
        int IDHDX;
        public frmPhieuGiaoXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;
        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter dataPhieuXuat = new dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter();

        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();

        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHDX = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();
        private void frmPhieuGiaoXuat_Load(object sender, EventArgs e)
        {
            grcCTHDX.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);

            lookKho.DisplayMember = "TenKho";
            lookKho.ValueMember = "ID";
            lookKho.DataSource = dataKho.GetAll();
            colKho.ColumnEdit = lookKho;

            lookHangHoa.DisplayMember = "TenHH";
            lookHangHoa.ValueMember = "ID";
            lookHangHoa.DataSource = dataHangHoa.GetAll();
            colHangHoa.ColumnEdit = lookHangHoa;

            lookGiamGia.DisplayMember = "PhanTram";
            lookGiamGia.ValueMember = "ID";
            lookGiamGia.DataSource = dataGiamGia.GetAll();
            colGiamGia.ColumnEdit = lookGiamGia;

        }
        private void grvCTHDX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grvCTHDX.FocusedRowHandle < 0)
                return;
            int IDCTHDX = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "ID").ToString());
           
            grcPhieuXuat.DataSource = dataPhieuXuat.GetDataByIDCTHDX(IDCTHDX);

            //Check Số Lượng
            int SoLuongDaGiao = int.Parse(colSoLuong.SummaryItem.SummaryValue.ToString());
            int SLCTHD = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "SoLuongXuat").ToString());
            if (SLCTHD == SoLuongDaGiao)
            {
                btnTaoPhieuXuat.Enabled = false;
            }
            else if(SLCTHD > SoLuongDaGiao)
            {
                btnTaoPhieuXuat.Enabled = true; ;
            }
            else
            {
                XtraMessageBox.Show("Số Lượng Không Hợp Lệ");
            }
        }
        private void btnTaoPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvCTHDX.FocusedRowHandle < 0)
                return;
            int IDCTHD = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "ID").ToString());
            int SoLuongDaGiao = int.Parse(colSoLuong.SummaryItem.SummaryValue.ToString());      
            frmModifyPhieuGiaoXuat frm = new frmModifyPhieuGiaoXuat(IDCTHD, SoLuongDaGiao);
            frm.ShowDialog();

            grcPhieuXuat.DataSource = dataPhieuXuat.GetDataByIDCTHDX(IDCTHD);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int  ID = int.Parse(grvPhieuXuat.GetRowCellValue(grvPhieuXuat.FocusedRowHandle, "ID").ToString());
            int SoLuong = int.Parse(grvPhieuXuat.GetRowCellValue(grvPhieuXuat.FocusedRowHandle, "SoLuong").ToString()); //Lấy số lượng hiện tại
            int SLCTHD = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "SoLuongXuat").ToString()); //lấy số lượng muốn xóa
            int IDCTHDX = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "ID").ToString()); // Lấy ID Chi Tiết Hóa Đơn Xuất
           


            //dataCTHDX.UpdateSoLuong(SoLuong+ SLCTHD, IDCTHDX);
            dataPhieuXuat.DeleteQuery(ID);

            grcCTHDX.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);
            grcPhieuXuat.DataSource = dataPhieuXuat.GetDataByIDCTHDX(IDCTHDX);
          
        }

        private void frmPhieuGiaoXuat_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            int CheckUpdate = 0;
            DataTable datChiTietHoaDonXuat = dataCTHDX.GetDataByIDHoaDon(IDHDX);
            foreach (DataRow itemCTHDX in datChiTietHoaDonXuat.Rows)
            {
                int SLCTHDX = int.Parse(itemCTHDX["SoLuongXuat"].ToString());
                int IDCTHDX = int.Parse(itemCTHDX["ID"].ToString());

                string SLPhieuXuat = dataPhieuXuat.GetSLByCTHDX(IDCTHDX).Rows[0]["SoLuong"].ToString();

                if(SLPhieuXuat.Length > 0 )
                {
                     int SLHHPhieuXuat= int.Parse(SLPhieuXuat);

                    if (SLCTHDX != SLHHPhieuXuat)
                    {
                        CheckUpdate = 1;                    
                    }
                }
                else
                {
                    CheckUpdate = 1;
                }
            }
            if(CheckUpdate == 0)
            {
                
                dataHDX.UpdateTrangThai(1, IDHDX);
                XtraMessageBox.Show("Đã cập nhật trạng thái hóa đơn");
            }
            


        }
    }
}