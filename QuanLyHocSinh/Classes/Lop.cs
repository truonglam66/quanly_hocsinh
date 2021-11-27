using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string MaGVCN { get; set; }

        public int NamHoc { get; set; }

        public List<Classes.HocSinh> HocSinhs { get; set; }
    }
}
