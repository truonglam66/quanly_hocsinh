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
    public partial class DanhSachHocSinh : Form
    {
        List<Classes.HocSinh> TatCaHocSinh = new List<Classes.HocSinh>();
        public List<Classes.HocSinh> HocSinhDaChon = new List<Classes.HocSinh>();
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }
        public DanhSachHocSinh(List<Classes.HocSinh> hocsinhdachons)
        {
            if(hocsinhdachons != null)
            {
                HocSinhDaChon = hocsinhdachons;
            }
            
            
            InitializeComponent();
           
        }
       


        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            TatCaHocSinh = new List<Classes.HocSinh>();
            if(HocSinhDaChon == null)
            {
                HocSinhDaChon = new List<Classes.HocSinh>();
            }
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "001", MaLop = "asd", TenHS = "Thằng đầu tiên" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "002", MaLop = "sdf", TenHS = "Thằng thứ hai" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "003", MaLop = "asdf", TenHS = "Thằng thứ ba" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "004", MaLop = "asd", TenHS = "Thằng thứ tư" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "005", MaLop = "as223d", TenHS = "Thằng thứ năm" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "006", MaLop = "as4d", TenHS = "Thằng thứ sáu" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "007", MaLop = "as5d", TenHS = "Thằng thứ bảy" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "008", MaLop = "as66bd", TenHS = "Thằng thứ tám" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "009", MaLop = "asd", TenHS = "Thằng thứ chín" });
            TatCaHocSinh.Add(new Classes.HocSinh() { MaHS = "0010", MaLop = "as121d", TenHS = "Thằng cuối cùng" });
            hocSinhChuaChonBindingSource.DataSource = TatCaHocSinh;
            hocSinhDaChonBindingSource.DataSource = HocSinhDaChon;
            if (HocSinhDaChon != null)
            {
                
                int i = 0;
                while(i < hocSinhChuaChonBindingSource.Count)
                {
                    Classes.HocSinh hs = hocSinhChuaChonBindingSource[i] as Classes.HocSinh;
                    foreach (Classes.HocSinh hsDaChon in HocSinhDaChon)
                    {
                        if (hsDaChon.MaHS == hs.MaHS)
                        {
                            hocSinhChuaChonBindingSource.Remove(hs);
                            i--;
                            break;
                        }
                    }
                    i++;
                }  
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            
            HocSinhDaChon = (List<Classes.HocSinh>)hocSinhDaChonBindingSource.DataSource;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dgvHocSinhChuaChon.SelectedRows.Count > 0)
            {
                Classes.HocSinh hsDangChon = hocSinhChuaChonBindingSource.Current as Classes.HocSinh;
                this.hocSinhDaChonBindingSource.Add(hsDangChon);
                this.hocSinhChuaChonBindingSource.RemoveCurrent();
                dgvHocSinhChuaChon.ClearSelection();
                dgvHocSinhDaChon.ClearSelection();
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvHocSinhDaChon.SelectedRows.Count > 0)
            {
                Classes.HocSinh hsDangChon = hocSinhChuaChonBindingSource.Current as Classes.HocSinh;
                this.hocSinhChuaChonBindingSource.Add(hsDangChon);
                this.hocSinhDaChonBindingSource.RemoveCurrent();
                dgvHocSinhChuaChon.ClearSelection();
                dgvHocSinhDaChon.ClearSelection();
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(DataGridViewRow row in dgvHocSinhChuaChon.Rows)
            {
                if(row.Cells[0].Value.ToString() == txbMaHS.Texts)
                {
                    row.Selected = true;
                    hocSinhChuaChonBindingSource.Position = row.Index;
                    break;
                }
                i++;
            }
            if(i == hocSinhChuaChonBindingSource.Count)
            {
                dgvHocSinhChuaChon.ClearSelection();
                hocSinhChuaChonBindingSource.Position = -1;
            }
        }
    }
}
