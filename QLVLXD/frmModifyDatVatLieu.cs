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
    public partial class frmModifyDatVatLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmModifyDatVatLieu()
        {
            InitializeComponent();
            NgayLap.EditValue = now;
        }
        DateTime now = DateTime.Now;
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter data = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
        private void btnTao_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Session.dtNhanVien.Rows[0]["ID"].ToString());
            DateTime now = DateTime.Now;          
            //Trang thay chưa duyệt 0
            data.InsertQuery(ID, now, 0, double.Parse(txtVAT.Text), txtTen.Text);
            this.Close();
        }
    }
}