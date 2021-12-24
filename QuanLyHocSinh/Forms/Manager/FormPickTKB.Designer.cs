
namespace QuanLyHocSinh.Forms
{
    partial class FormPickTKB
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_namhoc = new System.Windows.Forms.Label();
            this.cbb_namhoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(104, 260);
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
            this.panel1.Size = new System.Drawing.Size(1366, 27);
            this.panel1.TabIndex = 81;
            // 
            // cbb_hk
            // 
            this.cbb_hk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hk.FormattingEnabled = true;
            this.cbb_hk.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_hk.Location = new System.Drawing.Point(104, 138);
            this.cbb_hk.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_hk.Name = "cbb_hk";
            this.cbb_hk.Size = new System.Drawing.Size(251, 24);
            this.cbb_hk.TabIndex = 89;
            this.cbb_hk.Text = "1";
            this.cbb_hk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
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
            this.cbb_lop.Location = new System.Drawing.Point(104, 89);
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
            this.lbl_hk.Location = new System.Drawing.Point(41, 141);
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
            this.lbl_lop.Location = new System.Drawing.Point(61, 92);
            this.lbl_lop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(31, 16);
            this.lbl_lop.TabIndex = 86;
            this.lbl_lop.Text = "Lớp";
            this.lbl_lop.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 85;
            this.label6.Text = "Bước 2";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(264, 260);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(91, 36);
            this.btn_next.TabIndex = 90;
            this.btn_next.Text = "Tiếp >>";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Nhập danh sách các tiết học";
            // 
            // lbl_namhoc
            // 
            this.lbl_namhoc.AutoSize = true;
            this.lbl_namhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_namhoc.Location = new System.Drawing.Point(30, 193);
            this.lbl_namhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_namhoc.Name = "lbl_namhoc";
            this.lbl_namhoc.Size = new System.Drawing.Size(62, 16);
            this.lbl_namhoc.TabIndex = 92;
            this.lbl_namhoc.Text = "Năm Học";
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
            this.cbb_namhoc.Location = new System.Drawing.Point(104, 185);
            this.cbb_namhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_namhoc.Name = "cbb_namhoc";
            this.cbb_namhoc.Size = new System.Drawing.Size(251, 24);
            this.cbb_namhoc.TabIndex = 93;
            this.cbb_namhoc.Text = "2021";
            // 
            // FormPickTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1366, 733);
            this.Controls.Add(this.cbb_namhoc);
            this.Controls.Add(this.lbl_namhoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cbb_hk);
            this.Controls.Add(this.cbb_lop);
            this.Controls.Add(this.lbl_hk);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPickTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSetupTKB";
            this.Load += new System.EventHandler(this.FormSetupTKB_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_namhoc;
        private System.Windows.Forms.ComboBox cbb_namhoc;
    }
}