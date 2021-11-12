using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Class;
namespace QuanLyHocSinh.Forms
{
    public partial class DSHS : Form
    {
        public DSHS()
        {
            InitializeComponent();
        }
        List<CHocSinh> hs = new List<CHocSinh>();
        DataTable table = new DataTable();
        public bool check()
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học sinh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên phụ huynh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return false;
            }
            return true;
        }
        private void DSHS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string m;
                string t;
                string ns;
                string ph;
                string dc;
                m = textBox5.Text;
                t = textBox1.Text;
                ns = textBox2.Text;
                ph = textBox3.Text;
                dc = textBox4.Text;
                CHocSinh user = new CHocSinh(m, t, ns,ph,dc);
                hs.Add(user);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hs;
                dataGridView1.Refresh();
            }
        }
        int index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textBox5.Text = hs[index].MaHS;
                textBox1.Text = hs[index].TenHS;
                textBox2.Text = hs[index].NgaySinh;
                textBox3.Text = hs[index].PhuHuynh;
                textBox4.Text = hs[index].DiaChi;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không? ", "Cảnh bảo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                hs.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hs;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                hs[index].MaHS = textBox5.Text;
                hs[index].TenHS = textBox1.Text;
                hs[index].NgaySinh = textBox2.Text;
                hs[index].PhuHuynh = textBox3.Text;
                hs[index].DiaChi = textBox4.Text;
                // dataGridView1.DataSource = null;
                dataGridView1.DataSource = hs;
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
    
}
