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
    public partial class frmModifyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyKhachHang()
        {
            InitializeComponent();
        }
        public frmModifyKhachHang(int ID)
        {         
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);
            txtKhachHang.Text = dt.Rows[0]["TenKhachHang"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dt.Rows[0]["SDT"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();
            btnThem.Text = "Cập nhật";

        }
        dbQLVLXDTableAdapters.tblKhachHangTableAdapter data = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();
        private void frmModifyKhachHang_Load(object sender, EventArgs e)
        {
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.Insert(txtKhachHang.Text, txtDiaChi.Text, txtDienThoai.Text, int.Parse(loopTrangThai.EditValue.ToString()));
                this.Close();

            }
            if (Check == 1)
            {
                data.UpdateQuery(txtKhachHang.Text, txtDiaChi.Text, txtDienThoai.Text, int.Parse(loopTrangThai.EditValue.ToString()),ID);
                this.Close();
            }
        }
    }
}