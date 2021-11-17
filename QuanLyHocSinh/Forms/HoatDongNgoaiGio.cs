using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyHocSinh.Forms
{
    public partial class HoatDongNgoaiGio : Form
    {
        //private static string connstring = ConfigurationManager.ConnectionStrings[""].ConnectionString; 
        //private SqlConnection conn = new SqlConnection(connstring);


        public HoatDongNgoaiGio()
        {
            InitializeComponent();
        }

        /*
        private void dgvHDNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txbMaHoatDong.Texts = dgvHDNG.Rows[e.RowIndex].Cells[0].ToString();
            //txbGiaoVien.Texts = dgvHDNG.Rows[e.RowIndex].Cells[1].ToString();
            //txbDiaDiem.Texts = dgvHDNG.Rows[e.RowIndex].Cells[2].ToString();
            //DatePicker.Value = DateTime.Parse(dgvHDNG.Rows[e.RowIndex].Cells[3].ToString());
        }
        private void displayDgv()
        {
            //conn.Open();
            //using (SqlCommand cmd = new SqlCommand("Select MaHD,GiaoVien,Diadiem,ThoiGian from BangDKHDNG"))
            //{
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    sqlDataAdapter.Fill(dt);
            //    dgvHDNG.DataSource = dt;
            //}
            //conn.Close();
        }
        */
        private void HoatDongNgoaiGio_Load(object sender, EventArgs e)
        {
            lbSLHocSinh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(txbDiaDiem.Texts) || string.IsNullOrWhiteSpace(txbGiaoVien.Texts) || string.IsNullOrWhiteSpace(txbMaHoatDong.Texts)))
            {
                int i = 0;
                foreach(DataGridViewRow row in dgvHDNG.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txbMaHoatDong.Texts) break;
                    i++;
                }
                if (i == hoatDongBindingSource.Count)
                {
                    hoatDongBindingSource.Add(new Classes.HoatDong() { MaHD = txbMaHoatDong.Texts, MaGvPhuTrach = txbGiaoVien.Texts, DiaDiem = txbDiaDiem.Texts, ThoiGian = DatePicker.Value });
                    lbSLHocSinh.Text = "0";
                    dgvHDNG.ClearSelection();
                }
                else rtxbError.Text = "Mã hoạt động không được trùng";
            }
            else rtxbError.Text = "Không được để trống";
           
        }

        private void dgvHDNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
                txbDiaDiem.Texts = hoatdong.DiaDiem;
                txbGiaoVien.Texts = hoatdong.MaGvPhuTrach;
                txbMaHoatDong.Texts = hoatdong.MaHD;
                if (hoatdong.HocSinhs != null)
                    lbSLHocSinh.Text = hoatdong.HocSinhs.Count.ToString();
                else lbSLHocSinh.Text = "0";
            }
            else rtxbError.Text = "";
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
            if (hoatdong != null)
            {
                hoatdong.MaGvPhuTrach = txbMaHoatDong.Texts;
                hoatDongBindingSource[dgvHDNG.SelectedRows[0].Index] = new Classes.HoatDong() { MaHD = txbMaHoatDong.Texts, MaGvPhuTrach = txbGiaoVien.Texts, DiaDiem = txbDiaDiem.Texts, ThoiGian = DatePicker.Value };

            } else rtxbError.Text = "Chọn hoạt động muốn sửa";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHDNG.SelectedRows.Count > 0)
            {
                hoatDongBindingSource.RemoveAt(dgvHDNG.SelectedRows[0].Index);
                dgvHDNG.ClearSelection();
                lbSLHocSinh.Text = "";
            }
            else rtxbError.Text = "Chọn hoạt động muốn xóa";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbDiaDiem.Texts = txbGiaoVien.Texts = txbMaHoatDong.Texts = "";
            dgvHDNG.ClearSelection();
            lbSLHocSinh.Text = "";
            rtxbError.Text = "";
        }

        private void btnDsHocSinh_Click(object sender, EventArgs e)
        {
            if (dgvHDNG.SelectedRows.Count > 0)
            {
                Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
                using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(hoatdong.HocSinhs))
                {
                    danhSachHocSinh.HocSinhDaChon = hoatdong.HocSinhs;
                    if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                    {
                        hoatdong.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                        if (hoatdong.HocSinhs != null) lbSLHocSinh.Text = hoatdong.HocSinhs.Count.ToString();
                        else lbSLHocSinh.Text = "0";
                    }
                }
            }
            else rtxbError.Text = "Chọn hoạt động muốn sửa danh sách học sinh";
        }

        private void btnTimMaHoatDong_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvHDNG.Rows)
            {
                if (row.Cells[0].Value.ToString() == txbMaHoatDong.Texts)
                {
                    row.Selected = true;
                    hoatDongBindingSource.Position = row.Index;
                    Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
                    txbDiaDiem.Texts = hoatdong.DiaDiem;
                    txbGiaoVien.Texts = hoatdong.MaGvPhuTrach;
                    txbMaHoatDong.Texts = hoatdong.MaHD;
                    if (hoatdong.HocSinhs != null)
                        lbSLHocSinh.Text = hoatdong.HocSinhs.Count.ToString();
                    else lbSLHocSinh.Text = "0";
                    rtxbError.Text = "";
                    break;
                    
                }
                i++;
            }
            if (i == hoatDongBindingSource.Count)
            {
                dgvHDNG.ClearSelection();
                hoatDongBindingSource.Position = -1;
                rtxbError.Text = "Không tìm thấy mã hoạt động";
            }
        }

        private void txbMaHoatDong__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
