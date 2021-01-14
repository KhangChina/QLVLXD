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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblNhanVienTableAdapter data = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            Session.dtNhanVien = new DataTable();
            Session.dtNhanVien = data.GetLogin(txtUsername.Text, txtPassword.Text);
            if (Session.dtNhanVien.Rows.Count > 0)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu hoặc tài khoản sai !");
            }


        }
    }
}