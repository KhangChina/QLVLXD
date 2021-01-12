using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVLXD
{
    public partial class rpHoaDonXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rpHoaDonXuat(string TenKH,string DiacChi,string SDT,string IDHoaDon)
        {
            InitializeComponent();
            lbTenKH.Text = TenKH;
            lbDicChi.Text = DiacChi;
            lbSDT.Text = SDT;
            lbIDHDX.Text = IDHoaDon;       
            cTenHH.DataBindings.Add("Text", this.DataSource, "TeHH");
            cSoLuong.DataBindings.Add("Text", this.DataSource, "SoLuong");
            cPhanTram.DataBindings.Add("Text", this.DataSource, "PhanTram");
            cGia.DataBindings.Add("Text", this.DataSource, "Gia");

        }

    }
}
