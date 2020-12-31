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
    public partial class frmModifyHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyHoaDonXuat()
        {
            InitializeComponent();
            
        }
        public frmModifyHoaDonXuat(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            btnThem.Text = "Cập Nhật";
            DataTable dt = new DataTable();
            dt = dataHoaDonXuat.GetDataByID(ID);
            dateNgayLap.EditValue = dt.Rows[0]["NgayLapXuat"].ToString();
            lookKhacHang.EditValue = int.Parse(dt.Rows[0]["IDKH"].ToString());
            txtTenHD.Text = dt.Rows[0]["TenHD"].ToString();


        }
        dbQLVLXDTableAdapters.tblKhachHangTableAdapter dataKH = new dbQLVLXDTableAdapters.tblKhachHangTableAdapter();
        dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter dataHoaDonXuat = new dbQLVLXDTableAdapters.tblHoaDonXuatTableAdapter();
        private void frmModifyHoaDonXuat_Load(object sender, EventArgs e)
        {
            lookKhacHang.Properties.DataSource = dataKH.GetData();
            lookKhacHang.Properties.DisplayMember = "TenKhachHang";
            lookKhacHang.Properties.ValueMember = "ID";
            if(Check == 0)
            {
                dateNgayLap.EditValue = DateTime.Now;
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (Check == 0)
            {                
                dataHoaDonXuat.InsertQuery(
                   int.Parse(lookKhacHang.EditValue.ToString()),
                   int.Parse(Session.dtNhanVien.Rows[0]["ID"].ToString()),
                   null,
                   DateTime.Now,
                   0,
                   txtTenHD.Text,
                   0
                    );
                this.Close();
            }
            if(Check == 1)
            {             
                dataHoaDonXuat.UpdateQuery(
                   int.Parse(lookKhacHang.EditValue.ToString()),
                   int.Parse(Session.dtNhanVien.Rows[0]["ID"].ToString()),
                   null,
                   dateNgayLap.DateTime,
                   0,
                   txtTenHD.Text,
                   ID);
                this.Close();
            }
           
        }
    }
}