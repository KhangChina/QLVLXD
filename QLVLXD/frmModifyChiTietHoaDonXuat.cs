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
    public partial class frmModifyChiTietHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmModifyChiTietHoaDonXuat()
        {
            InitializeComponent();
        }
        int IDHDX;
        public frmModifyChiTietHoaDonXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;
        }
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKhoHangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();

        private void btnThem_Click(object sender, EventArgs e)
        {
            int IDKho = int.Parse(lookKho.EditValue.ToString());
           
            DataRowView row = (DataRowView)lookVatLieu.Properties.GetRowByKeyValue(lookVatLieu.EditValue);//get value all column
            int IDHH = int.Parse(row["IDHH"].ToString());
            int IDKhoHangHoa = int.Parse(row["ID"].ToString());
            int SoLuongTon =   int.Parse(row["SoLuongTon"].ToString());
            int IDGiamGia = int.Parse(lookGiamGia.EditValue.ToString());
            int SLXuat = int.Parse(spSoLuong.EditValue.ToString());


            double DGXuat = double.Parse(dataHangHoa.GetGiaByID(IDHH).Rows[0]["Gia"].ToString()) * double.Parse(SLXuat.ToString()) - (double.Parse(dataHangHoa.GetGiaByID(IDHH).Rows[0]["Gia"].ToString()) * double.Parse(SLXuat.ToString())*(double.Parse(lookGiamGia.Text)/100));
            dataCTHDX.InsertQuery(IDHDX, IDKho, IDHH, IDGiamGia, SLXuat, int.Parse(DGXuat.ToString()), IDKhoHangHoa);//insert Chi tiet hoa don
            dataKhoHangHoa.UpdateSoLuong((SoLuongTon - SLXuat), IDKhoHangHoa); //update Số lượng kho
            this.Close();

        }

        private void frmModifyChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {        
            lookKho.Properties.DataSource = dataKho.GetDataByTrangThai(1);
            lookKho.Properties.DisplayMember = "TenKho";
            lookKho.Properties.ValueMember = "ID";
            lookKho.ItemIndex = 0;

            lookGiamGia.Properties.DataSource = dataGiamGia.GetDataByTrangThai(1);
            lookGiamGia.Properties.DisplayMember = "PhanTram";
            lookGiamGia.Properties.ValueMember = "ID";
            lookGiamGia.ItemIndex = 0;
        }

        private void lookKho_EditValueChanged(object sender, EventArgs e)
        {
            lookVatLieu.Properties.DataSource = dataKhoHangHoa.GetDataByIDKhoTrangThai(int.Parse(lookKho.EditValue.ToString()),1);
            lookVatLieu.Properties.DisplayMember = "TenHH";
            lookVatLieu.Properties.ValueMember = "ID";
            
        }

        private void lookVatLieu_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)lookVatLieu.Properties.GetRowByKeyValue(lookVatLieu.EditValue);//get value all column
            int SoLuongTon = int.Parse(row["SoLuongTon"].ToString());
            spSoLuong.Properties.MaxValue = SoLuongTon;
            spSoLuong.Properties.MinValue = 1;
        }
    }
}