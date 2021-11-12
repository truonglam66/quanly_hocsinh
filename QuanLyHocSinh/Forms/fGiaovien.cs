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

        private void xemVàCậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void điểmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtQuảLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapdiem f = new fNhapdiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
