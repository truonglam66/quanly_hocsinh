namespace QuanLyHocSinh.Forms.Admin
{
    partial class FormAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHDNG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_HDNG = new System.Windows.Forms.DateTimePicker();
            this.rtxbLoi_HDNG = new System.Windows.Forms.RichTextBox();
            this.btnDsHocSinh_HDNG = new System.Windows.Forms.Button();
            this.btnHuy_HDNG = new System.Windows.Forms.Button();
            this.btnXoa_HDNG = new System.Windows.Forms.Button();
            this.btnSua_HDNG = new System.Windows.Forms.Button();
            this.btnThem_HDNG = new System.Windows.Forms.Button();
            this.txbDiaDiem_HDNG = new System.Windows.Forms.TextBox();
            this.txbGiaoVien_HDNG = new System.Windows.Forms.TextBox();
            this.txbMaHoatDong_HDNG = new System.Windows.Forms.TextBox();
            this.lbSLHocSinh_HDNG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGvPhuTrachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNG)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 459);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách bảng điểm cuối kỳ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1023, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách hoạt động ngoài giờ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHDNG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 427);
            this.panel2.TabIndex = 1;
            // 
            // dgvHDNG
            // 
            this.dgvHDNG.AllowUserToAddRows = false;
            this.dgvHDNG.AllowUserToDeleteRows = false;
            this.dgvHDNG.AllowUserToResizeColumns = false;
            this.dgvHDNG.AllowUserToResizeRows = false;
            this.dgvHDNG.AutoGenerateColumns = false;
            this.dgvHDNG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDNG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maGvPhuTrachDataGridViewTextBoxColumn,
            this.diaDiemDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn});
            this.dgvHDNG.DataSource = this.hoatDongBindingSource;
            this.dgvHDNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDNG.Location = new System.Drawing.Point(0, 0);
            this.dgvHDNG.Name = "dgvHDNG";
            this.dgvHDNG.ReadOnly = true;
            this.dgvHDNG.RowHeadersVisible = false;
            this.dgvHDNG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHDNG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNG.Size = new System.Drawing.Size(729, 427);
            this.dgvHDNG.TabIndex = 1;
            this.dgvHDNG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNG_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_HDNG);
            this.panel1.Controls.Add(this.rtxbLoi_HDNG);
            this.panel1.Controls.Add(this.btnDsHocSinh_HDNG);
            this.panel1.Controls.Add(this.btnHuy_HDNG);
            this.panel1.Controls.Add(this.btnXoa_HDNG);
            this.panel1.Controls.Add(this.btnSua_HDNG);
            this.panel1.Controls.Add(this.btnThem_HDNG);
            this.panel1.Controls.Add(this.txbDiaDiem_HDNG);
            this.panel1.Controls.Add(this.txbGiaoVien_HDNG);
            this.panel1.Controls.Add(this.txbMaHoatDong_HDNG);
            this.panel1.Controls.Add(this.lbSLHocSinh_HDNG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 427);
            this.panel1.TabIndex = 0;
            // 
            // dtp_HDNG
            // 
            this.dtp_HDNG.Location = new System.Drawing.Point(37, 201);
            this.dtp_HDNG.Name = "dtp_HDNG";
            this.dtp_HDNG.Size = new System.Drawing.Size(200, 20);
            this.dtp_HDNG.TabIndex = 4;
            this.dtp_HDNG.Value = new System.DateTime(2021, 11, 17, 0, 0, 0, 0);
            // 
            // rtxbLoi_HDNG
            // 
            this.rtxbLoi_HDNG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxbLoi_HDNG.Location = new System.Drawing.Point(0, 331);
            this.rtxbLoi_HDNG.Name = "rtxbLoi_HDNG";
            this.rtxbLoi_HDNG.Size = new System.Drawing.Size(288, 96);
            this.rtxbLoi_HDNG.TabIndex = 3;
            this.rtxbLoi_HDNG.Text = "";
            // 
            // btnDsHocSinh_HDNG
            // 
            this.btnDsHocSinh_HDNG.AutoSize = true;
            this.btnDsHocSinh_HDNG.BackColor = System.Drawing.Color.DimGray;
            this.btnDsHocSinh_HDNG.Image = global::QuanLyHocSinh.Properties.Resources.student;
            this.btnDsHocSinh_HDNG.Location = new System.Drawing.Point(216, 160);
            this.btnDsHocSinh_HDNG.Name = "btnDsHocSinh_HDNG";
            this.btnDsHocSinh_HDNG.Size = new System.Drawing.Size(31, 29);
            this.btnDsHocSinh_HDNG.TabIndex = 2;
            this.btnDsHocSinh_HDNG.Text = "\r\n";
            this.btnDsHocSinh_HDNG.UseVisualStyleBackColor = false;
            this.btnDsHocSinh_HDNG.Click += new System.EventHandler(this.btnDsHocSinh_HDNG_Click);
            // 
            // btnHuy_HDNG
            // 
            this.btnHuy_HDNG.Location = new System.Drawing.Point(153, 287);
            this.btnHuy_HDNG.Name = "btnHuy_HDNG";
            this.btnHuy_HDNG.Size = new System.Drawing.Size(75, 23);
            this.btnHuy_HDNG.TabIndex = 2;
            this.btnHuy_HDNG.Text = "Hủy";
            this.btnHuy_HDNG.UseVisualStyleBackColor = true;
            this.btnHuy_HDNG.Click += new System.EventHandler(this.btnHuy_HDNG_Click);
            // 
            // btnXoa_HDNG
            // 
            this.btnXoa_HDNG.Location = new System.Drawing.Point(37, 287);
            this.btnXoa_HDNG.Name = "btnXoa_HDNG";
            this.btnXoa_HDNG.Size = new System.Drawing.Size(75, 23);
            this.btnXoa_HDNG.TabIndex = 2;
            this.btnXoa_HDNG.Text = "Xóa";
            this.btnXoa_HDNG.UseVisualStyleBackColor = true;
            this.btnXoa_HDNG.Click += new System.EventHandler(this.btnXoa_HDNG_Click);
            // 
            // btnSua_HDNG
            // 
            this.btnSua_HDNG.Location = new System.Drawing.Point(153, 232);
            this.btnSua_HDNG.Name = "btnSua_HDNG";
            this.btnSua_HDNG.Size = new System.Drawing.Size(75, 23);
            this.btnSua_HDNG.TabIndex = 2;
            this.btnSua_HDNG.Text = "Sửa";
            this.btnSua_HDNG.UseVisualStyleBackColor = true;
            this.btnSua_HDNG.Click += new System.EventHandler(this.btnSua_HDNG_Click);
            // 
            // btnThem_HDNG
            // 
            this.btnThem_HDNG.Location = new System.Drawing.Point(37, 232);
            this.btnThem_HDNG.Name = "btnThem_HDNG";
            this.btnThem_HDNG.Size = new System.Drawing.Size(75, 23);
            this.btnThem_HDNG.TabIndex = 2;
            this.btnThem_HDNG.Text = "Thêm";
            this.btnThem_HDNG.UseVisualStyleBackColor = true;
            this.btnThem_HDNG.Click += new System.EventHandler(this.btnThem_HDNG_Click);
            // 
            // txbDiaDiem_HDNG
            // 
            this.txbDiaDiem_HDNG.Location = new System.Drawing.Point(167, 126);
            this.txbDiaDiem_HDNG.Name = "txbDiaDiem_HDNG";
            this.txbDiaDiem_HDNG.Size = new System.Drawing.Size(100, 20);
            this.txbDiaDiem_HDNG.TabIndex = 1;
            // 
            // txbGiaoVien_HDNG
            // 
            this.txbGiaoVien_HDNG.Location = new System.Drawing.Point(167, 86);
            this.txbGiaoVien_HDNG.Name = "txbGiaoVien_HDNG";
            this.txbGiaoVien_HDNG.Size = new System.Drawing.Size(100, 20);
            this.txbGiaoVien_HDNG.TabIndex = 1;
            // 
            // txbMaHoatDong_HDNG
            // 
            this.txbMaHoatDong_HDNG.Location = new System.Drawing.Point(167, 53);
            this.txbMaHoatDong_HDNG.Name = "txbMaHoatDong_HDNG";
            this.txbMaHoatDong_HDNG.Size = new System.Drawing.Size(100, 20);
            this.txbMaHoatDong_HDNG.TabIndex = 1;
            // 
            // lbSLHocSinh_HDNG
            // 
            this.lbSLHocSinh_HDNG.AutoSize = true;
            this.lbSLHocSinh_HDNG.Location = new System.Drawing.Point(164, 168);
            this.lbSLHocSinh_HDNG.Name = "lbSLHocSinh_HDNG";
            this.lbSLHocSinh_HDNG.Size = new System.Drawing.Size(25, 13);
            this.lbSLHocSinh_HDNG.TabIndex = 0;
            this.lbSLHocSinh_HDNG.Text = "slhs";
            this.lbSLHocSinh_HDNG.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng học sinh đã chọn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã giáo viên phụ trách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoạt động";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1023, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Các danh sách học sinh tham dự cuộc thi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1023, 433);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Danh sách thời khóa biểu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGvPhuTrachDataGridViewTextBoxColumn
            // 
            this.maGvPhuTrachDataGridViewTextBoxColumn.DataPropertyName = "MaGvPhuTrach";
            this.maGvPhuTrachDataGridViewTextBoxColumn.HeaderText = "MaGvPhuTrach";
            this.maGvPhuTrachDataGridViewTextBoxColumn.Name = "maGvPhuTrachDataGridViewTextBoxColumn";
            this.maGvPhuTrachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDiemDataGridViewTextBoxColumn
            // 
            this.diaDiemDataGridViewTextBoxColumn.DataPropertyName = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.HeaderText = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.Name = "diaDiemDataGridViewTextBoxColumn";
            this.diaDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoatDongBindingSource
            // 
            this.hoatDongBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HoatDong);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 509);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource hoatDongBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHDNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGvPhuTrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDiaDiem_HDNG;
        private System.Windows.Forms.TextBox txbGiaoVien_HDNG;
        private System.Windows.Forms.TextBox txbMaHoatDong_HDNG;
        private System.Windows.Forms.Label lbSLHocSinh_HDNG;
        private System.Windows.Forms.RichTextBox rtxbLoi_HDNG;
        private System.Windows.Forms.Button btnDsHocSinh_HDNG;
        private System.Windows.Forms.Button btnHuy_HDNG;
        private System.Windows.Forms.Button btnXoa_HDNG;
        private System.Windows.Forms.Button btnSua_HDNG;
        private System.Windows.Forms.Button btnThem_HDNG;
        private System.Windows.Forms.DateTimePicker dtp_HDNG;
    }
}