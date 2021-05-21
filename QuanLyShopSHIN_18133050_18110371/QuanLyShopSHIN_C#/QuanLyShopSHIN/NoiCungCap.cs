using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopSHIN
{
    public class NoiCungCap
    {
        // khóa chính
        private string sMaNoiCungCap;
        // thuộc tính
        private string sTenNoiCungCap;
        private string sSanPhamCungCap;
        private string sSĐT;
        private string sEmail;

        // plural
        public HDNhapHang HDNhapHang { get; set; }
        //public
                // khóa chính
        public string SMaNoiCungCap { get => sMaNoiCungCap; set => sMaNoiCungCap = value; }
                // thuộc tính
        public string STenNoiCungCap { get => sTenNoiCungCap; set => sTenNoiCungCap = value; }
        public string SSanPhamCungCap { get => sSanPhamCungCap; set => sSanPhamCungCap = value; }
        public string SSĐT { get => sSĐT; set => sSĐT = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }

        
        

    }
}
