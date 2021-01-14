using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class usBanChay : DevExpress.XtraEditors.XtraUserControl
    {
        private static usBanChay _instance;
        public static usBanChay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usBanChay();
                return _instance;
            }
        }
        public usBanChay()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter data = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        private void usBanChay_Load(object sender, EventArgs e)
        {
            dateNow.EditValue = DateTime.Now;
            DataTable dt = data.GetBanChay(dateNow.DateTime.Year, dateNow.DateTime.Month);
            chartControl1.DataSource = dt;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = data.GetBanChay(dateNow.DateTime.Year, dateNow.DateTime.Month);
            chartControl1.DataSource = dt;
        }
    }
}
