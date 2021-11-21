using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CPhuHuynh
    {
        private int MaPH;
        private string TenPH;
        private string SDT;

        public CPhuHuynh()
        {
            MaPH = 0;
            TenPH = "";
            SDT = "";
        }

<<<<<<< HEAD
        public CPhuHuynh(int _maph,string _tenph,string _sdt)
=======
        public CPhuHuynh(int _maph, string _tenph, string _sdt)
>>>>>>> origin/hoangtruong
        {
            MaPH = _maph;
            TenPH = _tenph;
            SDT = _sdt;
        }

        public int GetMaPH()
        {
            return MaPH;
        }

        public string GetTenPH()
        {
            return TenPH;
        }

        public string GetSDT()
        {
            return SDT;
        }

        public void SetMaPH(int _maph)
        {
            this.MaPH = _maph;
        }

        public void SetTenPH(string _tenph)
        {
            this.TenPH = _tenph;
        }

        public void SetSDT(string _sdt)
        {
            this.SDT = _sdt;
        }


    }
}
