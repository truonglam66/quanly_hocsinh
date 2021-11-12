using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CLop
    {
        private int MaLop;
        private List<CHocSinh> DSHocSinh;
        private int MaGVCN;

        public CLop()
        {
            this.MaLop = 0;
            this.MaGVCN = 0;
            this.DSHocSinh = new List<CHocSinh>();
        }

        public CLop(int _malop)
        {
            this.MaLop = _malop;
            this.MaGVCN = 0;
            this.DSHocSinh = new List<CHocSinh>();
        }

        public CLop(int _malop, List<CHocSinh> _dshocsinh, int _magvcn)
        {
            this.MaLop = _malop;
            this.DSHocSinh = _dshocsinh;
            this.MaGVCN = _magvcn;
        }

        public int GetMaLop()
        {
            return this.MaLop;
        }

        public int GetMaGVCN()
        {
            return this.MaGVCN;
        }

        public void SetMaLop(int _malop)
        {
            this.MaLop = _malop;
        }

        public void SetMaGVCN(int _magvcn)
        {
            this.MaGVCN = _magvcn;
        }
    }
}
