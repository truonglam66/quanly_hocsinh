using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CMonHoc
    {
        private int MaMH;
        private string TenMH;

        public CMonHoc(int _mamh, string _tenmh)
        {
            this.MaMH = _mamh;
            this.TenMH = _tenmh;
        }

        public int GetMaMH()
        {
            return this.MaMH;
        }

        public string GetTenMH()
        {
            return this.TenMH;
        }

        public void SetMaMH(int _mamh)
        {
            this.MaMH = _mamh;
        }

        public void SetTenMH(string _tenmh)
        {
            this.TenMH = _tenmh;
        }
    }
}
