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
            GetData(dateNow.DateTime.Month,dateNow.DateTime.Year);
        }
        void GetData(int month,int Year)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Month",typeof(decimal));
            dt.Columns.Add("Sum",typeof(decimal));
            for (int i = 1; i <= 12; i++)
            {
                dt.Rows.Add(i, decimal.Parse(dataHoaDonNhap.GetDataBySumMonthYear(Year, i).Rows[0]["Sum"].ToString()));
            }
            chartControl1.DataSource = dt;



            grc.DataSource = dataHoaDonNhap.GetDataByTrangThai(0);


            //#region //gauNhapDangGiao
            //arcScaleComponent1.MinValue = 0;
            //arcScaleComponent1.MaxValue = int.Parse(dataHoaDonNhap.GetDataBySumMonthYear(Year, month).Rows[0]["Sum"].ToString());
            //arcScaleComponent1.Value = int.Parse(dataHoaDonNhap.GetSLHoaDonByTrangThai(1,month,Year).Rows[0]["SoLuongHD"].ToString());
            //labelComponent1.Text = dataHoaDonNhap.GetSLHoaDonByTrangThai(1, month,Year).Rows[0]["SoLuongHD"].ToString();
            //#endregion


            //#region //gauNhapDaGiao
            //arcScaleComponent2.MinValue = 0;
            //arcScaleComponent2.MaxValue = int.Parse(dataHoaDonNhap.GetDataBySumMonthYear(Year, month).Rows[0]["Sum"].ToString());
            //arcScaleComponent2.Value = int.Parse(dataHoaDonNhap.GetSLHoaDonByTrangThai(2, month, Year).Rows[0]["SoLuongHD"].ToString());
            //labelComponent2.Text = dataHoaDonNhap.GetSLHoaDonByTrangThai(2, month, Year).Rows[0]["SoLuongHD"].ToString();
            //#endregion

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {           
            GetData(dateNow.DateTime.Month,dateNow.DateTime.Year);      
            arcScaleComponent1.EasingMode = EasingMode.EaseIn;
            arcScaleComponent1.EasingFunction = new BackEase();
            arcScaleComponent1.EnableAnimation = true;
        }

        private void btnDuyetHD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID  = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            dataHoaDonNhap.UpdateTrangThaiByAdmin(int.Parse(Session.dtNhanVien.Rows[0]["ID"].ToString()), 1, ID);
            grc.DataSource = dataHoaDonNhap.GetDataByTrangThai(0);
        }
    }
}
