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

namespace QuanLyHocSinh
{
    public partial class FormLogin : Form
    {
        CNhanVienQL nhanvien = new CNhanVienQL("truong", "123");

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
                }
                if (txt_username.Text == nhanvien.GetUserName() && txt_password.Text == nhanvien.GetPassword())
                {
                    //Load Form Teacher
                }
                if (txt_username.Text == nhanvien.GetUserName() && txt_password.Text == nhanvien.GetPassword())
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
