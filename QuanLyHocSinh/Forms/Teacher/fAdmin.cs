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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void txbMaTK_TextChanged(object sender, EventArgs e)
        {

        }
        List<TaiKhoan> ds = new List<TaiKhoan>();

        private void fAdmin_Load(object sender, EventArgs e)
        {
            //List<TaiKhoan> ds = new List<TaiKhoan>();
            /*TaiKhoan tk;
            tk = new TaiKhoan() { Matk = "Ad01", TenDangnhap = "Admin01", TenHienthi = "Admin01", Matkhau = "12345" };
            ds.Add(tk);
            tk = new TaiKhoan() { Matk = "Gv01", TenDangnhap = "NguyenVanA", TenHienthi = "Nguyễn Văn A", Matkhau = "123456" };
            ds.Add(tk);
            dgvTaikhoan.DataSource = ds;*/
        }
        int numrow;
        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if(numrow >= 0)
            txbMaTK.Text = dgvTaikhoan.Rows[numrow].Cells[0].Value.ToString();
            txbTenDangnhap.Text = dgvTaikhoan.Rows[numrow].Cells[1].Value.ToString();
            txbTenhienthi.Text = dgvTaikhoan.Rows[numrow].Cells[2].Value.ToString();
            txbMatkhau.Text = dgvTaikhoan.Rows[numrow].Cells[3].Value.ToString();
        }
        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(txbMaTK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaTK.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txbTenDangnhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txbTenDangnhap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txbTenhienthi.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenhienthi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txbMatkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMatkhau.Focus();
                return false;
            }
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                TaiKhoan tk = new TaiKhoan(txbMaTK.Text, txbTenDangnhap.Text, txbTenhienthi.Text, txbMatkhau.Text);
                ds.Add(tk);
                dgvTaikhoan.DataSource = null;
                dgvTaikhoan.DataSource = ds;
                dgvTaikhoan.Refresh();
            }    
            /*TaiKhoan tk;
            tk = new TaiKhoan() { Matk = txbMaTK.Text, TenDangnhap = txbTenDangnhap.Text, TenHienthi = txbTenhienthi.Text, Matkhau = txbMatkhau.Text };
            foreach(TaiKhoan i in ds)
            {
                if(tk.Matk == i.Matk || tk.TenDangnhap == i.TenDangnhap || tk.TenHienthi == i.TenHienthi || tk.Matkhau == i.Matkhau)
                {
                    MessageBox.Show("Thêm thất bại!");
                    break;
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    ds.Add(tk);
                    
                    break;
                }
            }
            dgvTaikhoan.DataSource = ds;*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(numrow >= 0)
            {
                ds[numrow].Matk = txbMaTK.Text;
                ds[numrow].TenDangnhap = txbTenDangnhap.Text;
                ds[numrow].TenHienthi = txbTenhienthi.Text;
                ds[numrow].Matkhau = txbMatkhau.Text;
                dgvTaikhoan.DataSource = null;
                dgvTaikhoan.DataSource = ds;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ds.RemoveAt(numrow);
                dgvTaikhoan.DataSource = null;
                dgvTaikhoan.DataSource = ds;
            }    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string value = txbMaTK.Text;
            if(rbMataikhoan.Checked)
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    dgvTaikhoan.DataSource = null;
                    dgvTaikhoan.DataSource = ds;
                    List<TaiKhoan> ds1 = new List<TaiKhoan>();
                    for(int i = 0; i < dgvTaikhoan.Rows.Count; i++)
                    {
                        if (dgvTaikhoan.Rows[i].Cells[0].Value.ToString().Contains(value))
                        {
                            ds1.Add(ds[i]);
                        }
                        dgvTaikhoan.DataSource = null;
                        dgvTaikhoan.DataSource = ds1;
                    }    
                }
                else
                {
                    dgvTaikhoan.DataSource = null;
                    dgvTaikhoan.DataSource = ds;
                }    
            }
            if(rbTenhienthi.Checked)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    dgvTaikhoan.DataSource = null;
                    dgvTaikhoan.DataSource = ds;
                    List<TaiKhoan> ds1 = new List<TaiKhoan>();
                    for (int i = 0; i < dgvTaikhoan.Rows.Count; i++)
                    {
                        if (dgvTaikhoan.Rows[i].Cells[2].Value.ToString() == txbTim.Text)
                        {
                            ds1.Add(ds[i]);
                        }
                        dgvTaikhoan.DataSource = null;
                        dgvTaikhoan.DataSource = ds1;
                    }
                }
                else
                {
                    dgvTaikhoan.DataSource = null;
                    dgvTaikhoan.DataSource = ds;
                }
                dgvTaikhoan.DataSource = null;
                dgvTaikhoan.DataSource = ds;
            }    
        }
    }
}
