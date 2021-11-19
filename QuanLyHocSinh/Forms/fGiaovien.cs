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
    public partial class fGiaovien : Form
    {
        public fGiaovien()
        {
            InitializeComponent();
        }
        public void setColor()
        {
            this.BackColor = darkMode.denlot;
            tabPage1.BackColor = darkMode.denlot;
            tabPage2.BackColor = darkMode.denlot;
            tabPage3.BackColor = darkMode.denlot;
            tabPage4.BackColor = darkMode.denlot;

            label2.ForeColor = darkMode.trang;
            tabPage1.ForeColor = darkMode.trang;
            tabPage2.ForeColor = darkMode.trang;
            tabPage3.ForeColor = darkMode.trang;
            tabPage4.ForeColor = darkMode.trang;
            label3.ForeColor = darkMode.trang;


            btnThemCK.BackColor = darkMode.xanh;
            btnTaoTKB.BackColor = darkMode.xanh;
            button1.BackColor = darkMode.xanh;
            button2.BackColor = darkMode.xanh;
            button3.BackColor = darkMode.xanh;
            button4.BackColor = darkMode.xanh;
            button5.BackColor = darkMode.xanh;
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

        }
    }
}
