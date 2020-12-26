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
    public partial class frmModifyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyNhanVien()
        {
            InitializeComponent();
        }
        public frmModifyNhanVien(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            btnThem.Text = "Cập nhật";
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);          
            txtNgaySinh.EditValue = dt.Rows[0]["NgaySinh"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
            txtTenNhanVien.Text = dt.Rows[0]["TenNV"].ToString();
            txtMoTa.Text = dt.Rows[0]["Mota"].ToString();
            txtPass.Text = dt.Rows[0]["PASSWORD"].ToString();

            loopGioiTinh.EditValue = dt.Rows[0]["GioiTinh"].ToString();
            loopQuyen.EditValue = dt.Rows[0]["IDPhanQuyen"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();

            if(dt.Rows[0]["URLHinh"].ToString().Length>1)
            {
                try
                {
                    Image im = Image.FromFile(dt.Rows[0]["URLHinh"].ToString());
                    pic.Image = im;
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Lỗi không tìm thấy hình: "+ex);
                }
                
                
            }
        }

        private void frmModifyNhanVien_Load(object sender, EventArgs e)
        {
            loopGioiTinh.Properties.DisplayMember = "Ten";
            loopGioiTinh.Properties.ValueMember = "ID";
            loopGioiTinh.Properties.DataSource = Session.KhoiTaoGioiTinh();
            loopGioiTinh.ItemIndex = 0;
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiNhanVien();
            loopTrangThai.ItemIndex = 0;
            loopQuyen.Properties.DisplayMember = "Ten";
            loopQuyen.Properties.ValueMember = "ID";
            loopQuyen.Properties.DataSource = dataPhanQuyen.GetData();
            loopQuyen.ItemIndex = 0;
        }
        dbQLVLXDTableAdapters.tblNhanVienTableAdapter data = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();
        dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter dataPhanQuyen = new dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.InsertQuery(
                        int.Parse(loopQuyen.EditValue.ToString()),
                        txtTenNhanVien.Text,
                        pic.GetLoadedImageLocation(),
                        int.Parse(loopGioiTinh.EditValue.ToString()),
                        DateTime.Parse(txtNgaySinh.EditValue.ToString()),
                        txtDiaChi.Text,                        
                        txtSoDienThoai.Text,
                        int.Parse(loopTrangThai.EditValue.ToString()),
                        txtMoTa.Text,
                        txtPass.Text
                        );
                Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(
                     int.Parse(loopQuyen.EditValue.ToString()),
                        txtTenNhanVien.Text,
                        pic.GetLoadedImageLocation(),
                        int.Parse(loopGioiTinh.EditValue.ToString()),
                        DateTime.Parse(txtNgaySinh.EditValue.ToString()),
                        txtDiaChi.Text,
                        txtSoDienThoai.Text,
                        int.Parse(loopTrangThai.EditValue.ToString()),
                        txtMoTa.Text,
                        txtPass.Text,
                        ID
                    );
               
                Close();
            }
        }
    }
}