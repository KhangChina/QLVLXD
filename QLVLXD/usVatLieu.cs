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
    public partial class usVatLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static usVatLieu _instance;
        public static usVatLieu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usVatLieu();
                return _instance;
            }
        }
        public usVatLieu()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter data = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter dataLoaiVatLieu = new dbQLVLXDTableAdapters.tblLoaiVatLieuTableAdapter();
        dbQLVLXDTableAdapters.tblDVTTableAdapter dataDonViTinh = new dbQLVLXDTableAdapters.tblDVTTableAdapter();
        private void usVatLieu_Load(object sender, EventArgs e)
        {
            #region Load Loai Vat Lieu
            loopLoaiVatTu.DisplayMember = "TenLoai";
            loopLoaiVatTu.ValueMember = "ID";
            loopLoaiVatTu.DataSource = dataLoaiVatLieu.GetData();//Get All
            colLoaiVatLieu.ColumnEdit = loopLoaiVatTu;
            #endregion

            #region Load Don Vi Tinh
            loopDVT.DisplayMember = "TenDVT";
            loopDVT.ValueMember = "ID";
            loopDVT.DataSource = dataDonViTinh.GetAll();
            colDVT.ColumnEdit = loopDVT;
            #endregion

            #region Trang Thai
            loopTrangThai.DisplayMember = "Ten";
            loopTrangThai.ValueMember = "ID";
            loopTrangThai.DataSource = Session.KhoiTaoTrangThaiVatLieu();
            colTrangThai.ColumnEdit = loopTrangThai;
            #endregion
            
            grc.DataSource = data.GetAll();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyVatLieu frm = new frmModifyVatLieu();
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ID = int.Parse(grv.GetRowCellValue(grv.FocusedRowHandle, "ID").ToString());
            frmModifyVatLieu frm = new frmModifyVatLieu(ID);
            frm.ShowDialog();
            grc.DataSource = data.GetAll();
        }
    }
}
