namespace QuanLyHocSinh
{
    partial class DanhSachBangDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new QuanLyHocSinh.CustomControl.CustomButton();
            this.txbLop = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.txbNamhoc = new QuanLyHocSinh.CustomControl.CustomTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txbLop);
            this.panel1.Controls.Add(this.txbNamhoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(566, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 411);
            this.panel1.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimkiem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimkiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimkiem.BorderRadius = 20;
            this.btnTimkiem.BorderSize = 0;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(51, 276);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(145, 40);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextColor = System.Drawing.Color.White;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txbLop
            // 
            this.txbLop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbLop.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txbLop.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txbLop.BorderRadius = 15;
            this.txbLop.BorderSize = 2;
            this.txbLop.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLop.ForeColor = System.Drawing.Color.MintCream;
            this.txbLop.Location = new System.Drawing.Point(51, 168);
            this.txbLop.Margin = new System.Windows.Forms.Padding(4);
            this.txbLop.Multiline = false;
            this.txbLop.Name = "txbLop";
            this.txbLop.Padding = new System.Windows.Forms.Padding(7);
            this.txbLop.PasswordChar = false;
            this.txbLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbLop.PlaceholderText = "Lớp";
            this.txbLop.Size = new System.Drawing.Size(145, 32);
            this.txbLop.TabIndex = 0;
            this.txbLop.Texts = "";
            this.txbLop.UnderlinedStyle = false;
            // 
            // txbNamhoc
            // 
            this.txbNamhoc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txbNamhoc.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txbNamhoc.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txbNamhoc.BorderRadius = 15;
            this.txbNamhoc.BorderSize = 2;
            this.txbNamhoc.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNamhoc.ForeColor = System.Drawing.Color.MintCream;
            this.txbNamhoc.Location = new System.Drawing.Point(51, 89);
            this.txbNamhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txbNamhoc.Multiline = false;
            this.txbNamhoc.Name = "txbNamhoc";
            this.txbNamhoc.Padding = new System.Windows.Forms.Padding(7);
            this.txbNamhoc.PasswordChar = false;
            this.txbNamhoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbNamhoc.PlaceholderText = "Năm học";
            this.txbNamhoc.Size = new System.Drawing.Size(145, 32);
            this.txbNamhoc.TabIndex = 0;
            this.txbNamhoc.Texts = "";
            this.txbNamhoc.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // DanhSachBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachBangDiem";
            this.Text = "DanhSachBangDiem";
            this.Load += new System.EventHandler(this.DanhSachBangDiem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.CustomTextBox txbNamhoc;
        private CustomControl.CustomTextBox txbLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.CustomButton btnTimkiem;
    }
}