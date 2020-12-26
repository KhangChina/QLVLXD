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
    public partial class frmModifyThemChiTietHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int IDHD;
        int IDChiTietHDNhap;
        public frmModifyThemChiTietHoaDonNhap(int IDHD)
        {
            InitializeComponent();         
            this.IDHD = IDHD;
            this.Text = "Thêm Chi Tiết Sản Phẩm (IDHD=" + IDHD + ")";
            LoadData();
        }
  
        public frmModifyThemChiTietHoaDonNhap(int IDHD,int IDChiTietHDNhap)
        {
            InitializeComponent();
            LoadData();
            Check = 1;
            this.IDHD = IDHD;
            this.IDChiTietHDNhap = IDChiTietHDNhap;
            this.Text = "Thêm Chi Tiết Sản Phẩm (IDHD=" + IDHD + ")";
            DataTable dt = new DataTable();
            dt = dataCTHDN.GetDataByID(IDChiTietHDNhap);
            txtDonGia.Text = dt.Rows[0]["DonGiaNhap"].ToString();
            spSoLuong.EditValue = int.Parse(dt.Rows[0]["DonGiaNhap"].ToString());
            loopGiamGia.EditValue = int.Parse(dt.Rows[0]["IDGiamGia"].ToString());
            loopNhaCungCap.EditValue = int.Parse(dt.Rows[0]["IDNCC"].ToString());
            loopVatLieu.EditValue = int.Parse(dt.Rows[0]["IDHH"].ToString());
            btnThem.Text = "Cập nhật";
        }
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHangHoa = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblDVTTableAdapter dataDonViTinh = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter dataGiamGia = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter dataCTHDN = new dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter();
        dbQLVLXDTableAdapters.tblNCCTableAdapter dataNCC = new dbQLVLXDTableAdapters.tblNCCTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                int IDHH = int.Parse(loopVatLieu.EditValue.ToString());
                int IDNCC = int.Parse(loopNhaCungCap.EditValue.ToString());
                int IDGiamGia = int.Parse(loopGiamGia.EditValue.ToString());
                int SLNhap = int.Parse(spSoLuong.EditValue.ToString());
                double DonGiaNhap = double.Parse(txtDonGia.Text);
                double TongGia = TinhTongGia();
                dataCTHDN.InsertQuery(IDHD, IDHH, IDNCC, IDGiamGia, SLNhap, DonGiaNhap, TongGia);
                this.Close();
            }
            if(Check == 1)
            {
                int IDHH = int.Parse(loopVatLieu.EditValue.ToString());
                int IDNCC = int.Parse(loopNhaCungCap.EditValue.ToString());
                int IDGiamGia = int.Parse(loopGiamGia.EditValue.ToString());
                int SLNhap = int.Parse(spSoLuong.EditValue.ToString());
                double DonGiaNhap = double.Parse(txtDonGia.Text);
                double TongGia = TinhTongGia();
                dataCTHDN.UpdateQuery(IDHD, IDHH, IDNCC, IDGiamGia, SLNhap, DonGiaNhap, TongGia,IDChiTietHDNhap);
                this.Close();
            }
          
        }

        private void frmModifyThemChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            
        }
        void LoadData()
        {
            loopDonViTinh.Properties.DisplayMember = "TenDVT";
            loopDonViTinh.Properties.ValueMember = "ID";
            loopDonViTinh.Properties.DataSource = dataDonViTinh.GetAll();
            loopDonViTinh.ItemIndex = 0;
            loopVatLieu.Properties.DisplayMember = "TenHH";
            loopVatLieu.Properties.ValueMember = "ID";
            loopVatLieu.Properties.DataSource = dataHangHoa.GetAll();
            loopVatLieu.ItemIndex = 0;
            loopGiamGia.Properties.DisplayMember = "PhanTram";
            loopGiamGia.Properties.ValueMember = "ID";
            loopGiamGia.Properties.DataSource = dataGiamGia.GetDataByTrangThai(0); //get theo loai nhập
            loopGiamGia.ItemIndex = 0;
            loopNhaCungCap.Properties.DisplayMember = "TenNCC";
            loopNhaCungCap.Properties.ValueMember = "ID";
            loopNhaCungCap.Properties.DataSource = dataNCC.GetData();
            loopNhaCungCap.ItemIndex = 0;
        }
        private void loopVatLieu_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataHangHoa.GetIDDVT(int.Parse(loopVatLieu.EditValue.ToString()));
            loopDonViTinh.EditValue = int.Parse(dt.Rows[0]["IDDVT"].ToString());
        }
        double TinhTongGia()
        {
            return (double.Parse(spSoLuong.Text) * double.Parse(txtDonGia.Text) * (double.Parse(loopGiamGia.Text) / 100));
        }

        private void btnThemGiamGia_Click(object sender, EventArgs e)
        {
            frmModifyGiamGia frm = new frmModifyGiamGia();
            frm.ShowDialog();
            LoadData();
        }
    }
}