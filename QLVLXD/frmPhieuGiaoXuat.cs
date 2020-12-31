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
    public partial class frmPhieuGiaoXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuGiaoXuat()
        {
            InitializeComponent();
        }
        int IDHDX;
        public frmPhieuGiaoXuat(int IDHDX)
        {
            InitializeComponent();
            this.IDHDX = IDHDX;     
        }
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();
        dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter dataPhieuXuat = new dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter();
        private void frmPhieuGiaoXuat_Load(object sender, EventArgs e)
        {
            grcCTHDX.DataSource = dataCTHDX.GetDataByIDHoaDon(IDHDX);
        }

        private void grvCTHDX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grvCTHDX.FocusedRowHandle < 0)
                return;
            int IDCTHDX = int.Parse(grvCTHDX.GetRowCellValue(grvCTHDX.FocusedRowHandle, "ID").ToString());
            grcPhieuXuat.DataSource = dataPhieuXuat.GetDataByIDCTHDX(IDCTHDX);
        }

        private void btnTaoPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
    }
}