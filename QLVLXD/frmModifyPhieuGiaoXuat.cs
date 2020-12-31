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
    public partial class frmModifyPhieuGiaoXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmModifyPhieuGiaoXuat()
        {
            InitializeComponent();
        }
        int IDCTHDX;
        public frmModifyPhieuGiaoXuat(int IDCTHDX)
        {
            InitializeComponent();
            this.IDCTHDX = IDCTHDX;
            DataTable dt = dataCTHDX.GetDataByID(IDCTHDX);
            lookVatLieu.EditValue = int.Parse(dt.Rows[0]["IDHH"].ToString());
            lookKho.EditValue = int.Parse(dt.Rows[0]["IDKho"].ToString());
            spSoLo.Text = dt.Rows[0]["SoLo"].ToString();
          //  spSoLuong.Properties.MaxValue = int.Parse(dt.Rows[0]["SoLuong"].ToString());

            spLanXuat.Properties.MinValue = 0;
        }

        dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter dataPhieuGiaoXuat = new dbQLVLXDTableAdapters.tblPhieuGiaoXuatTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKho = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataVatLieu = new dbQLVLXDTableAdapters.tblKhoTableAdapter();
        dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter dataCTHDX = new dbQLVLXDTableAdapters.tblChiTietHoaDonXuatTableAdapter();

        private void btnThem_Click(object sender, EventArgs e)
        {
            dataPhieuGiaoXuat.InsertQuery(IDCTHDX,int.Parse(spSoLuong.EditValue.ToString()), int.Parse(spLanXuat.EditValue.ToString()));
            Close();

        }
        
        private void frmModifyPhieuGiaoXuat_Load(object sender, EventArgs e)
        {
            lookKho.Properties.DisplayMember = "TenKho";
            lookKho.Properties.ValueMember = "ID";
            lookKho.Properties.DataSource = dataKho.GetData();

            lookVatLieu.Properties.DisplayMember = "TenHH";
            lookVatLieu.Properties.ValueMember = "ID";
            lookVatLieu.Properties.DataSource = dataVatLieu.GetData(); 

        }
    }
}