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
using DevExpress.XtraGauges.Core.Model;

namespace QLVLXD
{
    public partial class usDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private static usDashboard _instance;
        public static usDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usDashboard();
                return _instance;
            }
        }
        public usDashboard()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter dataHoaDonNhap = new dbQLVLXDTableAdapters.tblHoaDonNhapTableAdapter();
        private void usDashboard_Load(object sender, EventArgs e)
        {        
            DateTime now = DateTime.Now;
            dateNow.EditValue = now;
            GetData(now.Year);
        }
        void GetData(int Year)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Month",typeof(decimal));
            dt.Columns.Add("Sum",typeof(decimal));
            for (int i = 1; i <= 12; i++)
            {
                dt.Rows.Add(i, decimal.Parse(dataHoaDonNhap.GetDataBySumMonthYear(Year, i).Rows[0]["Sum"].ToString()));
            }
            chartControl1.DataSource = dt;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {           
            GetData(dateNow.DateTime.Year);
            arcScaleComponent1.MinValue = 0;
            arcScaleComponent1.MaxValue = 100;
            arcScaleComponent1.Value = 60;
            labelComponent1.Text = "60";
            arcScaleComponent1.EasingMode = EasingMode.EaseIn;
            arcScaleComponent1.EasingFunction = new BackEase();
            arcScaleComponent1.EnableAnimation = true;
        }
    }
}
