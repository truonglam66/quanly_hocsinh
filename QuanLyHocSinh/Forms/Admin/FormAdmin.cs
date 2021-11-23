using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Classes;

namespace QuanLyHocSinh.Forms.Admin
{
    public partial class FormAdmin : Form
    {
        List<Classes.BangDiem> BangDiems;
        List<Classes.HocSinh> HocSinhs;
        List<Classes.ThoiKhoaBieu> TKBs;
        Label[,] lbTKBs;
        public FormAdmin()
        {
            InitializeComponent();
        }

        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            BangDiems = new List<Classes.BangDiem>();
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "001", MaBangDiem = "001", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "002", MaBangDiem = "002", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "003", MaBangDiem = "003", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "004", MaBangDiem = "004", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "005", MaBangDiem = "005", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "006", MaBangDiem = "006", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "007", MaBangDiem = "007", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "008", MaBangDiem = "008", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "009", MaBangDiem = "009", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "010", MaBangDiem = "010", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });

            HocSinhs = new List<Classes.HocSinh>();
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "001", MaLop = "001", TenHS = "Thằng thứ nhất" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "002", MaLop = "001", TenHS = "Thằng thứ hai" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "003", MaLop = "001", TenHS = "Thằng thứ ba"});
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "004", MaLop = "001", TenHS = "Thằng thứ tư" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "005", MaLop = "002", TenHS = "Thằng thứ năm" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "006", MaLop = "002", TenHS = "Thằng thứ sáu" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "007", MaLop = "002", TenHS = "Thằng thứ bảy" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "008", MaLop = "003", TenHS = "Thằng thứ tám" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "009", MaLop = "003", TenHS = "Thằng thứ chín" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "010", MaLop = "003", TenHS = "Thằng thứ mười" });

            TKBs = new List<Classes.ThoiKhoaBieu>();
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "001", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] { { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "002", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] { { "Tiếng Việt", "Tiếng Việt", "Tiếng Việt", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });

            lbTKBs = new Label[,] { { lbMonHoc2_1, lbMonhoc2_2, lbMonhoc2_3, lbMonhoc2_4, lbMonhoc2_5, lbMonhoc2_6, lbMonhoc2_7 } , { lbMonhoc3_1, lbMonhoc3_2, lbMonhoc3_3, lbMonhoc3_4, lbMonhoc3_5, lbMonhoc3_6, lbMonhoc3_7 },{ lbMonhoc4_1, lbMonhoc4_2, lbMonhoc4_3, lbMonhoc4_4, lbMonhoc4_5, lbMonhoc4_6, lbMonhoc4_7 },{ lbMonhoc5_1, lbMonhoc5_2, lbMonhoc5_3, lbMonhoc5_4, lbMonhoc5_5, lbMonhoc5_6, lbMonhoc5_7 },{ lbMonhoc6_1, lbMonhoc6_2, lbMonhoc6_3, lbMonhoc6_4, lbMonhoc6_5, lbMonhoc6_6, lbMonhoc6_7 },{ lbMonhoc7_1, lbMonhoc7_2, lbMonhoc7_3, lbMonhoc7_4, lbMonhoc7_5, lbMonhoc7_6, lbMonhoc7_7 } };


            WindowState = FormWindowState.Maximized;

        }
        private void setColor()
        {
            menuStrip1.BackColor = darkMode.xanh;
            this.BackColor = darkMode.denlot;
            tabPage1.BackColor = darkMode.denlot;
            tabPage2.BackColor = darkMode.denlot;
            tabPage3.BackColor = darkMode.denlot;
            tabPage4.BackColor = darkMode.denlot;
            tabPage5.BackColor = darkMode.denlot;
            label1.BackColor = darkMode.denlot;




            btnTim_BDCK.BackColor = darkMode.xanh;
            btnTatCa_BDCK.BackColor = darkMode.xanh;
            button1.BackColor = darkMode.xanh;
            button2.BackColor = darkMode.xanh;
            button3.BackColor = darkMode.xanh;
            button4.BackColor = darkMode.xanh;
            button5.BackColor = darkMode.xanh;
            button6.BackColor = darkMode.xanh;
            button7.BackColor = darkMode.xanh;
            button8.BackColor = darkMode.xanh;
            button9.BackColor = darkMode.xanh;
            button10.BackColor = darkMode.xanh;
            button11.BackColor = darkMode.xanh;
            button12.BackColor = darkMode.xanh;
            button13.BackColor = darkMode.xanh;
            button1.BackColor = darkMode.xanh;
            btnTim_TKB.BackColor = darkMode.xanh;

            label1.ForeColor = darkMode.trang;
            tabPage1.ForeColor = darkMode.trang;
            tabPage2.ForeColor = darkMode.trang;
            tabPage3.ForeColor = darkMode.trang;
            tabPage4.ForeColor = darkMode.trang;
            tabPage5.ForeColor = darkMode.trang;

            chếĐộBanĐêmToolStripMenuItem.BackColor = darkMode.xanh;
            thoátToolStripMenuItem.BackColor = darkMode.xanh;

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            thêmHsThi hsThi = new thêmHsThi();
            this.Hide();
            hsThi.ShowDialog();
            this.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            themHoatDong hoatDong = new themHoatDong();
            this.Hide();
            hoatDong.ShowDialog();
            this.Show();

        }

        private void chếĐộBanĐêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkMode.TroCarMode();
            setColor();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachHocSinh ds = new DanhSachHocSinh();
            this.Hide();
            ds.ShowDialog();
            this.Show();
        }


        //
        //Thời khóa biểu
        //

    }
}
