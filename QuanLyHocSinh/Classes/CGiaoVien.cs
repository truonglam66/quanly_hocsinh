using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CGiaoVien
    {
        private int MaGV;
        private string TenGV;
        private string ChucVu;
        private CMonHoc BoMon;

        public CGiaoVien(int _magv, string _tengv, string _chucvu, CMonHoc _bomon)
        {
            this.MaGV = _magv;
            this.TenGV = _tengv;
            this.ChucVu = _chucvu;
            this.BoMon = _bomon;
        }

        public int GetMaGV()
        {
            return this.MaGV;
        }

        public string GetTenGV()
        {
            return this.TenGV;
        }

        public string GetChucVu()
        {
            return this.ChucVu;
        }

        public CMonHoc GetBoMon()
        {
            return this.BoMon;
        }

        public void SetMaGV(int _magv)
        {
            this.MaGV = _magv;
        }

        public void SetTenGV(string _tengv)
        {
            this.TenGV = _tengv;
        }

        public void SetChucVu(string _chucvu)
        {
            this.ChucVu = _chucvu;
        }

        public void SetBoMon(CMonHoc _monhoc)
        {
            this.BoMon = _monhoc;
        }
    }
}
