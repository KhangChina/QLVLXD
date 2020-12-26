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
    public partial class frmModifyNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyNhaCungCap()
        {
            InitializeComponent();
        }
        public frmModifyNhaCungCap(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);
            txtNCC.Text = dt.Rows[0]["TenNCC"].ToString();
            txtDC.Text = dt.Rows[0]["DiaChi"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            btnThem.Text = "Cập nhật";
            
        }
        dbQLVLXDTableAdapters.tblNCCTableAdapter data = new dbQLVLXDTableAdapters.tblNCCTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.Insert(txtNCC.Text,txtDC.Text,txtSDT.Text);
                this.Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(txtNCC.Text, txtDC.Text, txtSDT.Text, ID);
                this.Close();
            }
        }
    }
}