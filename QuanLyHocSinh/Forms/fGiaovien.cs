using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyHocSinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLyHocSinh.Forms
{
    public partial class fGiaovien : Form
    {
        public fGiaovien()
        {
            InitializeComponent();
        }

        //-------------------CONNECT_SQL-------------------
        //ConnectData c = new ConnectData();
        //--------------------------------------------------

        DataTable table = new DataTable("table");
        DataTable table1 = new DataTable("table");
        DataTable table2 = new DataTable("table");
        public void setColor()
        {
            this.BackColor = darkMode.denlot;
            tabPage1.BackColor = darkMode.denlot;
            tabPage2.BackColor = darkMode.denlot;
            tabPage3.BackColor = darkMode.denlot;
            tabPage4.BackColor = darkMode.denlot;
            dgvDiemCK.DefaultCellStyle.BackColor = darkMode.denlot;
            dgvCuocthi.DefaultCellStyle.BackColor = darkMode.denlot;
            dgvDiemCK.DefaultCellStyle.BackColor = darkMode.denlot;
            dgvHDNG.DefaultCellStyle.BackColor = darkMode.denlot;

            label2.ForeColor = darkMode.trang;
            tabPage1.ForeColor = darkMode.trang;
            tabPage2.ForeColor = darkMode.trang;
            tabPage3.ForeColor = darkMode.trang;
            tabPage4.ForeColor = darkMode.trang;
            label3.ForeColor = darkMode.trang;


            btnThemCK.BackColor = darkMode.xanh;
            btnTaoTKB.BackColor = darkMode.xanh;
            btnXuatFileCK.BackColor = darkMode.xanh;
            btnXuatHD.BackColor = darkMode.xanh;
            btnThemHD.BackColor = darkMode.xanh;
            btXuatCT.BackColor = darkMode.xanh;
            btnThemCT.BackColor = darkMode.xanh;
            button6.BackColor = darkMode.xanh;

            chếĐộBanĐêmToolStripMenuItem.BackColor = darkMode.xanh;
            thoátToolStripMenuItem.BackColor = darkMode.xanh;
            menuStrip1.BackColor = darkMode.xanh;


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


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chếĐộBanĐêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkMode.TroCarMode();
            setColor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbHDNG.SelectedIndex == 0)
            {
                if (dgvHDNG.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "HDNGReportPDF";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("Không thể ghi dữ liệu vào đĩa." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dgvHDNG.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgvHDNG.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgvHDNG.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Dữ liệu được xuất thành công !!!", "Thông báo");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào để xuất !!!", "Thông báo");
                }
            }
            else
            {
                // Save File Excel

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dgvHDNG.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvHDNG.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvHDNG.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHDNG.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvHDNG.Rows[i].Cells[j].Value.ToString();
                    }
                }
                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "HDNGReportExcel";
                saveFileDialoge.DefaultExt = ".xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();

            }
        }


        /*
        private void Showdata(string s, DataGridView dgv)
        { 
            DataSet data = new DataSet();
            string query = "select ma_gv [mã giáo viên], hoten_gv [Họ và tên], ngaysinh_gv [Ngày sinh], gioitinh_gv [Giới tính], dantoc_gv [Dân tộc], diachi_gv [Địa chỉ], sdt_gv [Số điện thoại], ma_tk [Mã tài khoản], trangthai_gv [Trạng thái], ghichu_gv [Ghi chú] from GiaoVien";
            SqlDataAdapter adp = new SqlDataAdapter(query, c.Conn);
            adp.Fill(data);
            dgv.DataSource = data.Tables[0];
            //dgv.Columns["Họ và tên"].Width = 150;
            //dgv.Columns["Ngày sinh"].Width = 150;
        }
        

        
        private void AddRows(string s, DataGridView dgv, string query)
        {
            bool kq = c.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                Showdata(s, dgv);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!");
            }
        }
        

        //--------------------Câu truy vấn lấy tất cả dữ liệu của từng bảng-----------
        //Điểm cuối kì
        string StringCK = "";
        //Hoạt động ngoài giờ
        string StringHDNG = "";
        //Cuộc thi
        string StringCT = "";
        */


        private void fGiaovien_Load(object sender, EventArgs e)
        {
            /*
            //---------------------------CONNECT_SQL-------------------------------
            c.Connect();
            //----------------Đổ CSDL vào datagridview-----------------
            //Điểm cuối kì
            Showdata(StringCK, dgvDiemCK);

            //Hoạt động ngoài giờ
            Showdata(StringHDNG, dgvHDNG);

            //Cuộc thi         
            Showdata(StringCT, dgvCuocthi);

            //---------------------------------------------------------------------
            */

            //primaryKey
            DataColumn column = new DataColumn("Mã bảng điểm", typeof(string));
            column.Unique = true;
            column.AllowDBNull = false;
            column.ReadOnly = true;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = table1.Columns["Mã bảng điểm"];
            table.PrimaryKey = primaryKey;

            table.Columns.Add(column);


            //table.Columns.Add("Mã bảng điểm", typeof(string));
            table.Columns.Add("Mã học sinh", typeof(string));
            table.Columns.Add("Học kì", typeof(Int32));
            table.Columns.Add("Năm học", typeof(Int32));
            table.Columns.Add("Toán", typeof(double));
            table.Columns.Add("Tiếng việt", typeof(double));
            table.Columns.Add("Đạo đức", typeof(double));
            table.Columns.Add("Tự nhiên_xã hội", typeof(double));
            table.Columns.Add("Khoa học", typeof(double));
            table.Columns.Add("Lịch sử_địa lý", typeof(double));
            table.Columns.Add("Nghệ thuật", typeof(double));
            table.Columns.Add("Âm nhạc", typeof(double));
            table.Columns.Add("Mĩ thuật", typeof(double));
            table.Columns.Add("Kĩ thuật", typeof(double));
            table.Columns.Add("Thể dục", typeof(double));
            dgvDiemCK.DataSource = table;
            cbDiemCK.SelectedIndex = 0;
            table.Rows.Add("BD01", "HS01", 1, 2021, 8, 7.5, 6, 5, 5, 7, 8, 5.5, 9, 10, 8.5);
            table.Rows.Add("BD02", "HS02", 1, 2021, 8.5, 7.5, 6, 7, 5, 10, 8, 5.5, 9, 9, 8.5);
            table.Rows.Add("BD03", "HS03", 1, 2021, 6, 7.5, 6, 7.5, 5, 7, 8, 5.5, 9, 10, 8.5);
            table.Rows.Add("BD04", "HS04", 1, 2021, 8, 8, 6, 9, 5, 7, 8, 5.5, 9, 10, 8.5);
            table.Rows.Add("BD05", "HS05", 1, 2021, 8, 7.5, 6, 8, 5, 6.5, 8, 6, 9, 9, 8.5);

            //primaryKey1
            DataColumn column1 = new DataColumn("Mã hoạt động", typeof(string));
            column1.Unique = true;
            column1.AllowDBNull = false;
            column1.ReadOnly = true;

            DataColumn[] primaryKey1 = new DataColumn[1];
            primaryKey1[0] = table1.Columns["Mã hoạt động"];
            table1.PrimaryKey = primaryKey1;

            table1.Columns.Add(column1);
            table1.Columns.Add("Giáo viên phụ trách", typeof(string));
            table1.Columns.Add("Học sinh", typeof(string));
            table1.Columns.Add("Thời gian", typeof(string));
            table1.Columns.Add("Địa điểm", typeof(string));
            table1.Columns.Add("Năm học", typeof(Int32));
            dgvHDNG.DataSource = table1;
            cbHDNG.SelectedIndex = 0;
            table1.Rows.Add("HD01", "Nguyễn Thị Nguyệt", "Trần Văn A, Trần Văn B", "20/11/2021", "TP.HCM", 2021);
            table1.Rows.Add("HD02", "Nguyễn Văn An", "Trần Văn C, Trần Văn D", "30/04/2021", "TP.HCM", 2021);
            table1.Rows.Add("HD03", "Trần Trung Đức", "Trần Văn E, Trần Văn F", "20/02/2021", "TP.HCM", 2021);
            table1.Rows.Add("HD04", "Nguyễn Thị Cúc Hoa", "Trần Văn G, Trần Văn H", "01/05/2021", "TP.HCM", 2021);

            //primaryKey2
            DataColumn column2 = new DataColumn("Mã cuộc thi", typeof(string));
            column2.Unique = true;
            column2.AllowDBNull = false;
            column2.ReadOnly = true;
            DataColumn[] primaryKey2 = new DataColumn[1];
            primaryKey2[0] = table2.Columns["Mã cuộc thi"];
            table2.PrimaryKey = primaryKey2;

            table2.Columns.Add(column2);
            table2.Columns.Add("Môn thi", typeof(string));
            table2.Columns.Add("Giáo viên phụ trách", typeof(string));
            table2.Columns.Add("Học sinh", typeof(string));
            table2.Columns.Add("Cấp thi", typeof(string));
            table2.Columns.Add("Thời gian", typeof(string));
            table2.Columns.Add("Địa điểm", typeof(string));
            table2.Columns.Add("Năm thi", typeof(Int32));
            table2.Rows.Add("CT01", "Anh văn", "Nguyễn Thị Tố Quyên", "Nguyễn Thị A, Trần Thị B", "Cấp huyện", "24/02/2021", "Trường THPT A", 2021);
            table2.Rows.Add("CT02", "Toán", "Nguyễn Thị Tố Lệ", "Nguyễn Thị C, Trần Thị D", "Cấp huyện", "24/02/2021", "Trường THPT A", 2021);
            table2.Rows.Add("CT03", "Ngữ văn", "Nguyễn Thị Tố Nữ", "Nguyễn Thị E, Trần Thị F", "Cấp tỉnh", "24/04/2021", "Trường THPT A", 2021);
            dgvCuocthi.DataSource = table2;
            cbCapthi.SelectedIndex = 0;
            cbCuocthi.SelectedIndex = 0;
        }

        private void btnThemCK_Click(object sender, EventArgs e)
        {
            /*
            //------------------------------CONNECT_SQL---------------------------------
            //Câu truy vấn thêm trường mới
            string QueryCK = "";
            AddRows(StringCK, dgvDiemCK, QueryCK);
            //--------------------------------------------------------------------------
            */


            if (string.IsNullOrEmpty(txbMaBangdiem.Text) || string.IsNullOrEmpty(txbMaHS.Text) || string.IsNullOrEmpty(txbHocki.Text) || string.IsNullOrEmpty(txbNamhoc.Text) || string.IsNullOrEmpty(txbToan.Text) || string.IsNullOrEmpty(txbTiengviet.Text) || string.IsNullOrEmpty(txbDaoduc.Text) || string.IsNullOrEmpty(txbTNvaXH.Text) || string.IsNullOrEmpty(txbKhoahoc.Text) || string.IsNullOrEmpty(txbLSvaDL.Text) || string.IsNullOrEmpty(txbNghethuat.Text) || string.IsNullOrEmpty(txbAmnhac.Text) || string.IsNullOrEmpty(txbMythuat.Text) || string.IsNullOrEmpty(txbKithuat.Text) || string.IsNullOrEmpty(txbTheduc.Text))
            {
                MessageBox.Show("Không để trống bất kỳ thông tin nào!", "LƯU Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    table.Rows.Add(txbMaBangdiem.Text, txbMaHS.Text, txbHocki.Text, txbNamhoc.Text, txbToan.Text, txbTiengviet.Text, txbDaoduc.Text, txbTNvaXH.Text, txbKhoahoc.Text, txbLSvaDL.Text, txbNghethuat.Text, txbAmnhac.Text, txbMythuat.Text, txbKithuat.Text, txbTheduc.Text);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm dữ liệu thất bại. Mã bảng điểm không được trùng nhau!", "Thông báo");
                }
                
            }    
            
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Đã xảy ra ngoại lệ khi giải phóng đối tượng " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDiemCK.SelectedIndex == 0)
            {
                if (dgvDiemCK.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "DiemCKReportPDF";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("Không thể ghi dữ liệu vào đĩa." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dgvDiemCK.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgvDiemCK.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgvDiemCK.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Dữ liệu được xuất thành công !!!", "Thông báo");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào để xuất !!!", "Thông báo");
                }
            }
            else
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dgvDiemCK.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDiemCK.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvDiemCK.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDiemCK.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDiemCK.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save file  
                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "DiemCKReportExcel";
                saveFileDialoge.DefaultExt = ".xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();

            }
        }

        private void dgvHDNG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*
            //------------------------------CONNECT_SQL---------------------------------
            //Câu truy vấn thêm trường mới
            string QueryHDNG = "";
            AddRows(StringHDNG, dgvHDNG, QueryHDNG);
            //--------------------------------------------------------------------------
            */



            if (string.IsNullOrEmpty(txbMaHD.Text) || string.IsNullOrEmpty(txbGV.Text) || string.IsNullOrEmpty(txbHS.Text) || string.IsNullOrEmpty(txbThoigian.Text) || string.IsNullOrEmpty(txbDiadiem.Text) || string.IsNullOrEmpty(txbNam.Text))
            {
                MessageBox.Show("Không để trống bất kì dữ liệu nào!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    table1.Rows.Add(txbMaHD.Text, txbGV.Text, txbHS.Text, txbThoigian.Text, txbDiadiem.Text, txbNam.Text);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm dữ liệu thất bại. Mã hoạt động không được trùng nhau!", "Thông báo");
                }
                
            }    
            
        }

        private void dgvDiemCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txbMaBangdiem.Text = dgvDiemCK.Rows[numrow].Cells[0].Value.ToString();
            txbMaHS.Text = dgvDiemCK.Rows[numrow].Cells[1].Value.ToString();
            txbHocki.Text = dgvDiemCK.Rows[numrow].Cells[2].Value.ToString();
            txbNamhoc.Text = dgvDiemCK.Rows[numrow].Cells[3].Value.ToString();
            txbToan.Text = dgvDiemCK.Rows[numrow].Cells[4].Value.ToString();
            txbTiengviet.Text = dgvDiemCK.Rows[numrow].Cells[5].Value.ToString();
            txbDaoduc.Text = dgvDiemCK.Rows[numrow].Cells[6].Value.ToString();
            txbTNvaXH.Text = dgvDiemCK.Rows[numrow].Cells[7].Value.ToString();
            txbKhoahoc.Text = dgvDiemCK.Rows[numrow].Cells[8].Value.ToString();
            txbLSvaDL.Text = dgvDiemCK.Rows[numrow].Cells[9].Value.ToString();
            txbNghethuat.Text = dgvDiemCK.Rows[numrow].Cells[10].Value.ToString();
            txbAmnhac.Text = dgvDiemCK.Rows[numrow].Cells[11].Value.ToString();
            txbMythuat.Text = dgvDiemCK.Rows[numrow].Cells[12].Value.ToString();
            txbKithuat.Text = dgvDiemCK.Rows[numrow].Cells[13].Value.ToString();
            txbTheduc.Text = dgvDiemCK.Rows[numrow].Cells[14].Value.ToString();
        }

        private void dgvHDNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txbMaHD.Text = dgvHDNG.Rows[numrow].Cells[0].Value.ToString();
            txbGV.Text = dgvHDNG.Rows[numrow].Cells[1].Value.ToString();
            txbHS.Text = dgvHDNG.Rows[numrow].Cells[2].Value.ToString();
            txbThoigian.Text = dgvHDNG.Rows[numrow].Cells[3].Value.ToString();
            txbDiadiem.Text = dgvHDNG.Rows[numrow].Cells[4].Value.ToString();
            txbNam.Text = dgvHDNG.Rows[numrow].Cells[5].Value.ToString();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {

            /*
            //------------------------------CONNECT_SQL---------------------------------
            //Câu truy vấn thêm trường mới
            string QueryCT = "";
            AddRows(StringCT, dgvCuocthi, QueryCT);
            //---------------------------------------------------------------------------
            */



            if (string.IsNullOrEmpty(txbMaCT.Text) || string.IsNullOrEmpty(txbMonthi.Text) || string.IsNullOrEmpty(cbGVPT.Text) || string.IsNullOrEmpty(txbHsThi.Text) || string.IsNullOrEmpty(cbCapthi.Text) || string.IsNullOrEmpty(txbTGthi.Text) || string.IsNullOrEmpty(txbDiadiemthi.Text) || string.IsNullOrEmpty(txbNamthi.Text))
            {
                MessageBox.Show("Không để trống bất kì dữ liệu nào!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    table2.Rows.Add(txbMaCT.Text, txbMonthi.Text, cbGVPT.Text, txbHsThi.Text, cbCapthi.Text, txbTGthi.Text, txbDiadiemthi.Text, txbNamthi.Text);
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm dữ liệu thất bại. Mã cuộc thi không được trùng nhau!", "Thông báo");
                }

            }    
        }

        private void btXuatCT_Click(object sender, EventArgs e)
        {
            if (cbCuocthi.SelectedIndex == 0)
            {
                if (dgvCuocthi.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "CuocThiReportPDF";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("Không thể ghi dữ liệu vào đĩa." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dgvCuocthi.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgvCuocthi.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgvCuocthi.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Dữ liệu được xuất thành công !!!", "Thông báo");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào để xuất !!!", "Thông báo");
                }
            }
            else
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dgvCuocthi.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvCuocthi.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvCuocthi.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCuocthi.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvCuocthi.Rows[i].Cells[j].Value.ToString();
                    }
                }
                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "CuocThiReportExcel";
                saveFileDialoge.DefaultExt = ".xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
        }

        private void dgvCuocthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txbMaCT.Text = dgvCuocthi.Rows[numrow].Cells[0].Value.ToString();
            txbMonthi.Text = dgvCuocthi.Rows[numrow].Cells[1].Value.ToString();
            cbGVPT.Text = dgvCuocthi.Rows[numrow].Cells[2].Value.ToString();
            txbHsThi.Text = dgvCuocthi.Rows[numrow].Cells[3].Value.ToString();
            cbCapthi.Text = dgvCuocthi.Rows[numrow].Cells[4].Value.ToString();
            txbTGthi.Text = dgvCuocthi.Rows[numrow].Cells[5].Value.ToString();
            txbDiadiemthi.Text = dgvCuocthi.Rows[numrow].Cells[6].Value.ToString();
            txbNamthi.Text = dgvCuocthi.Rows[numrow].Cells[7].Value.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
