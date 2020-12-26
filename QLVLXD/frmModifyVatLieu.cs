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
    public partial class frmModifyVatLieu : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyVatLieu()
        {
            InitializeComponent();

        }
        public frmModifyVatLieu(int ID)
        {
            Check = 1;
            InitializeComponent();
            this.ID = ID;
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);

            txtTenVatTu.Text = dt.Rows[0]["TenHH"].ToString();
            string pathImage = dt.Rows[0]["URLHinh"].ToString();
            if(pathImage.Length>1)
            {
                Image imges = Image.FromFile(pathImage);
                pic.Image = imges;
            }
            

            loopLoaiVatTu.EditValue = dt.Rows[0]["IDMaLoai"].ToString();
            loopDVT.EditValue = dt.Rows[0]["IDDVT"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();
            txtGia.Text = dt.Rows[0]["Gia"].ToString();
            txtXuatXu.Text = dt.Rows[0]["XuatXu"].ToString();

        }
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter data = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter dataLoaiVatLieu = new dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter();
        dbQLVLXDTableAdapters.tblDVTTableAdapter dataDonViTinh = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        private void frmModifyVatLieu_Load(object sender, EventArgs e)
        {

            #region Load Loai Vat Lieu
            loopLoaiVatTu.Properties.DisplayMember = "TenLoai";
            loopLoaiVatTu.Properties.ValueMember = "ID";
            loopLoaiVatTu.Properties.DataSource = dataLoaiVatLieu.GetData();   
            #endregion

            #region Load Don Vi Tinh
            loopDVT.Properties.DisplayMember = "TenDVT";
            loopDVT.Properties.ValueMember = "ID";
            loopDVT.Properties.DataSource = dataDonViTinh.GetAll();   
            #endregion

            #region Trang Thai
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiVatLieu();         
            #endregion
        }

        private void btnThem_Click(object sender, EventArgs e)
        {    
            if(Check == 0)
            {
                data.InsertQuery(int.Parse(loopLoaiVatTu.EditValue.ToString()), txtTenVatTu.Text, pic.GetLoadedImageLocation(), int.Parse(loopDVT.EditValue.ToString()), txtXuatXu.Text, int.Parse(loopTrangThai.EditValue.ToString()), decimal.Parse(txtGia.Text));
                this.Close();
            }
           if(Check == 1)
            {
                data.UpdateQuery(int.Parse(loopLoaiVatTu.EditValue.ToString()), txtTenVatTu.Text, pic.GetLoadedImageLocation(), int.Parse(loopDVT.EditValue.ToString()), txtXuatXu.Text, int.Parse(loopTrangThai.EditValue.ToString()), decimal.Parse(txtGia.Text), ID);
                this.Close();
            }
        } 
    }
}