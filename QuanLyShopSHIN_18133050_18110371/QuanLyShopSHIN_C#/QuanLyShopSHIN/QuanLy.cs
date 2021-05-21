using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class QuanLy : NhanVien, Luong
    {
        public QuanLy() : base()
        {
        }

        public QuanLy(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND, 
             String LoaiNV, String GioiTinh) : this()
        {
            this.SMaNV = MaNV;
            this.STen = Ten;
            this.INamSinh = NamSinh;
            this.SSDT = SDT;
            this.SDiaChi = DiaChi;
            this.SCMND = CMND;
            this.SLoaiNV = LoaiNV;
            this.SGioiTinh = GioiTinh;

        }

        // public QuanLy(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
        //        String sGioiTinh)
        //{


        //}


        public double LuongCoBan()
        {
            // lương cơ bản của quản lý là 6 triệu/tháng
            return 7000000;
        }


        public double LuongTangCa()
        {
            // ngày làm 8 tiếng, tăng ca tính thêm tiền
            return IGioTangCa * 40000;
        }


        public double LuongTong()
        {
            return (LuongCoBan() + LuongTangCa() + TienThuong());
        }


        public double TienThuong()
        {
            return TienThuong(ISoNgayLam, Thuong);

        }
        
    }
}

