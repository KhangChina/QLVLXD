using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVLXD
{
  public static  class Session
    {
       public static DataTable dtNhanVien;       
       public static DataTable dt;
       public static DataTable KhoiTaoTrangThaiKho()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0","Không hoạt động");
            dt.Rows.Add("1","Đang hoạt động");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiLoaiVatLieu()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Không sử dụng");
            dt.Rows.Add("1", "Đang sử dụng");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiVatLieu()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Ngừng kinh doanh");
            dt.Rows.Add("1", "Đang kinh doanh");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiGiamGia()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Giảm giá nhập");
            dt.Rows.Add("1", "Giảm giá xuất");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiKhachHang()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");           
            dt.Rows.Add("0", "Khách hàng thường");
            dt.Rows.Add("1", "Khách hàng VIP");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiNhanVien()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Nhân Viên Đang Làm Việc");
            dt.Rows.Add("1", "Nhân Viên Đã Nghỉ Việc");
            return dt;
        }
        public static DataTable KhoiTaoGioiTinh()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Nữ");
            dt.Rows.Add("1", "Nam");
            return dt;
        }
        public static DataTable KhoiTaoTrangThaiDatHang()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Rows.Add("0", "Chưa Duyệt");
            dt.Rows.Add("1", "Đang Giao");
            dt.Rows.Add("2", "Đã Nhập Kho");
            return dt;
        }


    }
}
