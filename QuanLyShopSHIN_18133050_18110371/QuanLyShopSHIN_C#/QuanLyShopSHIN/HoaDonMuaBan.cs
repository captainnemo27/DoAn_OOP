using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class HoaDonMuaBan 
    {
        // khóa chính
        private string sMaHDMuaBan;
        // thuộc tính
        private DateTime sNgayMua;
        private double iSoTien;         //đây là tiền mà bán cho Khách, chưa tính VAT
        private double iThueVAT;
        private bool sCachChiTra;
        
        //plural
        public List<ChiTietHDMuaBan> ChiTietHDMuaBans { get; set; }
        public List<PhieuThu> PhieuThus { get; set; }
        //singular
        public QuanLy QuanLy { get; set; }
        public KhachHang KhachHang { get; set; }
        //Khóa Ngoại
        public string maChiTietHoaDonMuaBan { get; set; }
        public string maNhanVien { get; set; }
        public string maKhachHang { get; set; }
        public string maPhieuThu { get; set; }
        
        //public
        public string SMaHDMuaBan { get => sMaHDMuaBan; set => sMaHDMuaBan = value; }
        public DateTime SNgayMua { get => sNgayMua; set => sNgayMua = value; }
        public double ISoTien { get => iSoTien; set => iSoTien = value; }
        public double IThueVAT { get => iThueVAT; set => iThueVAT = value; }
        public bool SCachChiTra { get => sCachChiTra; set => sCachChiTra = value; }
             

    }
}
