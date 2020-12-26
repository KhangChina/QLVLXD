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
    public partial class frmModifyKho : DevExpress.XtraEditors.XtraForm
    {
        int Check;
        public frmModifyKho()
        {
            Check = 0;
            InitializeComponent();
        }
        int ID;
        public frmModifyKho(int ID)
        {
            Check = 1;
            InitializeComponent();
            btnThem.Text = "Cập Nhật";
            this.ID = ID;
            DataTable dt = new DataTable();
            dt = data.FillByID(ID);
            txtTenKho.Text = dt.Rows[0]["TenKho"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();

        }
        dbQLVLXDTableAdapters.tblKhoTableAdapter data = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.InsertQuery(txtTenKho.Text, int.Parse(loopTrangThai.EditValue.ToString()));
                this.Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(txtTenKho.Text, int.Parse(loopTrangThai.EditValue.ToString()), ID);
                this.Close();
            }
        }
        private void frmModifyKho_Load(object sender, EventArgs e)
        {
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiKho();
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
        }
    }
}