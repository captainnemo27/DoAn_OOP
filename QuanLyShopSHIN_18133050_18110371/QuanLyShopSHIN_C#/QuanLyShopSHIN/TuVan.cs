using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class TuVan : NhanVien, Luong
    {
        public TuVan() : base()
        {
        }

        public TuVan(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND, int SoNgayLam, int GioTangCa,
             String LoaiNV, String GioiTinh) : this()
        {
            this.SMaNV = MaNV;
            this.STen = Ten;
            this.INamSinh = NamSinh;
            this.SSDT = SDT;
            this.SDiaChi = DiaChi;
            this.SCMND = CMND;
            this.ISoNgayLam = SoNgayLam;
            this.IGioTangCa = GioTangCa;
            this.SLoaiNV = LoaiNV;
            this.SGioiTinh = GioiTinh;

        }

        // public QuanLy(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
        //        String sGioiTinh)
        //{


        //}


        public double LuongCoBan()
        {
            return 650000;
        }

        
    public double LuongTangCa()
        {
            return iGioTangCa * 35000;
        }

        
    public double TienThuong()
        {
            return TienThuong(iSoNgayLam, Thuong);
        }

        
    public double LuongTong()
        {
            return (LuongCoBan() + LuongTangCa() + TienThuong());
        }
    }
}
