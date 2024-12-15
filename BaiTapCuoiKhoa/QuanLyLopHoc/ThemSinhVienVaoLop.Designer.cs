namespace BaiTapCuoiKhoa
{
    partial class ThemSinhVienVaoLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhsachmonhoc = new System.Windows.Forms.DataGridView();
            this.ma_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnxoasinhvienkhoilop = new System.Windows.Forms.Button();
            this.btnthemsinhvienvaolop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.danhsachlophoc = new System.Windows.Forms.DataGridView();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dssinhvien = new System.Windows.Forms.DataGridView();
            this.ma_sinh_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhsachsinhvientronglop = new System.Windows.Forms.DataGridView();
            this.lbldanhsachsvtronglop = new System.Windows.Forms.Label();
            this.ma_sinh_vien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachmonhoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachlophoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientronglop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhsachmonhoc);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Môn Học";
            // 
            // danhsachmonhoc
            // 
            this.danhsachmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mon,
            this.ten_mon});
            this.danhsachmonhoc.Location = new System.Drawing.Point(15, 26);
            this.danhsachmonhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.danhsachmonhoc.Name = "danhsachmonhoc";
            this.danhsachmonhoc.RowHeadersWidth = 51;
            this.danhsachmonhoc.RowTemplate.Height = 24;
            this.danhsachmonhoc.Size = new System.Drawing.Size(352, 177);
            this.danhsachmonhoc.TabIndex = 0;
            this.danhsachmonhoc.SelectionChanged += new System.EventHandler(this.danhsachmonhoc_SelectionChanged);
            // 
            // ma_mon
            // 
            this.ma_mon.DataPropertyName = "ma_mon";
            this.ma_mon.HeaderText = "Mã môn";
            this.ma_mon.MinimumWidth = 6;
            this.ma_mon.Name = "ma_mon";
            this.ma_mon.Width = 125;
            // 
            // ten_mon
            // 
            this.ten_mon.DataPropertyName = "ten_mon";
            this.ten_mon.HeaderText = "Tên môn";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            this.ten_mon.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnxoasinhvienkhoilop);
            this.panel1.Controls.Add(this.btnthemsinhvienvaolop);
            this.panel1.Location = new System.Drawing.Point(424, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 569);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(13, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Danh Sách Sinh Viên Đã Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnxoasinhvienkhoilop
            // 
            this.btnxoasinhvienkhoilop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoasinhvienkhoilop.Location = new System.Drawing.Point(13, 217);
            this.btnxoasinhvienkhoilop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoasinhvienkhoilop.Name = "btnxoasinhvienkhoilop";
            this.btnxoasinhvienkhoilop.Size = new System.Drawing.Size(108, 69);
            this.btnxoasinhvienkhoilop.TabIndex = 1;
            this.btnxoasinhvienkhoilop.Text = "Xóa Sinh Viên Khỏi Lớp";
            this.btnxoasinhvienkhoilop.UseVisualStyleBackColor = true;
            this.btnxoasinhvienkhoilop.Click += new System.EventHandler(this.btnxoasinhvienkhoilop_Click);
            // 
            // btnthemsinhvienvaolop
            // 
            this.btnthemsinhvienvaolop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemsinhvienvaolop.Location = new System.Drawing.Point(13, 70);
            this.btnthemsinhvienvaolop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthemsinhvienvaolop.Name = "btnthemsinhvienvaolop";
            this.btnthemsinhvienvaolop.Size = new System.Drawing.Size(108, 69);
            this.btnthemsinhvienvaolop.TabIndex = 0;
            this.btnthemsinhvienvaolop.Text = "Thêm Sinh Viên Vào Lớp";
            this.btnthemsinhvienvaolop.UseVisualStyleBackColor = true;
            this.btnthemsinhvienvaolop.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.danhsachlophoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(379, 431);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Lớp Học";
            // 
            // danhsachlophoc
            // 
            this.danhsachlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_lop,
            this.ma_lop_code,
            this.ten_lop,
            this.Column4});
            this.danhsachlophoc.Location = new System.Drawing.Point(13, 34);
            this.danhsachlophoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.danhsachlophoc.Name = "danhsachlophoc";
            this.danhsachlophoc.RowHeadersWidth = 51;
            this.danhsachlophoc.RowTemplate.Height = 24;
            this.danhsachlophoc.Size = new System.Drawing.Size(352, 390);
            this.danhsachlophoc.TabIndex = 1;
            this.danhsachlophoc.SelectionChanged += new System.EventHandler(this.danhsachlophoc_SelectionChanged);
            // 
            // ma_lop
            // 
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "STT";
            this.ma_lop.MinimumWidth = 6;
            this.ma_lop.Name = "ma_lop";
            this.ma_lop.Width = 125;
            // 
            // ma_lop_code
            // 
            this.ma_lop_code.DataPropertyName = "ma_lop_code";
            this.ma_lop_code.HeaderText = "Mã lớp";
            this.ma_lop_code.MinimumWidth = 6;
            this.ma_lop_code.Name = "ma_lop_code";
            this.ma_lop_code.Width = 125;
            // 
            // ten_lop
            // 
            this.ten_lop.DataPropertyName = "ten_lop";
            this.ten_lop.HeaderText = "Tên lớp";
            this.ten_lop.MinimumWidth = 6;
            this.ten_lop.Name = "ten_lop";
            this.ten_lop.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "si_so";
            this.Column4.HeaderText = "Sĩ số";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dssinhvien);
            this.groupBox3.Location = new System.Drawing.Point(608, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(571, 203);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sinh Viên";
            // 
            // dssinhvien
            // 
            this.dssinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sinh_vien,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dssinhvien.Location = new System.Drawing.Point(13, 27);
            this.dssinhvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dssinhvien.Name = "dssinhvien";
            this.dssinhvien.RowHeadersWidth = 51;
            this.dssinhvien.RowTemplate.Height = 24;
            this.dssinhvien.Size = new System.Drawing.Size(545, 158);
            this.dssinhvien.TabIndex = 0;
            // 
            // ma_sinh_vien
            // 
            this.ma_sinh_vien.DataPropertyName = "ma_sinh_vien";
            this.ma_sinh_vien.HeaderText = "STT";
            this.ma_sinh_vien.MinimumWidth = 6;
            this.ma_sinh_vien.Name = "ma_sinh_vien";
            this.ma_sinh_vien.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ho_ten";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ma_sinh_vien_code";
            this.Column3.HeaderText = "Mã sinh viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "so_dien_thoai";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "chuyen_nganh";
            this.Column7.HeaderText = "Chuyên ngành";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "gioi_tinh";
            this.Column8.HeaderText = "Giới tính";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ngay_sinh";
            this.Column9.HeaderText = "Ngày sinh";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "dia_chi";
            this.Column10.HeaderText = "Địa chỉ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "khoa_hoc";
            this.Column11.HeaderText = "Khóa học";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "so_can_cuoc";
            this.Column12.HeaderText = "Số căn cước công dân";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // danhsachsinhvientronglop
            // 
            this.danhsachsinhvientronglop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsinhvientronglop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sinh_vien1,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.danhsachsinhvientronglop.Location = new System.Drawing.Point(617, 295);
            this.danhsachsinhvientronglop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.danhsachsinhvientronglop.Name = "danhsachsinhvientronglop";
            this.danhsachsinhvientronglop.RowHeadersWidth = 51;
            this.danhsachsinhvientronglop.RowTemplate.Height = 24;
            this.danhsachsinhvientronglop.Size = new System.Drawing.Size(561, 366);
            this.danhsachsinhvientronglop.TabIndex = 4;
            // 
            // lbldanhsachsvtronglop
            // 
            this.lbldanhsachsvtronglop.AutoSize = true;
            this.lbldanhsachsvtronglop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachsvtronglop.Location = new System.Drawing.Point(617, 263);
            this.lbldanhsachsvtronglop.Name = "lbldanhsachsvtronglop";
            this.lbldanhsachsvtronglop.Size = new System.Drawing.Size(405, 29);
            this.lbldanhsachsvtronglop.TabIndex = 5;
            this.lbldanhsachsvtronglop.Text = "Danh Sách Sinh Viên Trong Lớp : ";
            // 
            // ma_sinh_vien1
            // 
            this.ma_sinh_vien1.DataPropertyName = "ma_sinh_vien";
            this.ma_sinh_vien1.HeaderText = "STT";
            this.ma_sinh_vien1.MinimumWidth = 6;
            this.ma_sinh_vien1.Name = "ma_sinh_vien1";
            this.ma_sinh_vien1.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "ho_ten";
            this.Column13.HeaderText = "Họ tên";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "ma_sinh_vien_code";
            this.Column14.HeaderText = "Mã sinh viên";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "email";
            this.Column15.HeaderText = "Email";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "so_dien_thoai";
            this.Column16.HeaderText = "Số điện thoại";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "chuyen_nganh";
            this.Column17.HeaderText = "Chuyên ngành";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "gioi_tinh";
            this.Column18.HeaderText = "Giới tính";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "ngay_sinh";
            this.Column19.HeaderText = "Ngày sinh";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "dia_chi";
            this.Column20.HeaderText = "Địa chỉ";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.Width = 125;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "khoa_hoc";
            this.Column21.HeaderText = "Khóa học";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            this.Column21.Width = 125;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "so_can_cuoc";
            this.Column22.HeaderText = "Số căn cước công dân";
            this.Column22.MinimumWidth = 6;
            this.Column22.Name = "Column22";
            this.Column22.Width = 125;
            // 
            // ThemSinhVienVaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1191, 679);
            this.Controls.Add(this.lbldanhsachsvtronglop);
            this.Controls.Add(this.danhsachsinhvientronglop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemSinhVienVaoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sinh Viên Vào Lớp Học";
            this.Load += new System.EventHandler(this.ThemSinhVienVaoLop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachmonhoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachlophoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientronglop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnthemsinhvienvaolop;
        private System.Windows.Forms.Button btnxoasinhvienkhoilop;
        private System.Windows.Forms.DataGridView danhsachmonhoc;
        private System.Windows.Forms.DataGridView danhsachlophoc;
        private System.Windows.Forms.DataGridView dssinhvien;
        private System.Windows.Forms.DataGridView danhsachsinhvientronglop;
        private System.Windows.Forms.Label lbldanhsachsvtronglop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sinh_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sinh_vien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
    }
}