﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        dbQLVLXDTableAdapters.tblNhanVienTableAdapter data = new dbQLVLXDTableAdapters.tblNhanVienTableAdapter();
        private void acKho_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usDanhMucKho.Instance))
            {
                container.Controls.Add(usDanhMucKho.Instance);
                usDanhMucKho.Instance.Dock = DockStyle.Fill;
                usDanhMucKho.Instance.BringToFront();
            }
            usDanhMucKho.Instance.BringToFront();
        }

        private void acDonViTinh_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usDonViTinh.Instance))
            {
                container.Controls.Add(usDonViTinh.Instance);
                usDonViTinh.Instance.Dock = DockStyle.Fill;
                usDonViTinh.Instance.BringToFront();
            }
            usDonViTinh.Instance.BringToFront();
        }

        private void acLoaiVatLieu_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usLoaiVatLieu.Instance))
            {
                container.Controls.Add(usLoaiVatLieu.Instance);
                usLoaiVatLieu.Instance.Dock = DockStyle.Fill;
                usLoaiVatLieu.Instance.BringToFront();
            }
            usLoaiVatLieu.Instance.BringToFront();
        }

        private void acVatLieu_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usVatLieu.Instance))
            {
                container.Controls.Add(usVatLieu.Instance);
                usVatLieu.Instance.Dock = DockStyle.Fill;
                usVatLieu.Instance.BringToFront();
            }
            usVatLieu.Instance.BringToFront();
        }

        private void acGiamGia_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usGiamGia.Instance))
            {
                container.Controls.Add(usGiamGia.Instance);
                usGiamGia.Instance.Dock = DockStyle.Fill;
                usGiamGia.Instance.BringToFront();
            }
            usGiamGia.Instance.BringToFront();
        }

        private void acNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usNhaCungCap.Instance))
            {
                container.Controls.Add(usNhaCungCap.Instance);
                usNhaCungCap.Instance.Dock = DockStyle.Fill;
                usNhaCungCap.Instance.BringToFront();
            }
            usNhaCungCap.Instance.BringToFront();
        }

        private void acKhachHang_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usKhachHang.Instance))
            {
                container.Controls.Add(usKhachHang.Instance);
                usKhachHang.Instance.Dock = DockStyle.Fill;
                usKhachHang.Instance.BringToFront();
            }
            usKhachHang.Instance.BringToFront();
        }

        private void acPhanQuyen_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usPhanQuyen.Instance))
            {
                container.Controls.Add(usPhanQuyen.Instance);
                usPhanQuyen.Instance.Dock = DockStyle.Fill;
                usPhanQuyen.Instance.BringToFront();
            }
            usPhanQuyen.Instance.BringToFront();
        }

        private void acNhanVien_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usNhanVien.Instance))
            {
                container.Controls.Add(usNhanVien.Instance);
                usNhanVien.Instance.Dock = DockStyle.Fill;
                usNhanVien.Instance.BringToFront();
            }
            usNhanVien.Instance.BringToFront();
        }

        private void acDatHangNhap_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usDatVatLieu.Instance))
            {
                container.Controls.Add(usDatVatLieu.Instance);
                usDatVatLieu.Instance.Dock = DockStyle.Fill;
                usDatVatLieu.Instance.BringToFront();
            }
            usDatVatLieu.Instance.BringToFront();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Session.dtNhanVien = new DataTable();
            Session.dtNhanVien = data.GetLogin("0964440775", "1");
            if(Session.dtNhanVien.Rows.Count>0)
            {
                txtNhanVienSession.Caption = Session.dtNhanVien.Rows[0]["TenNV"].ToString();
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập Fail");
            }
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usDashboard.Instance))
            {
                container.Controls.Add(usDashboard.Instance);
                usDashboard.Instance.Dock = DockStyle.Fill;
                usDashboard.Instance.BringToFront();
            }
            usDashboard.Instance.BringToFront();
        }

        private void acNhapVatLieu_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usNhapVatLieu.Instance))
            {
                container.Controls.Add(usNhapVatLieu.Instance);
                usNhapVatLieu.Instance.Dock = DockStyle.Fill;
                usNhapVatLieu.Instance.BringToFront();
            }
            usNhapVatLieu.Instance.BringToFront();
        }

        private void acTonKho_Click(object sender, EventArgs e)
        {
            //if (!container.Controls.Contains(usTonKho.Instance))
            //{
            //    container.Controls.Add(usTonKho.Instance);
            //    usTonKho.Instance.Dock = DockStyle.Fill;
            //    usTonKho.Instance.BringToFront();
            //}
            //usTonKho.Instance.BringToFront();
        }
    }
}