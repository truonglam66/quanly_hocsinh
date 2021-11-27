using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    public class HoatDong
    {
        public string MaHD { get; set; }
        public string TenHD { get; set; }
        public string MaGvPhuTrach { get; set; }
        public string DiaDiem { get; set; }
        public DateTime ThoiGian { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
    }
}
