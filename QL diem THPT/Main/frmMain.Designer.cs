namespace QL_diem_THPT.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TapHocSinh = new System.Windows.Forms.TabPage();
            this.labHienThiTTHS = new System.Windows.Forms.Label();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnSuaHS = new System.Windows.Forms.Button();
            this.btnThemHS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDShocsinh = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSGiaoVien = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSualop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            this.tapThoatMain = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoatMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TapHocSinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDShocsinh)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoVien)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 718);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(996, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ HỌC SINH - GIÁO VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TapHocSinh);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tapThoatMain);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 647);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.ptb2);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mở Đầu";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TapHocSinh
            // 
            this.TapHocSinh.BackColor = System.Drawing.Color.Silver;
            this.TapHocSinh.Controls.Add(this.labHienThiTTHS);
            this.TapHocSinh.Controls.Add(this.btnXoaHS);
            this.TapHocSinh.Controls.Add(this.btnSuaHS);
            this.TapHocSinh.Controls.Add(this.btnThemHS);
            this.TapHocSinh.Controls.Add(this.groupBox1);
            this.TapHocSinh.Location = new System.Drawing.Point(4, 32);
            this.TapHocSinh.Name = "TapHocSinh";
            this.TapHocSinh.Padding = new System.Windows.Forms.Padding(3);
            this.TapHocSinh.Size = new System.Drawing.Size(1207, 611);
            this.TapHocSinh.TabIndex = 1;
            this.TapHocSinh.Text = "QL Học sinh";
            this.TapHocSinh.Click += new System.EventHandler(this.TapHocSinh_Click);
            // 
            // labHienThiTTHS
            // 
            this.labHienThiTTHS.AutoSize = true;
            this.labHienThiTTHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labHienThiTTHS.ForeColor = System.Drawing.Color.Red;
            this.labHienThiTTHS.Location = new System.Drawing.Point(920, 71);
            this.labHienThiTTHS.Name = "labHienThiTTHS";
            this.labHienThiTTHS.Size = new System.Drawing.Size(263, 23);
            this.labHienThiTTHS.TabIndex = 4;
            this.labHienThiTTHS.Text = ">>Hiển thị thông tin chi tiết<<";
            this.labHienThiTTHS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labHienThiTTHS.Click += new System.EventHandler(this.labHienThiTTHS_Click);
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHS.Location = new System.Drawing.Point(824, 19);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(163, 34);
            this.btnXoaHS.TabIndex = 3;
            this.btnXoaHS.Text = "Xóa";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnSuaHS
            // 
            this.btnSuaHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaHS.Location = new System.Drawing.Point(530, 19);
            this.btnSuaHS.Name = "btnSuaHS";
            this.btnSuaHS.Size = new System.Drawing.Size(163, 32);
            this.btnSuaHS.TabIndex = 2;
            this.btnSuaHS.Text = "Sửa";
            this.btnSuaHS.UseVisualStyleBackColor = true;
            this.btnSuaHS.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemHS
            // 
            this.btnThemHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHS.Location = new System.Drawing.Point(231, 19);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(163, 34);
            this.btnThemHS.TabIndex = 1;
            this.btnThemHS.Text = "Thêm";
            this.btnThemHS.UseVisualStyleBackColor = true;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDShocsinh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvDShocsinh
            // 
            this.dgvDShocsinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDShocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDShocsinh.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dgvDShocsinh.Location = new System.Drawing.Point(4, 30);
            this.dgvDShocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDShocsinh.Name = "dgvDShocsinh";
            this.dgvDShocsinh.RowTemplate.Height = 24;
            this.dgvDShocsinh.Size = new System.Drawing.Size(1161, 464);
            this.dgvDShocsinh.TabIndex = 0;
            this.dgvDShocsinh.UseWaitCursor = true;
            this.dgvDShocsinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDShocsinh_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.btnXoaGV);
            this.tabPage3.Controls.Add(this.btnSuaGV);
            this.tabPage3.Controls.Add(this.btnThemGV);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1207, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QL Giáo viên";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGV.Location = new System.Drawing.Point(812, 24);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(163, 30);
            this.btnXoaGV.TabIndex = 7;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaGV.Location = new System.Drawing.Point(537, 24);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(163, 30);
            this.btnSuaGV.TabIndex = 6;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGV.Location = new System.Drawing.Point(242, 24);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(163, 30);
            this.btnThemGV.TabIndex = 5;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSGiaoVien);
            this.groupBox2.Location = new System.Drawing.Point(23, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 494);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvDSGiaoVien
            // 
            this.dgvDSGiaoVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGiaoVien.Location = new System.Drawing.Point(0, 23);
            this.dgvDSGiaoVien.Name = "dgvDSGiaoVien";
            this.dgvDSGiaoVien.RowTemplate.Height = 24;
            this.dgvDSGiaoVien.Size = new System.Drawing.Size(1161, 475);
            this.dgvDSGiaoVien.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.btnXoaLop);
            this.tabPage4.Controls.Add(this.btnSualop);
            this.tabPage4.Controls.Add(this.btnThemLop);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1207, 611);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "QL lớp học";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLop.Location = new System.Drawing.Point(865, 24);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(163, 34);
            this.btnXoaLop.TabIndex = 7;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSualop
            // 
            this.btnSualop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSualop.Location = new System.Drawing.Point(534, 24);
            this.btnSualop.Name = "btnSualop";
            this.btnSualop.Size = new System.Drawing.Size(163, 34);
            this.btnSualop.TabIndex = 6;
            this.btnSualop.Text = "Sửa";
            this.btnSualop.UseVisualStyleBackColor = true;
            this.btnSualop.Click += new System.EventHandler(this.btnSualop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLop.Location = new System.Drawing.Point(220, 24);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(163, 34);
            this.btnThemLop.TabIndex = 5;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSLop);
            this.groupBox3.Location = new System.Drawing.Point(23, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1161, 494);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Location = new System.Drawing.Point(0, 23);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.RowTemplate.Height = 24;
            this.dgvDSLop.Size = new System.Drawing.Size(1161, 475);
            this.dgvDSLop.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Controls.Add(this.btnXoaMH);
            this.tabPage5.Controls.Add(this.btnSuaMH);
            this.tabPage5.Controls.Add(this.btnThemMH);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1207, 611);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "QL Môn học";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ptb1);
            this.panel4.Location = new System.Drawing.Point(118, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 353);
            this.panel4.TabIndex = 8;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMH.Location = new System.Drawing.Point(615, 509);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(163, 50);
            this.btnXoaMH.TabIndex = 7;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMH.Location = new System.Drawing.Point(337, 509);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(163, 50);
            this.btnSuaMH.TabIndex = 6;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMH.Location = new System.Drawing.Point(50, 509);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(163, 50);
            this.btnThemMH.TabIndex = 5;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSMonHoc);
            this.groupBox4.Location = new System.Drawing.Point(862, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 580);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Location = new System.Drawing.Point(0, 29);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.RowTemplate.Height = 24;
            this.dgvDSMonHoc.Size = new System.Drawing.Size(326, 551);
            this.dgvDSMonHoc.TabIndex = 0;
            // 
            // tapThoatMain
            // 
            this.tapThoatMain.Location = new System.Drawing.Point(4, 32);
            this.tapThoatMain.Name = "tapThoatMain";
            this.tapThoatMain.Padding = new System.Windows.Forms.Padding(3);
            this.tapThoatMain.Size = new System.Drawing.Size(1207, 611);
            this.tapThoatMain.TabIndex = 5;
            this.tapThoatMain.Text = "Phân công";
            this.tapThoatMain.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 611);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Thoát";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnThoatMain);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(24, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 560);
            this.panel3.TabIndex = 0;
            // 
            // btnThoatMain
            // 
            this.btnThoatMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThoatMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoatMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatMain.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatMain.Location = new System.Drawing.Point(899, 40);
            this.btnThoatMain.Name = "btnThoatMain";
            this.btnThoatMain.Size = new System.Drawing.Size(123, 35);
            this.btnThoatMain.TabIndex = 13;
            this.btnThoatMain.Text = "Thoát";
            this.btnThoatMain.UseVisualStyleBackColor = false;
            this.btnThoatMain.Click += new System.EventHandler(this.btnThoatMain_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "*Chú ý: Người dùng vui lòng ấn Thoát khi không làm việc nữa để trở về màn hình đă" +
    "ng nhập";
            // 
            // ptb2
            // 
            this.ptb2.BackColor = System.Drawing.Color.White;
            this.ptb2.Location = new System.Drawing.Point(17, 19);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(1168, 571);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 0;
            this.ptb2.TabStop = false;
            this.ptb2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptb1
            // 
            this.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb1.InitialImage = null;
            this.ptb1.Location = new System.Drawing.Point(3, 3);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(473, 350);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            this.ptb1.Click += new System.EventHandler(this.ptb1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 734);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Hệ Thống";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TapHocSinh.ResumeLayout(false);
            this.TapHocSinh.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDShocsinh)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaoVien)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TapHocSinh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDShocsinh;
        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnSuaHS;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSGiaoVien;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSualop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
        private System.Windows.Forms.TabPage tapThoatMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labHienThiTTHS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThoatMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
    }
}