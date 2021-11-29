using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Classes;

namespace QuanLyHocSinh.Forms.Admin
{
    public partial class FormAdmin : Form
    {
        List<Classes.BangDiem> BangDiems;
        List<Classes.HocSinh> HocSinhs;
        List<Classes.ThoiKhoaBieu> TKBs;
        List<Classes.Lop> Lops;
        List<Classes.GiaoVien> GVs;
        List<Classes.HoatDong> HDs;
        List<Classes.CuocThi> CTs;
        Label[,] lbTKBs;
        public FormAdmin()
        {
            InitializeComponent();
        }

        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            GVs = new List<Classes.GiaoVien>();
            GVs.Add(new Classes.GiaoVien() { MaGv = "001", TenGv = "Giáo viên thứ nhất" });
            GVs.Add(new Classes.GiaoVien() { MaGv = "002", TenGv = "Giáo viên thứ hai" });
            GVs.Add(new Classes.GiaoVien() { MaGv = "003", TenGv = "Giáo viên thứ ba" });
            foreach (Classes.GiaoVien gv in GVs) giaoVienBindingSource.Add(gv);

            HDs = new List<Classes.HoatDong>();
            allHoatDongBS.DataSource = HDs;

            CTs = new List<Classes.CuocThi>();
            allCuocThiBS.DataSource = CTs;

            Lops = new List<Classes.Lop>();
            allLopBS.DataSource = Lops;
            foreach(Classes.Lop lop in Lops) lopBindingSource.Add(lop);
            Lops.Add(new Classes.Lop() { MaLop = "001", MaGVCN = "001", NamHoc = 2021 });
            Lops.Add(new Classes.Lop() { MaLop = "002", MaGVCN = "002", NamHoc = 2021 });
            for (int i = 0; i < Lops.Count; i++) allLopBS.ResetItem(i);

            CTs = new List<Classes.CuocThi>();


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
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "001", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] {  { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" },
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });
            TKBs.Add(new Classes.ThoiKhoaBieu() { MaLop = "002", MaTKB = "001", NamHoc = 2021, HocKy = 1, MonHoc = new string[,] {  { "Tiếng Việt", "Tiếng Việt", "Tiếng Việt", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" }, 
                                                                                                                                    { "Toán", "Toán", "Toán", "Toán", "Toán", "Toán", "Toán" } } });

            lbTKBs = new Label[,] { { lbMonHoc2_1, lbMonhoc2_2, lbMonhoc2_3, lbMonhoc2_4, lbMonhoc2_5, lbMonhoc2_6, lbMonhoc2_7 } , { lbMonhoc3_1, lbMonhoc3_2, lbMonhoc3_3, lbMonhoc3_4, lbMonhoc3_5, lbMonhoc3_6, lbMonhoc3_7 },{ lbMonhoc4_1, lbMonhoc4_2, lbMonhoc4_3, lbMonhoc4_4, lbMonhoc4_5, lbMonhoc4_6, lbMonhoc4_7 },{ lbMonhoc5_1, lbMonhoc5_2, lbMonhoc5_3, lbMonhoc5_4, lbMonhoc5_5, lbMonhoc5_6, lbMonhoc5_7 },{ lbMonhoc6_1, lbMonhoc6_2, lbMonhoc6_3, lbMonhoc6_4, lbMonhoc6_5, lbMonhoc6_6, lbMonhoc6_7 },{ lbMonhoc7_1, lbMonhoc7_2, lbMonhoc7_3, lbMonhoc7_4, lbMonhoc7_5, lbMonhoc7_6, lbMonhoc7_7 } };


            WindowState = FormWindowState.Maximized;

        }
        #region UI
        private void setColor()
        {
            menuStrip1.BackColor = darkMode.xanh;
            this.BackColor = darkMode.denlot;
            tabPage1.BackColor = darkMode.denlot;
            tabPage2.BackColor = darkMode.denlot;
            tabPage3.BackColor = darkMode.denlot;
            tabPage4.BackColor = darkMode.denlot;
            tabPage5.BackColor = darkMode.denlot;
            label1.BackColor = darkMode.denlot;
            btnTim_BDCK.BackColor = darkMode.xanh;
            btnTatCa_BDCK.BackColor = darkMode.xanh;
            btnTim_CT.BackColor = darkMode.xanh;
            btnThem_DSL.BackColor = darkMode.xanh;
            btnSua_DSL.BackColor = darkMode.xanh;
            btnXoa_DSL.BackColor = darkMode.xanh;
            btnHuy_DSL.BackColor = darkMode.xanh;
            btnThem_CT.BackColor = darkMode.xanh;
            btnTim_DSL.BackColor = darkMode.xanh;
            btnXoa_CT.BackColor = darkMode.xanh;
            btnSua_CT.BackColor = darkMode.xanh;
            btnSua_HDNG.BackColor = darkMode.xanh;
            btnXoa_HDNG.BackColor = darkMode.xanh;
            btnThem_HDNG.BackColor = darkMode.xanh;
            btnTim_HDNG.BackColor = darkMode.xanh;
            btnTim_CT.BackColor = darkMode.xanh;
            btnTim_TKB.BackColor = darkMode.xanh;
            btnTatCa_DLS.BackColor = darkMode.xanh;
            btnTatCa_HDNG.BackColor = darkMode.xanh;
            btnTatCa_CT.BackColor = darkMode.xanh;

            label1.ForeColor = darkMode.trang;
            tabPage1.ForeColor = darkMode.trang;
            tabPage2.ForeColor = darkMode.trang;
            tabPage3.ForeColor = darkMode.trang;
            tabPage4.ForeColor = darkMode.trang;
            tabPage5.ForeColor = darkMode.trang;

            chếĐộBanĐêmToolStripMenuItem.BackColor = darkMode.xanh;
            thoátToolStripMenuItem.BackColor = darkMode.xanh;

        }

