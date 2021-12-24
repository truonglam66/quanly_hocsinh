using QuanLyHocSinh.Classes;
using QuanLyHocSinh.Forms;
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
    public partial class FormLogin : Form
    {
        CNhanVienQL nhanvien = new CNhanVienQL("lamtruong", "123");
        CGiaoVien giaovien1 = new CGiaoVien("toannv", "123");
        CGiaoVien giaovien2 = new CGiaoVien("minhnt", "123");
        CGiaoVien giaovien3 = new CGiaoVien("lincd", "123");
        CGiaoVien giaovien4 = new CGiaoVien("vantn", "123");
        CGiaoVien giaovien5 = new CGiaoVien("hungtq", "123");
        CGiaoVien giaovien6 = new CGiaoVien("nganlt", "123");
        CGiaoVien giaovien7 = new CGiaoVien("vannth", "123");
        CGiaoVien giaovien8 = new CGiaoVien("linhlh", "123");
        CGiaoVien giaovien9 = new CGiaoVien("dungdv", "123");
        CGiaoVien giaovien10 = new CGiaoVien("oanhvv", "123");
        CGiaoVien giaovien11 = new CGiaoVien("tuanttp", "123");

        public FormLogin()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Hãy nhập username");
                txt_username.Focus();
            }

            else if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Hãy nhập password");
                txt_password.Focus();
            }

            else
            {
                if (txt_username.Text == nhanvien.GetUserName() && txt_password.Text == nhanvien.GetPassword())
                {
                    //Load Form Manager
                    Form form = new FormManagerMenu();
                    this.Hide();
                    form.Show();
                }
                else if ((txt_username.Text == giaovien1.GetUserName() && txt_password.Text == giaovien1.GetPassword())
                    || (txt_username.Text == giaovien2.GetUserName() && txt_password.Text == giaovien2.GetPassword())
                    || (txt_username.Text == giaovien3.GetUserName() && txt_password.Text == giaovien3.GetPassword())
                    || (txt_username.Text == giaovien4.GetUserName() && txt_password.Text == giaovien4.GetPassword())
                    || (txt_username.Text == giaovien5.GetUserName() && txt_password.Text == giaovien5.GetPassword())
                    || (txt_username.Text == giaovien6.GetUserName() && txt_password.Text == giaovien6.GetPassword())
                    || (txt_username.Text == giaovien7.GetUserName() && txt_password.Text == giaovien7.GetPassword())
                    || (txt_username.Text == giaovien8.GetUserName() && txt_password.Text == giaovien8.GetPassword())
                    || (txt_username.Text == giaovien9.GetUserName() && txt_password.Text == giaovien9.GetPassword())
                    || (txt_username.Text == giaovien10.GetUserName() && txt_password.Text == giaovien10.GetPassword())
                    || (txt_username.Text == giaovien11.GetUserName() && txt_password.Text == giaovien11.GetPassword()))
                {
                    //Load Form Teacher
                    Form form = new fGiaovien();
                    this.Hide();
                    form.Show();
                }
                else if (txt_username.Text == nhanvien.GetUserName() && txt_password.Text == nhanvien.GetPassword())
                {
                    //Load Form Admin
                }
                else MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Login failed!");
            }
        }

        public string GetUserName()
        {
            return nhanvien.GetUserName();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Exit", MessageBoxButtons.YesNo);
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

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
