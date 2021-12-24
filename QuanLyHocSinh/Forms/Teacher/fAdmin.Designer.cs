
namespace QuanLyHocSinh.Forms
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rbTenhienthi = new System.Windows.Forms.RadioButton();
            this.rbMataikhoan = new System.Windows.Forms.RadioButton();
            this.gbThongtin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txbMatkhau = new System.Windows.Forms.TextBox();
            this.txbTenhienthi = new System.Windows.Forms.TextBox();
            this.txbTenDangnhap = new System.Windows.Forms.TextBox();
            this.txbMaTK = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.gbTimkiem.SuspendLayout();
            this.gbThongtin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Controls.Add(this.dgvTaikhoan);
            this.tpTaiKhoan.Controls.Add(this.gbTimkiem);
            this.tpTaiKhoan.Controls.Add(this.gbThongtin);
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 29);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(867, 393);
            this.tpTaiKhoan.TabIndex = 0;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTaikhoan.Location = new System.Drawing.Point(335, 118);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersWidth = 62;
            this.dgvTaikhoan.RowTemplate.Height = 28;
            this.dgvTaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaikhoan.Size = new System.Drawing.Size(526, 275);
            this.dgvTaikhoan.TabIndex = 2;
            this.dgvTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaikhoan_CellClick);
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.btnTim);
            this.gbTimkiem.Controls.Add(this.txbTim);
            this.gbTimkiem.Controls.Add(this.rbTenhienthi);
            this.gbTimkiem.Controls.Add(this.rbMataikhoan);
            this.gbTimkiem.Location = new System.Drawing.Point(335, 6);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(526, 100);
            this.gbTimkiem.TabIndex = 1;
            this.gbTimkiem.TabStop = false;
            this.gbTimkiem.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(436, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 38);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(224, 45);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(197, 26);
            this.txbTim.TabIndex = 11;
            // 
            // rbTenhienthi
            // 
            this.rbTenhienthi.AutoSize = true;
            this.rbTenhienthi.Location = new System.Drawing.Point(6, 56);
            this.rbTenhienthi.Name = "rbTenhienthi";
            this.rbTenhienthi.Size = new System.Drawing.Size(116, 24);
            this.rbTenhienthi.TabIndex = 1;
            this.rbTenhienthi.TabStop = true;
            this.rbTenhienthi.Text = "Tên hiển thị";
            this.rbTenhienthi.UseVisualStyleBackColor = true;
            // 
            // rbMataikhoan
            // 
            this.rbMataikhoan.AutoSize = true;
            this.rbMataikhoan.Location = new System.Drawing.Point(6, 26);
            this.rbMataikhoan.Name = "rbMataikhoan";
            this.rbMataikhoan.Size = new System.Drawing.Size(125, 24);
            this.rbMataikhoan.TabIndex = 0;
            this.rbMataikhoan.TabStop = true;
            this.rbMataikhoan.Text = "Mã tài khoản";
            this.rbMataikhoan.UseVisualStyleBackColor = true;
            // 
            // gbThongtin
            // 
            this.gbThongtin.Controls.Add(this.btnXoa);
            this.gbThongtin.Controls.Add(this.btnSua);
            this.gbThongtin.Controls.Add(this.txbMatkhau);
            this.gbThongtin.Controls.Add(this.txbTenhienthi);
            this.gbThongtin.Controls.Add(this.txbTenDangnhap);
            this.gbThongtin.Controls.Add(this.txbMaTK);
            this.gbThongtin.Controls.Add(this.btnThem);
            this.gbThongtin.Controls.Add(this.label4);
            this.gbThongtin.Controls.Add(this.label3);
            this.gbThongtin.Controls.Add(this.label2);
            this.gbThongtin.Controls.Add(this.label1);
            this.gbThongtin.Location = new System.Drawing.Point(6, 6);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(307, 381);
            this.gbThongtin.TabIndex = 0;
            this.gbThongtin.TabStop = false;
            this.gbThongtin.Text = "Thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(216, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 314);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.Location = new System.Drawing.Point(134, 190);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.Size = new System.Drawing.Size(157, 26);
            this.txbMatkhau.TabIndex = 8;
            // 
            // txbTenhienthi
            // 
            this.txbTenhienthi.Location = new System.Drawing.Point(134, 140);
            this.txbTenhienthi.Name = "txbTenhienthi";
            this.txbTenhienthi.Size = new System.Drawing.Size(157, 26);
            this.txbTenhienthi.TabIndex = 7;
            // 
            // txbTenDangnhap
            // 
            this.txbTenDangnhap.Location = new System.Drawing.Point(134, 94);
            this.txbTenDangnhap.Name = "txbTenDangnhap";
            this.txbTenDangnhap.Size = new System.Drawing.Size(157, 26);
            this.txbTenDangnhap.TabIndex = 6;
            // 
            // txbMaTK
            // 
            this.txbMaTK.Location = new System.Drawing.Point(134, 45);
            this.txbMaTK.Name = "txbMaTK";
            this.txbMaTK.Size = new System.Drawing.Size(157, 26);
            this.txbMaTK.TabIndex = 5;
            this.txbMaTK.TextChanged += new System.EventHandler(this.txbMaTK_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hiển thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTaiKhoan);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 393);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Matk";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDangnhap";
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenHienthi";
            this.Column3.HeaderText = "Tên hiển thị";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Matkhau";
            this.Column4.HeaderText = "Mật khẩu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tpTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
            this.gbThongtin.ResumeLayout(false);
            this.gbThongtin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rbTenhienthi;
        private System.Windows.Forms.RadioButton rbMataikhoan;
        private System.Windows.Forms.GroupBox gbThongtin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txbMatkhau;
        private System.Windows.Forms.TextBox txbTenhienthi;
        private System.Windows.Forms.TextBox txbTenDangnhap;
        private System.Windows.Forms.TextBox txbMaTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}