        private void chếĐộBanĐêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkMode.TroCarMode();
            setColor();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Bảng điểm cuối kỳ
        private void btnTim_BDCK_Click(object sender, EventArgs e)
        {
            while (bangDiemBindingSource.Count > 0) bangDiemBindingSource.RemoveAt(0);

            foreach (Classes.HocSinh hs in HocSinhs)
            {
                if (hs.MaLop == cbbMaLop_BDCK.Text)
                {
                    foreach (Classes.BangDiem bangDiem in BangDiems)
                    {
                        if (bangDiem.MaHocSinh == hs.MaHS && bangDiem.HocKy == Convert.ToInt32(cbbHocKy_BDCK.Text) && bangDiem.NamHoc == Convert.ToInt32(txbNamHoc_BDCK.Text))
                        {
                            bangDiemBindingSource.Add(bangDiem);
                        }
                    }

                }
            }
        }
        #endregion

        #region Danh Sách Lớp
        private void btnThem_DSL_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach(Classes.Lop lop in Lops)
                {
                    if (txbMaLop_DSL.Text == lop.MaLop) break;
                    i++;
                }
                if(i == Lops.Count)
                using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh())
                {
                    if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                    {
                        Lops.Add(new Classes.Lop() { HocSinhs = danhSachHocSinh.HocSinhDaChon, MaGVCN = cbbGiaoVien_DSL.Text, MaLop = txbMaLop_DSL.Text, NamHoc = int.Parse(txbNamHoc_DSL.Text) });
                        lopBindingSource.Add(Lops[Lops.Count - 1]);
                        allLopBS.ResetCurrentItem();
                    }
                } else
                {
                    MessageBox.Show("Mã lớp không được trùng");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTimTatCa_DSL_Click(object sender, EventArgs e)
        {
            while (lopBindingSource.Count > 0) lopBindingSource.RemoveAt(0);
            foreach (Classes.Lop lop in Lops) lopBindingSource.Add((Classes.Lop)lop);
            int x = allLopBS.Count;
        }

        private void btnTim_DSL_Click(object sender, EventArgs e)
        {
            while (lopBindingSource.Count > 0) lopBindingSource.RemoveAt(0);
            foreach(Classes.Lop lop in Lops)
            {
                if(lop.NamHoc.ToString() == txbTimNamHoc_DSL.Text) lopBindingSource.Add((Classes.Lop)lop);   
            }


        }
        private void dgvDSL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.Lop lop = lopBindingSource.Current as Classes.Lop;
                txbMaLop_DSL.Text = lop.MaLop;
                txbNamHoc_DSL.Text = lop.NamHoc.ToString();
                cbbGiaoVien_DSL.Text = lop.MaGVCN;
                if (e.ColumnIndex == dgvDSL.Columns["ColumnButtonDSL"].Index)
                {
                    using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(lop.HocSinhs))
                    {
                        if(danhSachHocSinh.ShowDialog() == DialogResult.OK)
                        {
                            foreach (Classes.Lop lop1 in Lops)
                            {
                                if (lop1.MaLop == lop.MaLop)
                                {
                                    lop.HocSinhs = lop1.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                                }
                            }
                        }
                        
                    }
                }
            }
            
            
        }
        private void btnSua_DSL_Click(object sender, EventArgs e)
        {
            Classes.Lop lop = lopBindingSource.Current as Classes.Lop;
            if(lop != null)
            {
                int i = 0;
                foreach (Classes.Lop lop2 in Lops)
                {
                    if(txbMaLop_DSL.Text != lop.MaLop)
                    if (lop2.MaLop == txbMaLop_DSL.Text) break;
                    i++;
                }
                if (i == Lops.Count)
                {
                    foreach(Classes.Lop lop1 in Lops)
                    {
                        if(lop1.MaLop == lop.MaLop)
                        {
                            try
                            {
                                lop1.MaLop = txbMaLop_DSL.Text;
                                lop1.NamHoc = int.Parse(txbNamHoc_DSL.Text);
                                lop1.MaGVCN = cbbGiaoVien_DSL.Text;
                                lopBindingSource[dgvDSL.SelectedRows[0].Index] = new Classes.Lop() { MaLop = txbMaLop_DSL.Text, MaGVCN = cbbGiaoVien_DSL.Text, NamHoc = int.Parse(txbNamHoc_DSL.Text), HocSinhs = lop.HocSinhs };
                            } catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                else MessageBox.Show("Mã lớp không được trùng");
            }
        }
        private void btnXoa_DSL_Click(object sender, EventArgs e)
        {
            if(dgvDSL.SelectedRows.Count > 0)
            { 
                foreach(Classes.Lop lop in Lops)
                {
                    if(lop.MaLop == dgvDSL.SelectedRows[0].Cells[0].Value.ToString()){
                        Lops.Remove(lop);
                        lopBindingSource.RemoveAt(dgvDSL.SelectedRows[0].Index);
                        btnHuy_DSL_Click(sender, e);
                        return;
                    }
                }
            }
        }
        private void btnHuy_DSL_Click(object sender, EventArgs e)
        {
            lopBindingSource.Position = -1;
            dgvDSL.ClearSelection();
            txbMaLop_DSL.Text = "";
            cbbGiaoVien_DSL.Text = "";
            txbNamHoc_DSL.Text = "";
        }

        #endregion

        #region Hoạt động ngoài giờ
        private void btnThem_HDNG_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach(Classes.HoatDong hd in HDs)
                {
                    if (txbMaHD_HDNG.Text == hd.MaHD) break;
                    i++;
                }
                if(i == HDs.Count)
                using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh())
                {
                    if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                    {
                        HDs.Add(new Classes.HoatDong() {HocSinhs = danhSachHocSinh.HocSinhDaChon, MaHD = txbMaHD_HDNG.Text, TenHD = txbTenHD_HDNG.Text, DiaDiem = txbDiaDiem_HDNG.Text, ThoiGian = dtp_HDNG.Value, MaGvPhuTrach = cbbMaGv_HDNG.Text });
                        hoatDongBindingSource.Add(HDs[HDs.Count - 1]);
                        allHoatDongBS.ResetCurrentItem();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rbtnMaHD_HDNG_CheckedChanged(object sender, EventArgs e)
        {
            cbbMaHD_HDNG.Enabled = !cbbMaHD_HDNG.Enabled;
            cbbTimMaGV_HDNG.Enabled = !cbbTimMaGV_HDNG.Enabled;
        }
        private void btnTim_HDNG_Click(object sender, EventArgs e)
        {
            while (hoatDongBindingSource.Count > 0) hoatDongBindingSource.RemoveAt(0);
            if (cbbMaHD_HDNG.Enabled)
            {
                foreach (Classes.HoatDong hd in HDs)
                {
                    if (hd.MaHD == cbbMaHD_HDNG.Text) hoatDongBindingSource.Add(hd);
                }
            } else
            {
                foreach (Classes.HoatDong hd in HDs)
                {
                    if (hd.MaGvPhuTrach == cbbTimMaGV_HDNG.Text) hoatDongBindingSource.Add(hd);
                }
            }
        }

        private void btnTatCa_HDNG_Click(object sender, EventArgs e)
        {
            while (hoatDongBindingSource.Count > 0) hoatDongBindingSource.RemoveAt(0);
            foreach (Classes.HoatDong hd in HDs) hoatDongBindingSource.Add(hd);
        }
        private void btnXoa_HDNG_Click(object sender, EventArgs e)
        {
            if (dgvHDNG.SelectedRows.Count > 0)
            {
                foreach (Classes.HoatDong hd in HDs)
                {
                    if (hd.MaHD == dgvHDNG.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        HDs.Remove(hd);
                        for (int i = 0; i < HDs.Count; i++) allHoatDongBS.ResetItem(i);
                        hoatDongBindingSource.RemoveAt(dgvHDNG.SelectedRows[0].Index);
                        dgvHDNG.ClearSelection();
                        hoatDongBindingSource.Position = -1;
                        return;
                    }
                }
            }
        }
        private void btnSua_HDNG_Click(object sender, EventArgs e)
        {
            Classes.HoatDong hd = hoatDongBindingSource.Current as Classes.HoatDong;
            if (hd != null)
            {
                int i = 0;
                foreach (Classes.HoatDong hd2 in HDs)
                {
                    if (txbMaHD_HDNG.Text != hd.MaHD)
                        if (hd2.MaHD == txbMaHD_HDNG.Text) break;
                    i++;
                }
                if (i == HDs.Count)
                {
                    foreach (Classes.HoatDong hd1 in HDs)
                    {
                        if (hd1.MaHD == hd.MaHD)
                        {
                            try
                            {
                                hd1.MaHD = txbMaHD_HDNG.Text;
                                hd1.DiaDiem = txbDiaDiem_HDNG.Text;
                                hd1.MaGvPhuTrach = cbbMaGv_HDNG.Text;
                                hd1.TenHD = txbTenHD_HDNG.Text;
                                hd1.ThoiGian = dtp_HDNG.Value;
                                for(int j = 0; j< HDs.Count; j++) allHoatDongBS.ResetItem(j);
                                hoatDongBindingSource[dgvHDNG.SelectedRows[0].Index] = new Classes.HoatDong() { MaHD = txbMaHD_HDNG.Text, TenHD = txbTenHD_HDNG.Text, DiaDiem = txbDiaDiem_HDNG.Text, ThoiGian = dtp_HDNG.Value, MaGvPhuTrach = cbbMaGv_HDNG.Text, HocSinhs = hd.HocSinhs };
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                else MessageBox.Show("Mã hoạt động không được trùng");
            }
        }
        private void dgvHDNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.HoatDong hd = hoatDongBindingSource.Current as Classes.HoatDong;
                txbMaHD_HDNG.Text = hd.MaHD;
                txbTenHD_HDNG.Text = hd.TenHD;
                cbbMaGv_HDNG.Text = hd.MaGvPhuTrach;
                txbDiaDiem_HDNG.Text = hd.DiaDiem;
                dtp_HDNG.Value = hd.ThoiGian;
                if (e.ColumnIndex == dgvHDNG.Columns["ColumnButtonHDNG"].Index)
                {
                    using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(hd.HocSinhs))
                    {
                        if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                        {
                            foreach (Classes.HoatDong hd1 in HDs)
                            {
                                if (hd1.MaHD == hd.MaHD)
                                {
                                    hd.HocSinhs = hd1.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                                    return;
                                }
                            }
                        }

                    }
                }
            }
        }
        #endregion
        #region Danh sách cuộc thi
        private void btnTim_CT_Click(object sender, EventArgs e)
        {
            while (cuocThiBindingSource.Count > 0) cuocThiBindingSource.RemoveAt(0);
            foreach(Classes.CuocThi ct in CTs)
            {
                try
                {
                    if (ct.NamHoc == int.Parse(txbTimNamHoc_CT.Text)) cuocThiBindingSource.Add(ct);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private void btnTatCa_CT_Click(object sender, EventArgs e)
        {
            while (cuocThiBindingSource.Count > 0) cuocThiBindingSource.RemoveAt(0);
            foreach (Classes.CuocThi ct in CTs) cuocThiBindingSource.Add(ct);
        }
        private void btnThem_CT_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach(Classes.CuocThi ct in CTs)
                {
                    if (txbMaCuocThi_CT.Text == ct.MaCuocThi) break;
                    i++;
                }
                if(i == CTs.Count)
                {
                    using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh())
                    {
                        if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                        {
                            CTs.Add(new CuocThi() { MaCuocThi = txbMaCuocThi_CT.Text, MaGvPhuTrach = cbbMaGV_CT.Text, QuyMo = cbbQuyMo_CT.Text, DiaDiem = txbDiaDiem_CT.Text, MonThi = txbMonThi_CT.Text, NamHoc = int.Parse(txbNamHoc_CT.Text), ThoiGian = dtp_CT.Value, HocSinhs = danhSachHocSinh.HocSinhDaChon });
                            cuocThiBindingSource.Add(CTs[CTs.Count - 1]);
                        }
                    }
                } else
                {
                    MessageBox.Show("Mã cuộc thi không được trùng");
                }        
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnSua_CT_Click(object sender, EventArgs e)
        {
            Classes.CuocThi ct = cuocThiBindingSource.Current as Classes.CuocThi;
            if (ct != null)
            {
                int i = 0;
                foreach (Classes.CuocThi ct2 in CTs)
                {
                    if (txbMaCuocThi_CT.Text != ct.MaCuocThi)
                        if (ct2.MaCuocThi == txbMaCuocThi_CT.Text) break;
                    i++;
                }
                if (i == CTs.Count)
                {
                    foreach (Classes.CuocThi ct1 in CTs)
                    {
                        if (ct1.MaCuocThi == ct.MaCuocThi)
                        {
                            try
                            {
                                ct1.MaCuocThi = txbMaCuocThi_CT.Text;
                                ct1.MaGvPhuTrach = cbbMaGV_CT.Text;
                                ct1.QuyMo = cbbQuyMo_CT.Text;
                                ct1.DiaDiem = txbDiaDiem_CT.Text;
                                ct1.ThoiGian = dtp_CT.Value;
                                ct1.MonThi = txbMonThi_CT.Text;
                                ct1.NamHoc = int.Parse(txbNamHoc_CT.Text);
                                cuocThiBindingSource[dgvCT.SelectedRows[0].Index] = ct1;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                else MessageBox.Show("Mã lớp không được trùng");
            }
        }

        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Classes.CuocThi ct = cuocThiBindingSource.Current as Classes.CuocThi;
                txbMaCuocThi_CT.Text = ct.MaCuocThi;
                cbbMaGV_CT.Text = ct.MaGvPhuTrach;
                cbbQuyMo_CT.Text = ct.QuyMo;
                txbDiaDiem_CT.Text = ct.DiaDiem;
                dtp_CT.Value = ct.ThoiGian;
                cbbQuyMo_CT.Text = ct.QuyMo;
                txbMonThi_CT.Text = ct.MonThi;
                txbNamHoc_CT.Text = ct.NamHoc.ToString();
                if (e.ColumnIndex == dgvCT.Columns["ColumnButtonCT"].Index)
                {
                    using (DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh(ct.HocSinhs))
                    {
                        if (danhSachHocSinh.ShowDialog() == DialogResult.OK)
                        {
                            foreach (Classes.CuocThi ct1 in CTs)
                            {
                                if (ct1.MaCuocThi == ct.MaCuocThi)
                                {
                                    ct.HocSinhs = ct1.HocSinhs = danhSachHocSinh.HocSinhDaChon;
                                    return;
                                }
                            }
                        }

                    }
                }
            }   
        }
        private void btnXoa_CT_Click(object sender, EventArgs e)
        {
            if (dgvCT.SelectedRows.Count > 0)
            {
                foreach (Classes.CuocThi ct in CTs)
                {
                    if (ct.MaCuocThi == dgvCT.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        CTs.Remove(ct);
                        for (int i = 0; i < CTs.Count; i++) allCuocThiBS.ResetItem(i);
                        cuocThiBindingSource.RemoveAt(dgvCT.SelectedRows[0].Index);
                        dgvCT.ClearSelection();
                        cuocThiBindingSource.Position = -1;
                        return;
                    }
                }
            }
        }

        #endregion

        #region Thời khóa biểu
        private void btnTim_TKB_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Classes.ThoiKhoaBieu tkb in TKBs)
                {
                    if (tkb.MaLop == cbbMaLop_TKB.Text && tkb.NamHoc == Convert.ToInt32(txbNamHoc_TKB.Text) && tkb.HocKy == Convert.ToInt32(cbbHocKy_TKB.Text))
                    {
                        string[,] hmm = tkb.MonHoc;
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                lbTKBs[i, j].Text = hmm[i, j];
                            }
                        }
                        break;
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        #endregion
    }
}
