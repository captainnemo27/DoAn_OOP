using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class PhieuBaoHanh
    {
        // khóa chính 
        private string sMaPhieuBaoHanh;
        // thuộc tính
        private DateTime sNgayMua;
        private int iThoiHanBaoHanh;
        // maSanPham kế thừa từ classs san pham thông qua class HoaDonMuaBan

        public SanPham SanPham { get; set; }

        //public
                // khóa chính
        public string SMaPhieuBaoHanh { get => sMaPhieuBaoHanh; set => sMaPhieuBaoHanh = value; }
                // thuộc tính
        // ngayMua kế thừa từ class HoaDonMuaBan
        public int IThoiHanBaoHanh { get => iThoiHanBaoHanh; set => iThoiHanBaoHanh = value; }
        public DateTime SNgayMua { get => sNgayMua; set => sNgayMua = value; }

        public static List<PhieuBaoHanh> PhieuBaoHanhs = new List<PhieuBaoHanh>();
        
    }
}
