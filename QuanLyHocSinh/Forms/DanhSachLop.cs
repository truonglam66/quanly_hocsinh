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
    public partial class DanhSachLop : Form
    {
        public DanhSachLop()
        {
            InitializeComponent();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // xem danh sach hoc sinh
        }
    }
}
