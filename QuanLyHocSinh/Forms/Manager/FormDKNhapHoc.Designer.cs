﻿
namespace QuanLyHocSinh.Forms.Manager
{
    partial class FormDKNhapHoc
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
            this.lbl_titleDSHS = new System.Windows.Forms.Label();
            this.dataGridView_DSHS = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.lbl_Diachi = new System.Windows.Forms.Label();
            this.lbl_hotenPH = new System.Windows.Forms.Label();
            this.lbl_titlePH = new System.Windows.Forms.Label();
            this.lbl_DoB = new System.Windows.Forms.Label();
            this.dtP_DoB = new System.Windows.Forms.DateTimePicker();
            this.lbl_titleHS = new System.Windows.Forms.Label();
            this.lbl_hotenHS = new System.Windows.Forms.Label();
            this.rtxt_DC = new System.Windows.Forms.RichTextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_tenPH = new System.Windows.Forms.TextBox();
            this.txt_nameHS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titleDSHS
            // 
            this.lbl_titleDSHS.AutoSize = true;
            this.lbl_titleDSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleDSHS.Location = new System.Drawing.Point(469, 22);
            this.lbl_titleDSHS.Name = "lbl_titleDSHS";
            this.lbl_titleDSHS.Size = new System.Drawing.Size(177, 24);
            this.lbl_titleDSHS.TabIndex = 30;
            this.lbl_titleDSHS.Text = "Danh sách học sinh";
            // 
            // dataGridView_DSHS
            // 
            this.dataGridView_DSHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSHS.Location = new System.Drawing.Point(364, 64);
            this.dataGridView_DSHS.Name = "dataGridView_DSHS";
            this.dataGridView_DSHS.Size = new System.Drawing.Size(424, 311);
            this.dataGridView_DSHS.TabIndex = 29;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(130, 350);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(79, 25);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(4, 322);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(70, 13);
            this.lbl_sdt.TabIndex = 27;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // lbl_Diachi
            // 
            this.lbl_Diachi.AutoSize = true;
            this.lbl_Diachi.Location = new System.Drawing.Point(34, 149);
            this.lbl_Diachi.Name = "lbl_Diachi";
            this.lbl_Diachi.Size = new System.Drawing.Size(40, 13);
            this.lbl_Diachi.TabIndex = 26;
            this.lbl_Diachi.Text = "Địa chỉ";
            // 
            // lbl_hotenPH
            // 
            this.lbl_hotenPH.AutoSize = true;
            this.lbl_hotenPH.Location = new System.Drawing.Point(35, 283);
            this.lbl_hotenPH.Name = "lbl_hotenPH";
            this.lbl_hotenPH.Size = new System.Drawing.Size(39, 13);
            this.lbl_hotenPH.TabIndex = 25;
            this.lbl_hotenPH.Text = "Họ tên";
            // 
            // lbl_titlePH
            // 
            this.lbl_titlePH.AutoSize = true;
            this.lbl_titlePH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePH.Location = new System.Drawing.Point(76, 238);
            this.lbl_titlePH.Name = "lbl_titlePH";
            this.lbl_titlePH.Size = new System.Drawing.Size(186, 24);
            this.lbl_titlePH.TabIndex = 24;
            this.lbl_titlePH.Text = "Thông tin phụ huynh";
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.AutoSize = true;
            this.lbl_DoB.Location = new System.Drawing.Point(20, 103);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(54, 13);
            this.lbl_DoB.TabIndex = 23;
            this.lbl_DoB.Text = "Ngày sinh";
            // 
            // dtP_DoB
            // 
            this.dtP_DoB.Location = new System.Drawing.Point(80, 103);
            this.dtP_DoB.Name = "dtP_DoB";
            this.dtP_DoB.Size = new System.Drawing.Size(200, 20);
            this.dtP_DoB.TabIndex = 22;
            // 
            // lbl_titleHS
            // 
            this.lbl_titleHS.AutoSize = true;
            this.lbl_titleHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleHS.Location = new System.Drawing.Point(76, 22);
            this.lbl_titleHS.Name = "lbl_titleHS";
            this.lbl_titleHS.Size = new System.Drawing.Size(167, 24);
            this.lbl_titleHS.TabIndex = 21;
            this.lbl_titleHS.Text = "Thông tin học sinh";
            // 
            // lbl_hotenHS
            // 
            this.lbl_hotenHS.AutoSize = true;
            this.lbl_hotenHS.Location = new System.Drawing.Point(35, 67);
            this.lbl_hotenHS.Name = "lbl_hotenHS";
            this.lbl_hotenHS.Size = new System.Drawing.Size(39, 13);
            this.lbl_hotenHS.TabIndex = 20;
            this.lbl_hotenHS.Text = "Họ tên";
            // 
            // rtxt_DC
            // 
            this.rtxt_DC.Location = new System.Drawing.Point(80, 149);
            this.rtxt_DC.Name = "rtxt_DC";
            this.rtxt_DC.Size = new System.Drawing.Size(200, 76);
            this.rtxt_DC.TabIndex = 19;
            this.rtxt_DC.Text = "";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(80, 319);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 20);
            this.txt_SDT.TabIndex = 18;
            // 
            // txt_tenPH
            // 
            this.txt_tenPH.Location = new System.Drawing.Point(80, 280);
            this.txt_tenPH.Name = "txt_tenPH";
            this.txt_tenPH.Size = new System.Drawing.Size(200, 20);
            this.txt_tenPH.TabIndex = 17;
            // 
            // txt_nameHS
            // 
            this.txt_nameHS.Location = new System.Drawing.Point(80, 64);
            this.txt_nameHS.Name = "txt_nameHS";
            this.txt_nameHS.Size = new System.Drawing.Size(200, 20);
            this.txt_nameHS.TabIndex = 16;
            // 
            // FormDKNhapHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_titleDSHS);
            this.Controls.Add(this.dataGridView_DSHS);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_sdt);
            this.Controls.Add(this.lbl_Diachi);
            this.Controls.Add(this.lbl_hotenPH);
            this.Controls.Add(this.lbl_titlePH);
            this.Controls.Add(this.lbl_DoB);
            this.Controls.Add(this.dtP_DoB);
            this.Controls.Add(this.lbl_titleHS);
            this.Controls.Add(this.lbl_hotenHS);
            this.Controls.Add(this.rtxt_DC);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_tenPH);
            this.Controls.Add(this.txt_nameHS);
            this.Name = "FormDKNhapHoc";
            this.Text = "Đăng ký nhập học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titleDSHS;
        private System.Windows.Forms.DataGridView dataGridView_DSHS;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.Label lbl_Diachi;
        private System.Windows.Forms.Label lbl_hotenPH;
        private System.Windows.Forms.Label lbl_titlePH;
        private System.Windows.Forms.Label lbl_DoB;
        private System.Windows.Forms.DateTimePicker dtP_DoB;
        private System.Windows.Forms.Label lbl_titleHS;
        private System.Windows.Forms.Label lbl_hotenHS;
        private System.Windows.Forms.RichTextBox rtxt_DC;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_tenPH;
        private System.Windows.Forms.TextBox txt_nameHS;
    }
}