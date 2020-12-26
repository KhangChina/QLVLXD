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

        private void usDashboard_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID",typeof(int));
            //dt.Columns.Add("Value",typeof(int));
            //for (int i = 0; i < 12; i++)
            //{
            //    dt.Rows.Add(i, i);
            //}
            ////dt
            //chartControl1.DataSource = dt;
            //chartControl1.SeriesDataMember = "Value";


        }
    }
}
