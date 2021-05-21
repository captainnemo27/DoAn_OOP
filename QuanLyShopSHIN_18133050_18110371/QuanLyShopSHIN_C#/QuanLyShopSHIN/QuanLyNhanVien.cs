using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class QuanLyNhanVien: NhanVien
    {
        private List<NhanVien> lNhanVien;

        public List<NhanVien> LNhanVien { get => lNhanVien; set => lNhanVien = value; }


        public void addNhanVien()
        {

            Console.WriteLine("___Hãy nhập thông tin nhân viên mới___");
            Console.WriteLine("____Chọn loại nhân viên: ");
            Console.WriteLine("Quản Lý  : QL");
            Console.WriteLine("Thu Ngân : TN");
            Console.WriteLine("Tư Vấn   : TV");
            this.sLoaiNV = Console.ReadLine();
            Console.WriteLine("Tên nhân viên: ");
            this.sTen = Console.ReadLine();

            Console.WriteLine("Giới tính: ");
            this.SGioiTinh = Console.ReadLine();

            Console.WriteLine("CMND: ");
            this.sCMND = Console.ReadLine();

            Console.WriteLine("Năm sinh: ");
            this.iNamSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Địa chỉ: ");
            this.sDiaChi = (Console.ReadLine());

            Console.WriteLine("SĐT: ");
            this.sSDT = Console.ReadLine();

            String maNV;
            int so = 0;
            //System.out.println(loaiNV);
            for (int j = this.LNhanVien.Count - 1; j >= 0; j--)
            {
                if (LNhanVien[j].Equals(sLoaiNV))
                {
                    so = int.Parse(this.LNhanVien[j].sMaNV.Substring(2, 4)); //substring(a,b) lấy đoạn chuỗi từ a đến b-1
                    break;
                }
            }
            if (so < 9)
                maNV = sLoaiNV + "0" + 1 ;
            else
                maNV = sLoaiNV + (so + 1);
            // sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, sLoaiNV, sGioiTinh

            int i = 0;

            switch (sLoaiNV)
            {
                case "QL":
                    NhanVien ql = new QuanLy(maNV, sTen,iNamSinh, sSDT, sDiaChi, sCMND, "QL", sGioiTinh);
                    LNhanVien.Add(ql);
                    i++;
                    break;
                case "TN":
                    NhanVien tn = new ThuNgan(maNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, 0,0,"TN", sGioiTinh);
                    LNhanVien.Add(tn);
                    i++;
                    break;
                case "TV":
                    NhanVien tv = new TuVan(maNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND,0,0, "TV", sGioiTinh);
                    LNhanVien.Add(tv);
                    i++;
                    break;
                default:
                    break;
            }
            if (i > 0)
            {
                Console.WriteLine("Thông tin nhân viên mới đã được lưu !!");
                Console.WriteLine("________________________________________________________");
            }
            else
            {
                Console.WriteLine("Có gì đó không ổn, bạn gõ 1 để nhập lại thông tin nhé !!");
                Console.WriteLine("________________________________________________________");
            }
        }
        public QuanLyNhanVien()
        {

        }

        public void KhoiTaoNhanVien()
        {
            lNhanVien = new List<NhanVien>();
            // String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND,
            // int SoNgayLam, int GioTangCa, String LoaiNV

            // quản lý
            NhanVien ql1 = new QuanLy("QL01", "Trần Thị Quản Lý", 1999, "0988188449", "Quận 9, Tp.HCM", "251274983", "QL", "Nữ");
            lNhanVien.Add(ql1);
            NhanVien ql2 = new QuanLy("QL02", "Nguyễn Trần Quản Lý", 1999, "0988188733", "Quận 8, Tp.HCM", "251287483", "QL", "Nam");
            lNhanVien.Add(ql2);

            // thu ngân
            NhanVien tn1 = new ThuNgan("TN01", "Lê Quỳnh Thu Ngân", 1998, "0986978673", "Quận Thủ Đức, Tp.HCM", "251274453",
                    0, 0, "TV", "Nữ");
            lNhanVien.Add(tn1);
            NhanVien tn2 = new ThuNgan("TN02", "Cao Thu Ngân", 1997, "0984567673", "Quận Bình Thạnh, Tp.HCM", "256784453",
                    0, 0, "TV", "Nam");
            lNhanVien.Add(tn2);

            // tư vấn
            NhanVien tv1 = new TuVan("TV01", "Cao Mỹ Tư Vấn", 2001, "0987983245", "Quận 2, Tp.HCM", "245274983", 0, 0, "TV",
                    "Nữ");
            lNhanVien.Add(tv1);
            NhanVien tv2 = new TuVan("TV02", "Trần Nguyễn Tư Vấn", 2001, "0935983245", "Quận 3, Tp.HCM", "246274983", 0, 0,
                    "TV", "Nam");
            lNhanVien.Add(tv2);

        }

        public void showNhanVien()
        {
            
            Console.WriteLine("____Chọn danh sách: ");
            Console.WriteLine("	0.Toàn bộ nhân viên");
            Console.WriteLine("	1.Quản Lý");
            Console.WriteLine("	2.Thu Ngân");
            Console.WriteLine("	3.Tư Vấn Mua Hàng");
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
                    showAllNhanVien();
                    break;
                case 1:
                    showQuanLy();
                    break;
                case 2:
                    showThuNgan();
                    break;
                case 3:
                    showTuVan();
                    break;
                default:
                    break;
            }
        }

        public void showAllNhanVien()
        {
            Console.WriteLine("                               ***DANH SÁCH NHÂN VIÊN SHOP SHIN***");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach(var nv in LNhanVien)
            {
                Console.WriteLine("     {0,-5}{1,-10}{2,-25}{3,-9}{4,-12}{5,-15}{6,-28}{7,-20} ", i, nv.sMaNV , nv.sTen ,nv.sGioiTinh ,nv.sCMND ,nv.iNamSinh ,nv.sDiaChi ,nv.sSDT);
                i++;
            }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showQuanLy()
        {
            Console.WriteLine("                            ***DANH SÁCH NHÂN VIÊN QUAN LY SHOP SHIN***");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach (var nv in LNhanVien)
                if (nv.sLoaiNV == "QL")
                {
                    Console.WriteLine("     {0,-5}{1,-10}{2,-25}{3,-9}{4,-12}{5,-15}{6,-28}{7,-20} ", i, nv.sMaNV , nv.sTen ,nv.sGioiTinh ,nv.sCMND ,nv.iNamSinh ,nv.sDiaChi ,nv.sSDT);
                    i++;
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showThuNgan()
        {
            Console.WriteLine("                            ***DANH SÁCH NHÂN VIÊN THU NGÂN SHOP SHIN***");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach(var nv in LNhanVien)
                if (nv.sLoaiNV == "TN")
                {
                    Console.WriteLine("     {0,-5}{1,-10}{2,-25}{3,-9}{4,-12}{5,-15}{6,-28}{7,-20} ", i, nv.sMaNV, nv.sTen, nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
                    i++;
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showTuVan()
        {
            Console.WriteLine("                         ***DANH SÁCH NHÂN VIÊN TƯ VẤN MUA HÀNG SHOP SHIN***");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach (var nv in LNhanVien)
                if (nv.sLoaiNV == "TV")
                {
                    Console.WriteLine("     {0,-5}{1,-10}{2,-25}{3,-9}{4,-12}{5,-15}{6,-28}{7,-20} ", i, nv.sMaNV, nv.sTen, nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
                    i++;
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();

        }

        
        public void delNhanVien()
        {
            
            Console.WriteLine("Nhập mã nhân viên của nhân viên bạn muốn xóa: ");
            string m = Console.ReadLine();
            foreach ( var nv in LNhanVien)
            {
                if (nv.sMaNV.Equals(m))
                {
                    lNhanVien.Remove(nv);
                    Console.WriteLine("Nhân viên " + m + " đã bị xóa !");
                    Console.WriteLine("__________________________________________________________");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Mã nhân viên này không tồn tại, bạn gõ 3 đã tiếp tục xóa !");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }

            }

        }

        public void editNhanVien()
        {
            
            Console.WriteLine("Nhập mã nhân viên của nhân viên bạn muốn chỉnh sửa: ");
            string m = Console.ReadLine();
            foreach(var nv in LNhanVien)
            {
                if (nv.sMaNV.Equals(m))
                {
                    Console.WriteLine("Tên nhân viên: ");
                    String ten = Console.ReadLine();
                    nv.sTen = ten;

                    Console.WriteLine("Giới tính: ");
                    String gt = Console.ReadLine();
                    nv.sGioiTinh = gt;

                    Console.WriteLine("CMND: ");
                    String cmnd = Console.ReadLine();
                    nv.sCMND=(cmnd);

                    Console.WriteLine("Năm sinh: ");
                    int namsinh = int.Parse(Console.ReadLine());
                    nv.iNamSinh=(namsinh);

                    Console.WriteLine("Địa chỉ: ");
                    String dc = Console.ReadLine();
                    nv.sDiaChi=(dc);

                    Console.WriteLine("SĐT: ");
                    String sdt = Console.ReadLine();
                    nv.sSDT=(sdt);
                    

                    Console.WriteLine("Thông tin nhân viên " + m + " đã được cập nhật !");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }
                else
                {
                    Console.WriteLine("Mã nhân viên này không tồn tại, bạn gõ 2 đã tiếp tục  !");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }
            }

        }

        public void searchNhanVien()
        {

            Console.WriteLine("                                        ***TÌM NHÂN VIÊN***");
            Console.WriteLine("Nhập mã nhân viên của nhân viên bạn muốn tìm: ");
            Console.WriteLine();
            string m = Console.ReadLine();
            Console.WriteLine(
                    "    ______________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var nv in LNhanVien)
            {
                if (nv.sMaNV.Equals(m))
                {
                    Console.WriteLine("    {0,-10}{1,-25}{2,-9}{3,-12}{4,-15}{5,-28}{6,-20} ", nv.sMaNV, nv.sTen, nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
                    Console.WriteLine(  "    ______________________________________________________________________________________________________________");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Mã nhân viên này không tồn tại, bạn gõ 5 đã tiếp tục TÌM !");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }

            }
        }
    }
}
