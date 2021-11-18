
namespace QuanLyHocSinh.FormsGVmoi
{
    partial class fTaoTKB
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
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTKB = new System.Windows.Forms.Button();
            this.cbGiaovien = new System.Windows.Forms.ComboBox();
            this.cbMonhoc = new System.Windows.Forms.ComboBox();
            this.txbTiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(239, 503);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 46);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvTKB
            // 
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTKB.Location = new System.Drawing.Point(12, 12);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 62;
            this.dgvTKB.RowTemplate.Height = 28;
            this.dgvTKB.Size = new System.Drawing.Size(588, 472);
            this.dgvTKB.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thứ/Tiết";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thứ hai";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thứ ba";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thứ tư";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thứ năm";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thứ sáu";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // btnThemTKB
            // 
            this.btnThemTKB.Location = new System.Drawing.Point(760, 503);
            this.btnThemTKB.Name = "btnThemTKB";
            this.btnThemTKB.Size = new System.Drawing.Size(75, 46);
            this.btnThemTKB.TabIndex = 29;
            this.btnThemTKB.Text = "Thêm";
            this.btnThemTKB.UseVisualStyleBackColor = true;
            // 
            // cbGiaovien
            // 
            this.cbGiaovien.FormattingEnabled = true;
            this.cbGiaovien.Location = new System.Drawing.Point(793, 78);
            this.cbGiaovien.Name = "cbGiaovien";
            this.cbGiaovien.Size = new System.Drawing.Size(149, 28);
            this.cbGiaovien.TabIndex = 28;
            // 
            // cbMonhoc
            // 
            this.cbMonhoc.FormattingEnabled = true;
            this.cbMonhoc.Location = new System.Drawing.Point(793, 44);
            this.cbMonhoc.Name = "cbMonhoc";
            this.cbMonhoc.Size = new System.Drawing.Size(149, 28);
            this.cbMonhoc.TabIndex = 27;
            // 
            // txbTiet
            // 
            this.txbTiet.Location = new System.Drawing.Point(793, 12);
            this.txbTiet.Name = "txbTiet";
            this.txbTiet.Size = new System.Drawing.Size(149, 26);
            this.txbTiet.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tiết học";
            // 
            // fTaoTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 572);
            this.Controls.Add(this.btnThemTKB);
            this.Controls.Add(this.cbGiaovien);
            this.Controls.Add(this.cbMonhoc);
            this.Controls.Add(this.txbTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvTKB);
            this.Name = "fTaoTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTaoTKB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnThemTKB;
        private System.Windows.Forms.ComboBox cbGiaovien;
        private System.Windows.Forms.ComboBox cbMonhoc;
        private System.Windows.Forms.TextBox txbTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}