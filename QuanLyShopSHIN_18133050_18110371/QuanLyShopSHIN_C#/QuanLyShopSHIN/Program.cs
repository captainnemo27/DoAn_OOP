using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choose = 0;
            bool exit = false;
            

            while (true)
            {
                showMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        ThaoTacNhanVien();
                        break;
                    case 2:
                        // ThaoTacSanPham();
                        TaoDanhSachNhanVien();
                        TaoDanhSachNoiCungCap();
                        TaoDanhSachHDNhapHang();
                        TaoDanhSachSanPham();
                        TaoDanhSachKhachHang();
                        TaoDanhSachPhieuBaoHanh();
                        TaoDanhSachHoaDonMuaBan();
                        TaoDanhSachChiTietHDMuaBan();
                        CapNhatHDMuaBan();
                        TaoDanhSachPhieuThu();
                        CapNhatKhachHang();
                        Console.WriteLine("____Chọn danh sách lệnh : ");
                        Console.WriteLine("	0.Sắp xếp hóa đơn bán theo thời gian");
                        Console.WriteLine("	1.Tính số tiền lời khi bán 1 sản phẩm mã SP01");
                        Console.WriteLine("	2.Danh sách các sản phâm phải bảo hành và nơi cung cấp của nó");
                        Console.WriteLine("	3.Tính doanh thu trong ngày");
                        Console.WriteLine("	4.gia san pha nhap vo khong qua 800k");
                        Console.WriteLine("	5.Những Hóa đơn >5000K sẽ đc giảm giá 10%. Tìm và xuất ra thông tin số hóa đơn");
                        Console.WriteLine("	6.Nhân ngày 20/11 cửa hàng sẽ tặng quà cho các nhân viên nữ và sẽ rút thăm phần quà");
                        Console.WriteLine("	7.Liệt kê tất cả các sản phẩm được bán ra trong 1 ngày");
                        Console.WriteLine("	8.updating");
                        Console.WriteLine("	9.updating");
                        Console.WriteLine("	10.updating");
                        int ch = 0;
                        ch = int.Parse(Console.ReadLine());
                        String l = null;
                        if (ch == 1)
                            l = "QL";
                        if (ch == 2)
                            l = "TN";
                        if (ch == 3)
                            l = "TV";
                        switch (ch)
                        {
                            case 0:
                                lenh1();
                                break;
                            case 1:
                                lenh2();
                                break;
                            case 2:
                                lenh3();
                                break;
                            case 3:
                                lenh4();
                                break;
                            case 4:
                                lenh5();
                                break;
                            case 5:
                                lenh6();
                                break;
                            case 6:
                                lenh8();
                                break;
                            case 7:
                                lenh9();
                                break;
                            case 8:
                                Console.WriteLine("	8.updating");
                                break;
                            case 9:
                                Console.WriteLine("	9.updating");
                                break;
                            case 10:
                                Console.WriteLine("	10.updating");
                                break;
                            default:
                                break;
                        }
                        
                        Console.WriteLine("xong ròi nha ^^");
                        break;
                    case 3:
                        // ThaoTacMuaBan();
                        Console.WriteLine("chưa xong");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
                        break;
                }
                if (exit)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("SHIN rất vui vì đã giúp đỡ bạn ^^");
                    Console.WriteLine("Hẹn gặp lại lần sau");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    break;
                }
            }


            
            //CapNhatNhanVien();

            

        }

        public static List<QuanLy> NhanViens = new List<QuanLy>();
        public static List<NoiCungCap> NoiCungCaps = new List<NoiCungCap>();
        public static List<HDNhapHang> HDNhapHangs = new List<HDNhapHang>();
        public static List<SanPham> SanPhams = new List<SanPham>();
        public static List<PhieuBaoHanh> PhieuBaoHanhs = new List<PhieuBaoHanh>();
        public static List<ChiTietHDMuaBan> ChiTietHDMuaBans = new List<ChiTietHDMuaBan>();
        public static List<HoaDonMuaBan> HoaDonMuaBans = new List<HoaDonMuaBan>();
        public static List<KhachHang> KhachHangs = new List<KhachHang>();
        public static List<PhieuThu> PhieuThus = new List<PhieuThu>();


        public static void TaoDanhSachNoiCungCap()
        {
            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "SS01",
                STenNoiCungCap = "ANH BA",
                SSanPhamCungCap = "QUAN JEAN",
                SSĐT = "012345678",
                SEmail = "ANHBA@gmail.com",
            });

            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "SS02",
                STenNoiCungCap = "CHI HAI",
                SSanPhamCungCap = "AO THUN",
                SSĐT = "9756433562",
                SEmail = "CHIHAI@gmail.com",
            });
            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "AA01",
                STenNoiCungCap = "ANH MUOI",
                SSanPhamCungCap = "AO SO MI",
                SSĐT = "0465465456",
                SEmail = "ANHMUOI@gmail.com",

            });
            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "AA02",
                STenNoiCungCap = "ANH SAU",
                SSanPhamCungCap = "THAT LUNG",
                SSĐT = "0465465456",
                SEmail = "hANH SAU@gmail.com",

            });
            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "CC01",
                STenNoiCungCap = "HA NOI 1",
                SSanPhamCungCap = "AO KHOAC",
                SSĐT = "0865462132132",
                SEmail = "hanoi1@gmail.com",
            });
            NoiCungCaps.Add(new NoiCungCap()
            {
                SMaNoiCungCap = "CC02",
                STenNoiCungCap = "HA NOI 2",
                SSanPhamCungCap = "GIAY",
                SSĐT = "08564564561",
                SEmail = "hanoi2@gmail.com",

            });
        }
        public static void TaoDanhSachHDNhapHang()
        {
            //tạo danh sách các hoá đơn nhập ở SG01
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN01",
                SNgayNhap = new DateTime(2019, 1, 10),
                SGiaSanPham = 500000,
                ISoLuong = 10,
                IThue = 5,
                NoiCungCap = NoiCungCaps[0]
            });
            //tạo danh sách các hoá đơn nhập ở SG02
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN02",
                SNgayNhap = new DateTime(2018, 3, 20),
                SGiaSanPham = 600000,
                ISoLuong = 15,
                IThue = 10,
                NoiCungCap = NoiCungCaps[1]
            });
            //tạo danh sách các hoá đơn nhập ở HP01
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN03",
                SNgayNhap = new DateTime(2019, 4, 7),
                SGiaSanPham = 700000,
                ISoLuong = 50,
                IThue = 5,
                NoiCungCap = NoiCungCaps[2]
            });
            //tạo danh sách các hoá đơn nhập ở HP02
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN04",
                SNgayNhap = new DateTime(2018, 12, 10),
                SGiaSanPham = 800000,
                ISoLuong = 15,
                IThue = 10,
                NoiCungCap = NoiCungCaps[3]
            });
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN05",
                SNgayNhap = new DateTime(2017, 1, 2),
                SGiaSanPham = 900000,
                ISoLuong = 20,
                IThue = 10,
                NoiCungCap = NoiCungCaps[4]
            });
            HDNhapHangs.Add(new HDNhapHang()
            {
                SMaHoaDonNhap = "HDN06",
                SNgayNhap = new DateTime(2020, 7, 4),
                SGiaSanPham = 850000,
                ISoLuong = 25,
                IThue = 10,
                NoiCungCap = NoiCungCaps[5]
            });
        }
        public static void TaoDanhSachSanPham()
        {
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP01",
                SDonViTinh = "CAI",
                SHangSanPham = "NIKE",
                HDNhapHang = HDNhapHangs[0],
            });
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP02",
                SDonViTinh = "CAI",
                SHangSanPham = "ADIDAS",
                HDNhapHang = HDNhapHangs[1],
            });
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP03",
                SDonViTinh = "chiec",
                SHangSanPham = "TOMY",
                HDNhapHang = HDNhapHangs[2],
            });
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP04",
                SDonViTinh = "chiec",
                SHangSanPham = "ITALY",
                HDNhapHang = HDNhapHangs[3],
            });
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP05",
                SDonViTinh = "chiec",
                SHangSanPham = "PARIS",
                HDNhapHang = HDNhapHangs[4],
            });
            SanPhams.Add(new SanPham()
            {
                SMaSanPham = "SP06",
                SDonViTinh = "chiec",
                SHangSanPham = "CONVER",
                HDNhapHang = HDNhapHangs[5],
            });
        }
        public static void TaoDanhSachPhieuBaoHanh()
        {
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH01",
                SNgayMua = new DateTime(2019, 4, 10),
                IThoiHanBaoHanh = 6,
                SanPham = SanPhams[0]
            });
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH02",
                SNgayMua = new DateTime(2020, 7, 10),
                IThoiHanBaoHanh = 12,
                SanPham = SanPhams[1]
            });
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH03",
                SNgayMua = new DateTime(2019, 10, 10),
                IThoiHanBaoHanh = 24,
                SanPham = SanPhams[2]
            });
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH04",
                SNgayMua = new DateTime(2019, 1, 10),
                IThoiHanBaoHanh = 6,
                SanPham = SanPhams[3]
            });
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH05",
                SNgayMua = new DateTime(2018, 1, 10),
                IThoiHanBaoHanh = 18,
                SanPham = SanPhams[4]
            });
            PhieuBaoHanhs.Add(new PhieuBaoHanh()
            {
                SMaPhieuBaoHanh = "PBH06",
                SNgayMua = new DateTime(2019, 1, 10),
                IThoiHanBaoHanh = 6,
                SanPham = SanPhams[5]
            });
        }
        public static void TaoDanhSachHoaDonMuaBan()
        {
            HoaDonMuaBans.Add(new HoaDonMuaBan()
            {
                SMaHDMuaBan = "HDMB01",
                SNgayMua = new DateTime(2019, 5, 4),
                ISoTien = 3000000,
                IThueVAT = 10,
                SCachChiTra = true,
                maKhachHang = "KH01",
                KhachHang = (
                    from kh in KhachHangs
                    where kh.SMaKhachHang == "KH01"
                    select kh).Single(),
                maNhanVien = "NV01",
                QuanLy = (
                    from nv in NhanViens
                    where nv.sMaNV == "NV01"
                    select nv).Single(),
            });
            HoaDonMuaBans.Add(new HoaDonMuaBan()
            {
                SMaHDMuaBan = "HDMB02",
                SNgayMua = new DateTime(2019, 10, 4),
                ISoTien = 5000000,
                IThueVAT = 10,
                SCachChiTra = false,
                maKhachHang = "KH01",
                KhachHang = (
                from kh in KhachHangs
                where kh.SMaKhachHang == "KH01"
                select kh).Single(),
                maNhanVien = "NV01",
                QuanLy = (
                from nv in NhanViens
                where nv.sMaNV == "NV02"
                select nv).Single()
            });
            HoaDonMuaBans.Add(new HoaDonMuaBan()
            {
                SMaHDMuaBan = "HDMB03",
                SNgayMua = new DateTime(2019, 11, 4),
                ISoTien = 10000000,
                IThueVAT = 10,
                SCachChiTra = false,
                maKhachHang = "KH03",
                KhachHang = (
                from kh in KhachHangs
                where kh.SMaKhachHang == "KH03"
                select kh).Single(),
                maNhanVien = "NV01",
                QuanLy = (
                from nv in NhanViens
                where nv.sMaNV == "NV01"
                select nv).Single()
            });
            HoaDonMuaBans.Add(new HoaDonMuaBan()
            {
                SMaHDMuaBan = "HDMB04",
                SNgayMua = new DateTime(2019, 11, 4),
                ISoTien = 20000000,
                IThueVAT = 10,
                SCachChiTra = false,
                maKhachHang = "KH04",
                KhachHang = (
                from kh in KhachHangs
                where kh.SMaKhachHang == "KH04"
                select kh).Single(),
                maNhanVien = "NV01",
                QuanLy = (
                from nv in NhanViens
                where nv.sMaNV == "NV02"
                select nv).Single()
            });

        }
        public static void TaoDanhSachChiTietHDMuaBan()
        {
            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB01",
                ISoLuong = 10,
                SanPham = SanPhams[0],
                SHDMuaBan = "HDMB01",
                HoaDonMuaBan = (
                    from hd in HoaDonMuaBans
                    where hd.SMaHDMuaBan == "HDMB01"
                    select hd).Single()
            });

            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB02",
                ISoLuong = 10,
                SanPham = SanPhams[1],
                SHDMuaBan = "HDMB01",
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB01"
                select hd).Single()
            });
            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB03",
                ISoLuong = 25,
                SanPham = SanPhams[2],
                SHDMuaBan = "HDMB02",
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB02"
                select hd).Single()
            });
            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB04",
                ISoLuong = 11,
                SanPham = SanPhams[3],
                SHDMuaBan = "HDMB02",
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB02"
                select hd).Single()
            });
            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB05",
                ISoLuong = 20,
                SanPham = SanPhams[4],
                SHDMuaBan = "HDMB03",
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB03"
                select hd).Single()
            });
            ChiTietHDMuaBans.Add(new ChiTietHDMuaBan()
            {
                SMaChiTietHoaDonMuaBan = "CTHDMB06",
                ISoLuong = 17,
                SanPham = SanPhams[5],
                SHDMuaBan = "HDMB04",
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB04"
                select hd).Single()
            });




        }
        public static void TaoDanhSachKhachHang()
        {
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH01",
                STenKhachHang = "A",
                SDiaChi = "BIEN HOA",
                SLoaiKhach = "VIP",
                SSDT = "123456789"
            });
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH02",
                STenKhachHang = "B",
                SDiaChi = "TPHCM",
                SLoaiKhach = "VIP",
                SSDT = "45456465"
            });
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH03",
                STenKhachHang = "C",
                SDiaChi = "HAI PHONG",
                SLoaiKhach = "VIP",
                SSDT = "01246546546"
            });
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH04",
                STenKhachHang = "D",
                SDiaChi = "DA NANG",
                SLoaiKhach = "THAN THIET",
                SSDT = "02344484848"
            });
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH05",
                STenKhachHang = "E",
                SDiaChi = "HA NOI",
                SLoaiKhach = "THANH VIEN",
                SSDT = "0982478136"
            });
            KhachHangs.Add(new KhachHang()
            {
                SMaKhachHang = "KH06",
                STenKhachHang = "F",
                SDiaChi = "DA LAT",
                SLoaiKhach = "THAN THIET",
                SSDT = "09715486358"
            });
        }
        public static void TaoDanhSachNhanVien()
        {
            //tạo nhân viên cho nhóm Thu Ngân
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV01",
                sTen = "A",
                sGioiTinh = "NAM",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,

            });
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV02",
                sTen = "A",
                sGioiTinh = "NAM",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,
            });
            //tạo nhân viên cho nhóm Kỹ Thuật
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV03",
                sTen = "A",
                sGioiTinh = "NAM",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,
            });
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV04",
                sTen = "A",
                sGioiTinh = "NAM",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,
            });
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV05",
                sTen = "A",
                sGioiTinh = "NU",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,
            });
            NhanViens.Add(new QuanLy()
            {
                sMaNV = "NV06",
                sTen = "A",
                sGioiTinh = "NAM",
                iNamSinh = 1995,
                sSDT = "0123456789",
                sCMND = "123456",
                iSoNgayLam = 23,
                sDiaChi = "quan 9",
                sLoaiNV = "TN",
                iGioTangCa = 12,
            });
        }
        public static void CapNhatHDMuaBan()
        {
            HoaDonMuaBans[0].ChiTietHDMuaBans = (
                from hd in ChiTietHDMuaBans
                where hd.SHDMuaBan == "HDMB01"
                select hd).ToList();
            HoaDonMuaBans[1].ChiTietHDMuaBans = (
               from hd in ChiTietHDMuaBans
               where hd.SHDMuaBan == "HDMB02"
               select hd).ToList();
            HoaDonMuaBans[2].ChiTietHDMuaBans = (
               from hd in ChiTietHDMuaBans
               where hd.SHDMuaBan == "HDMB03"
               select hd).ToList();
            HoaDonMuaBans[3].ChiTietHDMuaBans = (
              from hd in ChiTietHDMuaBans
              where hd.SHDMuaBan == "HDMB04"
              select hd).ToList();
        }
        public static void CapNhatKhachHang()
        {
            KhachHangs[0].HoaDonMuaBans = (
                from kh in HoaDonMuaBans
                where kh.maKhachHang == "KH01"
                select kh).ToList();
            KhachHangs[1].HoaDonMuaBans = (
            from kh in HoaDonMuaBans
            where kh.maKhachHang == "KH02"
            select kh).ToList();
            KhachHangs[2].HoaDonMuaBans = (
                from kh in HoaDonMuaBans
                where kh.maKhachHang == "KH03"
                select kh).ToList();
            KhachHangs[3].HoaDonMuaBans = (
                from kh in HoaDonMuaBans
                where kh.maKhachHang == "KH04"
                select kh).ToList();
            KhachHangs[4].HoaDonMuaBans = (
                from kh in HoaDonMuaBans
                where kh.maKhachHang == "KH05"
                select kh).ToList();
            KhachHangs[5].HoaDonMuaBans = (
                from kh in HoaDonMuaBans
                where kh.maKhachHang == "KH06"
                select kh).ToList();
        }
        public static void TaoDanhSachPhieuThu()
        {
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT01",
                maHDMuaBan = "HDMB01",
                soTienTra = 23100000,
                HoaDonMuaBan = (
                    from hd in HoaDonMuaBans
                    where hd.SMaHDMuaBan == "HDMB01"
                    select hd).Single()
            });
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT02",
                maHDMuaBan = "HDMB01",
                soTienTra = 23100000,
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB01"
                select hd).Single()
            });
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT03",
                maHDMuaBan = "HDMB02",
                soTienTra = 10000000,
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB02"
                select hd).Single()
            });
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT04",
                maHDMuaBan = "HDMB02",
                soTienTra = 10000000,
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB02"
                select hd).Single()
            });
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT05",
                maHDMuaBan = "HDMB03",
                soTienTra = 8000000,
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB03"
                select hd).Single()
            });
            PhieuThus.Add(new PhieuThu()
            {
                maPhieuThu = "PT06",
                maHDMuaBan = "HDMB04",
                soTienTra = 5000000,
                HoaDonMuaBan = (
                from hd in HoaDonMuaBans
                where hd.SMaHDMuaBan == "HDMB04"
                select hd).Single()
            });
        }
        public static void lenh1()
        {
            //Sắp xếp hóa đơn bán theo thời gian
            var sapXep =
                from i in HoaDonMuaBans
                orderby i.SNgayMua
                select i;
            int count = 1;
            Console.WriteLine("         ----------------------SHOP Quần áo SHIN------------------------");
            Console.WriteLine("         ---------------------------------------------------------------");
            Console.WriteLine("         STT |   Ma Hoa Don    |        Ngay Xuat        |     So Tien  ");
            foreach (var i in sapXep)
            {
                Console.WriteLine("         {0}   |   {1}        |  {2}    |   {3}",
                    count++, i.SMaHDMuaBan, i.SNgayMua, i.ISoTien);
            }
        }       //OKE
        public static void lenh2()          //oke
        {
            //Tính số tiền lời khi bán 1 sản phẩm mã SP01
            var Tien =
                from n in HoaDonMuaBans
                where n.ChiTietHDMuaBans[0].SanPham.SMaSanPham == "SP01"
                select n;
            double s = 0;
            double s1 = 0;
            double s2 = 0;
            foreach (var n in Tien)
            {
                s1 = n.ISoTien * n.IThueVAT;
                s2 = n.ChiTietHDMuaBans[0].SanPham.HDNhapHang.SGiaSanPham
                    + (n.ChiTietHDMuaBans[0].SanPham.HDNhapHang.SGiaSanPham
                    * n.ChiTietHDMuaBans[0].SanPham.HDNhapHang.IThue / 100);
                s = s1 - s2;
                Console.WriteLine(">>>>>> So tien loi khi ban san pham {0} la: {1}",
                n.ChiTietHDMuaBans[0].SanPham.SMaSanPham, s);
                Console.WriteLine();
            }
        }
        public static void lenh3()
        {
            //Danh sách các sản phâm phải bảo hành và nơi cung cấp của nó
            var danhsach =
                from n in PhieuBaoHanhs
                select n;
            Console.WriteLine("Danh sach nhung san pham phai bao hanh: ");
            foreach (var n in danhsach)
            {
                Console.WriteLine("Ma san pham: {0}",
                    n.SanPham.SMaSanPham);
                Console.WriteLine("Ten san pham: {0}",
                    n.SanPham.HDNhapHang.NoiCungCap.SSanPhamCungCap);
                Console.WriteLine("Noi cung cap: {0}",
                    n.SanPham.HDNhapHang.NoiCungCap.STenNoiCungCap);
            }
        }       // OKE
        public static void lenh4()
        {
            //Tính doanh thu trong ngày
            var sanpham =
               from n in HoaDonMuaBans
               where n.SNgayMua == new DateTime(2019, 5, 4)
               select n;
            var TongBan_1Ngay =
                from n in sanpham
                group n by n.ChiTietHDMuaBans[0].HoaDonMuaBan into g
                select new
                {
                    hd = g.Key,
                    doanhthu = g.Sum(d => d.ChiTietHDMuaBans[0].ISoLuong
                    * d.ChiTietHDMuaBans[0].HoaDonMuaBan.ISoTien +
                    (d.ChiTietHDMuaBans[0].ISoLuong * d.ChiTietHDMuaBans[0].HoaDonMuaBan.ISoTien
                    * d.ChiTietHDMuaBans[0].HoaDonMuaBan.IThueVAT / 100))
                };
            foreach (var n in TongBan_1Ngay)
            {
                DateTime a = new DateTime(2019, 5, 4);
                Console.WriteLine("doanh thu ngày : {0}", a);
                Console.WriteLine("Doanh thu: {0:0}", n.doanhthu);
                Console.WriteLine();
            }
        }
        public static void lenh5()
        {
            // gia san pha nhap vo khong qua 800k
            var nhap =
                from n in SanPhams
                where n.HDNhapHang.SGiaSanPham +
                (n.HDNhapHang.SGiaSanPham * n.HDNhapHang.IThue / 100) <= 800000
                select n;
            Console.WriteLine("~~~~~~~~~~~~Danh sach san pham nhap vo co gia ko qua 800K: ");
            foreach (var n in nhap)
            {
                Console.WriteLine("----Ma san pham: {0}", n.SMaSanPham);
                Console.WriteLine("----Ten san pham: {0}", n.HDNhapHang.NoiCungCap.SSanPhamCungCap);
                Console.WriteLine("----Gia san pham: {0}", n.HDNhapHang.SGiaSanPham);
                Console.WriteLine("----Don vi tinh: {0}", n.SDonViTinh);
                Console.WriteLine("----So luong: {0}", n.HDNhapHang.ISoLuong);
                Console.WriteLine();
            }
        }
        public static void lenh6()
        {
            //Những Hóa đơn >5000K sẽ đc giảm giá 10%. Tìm và xuất ra thông tin số hóa đơn
            //đc giảm giá
            var hoaDon =
                from i in HoaDonMuaBans
                where i.ISoTien >= 5000000
                select i;
            double s = 0;
            int count = 1;
            Console.WriteLine("Cac Hoa Don Duoc Giam 10%");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("STT |  Ma Hoa Don    |    So Tien     |    Ngay Mua      |   Ten KH");
            foreach (var i in hoaDon)
            {
                s = i.ISoTien * 90 / 100;
                Console.WriteLine("{0}   |  {1}  \t     |   {2}\t|{3}\t|{4}", count++, i.SMaHDMuaBan, s, i.SNgayMua, i.KhachHang.STenKhachHang);
            }
        }      // oke
        public static void lenh8()
        {
            //Nhân ngày 20/11 cửa hàng sẽ tặng quà cho các nhân viên nữ và sẽ rút thăm phần quà
            //Tạo hàm random vs n nữ nhân viên tương ứng vs n phần quà và các nhân viên sẽ rút thăm
            //theo năm sinh tăng dần.
            string[] quaTang = { "HOA HONG", "TRANG PHAO TAY", "1 CHUYEN DI DU LICH", "1 CHIEC Dien Thoai", "1 DAY CHUYEN" };
            var rutTham =
                from i in NhanViens
                where i.sGioiTinh == "NU"
                orderby i.iNamSinh
                select new { i.sTen, i.iNamSinh };
            Console.WriteLine("Qua Tang Danh Cho Cac Nhan Vien Nu La: ");
            Console.WriteLine("----------------------------------------");
            foreach (var i in rutTham)
            {
                //Thread.Sleep(300);

                Random r = new Random();
                int k = r.Next(0, 5);
                Console.WriteLine("Ten Nu Nhan Vien: {0}, Ngay Sinh: {1}", i.sTen, i.iNamSinh);
                Console.WriteLine("---> Phan Thuong: {0}", quaTang[k]);
            }
        }     // oke
        /*public static void Linq12()
        {
            //Tìm nhân viên có lương cao nhất, xuất lương
            var dsNhanVien =
                from nv in NhanViens
                group nv by nv.sTen into g
                select new { sTen = g.Key, Luong = g.Max(n => n.LuongTong() };
            var luongCaoNhat =
                from i in dsNhanVien
                where i.Luong == (dsNhanVien.Max(n => n.LuongTong())
                select i;
            Console.WriteLine("Ten Nhan Vien Co Luong Cao Nhat");
            foreach (var i in luongCaoNhat)
            {
                Console.WriteLine("Ten: {0}, Luong: {1}", i.tenNhanVien, i.luong);
            }
        }*/
        public static void lenh9()
        {
            //Liệt kê tất cả các sản phẩm được bán ra trong 1 ngày
            Console.WriteLine("Cac San Pham Duoc Ban Ra Trong Ngay 10/1/2019");
            var lietKeSanPham =
                from i in PhieuBaoHanhs
                where i.SNgayMua == new DateTime(2019, 1, 10)
                select i;
            int count = 1;
            Console.WriteLine("STT   |     Ten San Pham    |     Gia Ban");
            foreach (var i in lietKeSanPham)
            {
                Console.WriteLine("{0}    \t      {1}       \t   {2}",
                    count++, i.SanPham.HDNhapHang.NoiCungCap.SSanPhamCungCap,
                    i.SanPham.HDNhapHang.SGiaSanPham);
            }
        } // oke

        public static void showMenu()
        {
            Console.WriteLine("--------- HÃY CÙNG SHIN QUẢN LÝ CỬA HÀNG NÀO ^^ ---------");
            Console.WriteLine("	0.Thoát.");
            Console.WriteLine("	1.Quản lý nhân viên nhà SHIN");
            Console.WriteLine("	2.Quản lý sản phẩm nhà SHIN");
            Console.WriteLine("	3.Quản lý bán hàng");
            Console.WriteLine("Chọn thao tác nào !");
            Console.WriteLine("****************************************************************************************");
        }

        public static void showMenuNhanVien()
        {
            Console.WriteLine("--------- HÃY CÙNG SHIN QUẢN LÝ NHÂN VIÊN CỬA HÀNG NÀO ^^ ---------");
            Console.WriteLine("	0.Thoát.");
            Console.WriteLine("	1.Thêm nhân viên mới");
            Console.WriteLine("	2.Cập nhật thông tin nhân viên");
            Console.WriteLine("	3.Xóa nhân viên theo mã nhân viên");
            Console.WriteLine("	4.In danh sách nhân viên");
            Console.WriteLine("	5.Tìm kiếm nhân viên");
        }

        public static void ThaoTacNhanVien()
        {
            int choose = 0;
            bool exit = false;
            
            showMenuNhanVien();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.KhoiTaoNhanVien();
            while (true)
            {
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        qlnv.addNhanVien();
                        showMenuNhanVien();
                        break;
                    case 2:
                        qlnv.editNhanVien();
                        showMenuNhanVien();
                        break;
                    case 3:
                        qlnv.delNhanVien();
                        showMenuNhanVien();
                        break;
                    case 4:
                        qlnv.showNhanVien();
                        showMenuNhanVien();
                        break;
                    case 5:
                        qlnv.searchNhanVien();
                        showMenuNhanVien();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
                        showMenuNhanVien();
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }

    }
}
