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
    public partial class frmModifyDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyDonViTinh()
        {
            InitializeComponent();
        }
        public frmModifyDonViTinh(int ID)
        {
            InitializeComponent();
            Check = 1;
            this.ID = ID;
            DataTable dt = new DataTable();
            dt = data.GetDataByID(ID);
            txtTenDonViTinh.Text = dt.Rows[0]["TenDVT"].ToString();
            btnThem.Text = "Cập Nhật";

        }
        dbQLVLXDTableAdapters.tblDVTTableAdapter data = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.InsertQuery(txtTenDonViTinh.Text);
                this.Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(txtTenDonViTinh.Text,ID);
                this.Close();
            }
           
        }
    }
}