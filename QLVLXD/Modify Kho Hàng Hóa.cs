using System;
using System.Data;

namespace QLVLXD
{
    public partial class frmModifyKhoHangHoa : DevExpress.XtraEditors.XtraForm
    {
        int Check = 0;
        int ID;
        public frmModifyKhoHangHoa()
        {
            InitializeComponent();
        }
        public frmModifyKhoHangHoa(int ID)
        {
            InitializeComponent();
            Check = 1;
            this.ID = ID;
            btnThem.Text = "Cập nhật";
        }
        dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter dataKho_HangHoa = new dbQLVLXDTableAdapters.tblKho_HangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblHangHoaTableAdapter dataHH = new dbQLVLXDTableAdapters.tblHangHoaTableAdapter();
        dbQLVLXDTableAdapters.tblKhoTableAdapter dataKHo = new dbQLVLXDTableAdapters.tblKhoTableAdapter();

        private void fmrModifyKhoHangHoa_Load(object sender, EventArgs e)
        {

            lookVatLieu.Properties.DisplayMember = "TenHH";
            lookVatLieu.Properties.ValueMember = "ID";
            lookVatLieu.Properties.DataSource = dataHH.GetAll();
            lookVatLieu.ItemIndex = 0;

            lookKho.Properties.DisplayMember = "TenKho";
            lookKho.Properties.ValueMember = "ID";
            lookKho.Properties.DataSource = dataKHo.GetAll();
            lookKho.ItemIndex = 0;

            if (Check == 1)
            {
                DataTable dt = new DataTable();
                dt = dataKho_HangHoa.GetDataByID(ID);
                lookKho.EditValue = int.Parse(dt.Rows[0]["IDKho"].ToString());
                lookVatLieu.EditValue = int.Parse(dt.Rows[0]["IDHH"].ToString());
                spSoLo.EditValue = int.Parse(dt.Rows[0]["SoLo"].ToString());
                dateHanSuDung.EditValue = DateTime.Parse(dt.Rows[0]["HanSuDung"].ToString());
                spTonKho.EditValue = int.Parse(dt.Rows[0]["SoLuongTon"].ToString());
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check == 0)
            {
                dataKho_HangHoa.Insert(
               int.Parse(lookKho.EditValue.ToString()),
               int.Parse(lookVatLieu.EditValue.ToString()),
               int.Parse(spSoLo.EditValue.ToString()),
               DateTime.Parse(dateHanSuDung.EditValue.ToString()),
               int.Parse(spTonKho.EditValue.ToString())
               );

            }
            if (Check == 1)
            {
                dataKho_HangHoa.UpdateQuery(
             int.Parse(lookKho.EditValue.ToString()),
             int.Parse(lookVatLieu.EditValue.ToString()),
             int.Parse(spSoLo.EditValue.ToString()),
             DateTime.Parse(dateHanSuDung.EditValue.ToString()),
             int.Parse(spTonKho.EditValue.ToString()),
             ID
             );
            }
            this.Close();


        }
    }
}