namespace QuanLyHocSinh.Forms
{
    partial class HoatDongNgoaiGio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoatDongNgoaiGio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxbError = new System.Windows.Forms.RichTextBox();
            this.lbSLHocSinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHDNG = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGvPhuTrachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTimMaHoatDong = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnHuy = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnXoa = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnSua = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnThem = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnDsHocSinh = new QuanLyHocSinh.CustomControl.CustomButton();
            this.txbDiaDiem = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.txbGiaoVien = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.txbMaHoatDong = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.DatePicker = new QuanLyHocSinh.CustomControl.CustomDateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnTimMaHoatDong);
            this.panel1.Controls.Add(this.rtxbError);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnDsHocSinh);
            this.panel1.Controls.Add(this.lbSLHocSinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbDiaDiem);
            this.panel1.Controls.Add(this.txbGiaoVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMaHoatDong);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(643, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 561);
            this.panel1.TabIndex = 1;
            // 
            // rtxbError
            // 
            this.rtxbError.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rtxbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxbError.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.rtxbError.ForeColor = System.Drawing.Color.MintCream;
            this.rtxbError.Location = new System.Drawing.Point(0, 433);
            this.rtxbError.Name = "rtxbError";
            this.rtxbError.Size = new System.Drawing.Size(321, 128);
            this.rtxbError.TabIndex = 6;
            this.rtxbError.Text = "";
            // 
            // lbSLHocSinh
            // 
            this.lbSLHocSinh.AutoSize = true;
            this.lbSLHocSinh.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lbSLHocSinh.ForeColor = System.Drawing.Color.MintCream;
            this.lbSLHocSinh.Location = new System.Drawing.Point(215, 211);
            this.lbSLHocSinh.Name = "lbSLHocSinh";
            this.lbSLHocSinh.Size = new System.Drawing.Size(37, 18);
            this.lbSLHocSinh.TabIndex = 4;
            this.lbSLHocSinh.Text = "slHS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng học sinh đã chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Gv Phụ Trách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hoạt động";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.dgvHDNG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 561);
            this.panel2.TabIndex = 2;
            // 
            // dgvHDNG
            // 
            this.dgvHDNG.AllowUserToAddRows = false;
            this.dgvHDNG.AllowUserToDeleteRows = false;
            this.dgvHDNG.AllowUserToResizeColumns = false;
            this.dgvHDNG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvHDNG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDNG.AutoGenerateColumns = false;
            this.dgvHDNG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDNG.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHDNG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHDNG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDNG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDNG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maGvPhuTrachDataGridViewTextBoxColumn,
            this.diaDiemDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn});
            this.dgvHDNG.DataSource = this.hoatDongBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDNG.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHDNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDNG.EnableHeadersVisualStyles = false;
            this.dgvHDNG.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHDNG.Location = new System.Drawing.Point(0, 0);
            this.dgvHDNG.Name = "dgvHDNG";
            this.dgvHDNG.ReadOnly = true;
            this.dgvHDNG.RowHeadersVisible = false;
            this.dgvHDNG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHDNG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNG.Size = new System.Drawing.Size(643, 561);
            this.dgvHDNG.TabIndex = 0;
            this.dgvHDNG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNG_CellClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hoạt động";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGvPhuTrachDataGridViewTextBoxColumn
            // 
            this.maGvPhuTrachDataGridViewTextBoxColumn.DataPropertyName = "MaGvPhuTrach";
            this.maGvPhuTrachDataGridViewTextBoxColumn.HeaderText = "Mã Gv Phụ Trách";
            this.maGvPhuTrachDataGridViewTextBoxColumn.Name = "maGvPhuTrachDataGridViewTextBoxColumn";
            this.maGvPhuTrachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDiemDataGridViewTextBoxColumn
            // 
            this.diaDiemDataGridViewTextBoxColumn.DataPropertyName = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.HeaderText = "Địa điểm";
            this.diaDiemDataGridViewTextBoxColumn.Name = "diaDiemDataGridViewTextBoxColumn";
            this.diaDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Thời Gian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoatDongBindingSource
            // 
            this.hoatDongBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HoatDong);
            // 
            // btnTimMaHoatDong
            // 
            this.btnTimMaHoatDong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimMaHoatDong.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimMaHoatDong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimMaHoatDong.BorderRadius = 15;
            this.btnTimMaHoatDong.BorderSize = 0;
            this.btnTimMaHoatDong.FlatAppearance.BorderSize = 0;
            this.btnTimMaHoatDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimMaHoatDong.ForeColor = System.Drawing.Color.White;
            this.btnTimMaHoatDong.Location = new System.Drawing.Point(256, 19);
            this.btnTimMaHoatDong.Name = "btnTimMaHoatDong";
            this.btnTimMaHoatDong.Size = new System.Drawing.Size(62, 32);
            this.btnTimMaHoatDong.TabIndex = 7;
            this.btnTimMaHoatDong.TextColor = System.Drawing.Color.White;
            this.btnTimMaHoatDong.UseVisualStyleBackColor = false;
            this.btnTimMaHoatDong.Click += new System.EventHandler(this.btnTimMaHoatDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(170, 377);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(28, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(170, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(28, 313);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDsHocSinh
            // 
            this.btnDsHocSinh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDsHocSinh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDsHocSinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDsHocSinh.BorderRadius = 20;
            this.btnDsHocSinh.BorderSize = 0;
            this.btnDsHocSinh.FlatAppearance.BorderSize = 0;
            this.btnDsHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDsHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnDsHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnDsHocSinh.Image")));
            this.btnDsHocSinh.Location = new System.Drawing.Point(265, 251);
            this.btnDsHocSinh.Name = "btnDsHocSinh";
            this.btnDsHocSinh.Size = new System.Drawing.Size(47, 35);
            this.btnDsHocSinh.TabIndex = 5;
            this.btnDsHocSinh.TextColor = System.Drawing.Color.White;
            this.btnDsHocSinh.UseVisualStyleBackColor = false;
            this.btnDsHocSinh.Click += new System.EventHandler(this.btnDsHocSinh_Click);
            // 
            // txbDiaDiem
            // 
            this.txbDiaDiem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbDiaDiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDiaDiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDiaDiem.BorderRadius = 0;
            this.txbDiaDiem.BorderSize = 2;
            this.txbDiaDiem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txbDiaDiem.ForeColor = System.Drawing.Color.MintCream;
            this.txbDiaDiem.Location = new System.Drawing.Point(136, 137);
            this.txbDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiaDiem.Multiline = false;
            this.txbDiaDiem.Name = "txbDiaDiem";
            this.txbDiaDiem.Padding = new System.Windows.Forms.Padding(7);
            this.txbDiaDiem.PasswordChar = false;
            this.txbDiaDiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDiaDiem.PlaceholderText = "";
            this.txbDiaDiem.Size = new System.Drawing.Size(174, 33);
            this.txbDiaDiem.TabIndex = 3;
            this.txbDiaDiem.Texts = "";
            this.txbDiaDiem.UnderlinedStyle = true;
            // 
            // txbGiaoVien
            // 
            this.txbGiaoVien.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbGiaoVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbGiaoVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbGiaoVien.BorderRadius = 0;
            this.txbGiaoVien.BorderSize = 2;
            this.txbGiaoVien.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txbGiaoVien.ForeColor = System.Drawing.Color.MintCream;
            this.txbGiaoVien.Location = new System.Drawing.Point(135, 78);
            this.txbGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbGiaoVien.Multiline = false;
            this.txbGiaoVien.Name = "txbGiaoVien";
            this.txbGiaoVien.Padding = new System.Windows.Forms.Padding(7);
            this.txbGiaoVien.PasswordChar = false;
            this.txbGiaoVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbGiaoVien.PlaceholderText = "";
            this.txbGiaoVien.Size = new System.Drawing.Size(175, 33);
            this.txbGiaoVien.TabIndex = 3;
            this.txbGiaoVien.Texts = "";
            this.txbGiaoVien.UnderlinedStyle = true;
            // 
            // txbMaHoatDong
            // 
            this.txbMaHoatDong.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbMaHoatDong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbMaHoatDong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbMaHoatDong.BorderRadius = 0;
            this.txbMaHoatDong.BorderSize = 2;
            this.txbMaHoatDong.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txbMaHoatDong.ForeColor = System.Drawing.Color.MintCream;
            this.txbMaHoatDong.Location = new System.Drawing.Point(135, 11);
            this.txbMaHoatDong.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaHoatDong.Multiline = false;
            this.txbMaHoatDong.Name = "txbMaHoatDong";
            this.txbMaHoatDong.Padding = new System.Windows.Forms.Padding(7);
            this.txbMaHoatDong.PasswordChar = false;
            this.txbMaHoatDong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMaHoatDong.PlaceholderText = "";
            this.txbMaHoatDong.Size = new System.Drawing.Size(175, 33);
            this.txbMaHoatDong.TabIndex = 1;
            this.txbMaHoatDong.Texts = "";
            this.txbMaHoatDong.UnderlinedStyle = true;
            // 
            // DatePicker
            // 
            this.DatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DatePicker.BorderSize = 0;
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.DatePicker.Location = new System.Drawing.Point(18, 249);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(234, 35);
            this.DatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.DatePicker.TabIndex = 0;
            this.DatePicker.TextColor = System.Drawing.Color.White;
            this.DatePicker.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // HoatDongNgoaiGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HoatDongNgoaiGio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoatDongNgoaiGio";
            this.Load += new System.EventHandler(this.HoatDongNgoaiGio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomControl.CustomButton btnThem;
        private CustomControl.CustomButton btnDsHocSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControl.CustomTextBox txbDiaDiem;
        private CustomControl.CustomTextBox txbGiaoVien;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTextBox txbMaHoatDong;
        private CustomControl.CustomDateTimePicker DatePicker;
        private CustomControl.CustomButton btnHuy;
        private CustomControl.CustomButton btnXoa;
        private CustomControl.CustomButton btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHDNG;
        private System.Windows.Forms.BindingSource hoatDongBindingSource;
        private System.Windows.Forms.Label lbSLHocSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGvPhuTrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox rtxbError;
        private CustomControl.CustomButton btnTimMaHoatDong;
    }
}