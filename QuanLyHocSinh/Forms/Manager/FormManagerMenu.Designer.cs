
namespace QuanLyHocSinh.Forms
{
    partial class FormManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerMenu));
            this.containerControl = new System.Windows.Forms.ContainerControl();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.tabControl_mainMenu = new System.Windows.Forms.TabControl();
            this.tabPageDKNH = new System.Windows.Forms.TabPage();
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
            this.tabPageDKXL = new System.Windows.Forms.TabPage();
            this.tabControl_ClassRegister = new System.Windows.Forms.TabControl();
            this.tabPageHS = new System.Windows.Forms.TabPage();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.dataGridView_HS = new System.Windows.Forms.DataGridView();
            this.btn_searchLop = new System.Windows.Forms.Button();
            this.btn_searchHS = new System.Windows.Forms.Button();
            this.txt_searchLop = new System.Windows.Forms.TextBox();
            this.txt_searchHS = new System.Windows.Forms.TextBox();
            this.lbl_DSLop = new System.Windows.Forms.Label();
            this.lbl_DSHS = new System.Windows.Forms.Label();
            this.tabPageGVCN = new System.Windows.Forms.TabPage();
            this.btn_OK1 = new System.Windows.Forms.Button();
            this.dataGridView_Lop1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_GV = new System.Windows.Forms.DataGridView();
            this.btn_Lop1 = new System.Windows.Forms.Button();
            this.btn_searchGV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_searchGV = new System.Windows.Forms.TextBox();
            this.lbl_DSLop1 = new System.Windows.Forms.Label();
            this.lbl_DSGV = new System.Windows.Forms.Label();
            this.tabPageChuyenTruong = new System.Windows.Forms.TabPage();
            this.btn_Create = new System.Windows.Forms.Button();
            this.dataGridView_HS1 = new System.Windows.Forms.DataGridView();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.tabPageTotNghiep = new System.Windows.Forms.TabPage();
            this.btn_Create2 = new System.Windows.Forms.Button();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.dataGridView_HS2 = new System.Windows.Forms.DataGridView();
            this.linkLabel_Logoff = new System.Windows.Forms.LinkLabel();
            this.tabControl_mainMenu.SuspendLayout();
            this.tabPageDKNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).BeginInit();
            this.tabPageDKXL.SuspendLayout();
            this.tabControl_ClassRegister.SuspendLayout();
            this.tabPageHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS)).BeginInit();
            this.tabPageGVCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GV)).BeginInit();
            this.tabPageChuyenTruong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS1)).BeginInit();
            this.tabPageTotNghiep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS2)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.AutoScroll = true;
            this.containerControl.Location = new System.Drawing.Point(0, 0);
            this.containerControl.Name = "containerControl";
            this.containerControl.Size = new System.Drawing.Size(800, 450);
            this.containerControl.TabIndex = 0;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(306, 13);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(124, 24);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Menu Chính";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(664, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(67, 13);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Chào, Admin";
            // 
            // tabControl_mainMenu
            // 
            this.tabControl_mainMenu.Controls.Add(this.tabPageDKNH);
            this.tabControl_mainMenu.Controls.Add(this.tabPageDKXL);
            this.tabControl_mainMenu.Controls.Add(this.tabPageChuyenTruong);
            this.tabControl_mainMenu.Controls.Add(this.tabPageTotNghiep);
            this.tabControl_mainMenu.Location = new System.Drawing.Point(1, 47);
            this.tabControl_mainMenu.Name = "tabControl_mainMenu";
            this.tabControl_mainMenu.SelectedIndex = 0;
            this.tabControl_mainMenu.Size = new System.Drawing.Size(800, 405);
            this.tabControl_mainMenu.TabIndex = 3;
            // 
            // tabPageDKNH
            // 
            this.tabPageDKNH.Controls.Add(this.lbl_titleDSHS);
            this.tabPageDKNH.Controls.Add(this.dataGridView_DSHS);
            this.tabPageDKNH.Controls.Add(this.btn_Save);
            this.tabPageDKNH.Controls.Add(this.lbl_sdt);
            this.tabPageDKNH.Controls.Add(this.lbl_Diachi);
            this.tabPageDKNH.Controls.Add(this.lbl_hotenPH);
            this.tabPageDKNH.Controls.Add(this.lbl_titlePH);
            this.tabPageDKNH.Controls.Add(this.lbl_DoB);
            this.tabPageDKNH.Controls.Add(this.dtP_DoB);
            this.tabPageDKNH.Controls.Add(this.lbl_titleHS);
            this.tabPageDKNH.Controls.Add(this.lbl_hotenHS);
            this.tabPageDKNH.Controls.Add(this.rtxt_DC);
            this.tabPageDKNH.Controls.Add(this.txt_SDT);
            this.tabPageDKNH.Controls.Add(this.txt_tenPH);
            this.tabPageDKNH.Controls.Add(this.txt_nameHS);
            this.tabPageDKNH.Location = new System.Drawing.Point(4, 22);
            this.tabPageDKNH.Name = "tabPageDKNH";
            this.tabPageDKNH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDKNH.Size = new System.Drawing.Size(792, 379);
            this.tabPageDKNH.TabIndex = 0;
            this.tabPageDKNH.Text = "Đăng ký nhập học";
            this.tabPageDKNH.UseVisualStyleBackColor = true;
            // 
            // lbl_titleDSHS
            // 
            this.lbl_titleDSHS.AutoSize = true;
            this.lbl_titleDSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleDSHS.Location = new System.Drawing.Point(464, 10);
            this.lbl_titleDSHS.Name = "lbl_titleDSHS";
            this.lbl_titleDSHS.Size = new System.Drawing.Size(177, 24);
            this.lbl_titleDSHS.TabIndex = 15;
            this.lbl_titleDSHS.Text = "Danh sách học sinh";
            // 
            // dataGridView_DSHS
            // 
            this.dataGridView_DSHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSHS.Location = new System.Drawing.Point(359, 52);
            this.dataGridView_DSHS.Name = "dataGridView_DSHS";
            this.dataGridView_DSHS.Size = new System.Drawing.Size(424, 311);
            this.dataGridView_DSHS.TabIndex = 14;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(125, 338);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(79, 25);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(-1, 310);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(70, 13);
            this.lbl_sdt.TabIndex = 12;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // lbl_Diachi
            // 
            this.lbl_Diachi.AutoSize = true;
            this.lbl_Diachi.Location = new System.Drawing.Point(29, 137);
            this.lbl_Diachi.Name = "lbl_Diachi";
            this.lbl_Diachi.Size = new System.Drawing.Size(40, 13);
            this.lbl_Diachi.TabIndex = 11;
            this.lbl_Diachi.Text = "Địa chỉ";
            // 
            // lbl_hotenPH
            // 
            this.lbl_hotenPH.AutoSize = true;
            this.lbl_hotenPH.Location = new System.Drawing.Point(30, 271);
            this.lbl_hotenPH.Name = "lbl_hotenPH";
            this.lbl_hotenPH.Size = new System.Drawing.Size(39, 13);
            this.lbl_hotenPH.TabIndex = 10;
            this.lbl_hotenPH.Text = "Họ tên";
            // 
            // lbl_titlePH
            // 
            this.lbl_titlePH.AutoSize = true;
            this.lbl_titlePH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePH.Location = new System.Drawing.Point(71, 226);
            this.lbl_titlePH.Name = "lbl_titlePH";
            this.lbl_titlePH.Size = new System.Drawing.Size(186, 24);
            this.lbl_titlePH.TabIndex = 9;
            this.lbl_titlePH.Text = "Thông tin phụ huynh";
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.AutoSize = true;
            this.lbl_DoB.Location = new System.Drawing.Point(15, 91);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(54, 13);
            this.lbl_DoB.TabIndex = 8;
            this.lbl_DoB.Text = "Ngày sinh";
            // 
            // dtP_DoB
            // 
            this.dtP_DoB.Location = new System.Drawing.Point(75, 91);
            this.dtP_DoB.Name = "dtP_DoB";
            this.dtP_DoB.Size = new System.Drawing.Size(200, 20);
            this.dtP_DoB.TabIndex = 7;
            // 
            // lbl_titleHS
            // 
            this.lbl_titleHS.AutoSize = true;
            this.lbl_titleHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleHS.Location = new System.Drawing.Point(71, 10);
            this.lbl_titleHS.Name = "lbl_titleHS";
            this.lbl_titleHS.Size = new System.Drawing.Size(167, 24);
            this.lbl_titleHS.TabIndex = 6;
            this.lbl_titleHS.Text = "Thông tin học sinh";
            // 
            // lbl_hotenHS
            // 
            this.lbl_hotenHS.AutoSize = true;
            this.lbl_hotenHS.Location = new System.Drawing.Point(30, 55);
            this.lbl_hotenHS.Name = "lbl_hotenHS";
            this.lbl_hotenHS.Size = new System.Drawing.Size(39, 13);
            this.lbl_hotenHS.TabIndex = 5;
            this.lbl_hotenHS.Text = "Họ tên";
            // 
            // rtxt_DC
            // 
            this.rtxt_DC.Location = new System.Drawing.Point(75, 137);
            this.rtxt_DC.Name = "rtxt_DC";
            this.rtxt_DC.Size = new System.Drawing.Size(200, 76);
            this.rtxt_DC.TabIndex = 4;
            this.rtxt_DC.Text = "";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(75, 307);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 20);
            this.txt_SDT.TabIndex = 2;
            // 
            // txt_tenPH
            // 
            this.txt_tenPH.Location = new System.Drawing.Point(75, 268);
            this.txt_tenPH.Name = "txt_tenPH";
            this.txt_tenPH.Size = new System.Drawing.Size(200, 20);
            this.txt_tenPH.TabIndex = 1;
            // 
            // txt_nameHS
            // 
            this.txt_nameHS.Location = new System.Drawing.Point(75, 52);
            this.txt_nameHS.Name = "txt_nameHS";
            this.txt_nameHS.Size = new System.Drawing.Size(200, 20);
            this.txt_nameHS.TabIndex = 0;
            // 
            // tabPageDKXL
            // 
            this.tabPageDKXL.Controls.Add(this.tabControl_ClassRegister);
            this.tabPageDKXL.Location = new System.Drawing.Point(4, 22);
            this.tabPageDKXL.Name = "tabPageDKXL";
            this.tabPageDKXL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDKXL.Size = new System.Drawing.Size(792, 379);
            this.tabPageDKXL.TabIndex = 1;
            this.tabPageDKXL.Text = "Đăng ký xếp lớp";
            this.tabPageDKXL.UseVisualStyleBackColor = true;
            // 
            // tabControl_ClassRegister
            // 
            this.tabControl_ClassRegister.Controls.Add(this.tabPageHS);
            this.tabControl_ClassRegister.Controls.Add(this.tabPageGVCN);
            this.tabControl_ClassRegister.Location = new System.Drawing.Point(0, 0);
            this.tabControl_ClassRegister.Name = "tabControl_ClassRegister";
            this.tabControl_ClassRegister.SelectedIndex = 0;
            this.tabControl_ClassRegister.Size = new System.Drawing.Size(796, 383);
            this.tabControl_ClassRegister.TabIndex = 0;
            // 
            // tabPageHS
            // 
            this.tabPageHS.Controls.Add(this.btn_OK);
            this.tabPageHS.Controls.Add(this.dataGridView_Lop);
            this.tabPageHS.Controls.Add(this.dataGridView_HS);
            this.tabPageHS.Controls.Add(this.btn_searchLop);
            this.tabPageHS.Controls.Add(this.btn_searchHS);
            this.tabPageHS.Controls.Add(this.txt_searchLop);
            this.tabPageHS.Controls.Add(this.txt_searchHS);
            this.tabPageHS.Controls.Add(this.lbl_DSLop);
            this.tabPageHS.Controls.Add(this.lbl_DSHS);
            this.tabPageHS.Location = new System.Drawing.Point(4, 22);
            this.tabPageHS.Name = "tabPageHS";
            this.tabPageHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHS.Size = new System.Drawing.Size(788, 357);
            this.tabPageHS.TabIndex = 0;
            this.tabPageHS.Text = "Đăng ký cho học sinh";
            this.tabPageHS.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(355, 157);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 42);
            this.btn_OK.TabIndex = 23;
            this.btn_OK.Text = "Chọn";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop.Location = new System.Drawing.Point(455, 42);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.Size = new System.Drawing.Size(325, 311);
            this.dataGridView_Lop.TabIndex = 22;
            // 
            // dataGridView_HS
            // 
            this.dataGridView_HS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HS.Location = new System.Drawing.Point(9, 43);
            this.dataGridView_HS.Name = "dataGridView_HS";
            this.dataGridView_HS.Size = new System.Drawing.Size(328, 310);
            this.dataGridView_HS.TabIndex = 21;
            // 
            // btn_searchLop
            // 
            this.btn_searchLop.Location = new System.Drawing.Point(734, 17);
            this.btn_searchLop.Name = "btn_searchLop";
            this.btn_searchLop.Size = new System.Drawing.Size(48, 21);
            this.btn_searchLop.TabIndex = 20;
            this.btn_searchLop.Text = "search";
            this.btn_searchLop.UseVisualStyleBackColor = true;
            this.btn_searchLop.Click += new System.EventHandler(this.btn_searchLop_Click);
            // 
            // btn_searchHS
            // 
            this.btn_searchHS.Location = new System.Drawing.Point(291, 17);
            this.btn_searchHS.Name = "btn_searchHS";
            this.btn_searchHS.Size = new System.Drawing.Size(48, 20);
            this.btn_searchHS.TabIndex = 19;
            this.btn_searchHS.Text = "search";
            this.btn_searchHS.UseVisualStyleBackColor = true;
            this.btn_searchHS.Click += new System.EventHandler(this.btn_searchHS_Click);
            // 
            // txt_searchLop
            // 
            this.txt_searchLop.Location = new System.Drawing.Point(644, 17);
            this.txt_searchLop.Name = "txt_searchLop";
            this.txt_searchLop.Size = new System.Drawing.Size(84, 20);
            this.txt_searchLop.TabIndex = 18;
            // 
            // txt_searchHS
            // 
            this.txt_searchHS.Location = new System.Drawing.Point(201, 17);
            this.txt_searchHS.Name = "txt_searchHS";
            this.txt_searchHS.Size = new System.Drawing.Size(84, 20);
            this.txt_searchHS.TabIndex = 17;
            // 
            // lbl_DSLop
            // 
            this.lbl_DSLop.AutoSize = true;
            this.lbl_DSLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSLop.Location = new System.Drawing.Point(464, 15);
            this.lbl_DSLop.Name = "lbl_DSLop";
            this.lbl_DSLop.Size = new System.Drawing.Size(140, 24);
            this.lbl_DSLop.TabIndex = 16;
            this.lbl_DSLop.Text = "Danh Sách Lớp";
            // 
            // lbl_DSHS
            // 
            this.lbl_DSHS.AutoSize = true;
            this.lbl_DSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSHS.Location = new System.Drawing.Point(6, 15);
            this.lbl_DSHS.Name = "lbl_DSHS";
            this.lbl_DSHS.Size = new System.Drawing.Size(186, 24);
            this.lbl_DSHS.TabIndex = 15;
            this.lbl_DSHS.Text = "Danh Sách Học Sinh";
            // 
            // tabPageGVCN
            // 
            this.tabPageGVCN.Controls.Add(this.btn_OK1);
            this.tabPageGVCN.Controls.Add(this.dataGridView_Lop1);
            this.tabPageGVCN.Controls.Add(this.dataGridView_GV);
            this.tabPageGVCN.Controls.Add(this.btn_Lop1);
            this.tabPageGVCN.Controls.Add(this.btn_searchGV);
            this.tabPageGVCN.Controls.Add(this.textBox1);
            this.tabPageGVCN.Controls.Add(this.txt_searchGV);
            this.tabPageGVCN.Controls.Add(this.lbl_DSLop1);
            this.tabPageGVCN.Controls.Add(this.lbl_DSGV);
            this.tabPageGVCN.Location = new System.Drawing.Point(4, 22);
            this.tabPageGVCN.Name = "tabPageGVCN";
            this.tabPageGVCN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGVCN.Size = new System.Drawing.Size(788, 357);
            this.tabPageGVCN.TabIndex = 1;
            this.tabPageGVCN.Text = "Đăng ký giáo viên chủ nhiệm";
            this.tabPageGVCN.UseVisualStyleBackColor = true;
            // 
            // btn_OK1
            // 
            this.btn_OK1.Location = new System.Drawing.Point(355, 157);
            this.btn_OK1.Name = "btn_OK1";
            this.btn_OK1.Size = new System.Drawing.Size(75, 42);
            this.btn_OK1.TabIndex = 17;
            this.btn_OK1.Text = "Chọn";
            this.btn_OK1.UseVisualStyleBackColor = true;
            this.btn_OK1.Click += new System.EventHandler(this.btn_OK1_Click);
            // 
            // dataGridView_Lop1
            // 
            this.dataGridView_Lop1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lop1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Lop1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop1.Location = new System.Drawing.Point(455, 42);
            this.dataGridView_Lop1.Name = "dataGridView_Lop1";
            this.dataGridView_Lop1.Size = new System.Drawing.Size(325, 304);
            this.dataGridView_Lop1.TabIndex = 16;
            // 
            // dataGridView_GV
            // 
            this.dataGridView_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GV.Location = new System.Drawing.Point(9, 43);
            this.dataGridView_GV.Name = "dataGridView_GV";
            this.dataGridView_GV.Size = new System.Drawing.Size(328, 304);
            this.dataGridView_GV.TabIndex = 15;
            // 
            // btn_Lop1
            // 
            this.btn_Lop1.Location = new System.Drawing.Point(732, 17);
            this.btn_Lop1.Name = "btn_Lop1";
            this.btn_Lop1.Size = new System.Drawing.Size(49, 20);
            this.btn_Lop1.TabIndex = 14;
            this.btn_Lop1.Text = "search";
            this.btn_Lop1.UseVisualStyleBackColor = true;
            this.btn_Lop1.Click += new System.EventHandler(this.btn_Lop1_Click);
            // 
            // btn_searchGV
            // 
            this.btn_searchGV.Location = new System.Drawing.Point(285, 17);
            this.btn_searchGV.Name = "btn_searchGV";
            this.btn_searchGV.Size = new System.Drawing.Size(49, 20);
            this.btn_searchGV.TabIndex = 13;
            this.btn_searchGV.Text = "search";
            this.btn_searchGV.UseVisualStyleBackColor = true;
            this.btn_searchGV.Click += new System.EventHandler(this.btn_searchGV_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 12;
            // 
            // txt_searchGV
            // 
            this.txt_searchGV.Location = new System.Drawing.Point(194, 17);
            this.txt_searchGV.Name = "txt_searchGV";
            this.txt_searchGV.Size = new System.Drawing.Size(85, 20);
            this.txt_searchGV.TabIndex = 11;
            // 
            // lbl_DSLop1
            // 
            this.lbl_DSLop1.AutoSize = true;
            this.lbl_DSLop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSLop1.Location = new System.Drawing.Point(464, 15);
            this.lbl_DSLop1.Name = "lbl_DSLop1";
            this.lbl_DSLop1.Size = new System.Drawing.Size(140, 24);
            this.lbl_DSLop1.TabIndex = 10;
            this.lbl_DSLop1.Text = "Danh Sách Lớp";
            // 
            // lbl_DSGV
            // 
            this.lbl_DSGV.AutoSize = true;
            this.lbl_DSGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSGV.Location = new System.Drawing.Point(6, 15);
            this.lbl_DSGV.Name = "lbl_DSGV";
            this.lbl_DSGV.Size = new System.Drawing.Size(191, 24);
            this.lbl_DSGV.TabIndex = 9;
            this.lbl_DSGV.Text = "Danh Sách Giáo Viên";
            // 
            // tabPageChuyenTruong
            // 
            this.tabPageChuyenTruong.Controls.Add(this.btn_Create);
            this.tabPageChuyenTruong.Controls.Add(this.dataGridView_HS1);
            this.tabPageChuyenTruong.Controls.Add(this.lbl_title1);
            this.tabPageChuyenTruong.Location = new System.Drawing.Point(4, 22);
            this.tabPageChuyenTruong.Name = "tabPageChuyenTruong";
            this.tabPageChuyenTruong.Size = new System.Drawing.Size(792, 379);
            this.tabPageChuyenTruong.TabIndex = 2;
            this.tabPageChuyenTruong.Text = "Mẫu đơn chuyển trường";
            this.tabPageChuyenTruong.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(322, 297);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(149, 49);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Tạo đơn xin chuyển trường";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // dataGridView_HS1
            // 
            this.dataGridView_HS1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HS1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HS1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HS1.Location = new System.Drawing.Point(49, 45);
            this.dataGridView_HS1.Name = "dataGridView_HS1";
            this.dataGridView_HS1.Size = new System.Drawing.Size(699, 246);
            this.dataGridView_HS1.TabIndex = 3;
            // 
            // lbl_title1
            // 
            this.lbl_title1.AutoSize = true;
            this.lbl_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title1.Location = new System.Drawing.Point(281, 17);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(211, 25);
            this.lbl_title1.TabIndex = 2;
            this.lbl_title1.Text = "Danh Sách Học Sinh";
            // 
            // tabPageTotNghiep
            // 
            this.tabPageTotNghiep.Controls.Add(this.btn_Create2);
            this.tabPageTotNghiep.Controls.Add(this.lbl_title2);
            this.tabPageTotNghiep.Controls.Add(this.dataGridView_HS2);
            this.tabPageTotNghiep.Location = new System.Drawing.Point(4, 22);
            this.tabPageTotNghiep.Name = "tabPageTotNghiep";
            this.tabPageTotNghiep.Size = new System.Drawing.Size(792, 379);
            this.tabPageTotNghiep.TabIndex = 3;
            this.tabPageTotNghiep.Text = "Mẫu giấy tốt nghiệp";
            this.tabPageTotNghiep.UseVisualStyleBackColor = true;
            // 
            // btn_Create2
            // 
            this.btn_Create2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create2.Location = new System.Drawing.Point(322, 297);
            this.btn_Create2.Name = "btn_Create2";
            this.btn_Create2.Size = new System.Drawing.Size(149, 49);
            this.btn_Create2.TabIndex = 2;
            this.btn_Create2.Text = "Tạo giấy tốt nghiệp";
            this.btn_Create2.UseVisualStyleBackColor = true;
            this.btn_Create2.Click += new System.EventHandler(this.btn_Create2_Click);
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.Location = new System.Drawing.Point(281, 17);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(211, 25);
            this.lbl_title2.TabIndex = 1;
            this.lbl_title2.Text = "Danh Sách Học Sinh";
            // 
            // dataGridView_HS2
            // 
            this.dataGridView_HS2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HS2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HS2.Location = new System.Drawing.Point(49, 45);
            this.dataGridView_HS2.Name = "dataGridView_HS2";
            this.dataGridView_HS2.Size = new System.Drawing.Size(699, 246);
            this.dataGridView_HS2.TabIndex = 0;
            // 
            // linkLabel_Logoff
            // 
            this.linkLabel_Logoff.AutoSize = true;
            this.linkLabel_Logoff.Location = new System.Drawing.Point(737, 9);
            this.linkLabel_Logoff.Name = "linkLabel_Logoff";
            this.linkLabel_Logoff.Size = new System.Drawing.Size(56, 13);
            this.linkLabel_Logoff.TabIndex = 4;
            this.linkLabel_Logoff.TabStop = true;
            this.linkLabel_Logoff.Text = "Đăng xuất";
            this.linkLabel_Logoff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Logoff_LinkClicked);
            // 
            // FormManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_Logoff);
            this.Controls.Add(this.tabControl_mainMenu);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManagerMenu";
            this.Text = "Nhân Viên Quản Lý";
            this.tabControl_mainMenu.ResumeLayout(false);
            this.tabPageDKNH.ResumeLayout(false);
            this.tabPageDKNH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHS)).EndInit();
            this.tabPageDKXL.ResumeLayout(false);
            this.tabControl_ClassRegister.ResumeLayout(false);
            this.tabPageHS.ResumeLayout(false);
            this.tabPageHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS)).EndInit();
            this.tabPageGVCN.ResumeLayout(false);
            this.tabPageGVCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GV)).EndInit();
            this.tabPageChuyenTruong.ResumeLayout(false);
            this.tabPageChuyenTruong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS1)).EndInit();
            this.tabPageTotNghiep.ResumeLayout(false);
            this.tabPageTotNghiep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContainerControl containerControl;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TabControl tabControl_mainMenu;
        private System.Windows.Forms.TabPage tabPageDKNH;
        private System.Windows.Forms.TabPage tabPageDKXL;
        private System.Windows.Forms.TabPage tabPageChuyenTruong;
        private System.Windows.Forms.TabPage tabPageTotNghiep;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.DataGridView dataGridView_HS1;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Button btn_Create2;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.DataGridView dataGridView_HS2;
        private System.Windows.Forms.TabControl tabControl_ClassRegister;
        private System.Windows.Forms.TabPage tabPageHS;
        private System.Windows.Forms.TabPage tabPageGVCN;
        private System.Windows.Forms.Button btn_searchLop;
        private System.Windows.Forms.Button btn_searchHS;
        private System.Windows.Forms.TextBox txt_searchLop;
        private System.Windows.Forms.TextBox txt_searchHS;
        private System.Windows.Forms.Label lbl_DSLop;
        private System.Windows.Forms.Label lbl_DSHS;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.DataGridView dataGridView_HS;
        private System.Windows.Forms.Button btn_Lop1;
        private System.Windows.Forms.Button btn_searchGV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_searchGV;
        private System.Windows.Forms.Label lbl_DSLop1;
        private System.Windows.Forms.Label lbl_DSGV;
        private System.Windows.Forms.Button btn_OK1;
        private System.Windows.Forms.DataGridView dataGridView_Lop1;
        private System.Windows.Forms.DataGridView dataGridView_GV;
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
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.Label lbl_titleDSHS;
        private System.Windows.Forms.DataGridView dataGridView_DSHS;
        private System.Windows.Forms.LinkLabel linkLabel_Logoff;
    }
}