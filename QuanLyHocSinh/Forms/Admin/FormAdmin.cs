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
        List<Classes.BangDiem> BangDiems;
        List<Classes.HocSinh> HocSinhs;
        public FormAdmin()
        {
            InitializeComponent();
        }

        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            BangDiems = new List<Classes.BangDiem>();
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "001", MaBangDiem = "001", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "002", MaBangDiem = "002", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "003", MaBangDiem = "003", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "004", MaBangDiem = "004", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "005", MaBangDiem = "005", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "006", MaBangDiem = "006", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "007", MaBangDiem = "007", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "008", MaBangDiem = "008", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "009", MaBangDiem = "009", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });
            BangDiems.Add(new Classes.BangDiem() { MaHocSinh = "010", MaBangDiem = "010", NamHoc = 2021, HocKy = 1, Toan = 10, TiengViet = 10, DaoDuc = 10, TuNhienXaHoi = 10, KhoaHoc = 10, LichSuDiaLy = 10, NgheThuat = 10, AmNhac = 10, KyThuat = 10, MyThuat = 10, TheDuc = 10 });

            HocSinhs = new List<Classes.HocSinh>();
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "001", MaLop = "001", TenHS = "Thằng thứ nhất" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "002", MaLop = "001", TenHS = "Thằng thứ hai" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "003", MaLop = "001", TenHS = "Thằng thứ ba"});
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "004", MaLop = "001", TenHS = "Thằng thứ tư" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "005", MaLop = "002", TenHS = "Thằng thứ năm" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "006", MaLop = "002", TenHS = "Thằng thứ sáu" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "007", MaLop = "002", TenHS = "Thằng thứ bảy" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "008", MaLop = "003", TenHS = "Thằng thứ tám" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "009", MaLop = "003", TenHS = "Thằng thứ chín" });
            HocSinhs.Add(new Classes.HocSinh() { MaHS = "010", MaLop = "003", TenHS = "Thằng thứ mười" });


        }
        //
        //Hoạt động ngoài giờ
        //
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

        //
        //Bảng điểm cuối kỳ
        //
        private void btnTim_BDCK_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txbMaLop_BDCK.Text) || string.IsNullOrWhiteSpace(txbNamHoc_BDCK.Text) || string.IsNullOrWhiteSpace(txbHocKy_BDCK.Text)))
            {
                while (bangDiemBindingSource.Count > 0) bangDiemBindingSource.RemoveAt(0);

                foreach (Classes.HocSinh hs in HocSinhs)
                {
                    if (hs.MaLop == txbMaLop_BDCK.Text)
                    {
                        foreach (Classes.BangDiem bangDiem in BangDiems)
                        {
                            if (bangDiem.MaHocSinh == hs.MaHS && bangDiem.HocKy == Convert.ToInt32(txbHocKy_BDCK.Text) && bangDiem.NamHoc == Convert.ToInt32(txbNamHoc_BDCK.Text))
                            {
                                bangDiemBindingSource.Add(bangDiem);
                            }
                        }

                    }
                }
                rtxbLoi_DSBD.Text = "";
            }
            else rtxbLoi_DSBD.Text = "Không được để trống";
        }

        private void btnTatCa_BDCK_Click(object sender, EventArgs e)
        {
            while (bangDiemBindingSource.Count > 0) bangDiemBindingSource.RemoveAt(0);
            foreach (Classes.HocSinh hs in HocSinhs)
            {
                foreach (Classes.BangDiem bangDiem in BangDiems)
                {
                    if (bangDiem.MaHocSinh == hs.MaHS)
                    {
                        bangDiemBindingSource.Add(bangDiem);
                    }
                }
            }
        }
    }
}
