using System;
using System.Windows.Forms;

namespace BaiTapCuoiKhoa
{
    partial class DanhSachSinhVien
    {
        // Các điều khiển cho form
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoCanCuoc;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;

        // Các biến Placeholder
        private const string placeholderMaSinhVien = "Mã sinh viên";
        private const string placeholderHoTen = "Họ và tên";
        private const string placeholderEmail = "Email";
        private const string placeholderSoDienThoai = "Số điện thoại";
        private const string placeholderDiaChi = "Địa chỉ";
        private const string placeholderSoCanCuoc = "Số căn cước công dân";

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSinhVien));
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sinh_vien_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyen_nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_can_cuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoCanCuoc = new System.Windows.Forms.TextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grgioitinh = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btndanhsachsinhviendaxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.grgioitinh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeight = 29;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.ma_sinh_vien_code,
            this.ho_ten,
            this.email,
            this.so_dien_thoai,
            this.chuyen_nganh,
            this.gioi_tinh,
            this.ngay_sinh,
            this.dia_chi,
            this.khoa_hoc,
            this.so_can_cuoc,
            this.trang_thai});
            this.dgvSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 430);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(976, 250);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "ma_sinh_vien";
            this.stt.HeaderText = "Số Thứ Tự";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // ma_sinh_vien_code
            // 
            this.ma_sinh_vien_code.DataPropertyName = "ma_sinh_vien_code";
            this.ma_sinh_vien_code.HeaderText = "Mã Sinh Viên";
            this.ma_sinh_vien_code.MinimumWidth = 6;
            this.ma_sinh_vien_code.Name = "ma_sinh_vien_code";
            this.ma_sinh_vien_code.ReadOnly = true;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ Tên";
            this.ho_ten.MinimumWidth = 6;
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.DataPropertyName = "so_dien_thoai";
            this.so_dien_thoai.HeaderText = "Số Điện Thoại";
            this.so_dien_thoai.MinimumWidth = 6;
            this.so_dien_thoai.Name = "so_dien_thoai";
            this.so_dien_thoai.ReadOnly = true;
            // 
            // chuyen_nganh
            // 
            this.chuyen_nganh.DataPropertyName = "chuyen_nganh";
            this.chuyen_nganh.HeaderText = "Chuyên Ngành";
            this.chuyen_nganh.MinimumWidth = 6;
            this.chuyen_nganh.Name = "chuyen_nganh";
            this.chuyen_nganh.ReadOnly = true;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới Tính";
            this.gioi_tinh.MinimumWidth = 6;
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày Sinh";
            this.ngay_sinh.MinimumWidth = 6;
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa Chỉ";
            this.dia_chi.MinimumWidth = 6;
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // khoa_hoc
            // 
            this.khoa_hoc.DataPropertyName = "khoa_hoc";
            this.khoa_hoc.HeaderText = "Khóa Học";
            this.khoa_hoc.MinimumWidth = 6;
            this.khoa_hoc.Name = "khoa_hoc";
            this.khoa_hoc.ReadOnly = true;
            // 
            // so_can_cuoc
            // 
            this.so_can_cuoc.DataPropertyName = "so_can_cuoc";
            this.so_can_cuoc.HeaderText = "Số Căn Cước";
            this.so_can_cuoc.MinimumWidth = 6;
            this.so_can_cuoc.Name = "so_can_cuoc";
            this.so_can_cuoc.ReadOnly = true;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng Thái";
            this.trang_thai.MinimumWidth = 6;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaSinhVien.ForeColor = System.Drawing.Color.Gray;
            this.txtMaSinhVien.Location = new System.Drawing.Point(150, 103);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(200, 22);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHoTen.ForeColor = System.Drawing.Color.Gray;
            this.txtHoTen.Location = new System.Drawing.Point(150, 143);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(150, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.txtSoDienThoai.Location = new System.Drawing.Point(150, 223);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 22);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChuyenNganh.Items.AddRange(new object[] {
            "Khoa học máy tính",
            "Công nghệ thông tin",
            "Kỹ thuật phần mềm",
            "Hệ thống thông tin"});
            this.cboChuyenNganh.Location = new System.Drawing.Point(150, 263);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(200, 24);
            this.cboChuyenNganh.TabIndex = 5;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboKhoaHoc.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboKhoaHoc.Location = new System.Drawing.Point(150, 303);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(200, 24);
            this.cboKhoaHoc.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.Location = new System.Drawing.Point(557, 103);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Gray;
            this.txtDiaChi.Location = new System.Drawing.Point(557, 143);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtSoCanCuoc
            // 
            this.txtSoCanCuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoCanCuoc.ForeColor = System.Drawing.Color.Gray;
            this.txtSoCanCuoc.Location = new System.Drawing.Point(557, 183);
            this.txtSoCanCuoc.Name = "txtSoCanCuoc";
            this.txtSoCanCuoc.Size = new System.Drawing.Size(200, 22);
            this.txtSoCanCuoc.TabIndex = 9;
            // 
            // rdoNam
            // 
            this.rdoNam.Location = new System.Drawing.Point(6, 31);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(73, 24);
            this.rdoNam.TabIndex = 10;
            this.rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            this.rdoNu.Location = new System.Drawing.Point(85, 31);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(64, 24);
            this.rdoNu.TabIndex = 11;
            this.rdoNu.Text = "Nữ";
            // 
            // rdoKhac
            // 
            this.rdoKhac.Location = new System.Drawing.Point(166, 31);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(91, 24);
            this.rdoKhac.TabIndex = 12;
            this.rdoKhac.Text = "Khác";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Location = new System.Drawing.Point(37, 395);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 30);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.Location = new System.Drawing.Point(214, 395);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(100, 30);
            this.btnChinhSua.TabIndex = 14;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(404, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Location = new System.Drawing.Point(404, 344);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Sinh Viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Họ Tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chuyên Ngành : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Khóa Học : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Địa Chỉ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số Căn Cước : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày Sinh : ";
            // 
            // grgioitinh
            // 
            this.grgioitinh.Controls.Add(this.rdoNam);
            this.grgioitinh.Controls.Add(this.rdoNu);
            this.grgioitinh.Controls.Add(this.rdoKhac);
            this.grgioitinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grgioitinh.Location = new System.Drawing.Point(449, 223);
            this.grgioitinh.Name = "grgioitinh";
            this.grgioitinh.Size = new System.Drawing.Size(263, 87);
            this.grgioitinh.TabIndex = 28;
            this.grgioitinh.TabStop = false;
            this.grgioitinh.Text = "Giới Tính ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 79);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(451, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Search : ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimKiem.Location = new System.Drawing.Point(150, 348);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiem.TabIndex = 31;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btndanhsachsinhviendaxoa
            // 
            this.btndanhsachsinhviendaxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndanhsachsinhviendaxoa.Location = new System.Drawing.Point(555, 395);
            this.btndanhsachsinhviendaxoa.Name = "btndanhsachsinhviendaxoa";
            this.btndanhsachsinhviendaxoa.Size = new System.Drawing.Size(202, 30);
            this.btndanhsachsinhviendaxoa.TabIndex = 32;
            this.btndanhsachsinhviendaxoa.Text = "Danh Sách Sinh Viên Đã Xóa";
            this.btndanhsachsinhviendaxoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSachSinhVien
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1000, 693);
            this.Controls.Add(this.btndanhsachsinhviendaxoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grgioitinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.cboChuyenNganh);
            this.Controls.Add(this.cboKhoaHoc);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoCanCuoc);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.grgioitinh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = System.Drawing.Color.Gray;

                if (textBox == txtMaSinhVien) textBox.Text = placeholderMaSinhVien;
                else if (textBox == txtHoTen) textBox.Text = placeholderHoTen;
                else if (textBox == txtEmail) textBox.Text = placeholderEmail;
                else if (textBox == txtSoDienThoai) textBox.Text = placeholderSoDienThoai;
                else if (textBox == txtDiaChi) textBox.Text = placeholderDiaChi;
                else if (textBox == txtSoCanCuoc) textBox.Text = placeholderSoCanCuoc;
            }
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox grgioitinh;
        private Panel panel1;
        private Label label10;
        private Label label11;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn ma_sinh_vien_code;
        private DataGridViewTextBoxColumn ho_ten;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn so_dien_thoai;
        private DataGridViewTextBoxColumn chuyen_nganh;
        private DataGridViewTextBoxColumn gioi_tinh;
        private DataGridViewTextBoxColumn ngay_sinh;
        private DataGridViewTextBoxColumn dia_chi;
        private DataGridViewTextBoxColumn khoa_hoc;
        private DataGridViewTextBoxColumn so_can_cuoc;
        private DataGridViewTextBoxColumn trang_thai;
        private Button btndanhsachsinhviendaxoa;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
