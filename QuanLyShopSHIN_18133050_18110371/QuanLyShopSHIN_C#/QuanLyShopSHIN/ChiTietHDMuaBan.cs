using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class ChiTietHDMuaBan
    {
        // khoa chính
        private string sMaChiTietHoaDonMuaBan;
        // thuộc tính
        private int iSoLuong;
        // khoa phu
        private string sMaSanPham;
        private string sHDMuaBan;
            
            // singular
        public SanPham SanPham { get; set; }
        public HoaDonMuaBan HoaDonMuaBan { get; set; }

        //public
            // khóa chính
        public string SMaChiTietHoaDonMuaBan { get => sMaChiTietHoaDonMuaBan; set => sMaChiTietHoaDonMuaBan = value; }
            // thuộc tính
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public string SMaSanPham { get => sMaSanPham; set => sMaSanPham = value; }
        public string SHDMuaBan { get => sHDMuaBan; set => sHDMuaBan = value; }

    }
}
