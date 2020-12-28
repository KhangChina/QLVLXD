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
    public partial class frmChiTietPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        int ID;
        public frmChiTietPhieuXuat(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {

        }
    }
}