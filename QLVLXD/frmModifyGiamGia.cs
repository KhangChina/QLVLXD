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
    public partial class frmModifyGiamGia : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyGiamGia()
        {
            InitializeComponent();
        }
        public frmModifyGiamGia(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Check = 1;
            DataTable dt = new DataTable();
            dt =  data.GetDataByID(ID);
            pGiamGia.EditValue = dt.Rows[0]["PhanTram"].ToString();
            loopTrangThai.EditValue = dt.Rows[0]["TrangThai"].ToString();
            btnThem.Text = "Cập nhật";
        }
        dbQLVLXDTableAdapters.tblGiamGiaTableAdapter data = new dbQLVLXDTableAdapters.tblGiamGiaTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check == 0)
            {
                data.Insert(double.Parse(pGiamGia.EditValue.ToString()), int.Parse(loopTrangThai.EditValue.ToString()));
                this.Close();
            }
            if(Check == 1)
            {
                data.UpdateQuery(double.Parse(pGiamGia.EditValue.ToString()), int.Parse(loopTrangThai.EditValue.ToString()), ID);
                this.Close();
            }
           
        }
        private void frmModifyGiamGia_Load(object sender, EventArgs e)
        {
            loopTrangThai.Properties.DisplayMember = "Ten";
            loopTrangThai.Properties.ValueMember = "ID";
            loopTrangThai.Properties.DataSource = Session.KhoiTaoTrangThaiGiamGia();
        }
    }
}