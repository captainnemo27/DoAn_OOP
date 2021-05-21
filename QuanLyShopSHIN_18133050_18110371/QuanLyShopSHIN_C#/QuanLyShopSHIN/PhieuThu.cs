using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class PhieuThu
    {
        //Khóa Chính
        public string maPhieuThu { get; set; }
        // Thuoc tinh
        public double soTienTra { get; set; }
        //Khóa Ngoại
        public string maHDMuaBan { get; set; }
        //singular
        public HoaDonMuaBan HoaDonMuaBan { get; set; }
    }
}
