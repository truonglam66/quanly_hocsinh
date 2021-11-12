using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Class
{
    class CHocSinh
    {
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public string NgaySinh { get; set; }
        public string PhuHuynh { get; set; }
        public string DiaChi { get; set; }

        public CHocSinh()
        {
            MaHS = "Khong co";
            TenHS = "Khong co";
            NgaySinh = "Khong co";
            PhuHuynh = "Khong co";
            DiaChi = "Khong co";
        }
        public CHocSinh(string mhs, string tenhs, string ngaysinh, string phuhuynh, string diachi)
        {
            MaHS = mhs;
            TenHS = tenhs;
            NgaySinh = ngaysinh;
            PhuHuynh = phuhuynh;
            DiaChi = diachi;
        }
    }
}
