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
        List<Classes.ThoiKhoaBieu> TKBs;
        Label[,] lbTKBs;
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

            TKBs = new List<Classes.ThoiKhoaBieu>();
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "001", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] { { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "002", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] { { "Tiếng Việt", "Tiếng Việt", "Tiếng Việt", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });

            lbTKBs = new Label[,] { { lbMonHoc2_1, lbMonhoc2_2, lbMonhoc2_3, lbMonhoc2_4, lbMonhoc2_5, lbMonhoc2_6, lbMonhoc2_7 } , { lbMonhoc3_1, lbMonhoc3_2, lbMonhoc3_3, lbMonhoc3_4, lbMonhoc3_5, lbMonhoc3_6, lbMonhoc3_7 },{ lbMonhoc4_1, lbMonhoc4_2, lbMonhoc4_3, lbMonhoc4_4, lbMonhoc4_5, lbMonhoc4_6, lbMonhoc4_7 },{ lbMonhoc5_1, lbMonhoc5_2, lbMonhoc5_3, lbMonhoc5_4, lbMonhoc5_5, lbMonhoc5_6, lbMonhoc5_7 },{ lbMonhoc6_1, lbMonhoc6_2, lbMonhoc6_3, lbMonhoc6_4, lbMonhoc6_5, lbMonhoc6_6, lbMonhoc6_7 },{ lbMonhoc7_1, lbMonhoc7_2, lbMonhoc7_3, lbMonhoc7_4, lbMonhoc7_5, lbMonhoc7_6, lbMonhoc7_7 } };

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
                dtp_HDNG.Value = hoatdong.ThoiGian;
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

        //
        //Menu strip
        //

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Danh sách cuộc thi
        //

        private void btnThem_DSCT_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txbDiaDiem_DSCT.Text) || string.IsNullOrWhiteSpace(txbGiaoVien_DSCT.Text) || string.IsNullOrWhiteSpace(txbMaCuocThi_DSCT.Text) || string.IsNullOrWhiteSpace(txbMonThi_DSCT.Text) || cbbQuyMo_DSCT.SelectedIndex == -1 ))
            {
                int i = 0;
                foreach (DataGridViewRow row in dgvDsCuocThi_DSCT.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txbMaCuocThi_DSCT.Text) break;
                    i++;
                }
                if (i == cuocThiBindingSource.Count)
                {
                   
                        cuocThiBindingSource.Add(new Classes.CuocThi() { MaCuocThi = txbMaCuocThi_DSCT.Text, MaGvPhuTrach = txbGiaoVien_DSCT.Text, DiaDiem = txbDiaDiem_DSCT.Text, NamHoc = dtp_DSCT.Value.Year, MonThi = txbMonThi_DSCT.Text, ThoiGian = dtp_DSCT.Value, QuyMo = cbbQuyMo_DSCT.SelectedItem.ToString() });
                    
                    
                    lbSLHocSinh_DSCT.Text = "0";
                    cuocThiBindingSource.Position = cuocThiBindingSource.Count - 1;
                    rtxbLoi_DSCT.Text = "";
                }
                else rtxbLoi_DSCT.Text = "Mã hoạt động không được trùng";
            }
            else rtxbLoi_DSCT.Text = "Không được để trống";
        }

        private void btnSua_DSCT_Click(object sender, EventArgs e)
        {
            Classes.CuocThi cuocthi = cuocThiBindingSource.Current as Classes.CuocThi;
            if (cuocThiBindingSource != null)
            {
                if (!(string.IsNullOrWhiteSpace(txbDiaDiem_DSCT.Text) || string.IsNullOrWhiteSpace(txbGiaoVien_DSCT.Text) || string.IsNullOrWhiteSpace(txbMaCuocThi_DSCT.Text) || string.IsNullOrWhiteSpace(txbMonThi_DSCT.Text) || cbbQuyMo_DSCT.SelectedIndex == -1))
                {
                    int i = 0;
                    foreach (DataGridViewRow row in dgvDsCuocThi_DSCT.Rows)
                    {
                        if (txbMaCuocThi_DSCT.Text != cuocthi.MaCuocThi)
                            if (row.Cells[0].Value.ToString() == txbMaCuocThi_DSCT.Text) break;
                        i++;
                    }

                    
                    if (i == cuocThiBindingSource.Count)
                    {
                        cuocThiBindingSource[dgvDsCuocThi_DSCT.SelectedRows[0].Index] = new Classes.CuocThi() { MaCuocThi = txbMaCuocThi_DSCT.Text, MaGvPhuTrach = txbGiaoVien_DSCT.Text, DiaDiem = txbDiaDiem_DSCT.Text, NamHoc = dtp_DSCT.Value.Year, MonThi = txbMonThi_DSCT.Text, ThoiGian = dtp_DSCT.Value, QuyMo = cbbQuyMo_DSCT.SelectedItem.ToString(), HocSinhs = cuocthi.HocSinhs };
                        rtxbLoi_DSCT.Text = "";
                    }
                    else rtxbLoi_DSCT.Text = "Mã hoạt động không được trùng";
                }
                else rtxbLoi_DSCT.Text = "Không được để trống";


            }
            else rtxbLoi_DSCT.Text = "Chọn hoạt động muốn sửa";
        }

        private void btnXoa_DSCT_Click(object sender, EventArgs e)
        {
            if(dgvDsCuocThi_DSCT.SelectedRows.Count > 0)
            {
                cuocThiBindingSource.RemoveAt(dgvDsCuocThi_DSCT.SelectedRows[0].Index);
                dgvDsCuocThi_DSCT.ClearSelection();
                cuocThiBindingSource.Position = -1;
                lbSLHocSinh_DSCT.Text = "";

            }
            else rtxbLoi_DSCT.Text = "Chọn hoạt động muốn xóa";
        }

        private void btnHuy_DSCT_Click(object sender, EventArgs e)
        {
            txbDiaDiem_DSCT.Text = txbGiaoVien_DSCT.Text = txbMaCuocThi_DSCT.Text = "";
            dgvDsCuocThi_DSCT.ClearSelection();
            lbSLHocSinh_DSCT.Text = "";
            rtxbLoi_DSCT.Text = "";
            cuocThiBindingSource.Position = -1;
        }

        private void btnDsHocSinh_DSCT_Click(object sender, EventArgs e)
        {
            if (dgvDsCuocThi_DSCT.SelectedRows.Count > 0)
            {
                Classes.CuocThi cuocthi = cuocThiBindingSource.Current as Classes.CuocThi;
                using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(cuocthi.HocSinhs))
                {
                    danhSachHocSinh.HocSinhDaChon = cuocthi.HocSinhs;
                    if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                    {
                        cuocthi.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                        if (cuocthi.HocSinhs != null) lbSLHocSinh_DSCT.Text = cuocthi.HocSinhs.Count.ToString();
                        else lbSLHocSinh_DSCT.Text = "0";
                    }
                }
            }
            else rtxbLoi_DSCT.Text = "Chọn hoạt động muốn sửa danh sách học sinh";
        }

        private void dgvDsCuocThi_DSCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.CuocThi cuocthi = cuocThiBindingSource.Current as Classes.CuocThi;
                txbDiaDiem_DSCT.Text = cuocthi.DiaDiem;
                txbGiaoVien_DSCT.Text = cuocthi.MaGvPhuTrach;
                txbMaCuocThi_DSCT.Text = cuocthi.MaCuocThi;
                cbbQuyMo_DSCT.Text = cuocthi.QuyMo;
                txbMonThi_DSCT.Text = cuocthi.MonThi;
                dtp_DSCT.Value = cuocthi.ThoiGian;

                if (cuocthi.HocSinhs != null)
                    lbSLHocSinh_DSCT.Text = cuocthi.HocSinhs.Count.ToString();
                else lbSLHocSinh_DSCT.Text = "0";
            }
            else rtxbLoi_DSCT.Text = "";
        }
        //
        //TKB
        //
        private void btnTim_TKB_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(txbMaLop_TKB.Text) || string.IsNullOrWhiteSpace(txbNamHoc_TKB.Text) || string.IsNullOrWhiteSpace(txbHocKy_TKB.Text)))
            {
                foreach(Classes.ThoiKhoaBieu tkb in TKBs)
                {
                    if (tkb.MaLop == txbMaLop_TKB.Text && tkb.NamHoc == Convert.ToInt32(txbNamHoc_TKB.Text) && tkb.HocKy == Convert.ToInt32(txbHocKy_TKB.Text))
                    {
                        string[,] hmm = tkb.MonHoc;
                        for(int i = 0; i < 6; i++)
                        {
                            for(int j = 0; j < 7; j++)
                            {
                                lbTKBs[i,j].Text = hmm[i,j];
                            }
                        }
                        break;
                    }

                }
            }
            
        }

        
        //
        //Thời khóa biểu
        //

    }
}
