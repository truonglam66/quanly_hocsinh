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
    public partial class fTaoTKB : Form
    {
        public fTaoTKB()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo thời khóa biểu thành công!");
            this.Close();
        }
    }
}
