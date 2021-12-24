
namespace QuanLyHocSinh.Forms
{
    partial class FormNhapDiem
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_hk = new System.Windows.Forms.ComboBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.lbl_hk = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_namhoc = new System.Windows.Forms.Label();
            this.cbb_namhoc = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_diemToan = new System.Windows.Forms.TextBox();
            this.lbl_diemToan = new System.Windows.Forms.Label();
            this.txt_diemTV = new System.Windows.Forms.TextBox();
            this.lbl_diemTV = new System.Windows.Forms.Label();
            this.panel_nhapdiem = new System.Windows.Forms.Panel();
            this.txt_diemTD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_diemKT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_diemMT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_diemAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diemNT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diemLSDL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diemKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diemTNXH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diemDD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_nhapdiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(120, 500);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(91, 36);
            this.btn_Exit.TabIndex = 29;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 27);
            this.panel1.TabIndex = 81;
            // 
            // cbb_hk
            // 
            this.cbb_hk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hk.FormattingEnabled = true;
            this.cbb_hk.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_hk.Location = new System.Drawing.Point(104, 169);
            this.cbb_hk.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_hk.Name = "cbb_hk";
            this.cbb_hk.Size = new System.Drawing.Size(251, 24);
            this.cbb_hk.TabIndex = 89;
            this.cbb_hk.Text = "1";
            this.cbb_hk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.Enabled = false;
            this.cbb_lop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Items.AddRange(new object[] {
            "1A1",
            "1A2",
            "1A3",
            "1A4",
            "2A1",
            "2A2",
            "2A3",
            "2A4",
            "3A1",
            "3A2",
            "3A3",
            "3A4",
            "4A1",
            "4A2",
            "4A3",
            "4A4",
            "5A1",
            "5A2",
            "5A3",
            "5A4"});
            this.cbb_lop.Location = new System.Drawing.Point(104, 120);
            this.cbb_lop.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(251, 24);
            this.cbb_lop.TabIndex = 88;
            this.cbb_lop.Text = "1A1";
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_hk
            // 
            this.lbl_hk.AutoSize = true;
            this.lbl_hk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_hk.Location = new System.Drawing.Point(41, 172);
            this.lbl_hk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hk.Name = "lbl_hk";
            this.lbl_hk.Size = new System.Drawing.Size(51, 16);
            this.lbl_hk.TabIndex = 87;
            this.lbl_hk.Text = "Học Kỳ";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_lop.Location = new System.Drawing.Point(61, 123);
            this.lbl_lop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(31, 16);
            this.lbl_lop.TabIndex = 86;
            this.lbl_lop.Text = "Lớp";
            this.lbl_lop.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(338, 500);
            this.btn_done.Margin = new System.Windows.Forms.Padding(2);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(91, 36);
            this.btn_done.TabIndex = 90;
            this.btn_done.Text = "Xong";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Nhập Điểm Cuối Kỳ";
            // 
            // lbl_namhoc
            // 
            this.lbl_namhoc.AutoSize = true;
            this.lbl_namhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_namhoc.Location = new System.Drawing.Point(30, 216);
            this.lbl_namhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_namhoc.Name = "lbl_namhoc";
            this.lbl_namhoc.Size = new System.Drawing.Size(62, 16);
            this.lbl_namhoc.TabIndex = 92;
            this.lbl_namhoc.Text = "Năm Học";
            this.lbl_namhoc.Click += new System.EventHandler(this.lbl_namhoc_Click);
            // 
            // cbb_namhoc
            // 
            this.cbb_namhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_namhoc.FormattingEnabled = true;
            this.cbb_namhoc.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbb_namhoc.Location = new System.Drawing.Point(104, 216);
            this.cbb_namhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_namhoc.Name = "cbb_namhoc";
            this.cbb_namhoc.Size = new System.Drawing.Size(251, 24);
            this.cbb_namhoc.TabIndex = 93;
            this.cbb_namhoc.Text = "2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::QuanLyHocSinh.Properties.Resources.education_icon_300x300;
            this.pictureBox1.InitialImage = global::QuanLyHocSinh.Properties.Resources.School_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(394, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Họ Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(104, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 96;
            this.textBox1.Text = "Nguyễn Văn A";
            // 
            // txt_diemToan
            // 
            this.txt_diemToan.Location = new System.Drawing.Point(135, 15);
            this.txt_diemToan.Name = "txt_diemToan";
            this.txt_diemToan.Size = new System.Drawing.Size(251, 22);
            this.txt_diemToan.TabIndex = 98;
            // 
            // lbl_diemToan
            // 
            this.lbl_diemToan.AutoSize = true;
            this.lbl_diemToan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diemToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_diemToan.Location = new System.Drawing.Point(46, 21);
            this.lbl_diemToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_diemToan.Name = "lbl_diemToan";
            this.lbl_diemToan.Size = new System.Drawing.Size(69, 16);
            this.lbl_diemToan.TabIndex = 97;
            this.lbl_diemToan.Text = "Điểm Toán";
            // 
            // txt_diemTV
            // 
            this.txt_diemTV.Location = new System.Drawing.Point(135, 43);
            this.txt_diemTV.Name = "txt_diemTV";
            this.txt_diemTV.Size = new System.Drawing.Size(251, 22);
            this.txt_diemTV.TabIndex = 100;
            // 
            // lbl_diemTV
            // 
            this.lbl_diemTV.AutoSize = true;
            this.lbl_diemTV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diemTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_diemTV.Location = new System.Drawing.Point(17, 49);
            this.lbl_diemTV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_diemTV.Name = "lbl_diemTV";
            this.lbl_diemTV.Size = new System.Drawing.Size(100, 16);
            this.lbl_diemTV.TabIndex = 99;
            this.lbl_diemTV.Text = "Điểm Tiếng Việt";
            // 
            // panel_nhapdiem
            // 
            this.panel_nhapdiem.AutoScroll = true;
            this.panel_nhapdiem.Controls.Add(this.txt_diemTD);
            this.panel_nhapdiem.Controls.Add(this.label11);
            this.panel_nhapdiem.Controls.Add(this.txt_diemKT);
            this.panel_nhapdiem.Controls.Add(this.label10);
            this.panel_nhapdiem.Controls.Add(this.txt_diemMT);
            this.panel_nhapdiem.Controls.Add(this.label9);
            this.panel_nhapdiem.Controls.Add(this.txt_diemAN);
            this.panel_nhapdiem.Controls.Add(this.label8);
            this.panel_nhapdiem.Controls.Add(this.txt_diemNT);
            this.panel_nhapdiem.Controls.Add(this.label7);
            this.panel_nhapdiem.Controls.Add(this.txt_diemLSDL);
            this.panel_nhapdiem.Controls.Add(this.label6);
            this.panel_nhapdiem.Controls.Add(this.txt_diemKH);
            this.panel_nhapdiem.Controls.Add(this.label5);
            this.panel_nhapdiem.Controls.Add(this.txt_diemTNXH);
            this.panel_nhapdiem.Controls.Add(this.label4);
            this.panel_nhapdiem.Controls.Add(this.txt_diemDD);
            this.panel_nhapdiem.Controls.Add(this.label3);
            this.panel_nhapdiem.Controls.Add(this.lbl_diemToan);
            this.panel_nhapdiem.Controls.Add(this.txt_diemTV);
            this.panel_nhapdiem.Controls.Add(this.txt_diemToan);
            this.panel_nhapdiem.Controls.Add(this.lbl_diemTV);
            this.panel_nhapdiem.Location = new System.Drawing.Point(12, 255);
            this.panel_nhapdiem.Name = "panel_nhapdiem";
            this.panel_nhapdiem.Size = new System.Drawing.Size(417, 240);
            this.panel_nhapdiem.TabIndex = 101;
            // 
            // txt_diemTD
            // 
            this.txt_diemTD.Location = new System.Drawing.Point(135, 295);
            this.txt_diemTD.Name = "txt_diemTD";
            this.txt_diemTD.Size = new System.Drawing.Size(251, 22);
            this.txt_diemTD.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(25, 298);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 118;
            this.label11.Text = "Điểm Thể Dục";
            // 
            // txt_diemKT
            // 
            this.txt_diemKT.Location = new System.Drawing.Point(135, 267);
            this.txt_diemKT.Name = "txt_diemKT";
            this.txt_diemKT.Size = new System.Drawing.Size(251, 22);
            this.txt_diemKT.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(21, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 116;
            this.label10.Text = "Điểm Kỹ Thuật";
            // 
            // txt_diemMT
            // 
            this.txt_diemMT.Location = new System.Drawing.Point(135, 239);
            this.txt_diemMT.Name = "txt_diemMT";
            this.txt_diemMT.Size = new System.Drawing.Size(251, 22);
            this.txt_diemMT.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(19, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 114;
            this.label9.Text = "Điểm Mỹ Thuật";
            // 
            // txt_diemAN
            // 
            this.txt_diemAN.Location = new System.Drawing.Point(135, 211);
            this.txt_diemAN.Name = "txt_diemAN";
            this.txt_diemAN.Size = new System.Drawing.Size(251, 22);
            this.txt_diemAN.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(19, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 112;
            this.label8.Text = "Điểm Âm Nhạc";
            // 
            // txt_diemNT
            // 
            this.txt_diemNT.Location = new System.Drawing.Point(135, 183);
            this.txt_diemNT.Name = "txt_diemNT";
            this.txt_diemNT.Size = new System.Drawing.Size(251, 22);
            this.txt_diemNT.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(7, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 110;
            this.label7.Text = "Điểm Nghệ Thuật";
            // 
            // txt_diemLSDL
            // 
            this.txt_diemLSDL.Location = new System.Drawing.Point(135, 155);
            this.txt_diemLSDL.Name = "txt_diemLSDL";
            this.txt_diemLSDL.Size = new System.Drawing.Size(251, 22);
            this.txt_diemLSDL.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(43, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Điểm LS&DL";
            // 
            // txt_diemKH
            // 
            this.txt_diemKH.Location = new System.Drawing.Point(135, 127);
            this.txt_diemKH.Name = "txt_diemKH";
            this.txt_diemKH.Size = new System.Drawing.Size(251, 22);
            this.txt_diemKH.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Điểm Khoa Học";
            // 
            // txt_diemTNXH
            // 
            this.txt_diemTNXH.Location = new System.Drawing.Point(135, 99);
            this.txt_diemTNXH.Name = "txt_diemTNXH";
            this.txt_diemTNXH.Size = new System.Drawing.Size(251, 22);
            this.txt_diemTNXH.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(41, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Điểm TN&XH";
            // 
            // txt_diemDD
            // 
            this.txt_diemDD.Location = new System.Drawing.Point(135, 71);
            this.txt_diemDD.Name = "txt_diemDD";
            this.txt_diemDD.Size = new System.Drawing.Size(251, 22);
            this.txt_diemDD.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 102;
            this.label3.Text = "Điểm Đạo Đức";
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(550, 553);
            this.Controls.Add(this.panel_nhapdiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbb_namhoc);
            this.Controls.Add(this.lbl_namhoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.cbb_hk);
            this.Controls.Add(this.cbb_lop);
            this.Controls.Add(this.lbl_hk);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSetupTKB";
            this.Load += new System.EventHandler(this.FormSetupTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_nhapdiem.ResumeLayout(false);
            this.panel_nhapdiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_hk;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label lbl_hk;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_namhoc;
        private System.Windows.Forms.ComboBox cbb_namhoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_diemToan;
        private System.Windows.Forms.Label lbl_diemToan;
        private System.Windows.Forms.TextBox txt_diemTV;
        private System.Windows.Forms.Label lbl_diemTV;
        private System.Windows.Forms.Panel panel_nhapdiem;
        private System.Windows.Forms.TextBox txt_diemTD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_diemKT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_diemMT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_diemAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_diemNT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diemLSDL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_diemKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diemTNXH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diemDD;
        private System.Windows.Forms.Label label3;
    }
}