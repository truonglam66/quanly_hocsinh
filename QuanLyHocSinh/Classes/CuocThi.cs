using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    public class CuocThi
    {
        public string MaCuocThi { get; set; }
        public string MaGvPhuTrach { get; set; }
        public string QuyMo { get; set; }
        public string DiaDiem { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MonThi { get; set; }
        public int NamHoc { get; set; }
        public List<Classes.HocSinh> HocSinhs { get; set; }
    }
}
