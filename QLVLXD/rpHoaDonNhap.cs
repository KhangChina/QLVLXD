using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVLXD
{
    public partial class rpHoaDonNhap : DevExpress.XtraReports.UI.XtraReport
    {
        int IDHD, LanNhap;
        string TongGiaHD;

        public rpHoaDonNhap(int IDHD, int LanNhap,string TongGiaHD)
        {
            InitializeComponent();
            this.IDHD = IDHD;
            this.LanNhap = LanNhap;
            this.TongGiaHD = TongGiaHD;
            lbDate.Text = DateTime.Now.ToString();
        }
        public void LoadData()
        {
            lbIDHoaDon.Text = IDHD.ToString();
            lbLanNhap.Text = LanNhap.ToString();

            cTenHH.DataBindings.Add("Text",this.DataSource, "TeHH");
            cSoLuong.DataBindings.Add("Text",this.DataSource, "SoLuong");
            cDonGiaNhap.DataBindings.Add("Text",this.DataSource, "DonGiaNhap");
            cGiamGia.DataBindings.Add("Text",this.DataSource, "PhanTram");
            cTongGia.DataBindings.Add("Text",this.DataSource, "TongGia");

            lbTongGia.Text = TongGiaHD;
        }

    }
}
