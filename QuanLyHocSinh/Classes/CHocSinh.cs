using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CHocSinh
    {
        private int MaHS;
        private string TenHS;
        private int MaLop;
        private int MaPH;
        private DateTime NgaySinh;
        private string DiaChi;
        private string Status;

        public CHocSinh()
        {
            this.MaHS = 0;
            this.TenHS = "";
            this.MaLop = 0;
            this.MaPH = 0;
            this.NgaySinh = new DateTime();
            this.DiaChi = "";
            this.Status = "";
        }

        public CHocSinh(int _mahs, string _tenhs, int _maph, DateTime _ngaysinh, string _diachi, string _status)
        {
            this.MaHS = _mahs;
            this.TenHS = _tenhs;
            this.MaPH = _maph;
            this.NgaySinh = _ngaysinh;
            this.DiaChi = _diachi;
            this.Status = _status;
        }

        public CHocSinh(int _mahs, string _tenhs, int _malop,int _maph,string _status)
        {
            this.MaHS = _mahs;
            this.TenHS = _tenhs;
            this.MaLop = _malop;
            this.MaPH = _maph;
            this.Status = _status;
        }

        public int GetMaHS()
        {
            return this.MaHS;
        }

        public string GetTenHS()
        {
            return this.TenHS;
        }

        public int GetMaLop()
        {
            return this.MaLop;
        }

        public int GetMaPH()
        {
            return this.MaPH;
        }

        public DateTime GetNgaySinh()
        {
            return this.NgaySinh;
        }

        public string GetDiaChi()
        {
            return DiaChi;
        }

        public string GetStatus()
        {
            return this.Status;
        }

        public void SetMaHS(int _mahs)
        {
            this.MaHS = _mahs;
        }

        public void SetTenHS(string _tenhs)
        {
            this.TenHS = _tenhs;
        }

        public void SetMaLop(int _malop)
        {
            this.MaLop = _malop;
        }

        public void SetMaPH(int _maph)
        {
            this.MaPH = _maph;
        }

        public void SetNgaySinh(DateTime _ngaysinh)
        {
            this.NgaySinh = _ngaysinh;
        }

        public void SetDiaChi(string _diachi)
        {
            this.DiaChi = _diachi;
        }

        public void SetStatus(string _status)
        {
            this.Status = _status;
        }
    }
}
