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

namespace QuanLyHocSinh.Forms.Manager
{
    public partial class FormDKNhapHoc : System.Windows.Forms.Form
    {
        List<CHocSinh> DSHS = new List<CHocSinh>();
        List<CPhuHuynh> DSPH = new List<CPhuHuynh>();

        DataTable dt_hs = new DataTable();

        public FormDKNhapHoc()
        {
            InitializeComponent();

            //ds hocsinh
            DSHS.Add(new CHocSinh(1000000, "Nguyễn Thông Thái", 1, new DateTime(2015, 12, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000001, "Lâm Ý Bình", 2, new DateTime(2015, 6, 15), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000002, "Lâm Vũ", 2, new DateTime(2015, 5, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000003, "Lý Hùng", 3, new DateTime(2015, 6, 25), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000004, "Nguyễn Đoàn Tấn Thịnh", 4, new DateTime(2015, 1, 1), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000005, "Trần Công Phúc", 5, new DateTime(2015, 10, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000006, "Trần Tỵ", 6, new DateTime(2015, 4, 28), "TP.HCM", "Đang xử lý chuyển trường"));
            DSHS.Add(new CHocSinh(1000007, "Lã Minh Hùng", 7, new DateTime(2015, 2, 17), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000008, "Lê Thanh Minh Tùng", 8, new DateTime(2015, 4, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000009, "Lê Thị Tuyết Nhung", 8, new DateTime(2015, 9, 14), "TP.HCM", "Báo nằm viện"));
            DSHS.Add(new CHocSinh(1000010, "Nguyễn Huỳnh Đức", 9, new DateTime(2015, 12, 12), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000011, "Nguyễn Hùng Mạnh", 10, new DateTime(2015, 9, 15), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000012, "Võ Ngọc Trân", 11, new DateTime(2015, 11, 23), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000013, "Trần Thị Thu Hương", 12, new DateTime(2015, 6, 24), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000014, "Kiều Nguyệt Nga", 13, new DateTime(2015, 6, 30), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000015, "Trần Thống", 14, new DateTime(2015, 5, 9), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000016, "Lê Thị Hồng Hoa", 15, new DateTime(2015, 3, 13), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000017, "Trần Bảo An", 16, new DateTime(2015, 8, 8), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000018, "Nguyễn Tấn Phúc", 17, new DateTime(2015, 11, 20), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000019, "Nguyễn Tấn Tài", 17, new DateTime(2015, 11, 16), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000020, "Huỳnh Minh Trí", 18, new DateTime(2015, 3, 21), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000021, "Lý Kim Anh", 19, new DateTime(2015, 7, 14), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000022, "Nguyễn Thị Hồng Nhung", 20, new DateTime(2015, 7, 6), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000023, "Lâm Ngọc Hải", 21, new DateTime(2015, 12, 21), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000024, "Ngô Minh Toàn", 22, new DateTime(2015, 12, 5), "TP.HCM", "Đang học"));
            DSHS.Add(new CHocSinh(1000025, "Nguyễn Thị Minh Thư", 23, new DateTime(2015, 12, 5), "TP.HCM", "Đang học"));

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

            //add columns dt_hs
            dt_hs.Columns.Add("Mã số");
            dt_hs.Columns.Add("Họ tên");
            dt_hs.Columns.Add("Lớp");
            dt_hs.Columns.Add("Phụ huynh");
            dt_hs.Columns.Add("Ngày sinh");
            dt_hs.Columns.Add("Tình trạng");

            //add data dt_hs
            for (int i = 0; i < DSHS.Count; i++)
            {
                string tenPH = "";

                for (int j = 0; j < DSPH.Count; j++)
                {
                    if (DSPH[j].GetMaPH() == DSHS[i].GetMaPH())
                    {
                        tenPH = DSPH[j].GetTenPH();
                        break;
                    }
                }

                dt_hs.Rows.Add(DSHS[i].GetMaHS(), DSHS[i].GetTenHS(), DSHS[i].GetMaLop(), tenPH, DSHS[i].GetNgaySinh(), DSHS[i].GetStatus());
            }

            //add data dataGridView_HS
            dataGridView_DSHS.DataSource = dt_hs;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //thong tin hoc sinh
            string name_hs = txt_nameHS.Text;
            DateTime dob = dtP_DoB.Value;
            string adress = rtxt_DC.Text;

            //thong tin phu huynh
            string name_ph = txt_tenPH.Text;
            string sdt = txt_SDT.Text;

            if (string.IsNullOrWhiteSpace(name_hs))
            {
                MessageBox.Show("Hãy nhập tên học sinh");
                txt_nameHS.Focus();
            }

            else if (dob.Date == DateTime.UtcNow.Date)
            {
                MessageBox.Show("Hãy chọn ngày sinh");
                dtP_DoB.Focus();
            }

            else if (string.IsNullOrWhiteSpace(adress))
            {
                MessageBox.Show("Hãy nhập địa chỉ");
                rtxt_DC.Focus();
            }

            else if (string.IsNullOrWhiteSpace(name_ph))
            {
                MessageBox.Show("Hãy nhập tên phụ huynh");
                txt_tenPH.Focus();
            }

            else if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Hãy nhập số điện thoại phụ huynh");
                txt_SDT.Focus();
            }

            else
            {
                //executed code
                DSHS.Add(new CHocSinh(DSHS[DSHS.Count - 1].GetMaHS() + 1, name_hs, DSPH[DSPH.Count - 1].GetMaPH(), dob, adress, "đang học"));
                DSPH.Add(new CPhuHuynh(DSPH[DSPH.Count - 1].GetMaPH() + 1, name_ph, sdt));

                dt_hs.Rows.Add(DSHS[DSHS.Count - 1].GetMaHS(), DSHS[DSHS.Count - 1].GetTenHS(), DSHS[DSHS.Count - 1].GetMaLop(), DSPH[DSPH.Count - 1].GetTenPH(), DSHS[DSHS.Count - 1].GetNgaySinh(), DSHS[DSHS.Count - 1].GetStatus());

                MessageBox.Show("Lưu thành công!");
            }
        }
    }
}
