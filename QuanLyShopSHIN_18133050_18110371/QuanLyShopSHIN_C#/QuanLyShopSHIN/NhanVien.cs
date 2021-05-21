using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{

    public abstract class NhanVien
    {
        public static int iSoLuongNhanVien = 0;
        public String sMaNV;
        public String sTen;
        public int iNamSinh;
        public String sSDT;
        public String sDiaChi;
        public String sCMND;
        public int iSoNgayLam;
        public int iGioTangCa;
        const double thuong = 500000;
        public String sLoaiNV;
        public String sGioiTinh;

        protected static int ISoLuongNhanVien { get => iSoLuongNhanVien; set => iSoLuongNhanVien = value; }
        protected string SMaNV { get => sMaNV; set => sMaNV = value; }
        protected string STen { get => sTen; set => sTen = value; }
        protected int INamSinh { get => iNamSinh; set => iNamSinh = value; }
        protected string SSDT { get => sSDT; set => sSDT = value; }
        protected string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        protected string SCMND { get => sCMND; set => sCMND = value; }
        protected int ISoNgayLam { get => iSoNgayLam; set => iSoNgayLam = value; }
        protected int IGioTangCa { get => iGioTangCa; set => iGioTangCa = value; }

        public static double Thuong => thuong;

        protected string SLoaiNV { get => sLoaiNV; set => sLoaiNV = value; }
        protected string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }

        public NhanVien(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, int iSoNgayLam,
                int iGioTangCa, String sLoaiNV, String sGioiTinh)
        {

            this.SMaNV = sMaNV;
            this.STen = sTen;
            this.INamSinh = iNamSinh;
            this.SSDT = sSDT;
            this.SDiaChi = sDiaChi;
            this.SCMND = sCMND;
            this.ISoNgayLam = iSoNgayLam;
            this.IGioTangCa = iGioTangCa;
            this.SLoaiNV = sLoaiNV;
            this.SGioiTinh = sGioiTinh;
            ISoLuongNhanVien++;
        }



        public NhanVien(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
                String sGioiTinh)
        {

            this.SMaNV = sMaNV;
            this.STen = sTen;
            this.INamSinh = iNamSinh;
            this.SSDT = sSDT;
            this.SDiaChi = sDiaChi;
            this.SCMND = sCMND;
            this.SLoaiNV = sLoaiNV;
            this.SGioiTinh = sGioiTinh;
        }

        protected NhanVien()
        {
        }

        public static double TienThuong(int iSoNgayLam, double thuong)
        {
            // mỗi tháng 30 ngày, được nghỉ 4 ngày tùy chọn
            // ngoài lương cơ bản, mỗi tháng có 500000 tiền thưởng
            // nghỉ thêm 1 ngày thì tiền thưởng giảm 100000, nghỉ quá 3 ngày thì không có
            // thưởng
            if (iSoNgayLam > 26)
                return (thuong + (iSoNgayLam - 26) * 100000);
            int soNgayNghi = 26 - iSoNgayLam;
            if (soNgayNghi < 4)
                return (thuong - soNgayNghi * 100000);
            else
                return 0;
        }


    }
}

