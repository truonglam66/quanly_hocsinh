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
    public partial class dangKiThi : Form
    {
        List<dkThi> dkt = new List<dkThi>();
        DataTable table = new DataTable();
        public dangKiThi()
        {
            InitializeComponent();
        }
        public bool check()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học sinh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên GVCN! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Bạn chưa nhập môn thi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại cuộc thi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string m;
                string t;
                string l;
                string gv;
                string mt;
                string lt;
                m = textBox6.Text;
                t = textBox1.Text;
                l = textBox2.Text;
                gv = textBox3.Text;
                mt = textBox4.Text;
                lt = textBox5.Text;
                dkThi user = new dkThi(m, t, l, gv, mt, lt);
                dkt.Add(user);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dkt;
                dataGridView1.Refresh();
            }
        }
        int index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textBox6.Text = dkt[index].Mhs;
                textBox1.Text = dkt[index].TenHS;
                textBox2.Text = dkt[index].Lop;
                textBox3.Text = dkt[index].TenGV;
                textBox4.Text = dkt[index].MonThi;
                textBox5.Text = dkt[index].LoaiThi;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không? ", "Cảnh bảo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dkt.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dkt;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                dkt[index].Mhs = textBox6.Text;
                dkt[index].TenHS = textBox1.Text;
                dkt[index].Lop = textBox2.Text;
                dkt[index].TenGV = textBox3.Text;
                dkt[index].MonThi = textBox4.Text;
                dkt[index].LoaiThi = textBox5.Text;
               // dataGridView1.DataSource = null;
                dataGridView1.DataSource = dkt;
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
