using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class KhachHang
    {
        // KHÓA CHÍNH
        private string sMaKhachHang;
        // thuộc tính
        private string sTenKhachHang;
        private string sDiaChi;
        private string sLoaiKhach;
        private string sSDT;
        //khóa ngoại
        public string maHDMuaBan { get; set; }
        // plural
        public List<HoaDonMuaBan> HoaDonMuaBans { get; set; }
        // public 
        public string SMaKhachHang { get => sMaKhachHang; set => sMaKhachHang = value; }
        public string STenKhachHang { get => sTenKhachHang; set => sTenKhachHang = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SLoaiKhach { get => sLoaiKhach; set => sLoaiKhach = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
    }
}
