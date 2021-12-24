using QuanLyHocSinh.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.Forms
{
    public partial class fGiaovien : Form
    {
        List<CMonHoc> DSMH = new List<CMonHoc>();
        List<CHocSinh> DSHS = new List<CHocSinh>();
        List<CLop> DSLop = new List<CLop>();
        List<CGiaoVien> DSGV = new List<CGiaoVien>();
        List<CPhuHuynh> DSPH = new List<CPhuHuynh>();

        DataTable dt_hs = new DataTable();
        DataTable dt_hs_nhapdiem = new DataTable();
        DataTable dt_lop = new DataTable();
        DataTable dt_gv = new DataTable();
        DataTable dt_ph = new DataTable();

        public fGiaovien()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeacherMenu_FormClosing);

            //ds hocsinh
            DSHS.Add(new CHocSinh(1000000, "Nguyễn Thông Thái", 101, 1, new DateTime(2015, 12, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000001, "Lâm Ý Bình", 101, 2, new DateTime(2015, 6, 15), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000002, "Lâm Vũ", 101, 2, new DateTime(2015, 5, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000003, "Lý Hùng", 101, 3, new DateTime(2015, 6, 25), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000004, "Nguyễn Đoàn Tấn Thịnh", 101, 4, new DateTime(2015, 1, 1), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000005, "Trần Công Phúc", 101, 5, new DateTime(2015, 10, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000006, "Trần Tỵ", 102, 6, new DateTime(2015, 4, 28), "TP.HCM", "Đang xử lý chuyển trường"));
            DSHS.Add(new CHocSinh(1000007, "Lã Minh Hùng", 102, 7, new DateTime(2015, 2, 17), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000008, "Lê Thanh Minh Tùng", 103, 8, new DateTime(2015, 4, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000009, "Lê Thị Tuyết Nhung", 104, 8, new DateTime(2015, 9, 14), "TP.HCM", "Báo nằm viện"));
            DSHS.Add(new CHocSinh(1000010, "Nguyễn Huỳnh Đức", 201, 9, new DateTime(2014, 12, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000011, "Nguyễn Hùng Mạnh", 201, 10, new DateTime(2014, 9, 15), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000012, "Võ Ngọc Trân", 202, 11, new DateTime(2014, 11, 23), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000013, "Trần Thị Thu Hương", 202, 12, new DateTime(2014, 6, 24), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000014, "Kiều Nguyệt Nga", 202, 13, new DateTime(2014, 6, 30), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000015, "Trần Thống", 203, 14, new DateTime(2014, 5, 9), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000016, "Lê Thị Hồng Hoa", 204, 15, new DateTime(2014, 3, 13), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000017, "Trần Bảo An", 301, 16, new DateTime(2013, 8, 8), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000018, "Nguyễn Tấn Phúc", 302, 17, new DateTime(2013, 11, 20), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000019, "Nguyễn Tấn Tài", 302, 17, new DateTime(2013, 11, 16), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000020, "Huỳnh Minh Trí", 303, 18, new DateTime(2013, 3, 21), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000021, "Lý Kim Anh", 303, 19, new DateTime(2013, 7, 14), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000022, "Nguyễn Thị Hồng Nhung", 303, 20, new DateTime(2013, 7, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000023, "Lâm Ngọc Hải", 304, 21, new DateTime(2013, 12, 21), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000024, "Ngô Minh Toàn", 304, 22, new DateTime(2013, 12, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000025, "Nguyễn Thị Minh Thư", 401, 23, new DateTime(2012, 12, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000026, "Lê Hoàng", 401, 24, new DateTime(2012, 12, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000027, "Lê Minh Triết", 402, 24, new DateTime(2012, 12, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000028, "Đỗ Minh Nhật", 403, 25, new DateTime(2012, 5, 13), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000029, "Nguyễn Đức Huy", 0, 26, new DateTime(2015, 12, 31), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000030, "Trần Việt Hùng", 0, 27, new DateTime(2015, 7, 23), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000031, "Mai Anh Tài", 0, 28, new DateTime(2015, 12, 21), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000032, "Nguyễn Đức Hiển", 0, 29, new DateTime(2015, 5, 15), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000033, "Nguyễn Anh Thư", 0, 29, new DateTime(2015, 5, 14), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000034, "Trần Huyền Trang", 0, 30, new DateTime(2015, 1, 23), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000035, "Đỗ Xuân Hợp", 0, 31, new DateTime(2015, 5, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000036, "Nguyễn Thị Thanh", 0, 32, new DateTime(2015, 3, 24), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000037, "Nguyễn Cao Cường", 0, 33, new DateTime(2015, 3, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000038, "Hoàng Minh Trí", 0, 34, new DateTime(2015, 7, 1), "TP.HCM", "Đang học"));

            //ds phuhuynh
            DSPH.Add(new CPhuHuynh(1, "Nguyễn Thông Thạo", "0905746135"));
            DSPH.Add(new CPhuHuynh(2, "Lâm Văn Thái", "0253647981"));
            DSPH.Add(new CPhuHuynh(3, "Lý Mạnh", "0239620355"));
            DSPH.Add(new CPhuHuynh(4, "Nguyễn Đoàn Trúc Ngân", "01257786032"));
            DSPH.Add(new CPhuHuynh(5, "Trần Công Trí", "0123869410"));
            DSPH.Add(new CPhuHuynh(6, "Trần Thìn", "0257190380"));
            DSPH.Add(new CPhuHuynh(7, "Lã Minh Nghĩa", "0916357432"));
            DSPH.Add(new CPhuHuynh(8, "Lê Thanh Minh Tú", "0985311940"));
            DSPH.Add(new CPhuHuynh(9, "Nguyễn Xinh", "01658819901"));
            DSPH.Add(new CPhuHuynh(10, "Nguyễn Hùng Cường", "02351903878"));
            DSPH.Add(new CPhuHuynh(11, "Lê Thị Tuyết Mai", "0665791333"));
            DSPH.Add(new CPhuHuynh(12, "Trần Văn Dậu", "02544962321"));
            DSPH.Add(new CPhuHuynh(13, "Kiều Cảnh", "0985160491"));
            DSPH.Add(new CPhuHuynh(14, "Bùi Thị Lan Anh", "0975419659"));
            DSPH.Add(new CPhuHuynh(15, "Mai Anh Đào", "01256893122"));
            DSPH.Add(new CPhuHuynh(16, "Nguyễn Thị Nhung", "0971228635"));
            DSPH.Add(new CPhuHuynh(17, "Nguyễn Tấn Trường", "0673918350"));
            DSPH.Add(new CPhuHuynh(18, "Trần Thị Ngọc Mai", "01679806153"));
            DSPH.Add(new CPhuHuynh(19, "Lý Thập Vân", "012567430911"));
            DSPH.Add(new CPhuHuynh(20, "Nguyễn Minh Triết", "0988549130"));
            DSPH.Add(new CPhuHuynh(21, "Lâm Xung", "0987551653"));
            DSPH.Add(new CPhuHuynh(22, "Ngô Quốc Lâm", "01223398512"));
            DSPH.Add(new CPhuHuynh(23, "Nguyễn Đức Mạnh", "01699357410"));
            DSPH.Add(new CPhuHuynh(24, "Lê Thanh Toàn", "0903656069"));
            DSPH.Add(new CPhuHuynh(25, "Nguyễn Thị Cúc", "0936728675"));
            DSPH.Add(new CPhuHuynh(26, "Nguyễn Minh Nhựt", "01658999043"));
            DSPH.Add(new CPhuHuynh(27, "Trần Đình Trọng", "02552886004"));
            DSPH.Add(new CPhuHuynh(28, "Mai Quốc Hùng", "0932536069"));
            DSPH.Add(new CPhuHuynh(29, "Nguyễn Thị Đinh Lan", "03268705900"));
            DSPH.Add(new CPhuHuynh(30, "Nguyễn Trần Công Trí", "0976443916"));
            DSPH.Add(new CPhuHuynh(31, "Trần Xuân Hùng", "0913220661"));
            DSPH.Add(new CPhuHuynh(32, "Trần Thị Trúc", "0988752012"));
            DSPH.Add(new CPhuHuynh(33, "Nguyễn Anh Dũng", "0947653001"));
            DSPH.Add(new CPhuHuynh(34, "Trần Thị Kiều Trinh", "0909665087"));

            //ds lop
            DSLop.Add(new CLop(101));
            DSLop.Add(new CLop(102));
            DSLop.Add(new CLop(103));
            DSLop.Add(new CLop(104));
            DSLop.Add(new CLop(201));
            DSLop.Add(new CLop(202));
            DSLop.Add(new CLop(203));
            DSLop.Add(new CLop(204));
            DSLop.Add(new CLop(301));
            DSLop.Add(new CLop(302));
            DSLop.Add(new CLop(303));
            DSLop.Add(new CLop(304));
            DSLop.Add(new CLop(401));
            DSLop.Add(new CLop(402));
            DSLop.Add(new CLop(403));
            DSLop.Add(new CLop(404));
            DSLop.Add(new CLop(501));
            DSLop.Add(new CLop(502));
            DSLop.Add(new CLop(503));
            DSLop.Add(new CLop(504));

            //mon hoc
            DSMH.Add(new CMonHoc(1, "Toán"));
            DSMH.Add(new CMonHoc(2, "Tiếng Việt"));
            DSMH.Add(new CMonHoc(3, "Đạo Đức"));
            DSMH.Add(new CMonHoc(4, "Tự Nhiên & Xã Hội"));
            DSMH.Add(new CMonHoc(5, "Khoa Học"));
            DSMH.Add(new CMonHoc(6, "Lịch Sử & Địa Lý"));
            DSMH.Add(new CMonHoc(7, "Nghệ Thuật"));
            DSMH.Add(new CMonHoc(8, "Âm Nhạc"));
            DSMH.Add(new CMonHoc(9, "Mỹ Thuật"));
            DSMH.Add(new CMonHoc(10, "Kỹ Thuật"));
            DSMH.Add(new CMonHoc(11, "Thể Dục"));

            //ds giaovien
            DSGV.Add(new CGiaoVien(100000, "Nguyễn Văn Toàn", "Hiệu Trưởng", DSMH[2]));
            DSGV.Add(new CGiaoVien(100001, "Nguyễn Thông Minh", "Phó Hiệu Trưởng", DSMH[0]));
            DSGV.Add(new CGiaoVien(100002, "Chu Diệu Linh", "Giáo Viên Bộ Môn", DSMH[7]));
            DSGV.Add(new CGiaoVien(100003, "Tô Ngọc Vân", "Giáo Viên Bộ Môn", DSMH[8]));
            DSGV.Add(new CGiaoVien(100004, "Trần Quốc Hùng", "Giáo Viên Bộ Môn", DSMH[10]));
            DSGV.Add(new CGiaoVien(100005, "Lê Trọng Ngân", "Giáo Viên Bộ Môn", DSMH[4]));
            DSGV.Add(new CGiaoVien(100006, "Nguyễn Thị Hồng Vân", "Giáo Viên Bộ Môn", DSMH[1]));
            DSGV.Add(new CGiaoVien(100007, "Lữ Hoài Linh", "Giáo Viên Bộ Môn", DSMH[3]));
            DSGV.Add(new CGiaoVien(100008, "Đinh Văn Dũng", "Giáo Viên Bộ Môn", DSMH[5]));
            DSGV.Add(new CGiaoVien(100009, "Vũ Vy Oanh", "Giáo Viên Bộ Môn", DSMH[9]));
            DSGV.Add(new CGiaoVien(100010, "Trịnh Trần Phương Tuấn", "Giáo Viên Bộ Môn", DSMH[6]));

            //add columns dt_hs_nhapdiem
            dt_hs_nhapdiem.Columns.Add("Mã số");
            dt_hs_nhapdiem.Columns.Add("Họ tên");
            dt_hs_nhapdiem.Columns.Add("Lớp");
            dt_hs_nhapdiem.Columns.Add("Trạng thái");

            //add columns dt_gv
            dt_gv.Columns.Add("Mã số");
            dt_gv.Columns.Add("Họ tên");
            dt_gv.Columns.Add("Chức vụ");
            dt_gv.Columns.Add("Bộ môn");

            //add columns dt_lop
            dt_lop.Columns.Add("Mã lớp");
            dt_lop.Columns.Add("Tên lớp");
            dt_lop.Columns.Add("Giáo viên chủ nhiệm");
            dt_lop.Columns.Add("Sĩ số");

            //add data dt_hs_nhapdiem
            for (int i = 0; i < DSHS.Count; i++)
            {
                if (DSHS[i].GetMaLop() != 0)
                {
                    string tenlop = DSHS[i].GetMaLop().ToString().Substring(0, 1) + "A" + DSHS[i].GetMaLop().ToString().Substring(2, 1);
                    dt_hs_nhapdiem.Rows.Add(DSHS[i].GetMaHS(), DSHS[i].GetTenHS(), tenlop, "Chưa nhập điểm");
                }

            }

            //add data dt_gv
            for (int i = 0; i < DSGV.Count; i++)
            {
                dt_gv.Rows.Add(DSGV[i].GetMaGV(), DSGV[i].GetTenGV(), DSGV[i].GetChucVu(), DSGV[i].GetBoMon().GetTenMH());
            }

            //add data dt_lop
            for (int i = 0; i < DSLop.Count; i++)
            {
                string tenlop = DSLop[i].GetMaLop().ToString().Substring(0, 1) + "A" + DSLop[i].GetMaLop().ToString().Substring(2, 1);
                dt_lop.Rows.Add(DSLop[i].GetMaLop(), tenlop, DSLop[i].GetMaGVCN());
            }

            //add data dataGridView_HS
            dgv_DSHS.DataSource = dt_hs_nhapdiem;
        }

        private void kếtQuảLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapdiem f = new fNhapdiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            fTaotkb f = new fTaotkb();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuItemLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Log off", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin form = new FormLogin();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTeacherMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình? Những thay đổi có thể không được lưu.", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThemCK_Click(object sender, EventArgs e)
        {
            Form form = new FormNhapDiem();
            form.ShowDialog();
        }

        private void fGiaovien_Load(object sender, EventArgs e)
        {

        }
    }
}
