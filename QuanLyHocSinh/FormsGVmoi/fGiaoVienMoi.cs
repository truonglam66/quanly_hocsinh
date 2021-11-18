using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.FormsGVmoi
{
    public partial class fGiaoVienMoi : Form
    {
        public fGiaoVienMoi()
        {
            InitializeComponent();
        }

        private void btnTaoTKB_Click(object sender, EventArgs e)
        {
            fTaoTKB f = new fTaoTKB();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
