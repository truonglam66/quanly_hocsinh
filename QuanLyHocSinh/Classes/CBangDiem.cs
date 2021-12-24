using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CBangDiem
    {
        private int MaHS;
        private int HocKy;
        private int NamHoc;
        public double DiemToan;
        public double DiemTV;
        public double DiemDD;
        public double DiemTNXH;
        public double DiemKhoaHoc;
        public double DiemLSDL;
        public double DiemNT;
        public double DiemAN;
        public double DiemMT;
        public double DiemKT;
        public double DiemTD;

        public CBangDiem(int mahs,int hocky, int namhoc, double diemtoan, double diemtv, double diemdd, double diemtnxh, double diemkhoahoc, double diemlsdl, double diemnt, double dieman, double diemmt, double diemkt, double diemtd)
        {
            MaHS = mahs;
            HocKy = hocky;
            NamHoc = namhoc;
            DiemToan = diemtoan;
            DiemTV = diemtv;
            DiemDD = diemdd;
            DiemTNXH = diemtnxh;
            DiemKhoaHoc = diemkhoahoc;
            DiemLSDL = diemlsdl;
            DiemNT = diemnt;
            DiemAN = dieman;
            DiemMT = diemmt;
            DiemKT = diemkt;
            DiemTD = diemtd;
        }
    }
}
