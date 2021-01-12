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
    public partial class frmReportXuatHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        int IDHDX;
        public frmReportXuatHoaDonXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;
            txtSoLan.EditValue = "1";
        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter data = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        private void btnGetData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = data.GetReportHDX(IDHDX,int.Parse(txtSoLan.EditValue.ToString()));
            if(dt.Rows.Count > 0)
            {
                string tenKH = dt.Rows[0]["TenKhachHang"].ToString();
                string DiaChi = dt.Rows[0]["DiaChi"].ToString();
                string SDT = dt.Rows[0]["SDT"].ToString();
                rpHoaDonXuat rp = new rpHoaDonXuat(tenKH, DiaChi, SDT, IDHDX.ToString());
                rp.DataSource = dt;
                rp.CreateDocument();
                documentViewer1.DocumentSource = rp;
            }
          


        }
    }
}