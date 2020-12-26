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
    public partial class frmModifyPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter data = new dbQLVLXDTableAdapters.tblPhanQuyenTableAdapter();
        public frmModifyPhanQuyen()
        {
            InitializeComponent();
        }
        public frmModifyPhanQuyen(int ID)
        {
            InitializeComponent();
            Check = 1;
            this.ID = ID;
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);
            txtTen.Text = dt.Rows[0]["Ten"].ToString();
            txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
            btnThem.Text = "Cập nhật";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            if(Check == 1)
            {
                data.UpdateQuery(txtTen.Text, txtMoTa.Text, ID);
                this.Close();
            }
        }
    }
}