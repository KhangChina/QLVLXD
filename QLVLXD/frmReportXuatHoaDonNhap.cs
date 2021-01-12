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
    public partial class frmReportXuatHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {

        int IDHDN;
        public frmReportXuatHoaDonNhap(int IDHDN)
        {
            InitializeComponent();
            this.IDHDN = IDHDN;
            txtSoLan.EditValue = "1";



        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter data = new dbQLVLXDTableAdapters.tblChiTietHoaDonNhapTableAdapter();
        
        private void btnGetData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SLan = int.Parse(txtSoLan.EditValue.ToString());
            DataTable table =  data.GetReportHoaDonNhap(IDHDN, SLan);
            double TongGia = 0;
            foreach (DataRow item in table.Rows)
            {
                TongGia += double.Parse(item["TongGia"].ToString());
            }

            rpHoaDonNhap rp = new rpHoaDonNhap(IDHDN, SLan, TongGia.ToString());
            rp.LoadData();
            rp.DataSource = table;
           
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();

        }
    }
}