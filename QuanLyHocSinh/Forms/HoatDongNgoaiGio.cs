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
        private void HoatDongNgoaiGio_Load(object sender, EventArgs e)
        {
            
            displayDgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
