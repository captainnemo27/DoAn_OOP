using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class HDNhapHang
    {
        //khoa chính
        private string sMaHoaDonNhap;
        // thuộc tính
        private DateTime sNgayNhap;
        private double sGiaSanPham;
        private int iSoLuong;
        private double iThue;
        // khóa ngoại
        private string sMaNoiCungCap;
        private string sMaSanPham;

        public NoiCungCap NoiCungCap { get; set; }
        public SanPham SanPham { get; set; }


        // public 
              // khóa chính
        public string SMaHoaDonNhap { get => sMaHoaDonNhap; set => sMaHoaDonNhap = value; }
              // thuộc tính
        public DateTime SNgayNhap { get => sNgayNhap; set => sNgayNhap = value; }
        public double SGiaSanPham { get => sGiaSanPham; set => sGiaSanPham = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public double IThue { get => iThue; set => iThue = value; }
              // khóa ngoại
        public string SMaNoiCungCap { get => sMaNoiCungCap; set => sMaNoiCungCap = value; }
        public string SMaSanPham { get => sMaSanPham; set => sMaSanPham = value; }
    }
}
