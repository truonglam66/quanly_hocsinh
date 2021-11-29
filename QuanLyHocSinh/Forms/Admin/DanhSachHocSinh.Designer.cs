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
            this.dgvHocSinhChuaChon = new System.Windows.Forms.DataGridView();
            this.maHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhChuaChonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHocSinhDaChon = new System.Windows.Forms.DataGridView();
            this.maHSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhDaChonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaHS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhChuaChonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhDaChonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocSinhChuaChon
            // 
            this.dgvHocSinhChuaChon.AllowUserToAddRows = false;
            this.dgvHocSinhChuaChon.AllowUserToDeleteRows = false;
            this.dgvHocSinhChuaChon.AllowUserToResizeColumns = false;
            this.dgvHocSinhChuaChon.AllowUserToResizeRows = false;
            this.dgvHocSinhChuaChon.AutoGenerateColumns = false;
            this.dgvHocSinhChuaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhChuaChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHocSinhChuaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhChuaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSDataGridViewTextBoxColumn,
            this.tenHSDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dgvHocSinhChuaChon.DataSource = this.hocSinhChuaChonBindingSource;
            this.dgvHocSinhChuaChon.Location = new System.Drawing.Point(0, 75);
            this.dgvHocSinhChuaChon.Name = "dgvHocSinhChuaChon";
            this.dgvHocSinhChuaChon.ReadOnly = true;
            this.dgvHocSinhChuaChon.RowHeadersVisible = false;
            this.dgvHocSinhChuaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinhChuaChon.Size = new System.Drawing.Size(574, 573);
            this.dgvHocSinhChuaChon.TabIndex = 0;
            // 
            // maHSDataGridViewTextBoxColumn
            // 
            this.maHSDataGridViewTextBoxColumn.DataPropertyName = "MaHS";
            this.maHSDataGridViewTextBoxColumn.HeaderText = "MaHS";
            this.maHSDataGridViewTextBoxColumn.Name = "maHSDataGridViewTextBoxColumn";
            this.maHSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHSDataGridViewTextBoxColumn
            // 
            this.tenHSDataGridViewTextBoxColumn.DataPropertyName = "TenHS";
            this.tenHSDataGridViewTextBoxColumn.HeaderText = "TenHS";
            this.tenHSDataGridViewTextBoxColumn.Name = "tenHSDataGridViewTextBoxColumn";
            this.tenHSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hocSinhChuaChonBindingSource
            // 
            this.hocSinhChuaChonBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HocSinh);
            // 
            // dgvHocSinhDaChon
            // 
            this.dgvHocSinhDaChon.AllowUserToAddRows = false;
            this.dgvHocSinhDaChon.AllowUserToDeleteRows = false;
            this.dgvHocSinhDaChon.AllowUserToResizeColumns = false;
            this.dgvHocSinhDaChon.AllowUserToResizeRows = false;
            this.dgvHocSinhDaChon.AutoGenerateColumns = false;
            this.dgvHocSinhDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhDaChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHocSinhDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSDataGridViewTextBoxColumn1,
            this.tenHSDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1});
            this.dgvHocSinhDaChon.DataSource = this.hocSinhDaChonBindingSource;
            this.dgvHocSinhDaChon.Location = new System.Drawing.Point(775, 75);
            this.dgvHocSinhDaChon.Name = "dgvHocSinhDaChon";
            this.dgvHocSinhDaChon.ReadOnly = true;
            this.dgvHocSinhDaChon.RowHeadersVisible = false;
            this.dgvHocSinhDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinhDaChon.Size = new System.Drawing.Size(594, 573);
            this.dgvHocSinhDaChon.TabIndex = 1;
            // 
            // maHSDataGridViewTextBoxColumn1
            // 
            this.maHSDataGridViewTextBoxColumn1.DataPropertyName = "MaHS";
            this.maHSDataGridViewTextBoxColumn1.HeaderText = "MaHS";
            this.maHSDataGridViewTextBoxColumn1.Name = "maHSDataGridViewTextBoxColumn1";
            this.maHSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenHSDataGridViewTextBoxColumn1
            // 
            this.tenHSDataGridViewTextBoxColumn1.DataPropertyName = "TenHS";
            this.tenHSDataGridViewTextBoxColumn1.HeaderText = "TenHS";
            this.tenHSDataGridViewTextBoxColumn1.Name = "tenHSDataGridViewTextBoxColumn1";
            this.tenHSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hocSinhDaChonBindingSource
            // 
            this.hocSinhDaChonBindingSource.DataSource = typeof(QuanLyHocSinh.Classes.HocSinh);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 24);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(630, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách học sinh chưa chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(979, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách học sinh đã chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(646, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm kiếm";
            // 
            // txbMaHS
            // 
            this.txbMaHS.Location = new System.Drawing.Point(598, 152);
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.Size = new System.Drawing.Size(171, 20);
            this.txbMaHS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(595, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên học sinh:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(630, 323);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(630, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(630, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Xong";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 647);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbMaHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHocSinhDaChon);
            this.Controls.Add(this.dgvHocSinhChuaChon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachHocSinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhChuaChonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhDaChonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hocSinhChuaChonBindingSource;
        private System.Windows.Forms.BindingSource hocSinhDaChonBindingSource;
        private System.Windows.Forms.DataGridView dgvHocSinhChuaChon;
        private System.Windows.Forms.DataGridView dgvHocSinhDaChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
    }
}