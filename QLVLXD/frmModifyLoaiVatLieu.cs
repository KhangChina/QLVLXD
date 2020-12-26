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
    public partial class frmModifyLoaiVatLieu : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyLoaiVatLieu()
        {
            InitializeComponent();
        }
        public frmModifyLoaiVatLieu(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            DataTable dt = new DataTable();
            this.ID = ID;
            dt = data.GetDataByID(ID);
            txtTen.Text = dt.Rows[0]["TenLoai"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();
            txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
            btnThem.Text = "Cập Nhật";
        }
        dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter data = new dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter();
        private void frmModifyLoaiVatLieu_Load(object sender, EventArgs e)
        {
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiLoaiVatLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.Insert(txtTen.Text, loopTrangThai.EditValue.ToString(), txtMoTa.Text);
                this.Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(txtTen.Text, loopTrangThai.EditValue.ToString(), txtMoTa.Text,ID);
                this.Close();
            }
           
        }
    }
}