namespace QuanLyHocSinh.Forms
{
    partial class DanhSachHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnThem = new QuanLyHocSinh.CustomControl.CustomButton();
            this.customButton3 = new QuanLyHocSinh.CustomControl.CustomButton();
            this.btnTimKiem = new QuanLyHocSinh.CustomControl.CustomButton();
            this.txbMaHS = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvHocSinhChuaChon = new System.Windows.Forms.DataGridView();
            this.maHSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhChuaChonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvHocSinhDaChon = new System.Windows.Forms.DataGridView();
            this.maHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhDaChonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhChuaChonBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhDaChonBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txbMaHS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
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
            this.btnXoa.Location = new System.Drawing.Point(82, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(37, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "<";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(82, 184);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(37, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = ">";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(15, 339);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(175, 40);
            this.customButton3.TabIndex = 6;
            this.customButton3.Text = "Xong";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(15, 114);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 40);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txbMaHS
            // 
            this.txbMaHS.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbMaHS.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbMaHS.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbMaHS.BorderRadius = 0;
            this.txbMaHS.BorderSize = 2;
            this.txbMaHS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txbMaHS.ForeColor = System.Drawing.Color.MintCream;
            this.txbMaHS.Location = new System.Drawing.Point(15, 62);
            this.txbMaHS.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaHS.Multiline = false;
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.Padding = new System.Windows.Forms.Padding(7);
            this.txbMaHS.PasswordChar = false;
            this.txbMaHS.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMaHS.PlaceholderText = "";
            this.txbMaHS.Size = new System.Drawing.Size(175, 33);
            this.txbMaHS.TabIndex = 4;
            this.txbMaHS.Texts = "";
            this.txbMaHS.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã học sinh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 600);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvHocSinhChuaChon);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 40);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(390, 560);
            this.panel7.TabIndex = 1;
            // 
            // dgvHocSinhChuaChon
            // 
            this.dgvHocSinhChuaChon.AllowUserToAddRows = false;
            this.dgvHocSinhChuaChon.AllowUserToDeleteRows = false;
            this.dgvHocSinhChuaChon.AllowUserToResizeColumns = false;
            this.dgvHocSinhChuaChon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvHocSinhChuaChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocSinhChuaChon.AutoGenerateColumns = false;
            this.dgvHocSinhChuaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhChuaChon.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHocSinhChuaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHocSinhChuaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocSinhChuaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocSinhChuaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhChuaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSDataGridViewTextBoxColumn1,
            this.tenHSDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1});
            this.dgvHocSinhChuaChon.DataSource = this.hocSinhChuaChonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinhChuaChon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocSinhChuaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinhChuaChon.EnableHeadersVisualStyles = false;
            this.dgvHocSinhChuaChon.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHocSinhChuaChon.Location = new System.Drawing.Point(0, 0);
            this.dgvHocSinhChuaChon.MultiSelect = false;
            this.dgvHocSinhChuaChon.Name = "dgvHocSinhChuaChon";
            this.dgvHocSinhChuaChon.ReadOnly = true;
            this.dgvHocSinhChuaChon.RowHeadersVisible = false;
            this.dgvHocSinhChuaChon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHocSinhChuaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinhChuaChon.Size = new System.Drawing.Size(390, 560);
            this.dgvHocSinhChuaChon.TabIndex = 1;
            // 
            // maHSDataGridViewTextBoxColumn1
            // 
            this.maHSDataGridViewTextBoxColumn1.DataPropertyName = "MaHS";
            this.maHSDataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.maHSDataGridViewTextBoxColumn1.Name = "maHSDataGridViewTextBoxColumn1";
            this.maHSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenHSDataGridViewTextBoxColumn1
            // 
            this.tenHSDataGridViewTextBoxColumn1.DataPropertyName = "TenHS";
            this.tenHSDataGridViewTextBoxColumn1.HeaderText = "Tên học sinh";
            this.tenHSDataGridViewTextBoxColumn1.Name = "tenHSDataGridViewTextBoxColumn1";
            this.tenHSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "Mã lớp";
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hocSinhChuaChonBindingSource
            // 
            this.hocSinhChuaChonBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HocSinh);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 40);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học sinh chưa chọn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(590, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 600);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvHocSinhDaChon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 560);
            this.panel5.TabIndex = 1;
            // 
            // dgvHocSinhDaChon
            // 
            this.dgvHocSinhDaChon.AllowUserToAddRows = false;
            this.dgvHocSinhDaChon.AllowUserToDeleteRows = false;
            this.dgvHocSinhDaChon.AllowUserToResizeColumns = false;
            this.dgvHocSinhDaChon.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvHocSinhDaChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHocSinhDaChon.AutoGenerateColumns = false;
            this.dgvHocSinhDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhDaChon.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHocSinhDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHocSinhDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocSinhDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHocSinhDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSDataGridViewTextBoxColumn,
            this.tenHSDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dgvHocSinhDaChon.DataSource = this.hocSinhDaChonBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinhDaChon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHocSinhDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinhDaChon.EnableHeadersVisualStyles = false;
            this.dgvHocSinhDaChon.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHocSinhDaChon.Location = new System.Drawing.Point(0, 0);
            this.dgvHocSinhDaChon.MultiSelect = false;
            this.dgvHocSinhDaChon.Name = "dgvHocSinhDaChon";
            this.dgvHocSinhDaChon.ReadOnly = true;
            this.dgvHocSinhDaChon.RowHeadersVisible = false;
            this.dgvHocSinhDaChon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHocSinhDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinhDaChon.Size = new System.Drawing.Size(390, 560);
            this.dgvHocSinhDaChon.TabIndex = 1;
            // 
            // maHSDataGridViewTextBoxColumn
            // 
            this.maHSDataGridViewTextBoxColumn.DataPropertyName = "MaHS";
            this.maHSDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.maHSDataGridViewTextBoxColumn.Name = "maHSDataGridViewTextBoxColumn";
            this.maHSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHSDataGridViewTextBoxColumn
            // 
            this.tenHSDataGridViewTextBoxColumn.DataPropertyName = "TenHS";
            this.tenHSDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.tenHSDataGridViewTextBoxColumn.Name = "tenHSDataGridViewTextBoxColumn";
            this.tenHSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hocSinhDaChonBindingSource
            // 
            this.hocSinhDaChonBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HocSinh);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 40);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học sinh đã chọn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachHocSinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinh_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhChuaChonBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhDaChonBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocSinhDaChon;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomTextBox txbMaHS;
        private CustomControl.CustomButton btnXoa;
        private CustomControl.CustomButton btnThem;
        private CustomControl.CustomButton btnTimKiem;
        private CustomControl.CustomButton customButton3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvHocSinhChuaChon;
        private System.Windows.Forms.BindingSource hocSinhChuaChonBindingSource;
        private System.Windows.Forms.BindingSource hocSinhDaChonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
    }
}