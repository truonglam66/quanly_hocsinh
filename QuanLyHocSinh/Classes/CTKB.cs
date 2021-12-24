using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CTKB
    {
        private int MaTKB;
        private DateTime NgayTao;
        private int Lop;
        private int HocKy;
        private int NamHoc;
        private List<CMonHoc> list;

        public CTKB(int matkb, int lop, int hocky, int namhoc, DateTime ngaytao)
        {
            MaTKB = matkb;
            Lop = lop;
            HocKy = hocky;
            NamHoc = namhoc;
            NgayTao = ngaytao;
            list = new List<CMonHoc>();
        }

        public int GetMaLop()
        {
            return Lop;
        }

        public int GetMaTKB()
        {
            return MaTKB;
        }

        public int GetHK()
        {
            return HocKy;
        }

        public int GetNamHoc()
        {
            return NamHoc;
        }

        public DateTime GetNgayTao()
        {
            return NgayTao;
        }

        public List<CMonHoc> GetListMH()
        {
            return list;
        }

        public void SetMaLop(int malop)
        {
            malop = Lop;
        }

        public void SetMaTKB(int matkb)
        {
            MaTKB = matkb;
        }

        public void SetHK(int hk)
        {
            HocKy = hk;
        }

        public void SetNamHoc(int namhoc)
        {
            NamHoc = namhoc;
        }

        public void SetNgayTao(DateTime ngaytao)
        {
            NgayTao = ngaytao;
        }

        public void SetListMH(List<CMonHoc> list)
        {
            this.list = list;
        }
    }
}
