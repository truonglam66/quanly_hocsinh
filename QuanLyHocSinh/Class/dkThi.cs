using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Class
{
    class dkThi
    {
        public string Mhs { get; set; }
        public string TenHS { get; set; }
        public string Lop { get; set; }
        public string TenGV { get; set; }
        public string MonThi { get; set; }
        public string LoaiThi { get; set; }
        public dkThi()
        {
            Mhs = "Khong co";
            TenHS = "Khong co";
            Lop = "Khong co";
            TenGV = "Khong co";
            MonThi = "Khong co";
            LoaiThi = "Khong co";
        }
        public dkThi(string mhs, string tenhs, string lop, string tengv, string monthi, string loai)
        {
            Mhs = mhs;
            TenHS = tenhs;
            Lop = lop;
            TenGV = tengv;
            MonThi = monthi;
            LoaiThi = loai;
        }
    }
}
