using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.Forms.Admin
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_HDNG_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txbDiaDiem_HDNG.Text) || string.IsNullOrWhiteSpace(txbGiaoVien_HDNG.Text) || string.IsNullOrWhiteSpace(txbMaHoatDong_HDNG.Text)))
            {
                int i = 0;
                foreach (DataGridViewRow row in dgvHDNG.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txbMaHoatDong_HDNG.Text) break;
                    i++;
                }
                if (i == hoatDongBindingSource.Count)
                {
                    hoatDongBindingSource.Add(new Classes.HoatDong() { MaHD = txbMaHoatDong_HDNG.Text, MaGvPhuTrach = txbGiaoVien_HDNG.Text, DiaDiem = txbDiaDiem_HDNG.Text, ThoiGian = dtp_HDNG.Value });
                    lbSLHocSinh_HDNG.Text = "0";
                    hoatDongBindingSource.Position = hoatDongBindingSource.Count - 1;
                    rtxbLoi_HDNG.Text = "";
                }
                else rtxbLoi_HDNG.Text = "Mã hoạt động không được trùng";
            }
            else rtxbLoi_HDNG.Text = "Không được để trống";
        }

        private void btnSua_HDNG_Click(object sender, EventArgs e)
        {
            Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
            if (hoatdong != null)
            {
                if (!(string.IsNullOrWhiteSpace(txbDiaDiem_HDNG.Text) || string.IsNullOrWhiteSpace(txbGiaoVien_HDNG.Text) || string.IsNullOrWhiteSpace(txbMaHoatDong_HDNG.Text)))
                {
                    int i = 0;
                    foreach (DataGridViewRow row in dgvHDNG.Rows)
                    {
                        if (txbMaHoatDong_HDNG.Text != hoatdong.MaHD )
                        if (row.Cells[0].Value.ToString() == txbMaHoatDong_HDNG.Text) break;
                        i++;
                    }
                    if (i == hoatDongBindingSource.Count)
                    {
                        hoatdong.MaGvPhuTrach = txbMaHoatDong_HDNG.Text;
                        hoatDongBindingSource[dgvHDNG.SelectedRows[0].Index] = new Classes.HoatDong() { MaHD = txbMaHoatDong_HDNG.Text, MaGvPhuTrach = txbGiaoVien_HDNG.Text, DiaDiem = txbDiaDiem_HDNG.Text, ThoiGian = dtp_HDNG.Value, HocSinhs = hoatdong.HocSinhs };
                        rtxbLoi_HDNG.Text = "";
                    }
                    else rtxbLoi_HDNG.Text = "Mã hoạt động không được trùng";
                }
                else rtxbLoi_HDNG.Text = "Không được để trống";
                

            }
            else rtxbLoi_HDNG.Text = "Chọn hoạt động muốn sửa";
        }

        private void btnXoa_HDNG_Click(object sender, EventArgs e)
        {
            if (dgvHDNG.SelectedRows.Count > 0)
            {
                hoatDongBindingSource.RemoveAt(dgvHDNG.SelectedRows[0].Index);
                dgvHDNG.ClearSelection();
                hoatDongBindingSource.Position = -1;
                lbSLHocSinh_HDNG.Text = "";

            }
            else rtxbLoi_HDNG.Text = "Chọn hoạt động muốn xóa";
        }

        private void btnHuy_HDNG_Click(object sender, EventArgs e)
        {
            txbDiaDiem_HDNG.Text = txbGiaoVien_HDNG.Text = txbMaHoatDong_HDNG.Text = "";
            dgvHDNG.ClearSelection();
            lbSLHocSinh_HDNG.Text = "";
            rtxbLoi_HDNG.Text = "";
            hoatDongBindingSource.Position = -1;
        }

        private void btnDsHocSinh_HDNG_Click(object sender, EventArgs e)
        {
            if (dgvHDNG.SelectedRows.Count > 0)
            {
                Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
                using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(hoatdong.HocSinhs))
                {
                    danhSachHocSinh.HocSinhDaChon = hoatdong.HocSinhs;
                    if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                    {
                        hoatdong.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                        if (hoatdong.HocSinhs != null) lbSLHocSinh_HDNG.Text = hoatdong.HocSinhs.Count.ToString();
                        else lbSLHocSinh_HDNG.Text = "0";
                    }
                }
            }
            else rtxbLoi_HDNG.Text = "Chọn hoạt động muốn sửa danh sách học sinh";
        }

        private void dgvHDNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.HoatDong hoatdong = hoatDongBindingSource.Current as Classes.HoatDong;
                txbDiaDiem_HDNG.Text = hoatdong.DiaDiem;
                txbGiaoVien_HDNG.Text = hoatdong.MaGvPhuTrach;
                txbMaHoatDong_HDNG.Text = hoatdong.MaHD;
                if (hoatdong.HocSinhs != null)
                    lbSLHocSinh_HDNG.Text = hoatdong.HocSinhs.Count.ToString();
                else lbSLHocSinh_HDNG.Text = "0";
            }
            else rtxbLoi_HDNG.Text = "";
        }
    }
}
