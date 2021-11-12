using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class TaiKhoan
    {
        public string Matk { get; set; }
        public string TenDangnhap { get; set; }
        public string TenHienthi { get; set; }
        public string Matkhau { get; set; }
        public TaiKhoan(string matk, string tendn, string tenht, string mk)
        {
            Matk = matk;
            TenDangnhap = tendn;
            TenHienthi = tenht;
            Matkhau = mk;
        }
    }
}
