using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class DanhSachBangDiem : Form
    {
        //private static string connstring = ConfigurationManager.ConnectionStrings[""].ConnectionString; 
        //private SqlConnection conn = new SqlConnection(connstring);
        //SqlCommand cmd = new SqlCommand("Select * from BangDiemCuoiKi")
        public DanhSachBangDiem()
        {
            InitializeComponent();
        }
        private void DanhSachBangDiem_Load(object sender, EventArgs e)
        {
        }
        private void displayDgv()
        {
            //conn.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sqlDataAdapter.Fill(dt);
            //dgvHDNG.DataSource = dt;
            //conn.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            //cmd = newSqlConnection("Select * from BangDiemCuoiKi
            //                        where namhoc = txbNamHoc   and     and        ")                             
        }
    }
}
