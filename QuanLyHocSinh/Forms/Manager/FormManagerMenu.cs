using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using QuanLyHocSinh.Classes;

namespace QuanLyHocSinh.Forms
{
    public partial class FormManagerMenu : Form
    {
        List<CMonHoc> DSMH = new List<CMonHoc>();
        List<CHocSinh> DSHS = new List<CHocSinh>();
        List<CLop> DSLop = new List<CLop>();
        List<CGiaoVien> DSGV = new List<CGiaoVien>();
        List<CPhuHuynh> DSPH = new List<CPhuHuynh>();

        DataTable dt_hs = new DataTable();
        DataTable dt_lop = new DataTable();
        DataTable dt_gv = new DataTable();
        DataTable dt_ph = new DataTable();

        public FormManagerMenu()
        {
            InitializeComponent();
            //setColor();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManagerMenu_FormClosing);

            //ds hocsinh
            DSHS.Add(new CHocSinh(1000000, "Nguyễn Thông Thái", 1, new DateTime(2015,12,5), "Đang học"));
            DSHS.Add(new CHocSinh(1000001, "Lâm Ý Bình", 2, new DateTime(2015, 6, 15), "Đang học"));
            DSHS.Add(new CHocSinh(1000002, "Lâm Vũ", 2, new DateTime(2015, 5, 5), "Đang học"));
            DSHS.Add(new CHocSinh(1000003, "Lý Hùng", 3, new DateTime(2015, 6, 25), "Đang học"));
            DSHS.Add(new CHocSinh(1000004, "Nguyễn Đoàn Tấn Thịnh", 4, new DateTime(2015, 1, 1), "Đang học"));
            DSHS.Add(new CHocSinh(1000005, "Trần Công Phúc", 5, new DateTime(2015, 10, 6), "Đang học"));
            DSHS.Add(new CHocSinh(1000006, "Trần Tỵ", 6, new DateTime(2015, 4, 28), "Đang xử lý chuyển trường"));
            DSHS.Add(new CHocSinh(1000007, "Lã Minh Hùng", 7, new DateTime(2015, 2, 17), "Đang học"));
            DSHS.Add(new CHocSinh(1000008, "Lê Thanh Minh Tùng", 8, new DateTime(2015, 4, 12), "Đang học"));
            DSHS.Add(new CHocSinh(1000009, "Lê Thị Tuyết Nhung", 8, new DateTime(2015, 9, 14), "Báo nằm viện"));
            DSHS.Add(new CHocSinh(1000010, "Nguyễn Huỳnh Đức", 9, new DateTime(2015, 12, 12), "Đang học"));
            DSHS.Add(new CHocSinh(1000011, "Nguyễn Hùng Mạnh", 10, new DateTime(2015, 9, 15), "Đang học"));
            DSHS.Add(new CHocSinh(1000012, "Võ Ngọc Trân", 11, new DateTime(2015, 11, 23), "Đang học"));
            DSHS.Add(new CHocSinh(1000013, "Trần Thị Thu Hương", 12, new DateTime(2015, 6, 24), "Đang học"));
            DSHS.Add(new CHocSinh(1000014, "Kiều Nguyệt Nga", 13, new DateTime(2015, 6, 30), "Đang học"));
            DSHS.Add(new CHocSinh(1000015, "Trần Thống", 14, new DateTime(2015, 5, 9), "Đang học"));
            DSHS.Add(new CHocSinh(1000016, "Lê Thị Hồng Hoa", 15, new DateTime(2015, 3, 13), "Đang học"));
            DSHS.Add(new CHocSinh(1000017, "Trần Bảo An", 16, new DateTime(2015, 8, 8), "Đang học"));
            DSHS.Add(new CHocSinh(1000018, "Nguyễn Tấn Phúc", 17, new DateTime(2015, 11, 20), "Đang học"));
            DSHS.Add(new CHocSinh(1000019, "Nguyễn Tấn Tài", 17, new DateTime(2015, 11, 16), "Đang học"));
            DSHS.Add(new CHocSinh(1000020, "Huỳnh Minh Trí", 18, new DateTime(2015, 3, 21), "Đang học"));
            DSHS.Add(new CHocSinh(1000021, "Lý Kim Anh", 19, new DateTime(2015, 7, 14), "Đang học"));
            DSHS.Add(new CHocSinh(1000022, "Nguyễn Thị Hồng Nhung", 20, new DateTime(2015, 7, 6), "Đang học"));
            DSHS.Add(new CHocSinh(1000023, "Lâm Ngọc Hải", 21, new DateTime(2015, 12, 21), "Đang học"));
            DSHS.Add(new CHocSinh(1000024, "Ngô Minh Toàn", 22, new DateTime(2015, 12, 5), "Đang học"));
            DSHS.Add(new CHocSinh(1000025, "Nguyễn Thị Minh Thư", 23, new DateTime(2015, 12, 5), "Đang học"));

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

            //ds lop
            DSLop.Add(new CLop(101));
            DSLop.Add(new CLop(102));
            DSLop.Add(new CLop(103));
            DSLop.Add(new CLop(104));
            DSLop.Add(new CLop(105));
            DSLop.Add(new CLop(106));
            DSLop.Add(new CLop(107));

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

            //add columns dt_hs
            dt_hs.Columns.Add("Mã số");
            dt_hs.Columns.Add("Họ tên");
            dt_hs.Columns.Add("Lớp");
            dt_hs.Columns.Add("Phụ huynh");
            dt_hs.Columns.Add("Ngày sinh");
            dt_hs.Columns.Add("Tình trạng");

            //add columns dt_lop
            dt_lop.Columns.Add("Mã lớp");
            dt_lop.Columns.Add("Tên lớp");
            dt_lop.Columns.Add("Giáo viên chủ nhiệm");

            //add columns dt_gv
            dt_gv.Columns.Add("Mã số");
            dt_gv.Columns.Add("Họ tên");
            dt_gv.Columns.Add("Chức vụ");
            dt_gv.Columns.Add("Bộ môn");

            //add data dt_hs
            for (int i = 0; i < DSHS.Count; i++)
            {
                string tenPH="";

                for(int j=0;j<DSPH.Count;j++)
                {
                    if(DSPH[j].GetMaPH() == DSHS[i].GetMaPH())
                    {
                        tenPH = DSPH[j].GetTenPH();
                        break;
                    }    
                }

                dt_hs.Rows.Add(DSHS[i].GetMaHS(), DSHS[i].GetTenHS(), DSHS[i].GetMaLop(), tenPH, DSHS[i].GetNgaySinh(), DSHS[i].GetStatus());
            }

            //add data dt_lop
            for (int i = 0; i < DSLop.Count; i++)
            {
                string tenlop = DSLop[i].GetMaLop().ToString().Substring(0, 1) + "A" + DSLop[i].GetMaLop().ToString().Substring(2, 1);
                dt_lop.Rows.Add(DSLop[i].GetMaLop(), tenlop, DSLop[i].GetMaGVCN());
            }

            //add data dt_gv
            for (int i = 0; i < DSGV.Count; i++)
            {
                dt_gv.Rows.Add(DSGV[i].GetMaGV(), DSGV[i].GetTenGV(), DSGV[i].GetChucVu(), DSGV[i].GetBoMon().GetTenMH());
            }

            //add data dataGridView_HS
            dataGridView_HS.DataSource = dt_hs;

            //add data dataGridView_Lop
            dataGridView_Lop.DataSource = dt_lop;

            //add data dataGridView_Lop1
            dataGridView_Lop1.DataSource = dt_lop;

            //add data dataGridView_GV
            dataGridView_GV.DataSource = dt_gv;

            //add data dataGridView_HS1
            dataGridView_HS1.DataSource = dt_hs;

            //add data dataGridView_HS2
            dataGridView_HS2.DataSource = dt_hs;

            //add data dataGridView_DSHS
            dataGridView_DSHS.DataSource = dt_hs;
        }

