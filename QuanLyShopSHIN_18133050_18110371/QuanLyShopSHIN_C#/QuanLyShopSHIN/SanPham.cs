using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class SanPham
    {
        // khóa chính
        private string sMaSanPham;
        // thuộc tính
        private string sDonViTinh;
        private string sHangSanPham;
        // khóa ngoại
        //private string sMaHoaDonNhap;
        private string sMaHoaDonMuaBan;
        private string sMaBaoHanh;
        
        
        // sigular
        public HDNhapHang HDNhapHang { get; set; }
        public PhieuBaoHanh PhieuBaoHanh { get; set; }
        public ChiTietHDMuaBan ChiTietHDMuaBan { get; set; }
        
        
        
        // khoa chính
        public string SMaSanPham { get => sMaSanPham; set => sMaSanPham = value; }
        //thuộc tính
        public string SDonViTinh { get => sDonViTinh; set => sDonViTinh = value; }
        public string SHangSanPham { get => sHangSanPham; set => sHangSanPham = value; }
        //khóa phụ
        public string SMaHoaDonNhap { get => SMaHoaDonNhap; set => SMaHoaDonNhap = value; }
        public string SMaHoaDonMuaBan { get => sMaHoaDonMuaBan; set => sMaHoaDonMuaBan = value; }
        public string SMaBaoHanh { get => sMaBaoHanh; set => sMaBaoHanh = value; }

        
        
        
    }
}