        private void btn_searchHS_Click(object sender, EventArgs e)
        {
            string searchValue = txt_searchHS.Text;
            dataGridView_HS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView_HS.Rows)
                {
                    if (row.Cells[1].Value != null && (row.Cells[1].Value.ToString().ToLower().Equals(searchValue) || row.Cells[1].Value.ToString().Equals(searchValue)))
                    {
                        int rowIndex = row.Index;
                        dataGridView_HS.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Không tìm thấy " + txt_searchHS.Text, "Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_searchLop_Click(object sender, EventArgs e)
        {
            string searchValue = txt_searchLop.Text;
            dataGridView_Lop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView_Lop.Rows)
                {
                    if (row.Cells[1].Value != null && (row.Cells[1].Value.ToString().ToLower().Equals(searchValue) || row.Cells[1].Value.ToString().Equals(searchValue)))
                    {
                        int rowIndex = row.Index;
                        dataGridView_Lop.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Không tìm thấy " + txt_searchLop.Text, "Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_HS.Rows[dataGridView_HS.CurrentCell.RowIndex].Cells[2].Value = dataGridView_Lop.Rows[dataGridView_Lop.CurrentCell.RowIndex].Cells[1].Value;
                DSHS[dataGridView_HS.CurrentCell.RowIndex].SetMaLop(DSLop[dataGridView_Lop.CurrentCell.RowIndex].GetMaLop());
                MessageBox.Show("Đăng ký lớp thành công. Học sinh " + dataGridView_HS.Rows[dataGridView_HS.CurrentCell.RowIndex].Cells[1].Value.ToString() + " đã được xếp vào lớp " + dataGridView_Lop.Rows[dataGridView_Lop.CurrentCell.RowIndex].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("xin hãy chọn dòng của danh sách học sinh và danh sách lớp để thêm học sinh vào lớp");
            }
        }

        private void btn_searchGV_Click(object sender, EventArgs e)
        {
            string searchValue = txt_searchGV.Text;
            dataGridView_GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView_GV.Rows)
                {
                    if (row.Cells[1].Value != null && (row.Cells[1].Value.ToString().ToLower().Equals(searchValue) || row.Cells[1].Value.ToString().Equals(searchValue)))
                    {
                        int rowIndex = row.Index;
                        dataGridView_GV.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Không tìm thấy " + txt_searchGV.Text, "Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Lop1_Click(object sender, EventArgs e)
        {
            string searchValue = txt_searchLop.Text;
            dataGridView_Lop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView_Lop.Rows)
                {
                    if (row.Cells[1].Value != null && (row.Cells[1].Value.ToString().ToLower().Equals(searchValue) || row.Cells[1].Value.ToString().Equals(searchValue)))
                    {
                        int rowIndex = row.Index;
                        dataGridView_Lop.Rows[rowIndex].Selected = true;
                        valueResult = true;
                        break;
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Không tìm thấy " + txt_searchLop.Text, "Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_OK1_Click(object sender, EventArgs e)
        {
            bool valueResult = true;
            try
            {
                foreach (DataGridViewRow row in dataGridView_Lop1.Rows)
                {
                    if (row.Cells[2].Value == dataGridView_GV.Rows[dataGridView_GV.CurrentCell.RowIndex].Cells[1].Value)
                    {
                        MessageBox.Show("giáo viên " + dataGridView_GV.Rows[dataGridView_GV.CurrentCell.RowIndex].Cells[1].Value + " đã đăng ký chủ nhiệm trước đó");
                        valueResult = false;
                        break;
                    }
                }
                if (valueResult)
                {
                    dataGridView_Lop1.Rows[dataGridView_Lop1.CurrentCell.RowIndex].Cells[2].Value = dataGridView_GV.Rows[dataGridView_GV.CurrentCell.RowIndex].Cells[1].Value;
                    DSLop[dataGridView_Lop1.CurrentCell.RowIndex].SetMaGVCN(DSGV[dataGridView_GV.CurrentCell.RowIndex].GetMaGV());
                    MessageBox.Show("Đăng ký lớp thành công. Giáo viên " + dataGridView_GV.Rows[dataGridView_GV.CurrentCell.RowIndex].Cells[1].Value.ToString() + " phụ trách lớp " + dataGridView_Lop1.Rows[dataGridView_Lop1.CurrentCell.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("xin hãy chọn dòng của danh sách giáo viên và danh sách lớp để thêm giáo viên chủ nhiệm vào lớp");
            }
        }

        private void btn_Create2_Click(object sender, EventArgs e)
        {
            string name = dataGridView_HS2.Rows[dataGridView_HS2.CurrentCell.RowIndex].Cells[1].Value.ToString();
            DateTime curentDate = DateTime.UtcNow.Date;
            string lop= dataGridView_HS2.Rows[dataGridView_HS2.CurrentCell.RowIndex].Cells[2].Value.ToString();
            DateTime dob = DSHS[dataGridView_DSHS.CurrentCell.RowIndex].GetNgaySinh();

            //dia chi add later
            //string diachi = dataGridView_HS2.Rows[dataGridView_HS2.CurrentCell.RowIndex].Cells[1].Value.ToString();

            try
            {
                Document doc = new Document();
                DocumentBuilder builder = new DocumentBuilder(doc);

                // Specify font formatting
                Aspose.Words.Font font = builder.Font;
                font.Size = 11;
                font.Color = System.Drawing.Color.Black;
                font.Name = "Calibri";

                builder.ParagraphFormat.LineSpacingRule = LineSpacingRule.Multiple;
                builder.ParagraphFormat.LineSpacing = 18;

                //Insert text
                font.Size = 12;
                builder.Write("PHÒNG GD&DT HUYỆN \t\t\t\t");
                builder.Writeln("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM");

                //Change formatting for next elements.
                font.Bold = true;
                font.Size = 11;

                //Text
                builder.Write("\tTRƯỜNG TIỂU HỌC TÂN THẠNH ĐÔNG\t\t\t");
                builder.Writeln("Độc lập – Tự do – Hạnh phúc");
                builder.Writeln();

                //Change formatting for next elements.
                font.Size = 20;

                //Text
                builder.Writeln("\t\tGIẤY CHỨNG NHẬN TỐT NGHIỆP TIỂU HỌC");

                //Change formatting for next elements.
                font.Size = 11;
                font.Bold = false;

                //Text
                builder.Writeln("\t\t\t\t\t\t(tạm thời)");
                font.Size = 14;
                builder.Writeln("Chứng nhận: "+name);
                builder.Writeln("Ngày sinh: ngày "+dob.Day+" tháng "+dob.Month+" năm "+dob.Year);
                builder.Writeln("Nơi sinh: Xã … - Huyện … - Tỉnh …");
                builder.Writeln("Lớp: "+lop+" Trường Tiểu Học Tân Thạnh Đông");
                builder.Writeln("Hiện đang cư trú tại: ");
                builder.Writeln("Đã được công nhận tốt nghiệp tiểu học tại hội đồng xét công nhận tốt nghiệp");
                builder.Writeln("Trường Tiểu học Tân Thạnh Đông ngày "+ curentDate.Day+" tháng "+curentDate.Month+" năm "+curentDate.Year);
                builder.Writeln("Xếp loại tốt nghiệp: …");
                builder.Writeln("\t\t\t\t\t\t… … … , ngày … … tháng … năm …");
                builder.Writeln("\t\t\t\t\t\t\tHIỆU TRƯỞNG");

                doc.Save("C:/Users/DELL 6440/OneDrive/DocumentsDocument.docx");
                doc.Save("Document.txt");
                MessageBox.Show("Save successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document();
                DocumentBuilder builder = new DocumentBuilder(doc);

                // Specify font formatting
                Aspose.Words.Font font = builder.Font;
                font.Size = 12;
                font.Color = System.Drawing.Color.Black;
                font.Name = "Calibri";
                font.Color = Color.DarkRed;

                builder.ParagraphFormat.LineSpacingRule = LineSpacingRule.Multiple;
                builder.ParagraphFormat.LineSpacing = 18;

                builder.Writeln("\t\t\tCỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM");
                font.Size = 11;
                font.Bold = true;
                builder.Writeln("\t\t\t\tĐộc lập - Tự do - Hạnh phúc");
                font.Bold = false;
                builder.Writeln("\t\t\t\t-------------------------");
                font.Size = 22;
                builder.Writeln("\t\tĐƠN XIN CHUYỂN TRƯỜNG TIỂU HỌC");
                font.Size = 12;
                font.Color = Color.Black;
                builder.Writeln("Kính gửi: - Phòng Giáo dục và Đào tạo...........................(1)");
                builder.Writeln(" - Hiệu trưởng Trường Tiểu học...........................(2)");
                builder.Writeln("Tên tôi là: ................");
                builder.Writeln("Sinh ngày: ...........................");
                builder.Writeln("CMND/CCCD số: ........................Cấp ngày: ..............................Tại: .................................................................");
                builder.Writeln("Hộ khẩu thường trú: .....................................");
                builder.Writeln("Số điện thoại: ....................................");
                builder.Writeln("Là cha mẹ/ người giám hộ của học sinh: ........................");
                builder.Writeln("Đang học lớp: ............... Trường Tiểu học ........................ Quận (Huyện) ...............................");
                builder.Writeln("Tỉnh( Thành phố) .....................................");
                builder.Writeln("Kết quả học tập năm học .............. Học lực:................Hạnh kiểm:.................");
                builder.Writeln("Nay tôi làm đơn này xin phép Hiệu trưởng Trường Tiểu học ................................" +
                    "Quận(Huyện)...............Tỉnh(Thành phố)...............đồng ý cho học sinh............." +
                    "được chuyển đến học tại Trường Tiểu học......................Quận(Huyện)...............Tỉnh(Thành phố)................" +
                    "đồng thời xin phép Hiểu trưởng Trường Tiểu học.....................Quận(Huyện).............................." +
                    "Tỉnh(Thành phố).................đồng ý cho học sinh.......................được nhập học tại nhà Trường");
                builder.Writeln("Lý do chuyển trường:(3).....................................................................................................");
                builder.Writeln("Mong nhận được sự đồng ý và chấp thuận của Quý Hiệu trưởng và Nhà trường");
                builder.Writeln("Tôi xin chân thành cảm ơn.");
                builder.ParagraphFormat.Alignment = ParagraphAlignment.Right;
                builder.Writeln(".............., ngày.....tháng.......năm 20...");
                font.Bold = true;
                font.Color = Color.DarkRed;
                font.Size = 14;
                builder.Writeln("NGƯỜI LÀM ĐƠN");
                font.Color = Color.Black;
                font.Bold = false;
                font.Size = 12;
                builder.Writeln("(Ký và ghi rõ họ tên)");

                doc.Save("C:/Users/DELL 6440/OneDrive/Document.docx");
                doc.Save("Document.txt");
                MessageBox.Show("Save successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                DSHS.Add(new CHocSinh(DSHS[DSHS.Count - 1].GetMaHS() + 1, name_hs, DSPH[DSPH.Count - 1].GetMaPH(), dob, "đang học"));
                DSPH.Add(new CPhuHuynh(DSPH[DSPH.Count - 1].GetMaPH() + 1, name_ph, sdt));

                dt_hs.Rows.Add(DSHS[DSHS.Count - 1].GetMaHS(), DSHS[DSHS.Count - 1].GetTenHS(), DSHS[DSHS.Count - 1].GetMaLop(), DSPH[DSPH.Count-1].GetTenPH(), DSHS[DSHS.Count - 1].GetNgaySinh(), DSHS[DSHS.Count - 1].GetStatus());

                MessageBox.Show("Lưu thành công!");
            }
        }

        private void linkLabel_Logoff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Log off", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                this.Close();
                //FormLogin form = new FormLogin();
                //form.Show();
            }
        }

        private void FormManagerMenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Log off", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //FormLogin form = new FormLogin();
                //form.Show();
            }
        }
        private void setColor()
        {
            this.BackColor = darkMode.denlot;
            tabPageDKNH.BackColor = darkMode.denlot;
            tabPageHS.BackColor = darkMode.denlot;
            tabPageGVCN.BackColor = darkMode.denlot;
            tabPageChuyenTruong.BackColor = darkMode.denlot;
            tabPageTotNghiep.BackColor = darkMode.denlot;
            tabPageDKXL.BackColor = darkMode.denlot;

            dataGridView_DSHS.BackgroundColor = darkMode.denlot;

            tabPageGVCN.BackColor = darkMode.dendam;
            menuStrip1.BackColor = darkMode.xanh;
            đăngXuấtToolStripMenuItem.BackColor = darkMode.dendam;
            chếĐộBanĐêmToolStripMenuItem.BackColor = darkMode.dendam;
            thoátToolStripMenuItem.BackColor = darkMode.dendam;


            lbl_header.ForeColor = darkMode.trang;
            lbl_titleHS.ForeColor = darkMode.trang;
            lbl_hotenHS.ForeColor = darkMode.trang;
            lbl_DoB.ForeColor = darkMode.trang;
            lbl_Diachi.ForeColor = darkMode.trang;
            lbl_titlePH.ForeColor = darkMode.trang;
            lbl_hotenPH.ForeColor = darkMode.trang;
            lbl_sdt.ForeColor = darkMode.trang;
            lbl_titleDSHS.ForeColor = darkMode.trang;
            lbl_DSHS.ForeColor = darkMode.trang;
            lbl_DSLop.ForeColor = darkMode.trang;
            lbl_DSLop1.ForeColor = darkMode.trang;
            lbl_DSGV.ForeColor = darkMode.trang;
            lbl_title1.ForeColor = darkMode.trang;
            lbl_title2.ForeColor = darkMode.trang;
            đăngXuấtToolStripMenuItem.ForeColor = darkMode.trang;
            chếĐộBanĐêmToolStripMenuItem.ForeColor = darkMode.trang;
            thoátToolStripMenuItem.ForeColor = darkMode.trang;
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
    }
    
}
