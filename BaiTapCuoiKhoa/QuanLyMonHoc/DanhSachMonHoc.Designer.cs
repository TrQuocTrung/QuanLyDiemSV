namespace BaiTapCuoiKhoa
{
    partial class DanhSachMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.ComboBox cboPhanLoai;
        private System.Windows.Forms.TextBox txtDiemToiThieuPass;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblTongSoBuoi;
        private System.Windows.Forms.Label lblDiemToiThieuPass;
        private System.Windows.Forms.Label lblDauDiem;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachMonHoc));
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.cboPhanLoai = new System.Windows.Forms.ComboBox();
            this.txtDiemToiThieuPass = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblTongSoBuoi = new System.Windows.Forms.Label();
            this.lblDiemToiThieuPass = new System.Windows.Forms.Label();
            this.lblDauDiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnxoadaudiem = new System.Windows.Forms.Button();
            this.btnsuadaudiem = new System.Windows.Forms.Button();
            this.btnthemdaudiem = new System.Windows.Forms.Button();
            this.txtSoDauDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttiledaudiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaidaudiem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongSoBuoi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThongtinmonhoc = new System.Windows.Forms.DataGridView();
            this.ma_mon_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_tin_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_so_buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_toi_thieu_de_dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danh_sach_dau_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsuathongtinmonhoc = new System.Windows.Forms.Button();
            this.btnxoathongtinmonhoc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.danhsachmondaxa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinmonhoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaMon
            // 
            this.txtMaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaMon.Location = new System.Drawing.Point(149, 21);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(273, 22);
            this.txtMaMon.TabIndex = 0;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTenMon.Location = new System.Drawing.Point(148, 63);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(273, 22);
            this.txtTenMon.TabIndex = 1;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoTinChi.Location = new System.Drawing.Point(148, 103);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(273, 22);
            this.txtSoTinChi.TabIndex = 2;
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanLoai.Items.AddRange(new object[] {
            "Truyền thống",
            "Blended",
            "Online",
            "ORIT"});
            this.cboPhanLoai.Location = new System.Drawing.Point(148, 144);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(273, 24);
            this.cboPhanLoai.TabIndex = 3;
            // 
            // txtDiemToiThieuPass
            // 
            this.txtDiemToiThieuPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDiemToiThieuPass.Location = new System.Drawing.Point(148, 225);
            this.txtDiemToiThieuPass.Name = "txtDiemToiThieuPass";
            this.txtDiemToiThieuPass.Size = new System.Drawing.Size(274, 22);
            this.txtDiemToiThieuPass.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(17, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 42);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Thêm Thông Tin Môn Học";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblMaMon
            // 
            this.lblMaMon.Location = new System.Drawing.Point(6, 30);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(100, 23);
            this.lblMaMon.TabIndex = 11;
            this.lblMaMon.Text = "Mã môn học :";
            // 
            // lblTenMon
            // 
            this.lblTenMon.Location = new System.Drawing.Point(6, 69);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(100, 23);
            this.lblTenMon.TabIndex = 12;
            this.lblTenMon.Text = "Tên môn học :";
            this.lblTenMon.Click += new System.EventHandler(this.lblTenMon_Click);
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.Location = new System.Drawing.Point(6, 108);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(100, 23);
            this.lblSoTinChi.TabIndex = 13;
            this.lblSoTinChi.Text = "Số Tín Chỉ : ";
            this.lblSoTinChi.Click += new System.EventHandler(this.lblSoTinChi_Click);
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.Location = new System.Drawing.Point(6, 147);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(100, 23);
            this.lblPhanLoai.TabIndex = 14;
            this.lblPhanLoai.Text = "Phân loại :";
            // 
            // lblTongSoBuoi
            // 
            this.lblTongSoBuoi.Location = new System.Drawing.Point(6, 186);
            this.lblTongSoBuoi.Name = "lblTongSoBuoi";
            this.lblTongSoBuoi.Size = new System.Drawing.Size(100, 23);
            this.lblTongSoBuoi.TabIndex = 15;
            this.lblTongSoBuoi.Text = "Tổng số buổi học";
            // 
            // lblDiemToiThieuPass
            // 
            this.lblDiemToiThieuPass.Location = new System.Drawing.Point(6, 225);
            this.lblDiemToiThieuPass.Name = "lblDiemToiThieuPass";
            this.lblDiemToiThieuPass.Size = new System.Drawing.Size(145, 23);
            this.lblDiemToiThieuPass.TabIndex = 16;
            this.lblDiemToiThieuPass.Text = "Điểm tối thiểu qua môn :";
            // 
            // lblDauDiem
            // 
            this.lblDauDiem.Location = new System.Drawing.Point(6, 27);
            this.lblDauDiem.Name = "lblDauDiem";
            this.lblDauDiem.Size = new System.Drawing.Size(100, 23);
            this.lblDauDiem.TabIndex = 17;
            this.lblDauDiem.Text = "Loại đầu điểm :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 90);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Môn Học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(2, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 260);
            this.panel2.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnxoadaudiem);
            this.groupBox2.Controls.Add(this.btnsuadaudiem);
            this.groupBox2.Controls.Add(this.btnthemdaudiem);
            this.groupBox2.Controls.Add(this.txtSoDauDiem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttiledaudiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboLoaidaudiem);
            this.groupBox2.Controls.Add(this.lblDauDiem);
            this.groupBox2.Location = new System.Drawing.Point(682, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 254);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đầu Điểm ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 29;
            this.button4.Text = "Danh Sách Đầu Điểm Đã Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnxoadaudiem
            // 
            this.btnxoadaudiem.Location = new System.Drawing.Point(220, 186);
            this.btnxoadaudiem.Name = "btnxoadaudiem";
            this.btnxoadaudiem.Size = new System.Drawing.Size(97, 47);
            this.btnxoadaudiem.TabIndex = 28;
            this.btnxoadaudiem.Text = "Xóa Đầu Điểm";
            this.btnxoadaudiem.UseVisualStyleBackColor = true;
            this.btnxoadaudiem.Click += new System.EventHandler(this.btnxoadaudiem_Click);
            // 
            // btnsuadaudiem
            // 
            this.btnsuadaudiem.Location = new System.Drawing.Point(115, 183);
            this.btnsuadaudiem.Name = "btnsuadaudiem";
            this.btnsuadaudiem.Size = new System.Drawing.Size(84, 50);
            this.btnsuadaudiem.TabIndex = 27;
            this.btnsuadaudiem.Text = "Sửa Đầu Điểm";
            this.btnsuadaudiem.UseVisualStyleBackColor = true;
            this.btnsuadaudiem.Click += new System.EventHandler(this.btnsuadaudiem_Click);
            // 
            // btnthemdaudiem
            // 
            this.btnthemdaudiem.Location = new System.Drawing.Point(9, 183);
            this.btnthemdaudiem.Name = "btnthemdaudiem";
            this.btnthemdaudiem.Size = new System.Drawing.Size(91, 50);
            this.btnthemdaudiem.TabIndex = 26;
            this.btnthemdaudiem.Text = "Thêm Đầu Điểm";
            this.btnthemdaudiem.UseVisualStyleBackColor = true;
            this.btnthemdaudiem.Click += new System.EventHandler(this.btnthemdaudiem_Click);
            // 
            // txtSoDauDiem
            // 
            this.txtSoDauDiem.Location = new System.Drawing.Point(156, 70);
            this.txtSoDauDiem.Name = "txtSoDauDiem";
            this.txtSoDauDiem.Size = new System.Drawing.Size(274, 22);
            this.txtSoDauDiem.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số Đầu Điểm : ";
            // 
            // txttiledaudiem
            // 
            this.txttiledaudiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txttiledaudiem.Location = new System.Drawing.Point(156, 111);
            this.txttiledaudiem.Name = "txttiledaudiem";
            this.txttiledaudiem.Size = new System.Drawing.Size(274, 22);
            this.txttiledaudiem.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tỉ Lệ Đầu Điểm : ";
            // 
            // cboLoaidaudiem
            // 
            this.cboLoaidaudiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaidaudiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaidaudiem.FormattingEnabled = true;
            this.cboLoaidaudiem.Items.AddRange(new object[] {
            "Điểm Lab",
            "Điểm Quiz",
            "Điểm Assignment",
            "Điểm Thi"});
            this.cboLoaidaudiem.Location = new System.Drawing.Point(156, 24);
            this.cboLoaidaudiem.Name = "cboLoaidaudiem";
            this.cboLoaidaudiem.Size = new System.Drawing.Size(274, 24);
            this.cboLoaidaudiem.TabIndex = 19;
            this.cboLoaidaudiem.SelectedIndexChanged += new System.EventHandler(this.cboLoaidaudiem_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.groupBox1.Controls.Add(this.txtTongSoBuoi);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.cboPhanLoai);
            this.groupBox1.Controls.Add(this.txtDiemToiThieuPass);
            this.groupBox1.Controls.Add(this.lblMaMon);
            this.groupBox1.Controls.Add(this.lblTenMon);
            this.groupBox1.Controls.Add(this.lblDiemToiThieuPass);
            this.groupBox1.Controls.Add(this.lblSoTinChi);
            this.groupBox1.Controls.Add(this.lblPhanLoai);
            this.groupBox1.Controls.Add(this.lblTongSoBuoi);
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 254);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học";
            // 
            // txtTongSoBuoi
            // 
            this.txtTongSoBuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTongSoBuoi.Location = new System.Drawing.Point(148, 183);
            this.txtTongSoBuoi.Name = "txtTongSoBuoi";
            this.txtTongSoBuoi.Size = new System.Drawing.Size(273, 22);
            this.txtTongSoBuoi.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.dgvThongtinmonhoc);
            this.panel3.Location = new System.Drawing.Point(2, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 218);
            this.panel3.TabIndex = 20;
            // 
            // dgvThongtinmonhoc
            // 
            this.dgvThongtinmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvThongtinmonhoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongtinmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mon_hoc,
            this.ma_mon,
            this.ten_mon,
            this.so_tin_chi,
            this.loai_mon,
            this.tong_so_buoi,
            this.diem_toi_thieu_de_dat,
            this.danh_sach_dau_diem,
            this.trang_thai});
            this.dgvThongtinmonhoc.Location = new System.Drawing.Point(3, 3);
            this.dgvThongtinmonhoc.Name = "dgvThongtinmonhoc";
            this.dgvThongtinmonhoc.RowHeadersWidth = 51;
            this.dgvThongtinmonhoc.RowTemplate.Height = 24;
            this.dgvThongtinmonhoc.Size = new System.Drawing.Size(1127, 212);
            this.dgvThongtinmonhoc.TabIndex = 0;
            this.dgvThongtinmonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtinmonhoc_CellContentClick);
            this.dgvThongtinmonhoc.SelectionChanged += new System.EventHandler(this.dgvThongtinmonhoc_SelectionChanged);
            // 
            // ma_mon_hoc
            // 
            this.ma_mon_hoc.DataPropertyName = "ma_mon_hoc";
            this.ma_mon_hoc.HeaderText = "STT";
            this.ma_mon_hoc.MinimumWidth = 6;
            this.ma_mon_hoc.Name = "ma_mon_hoc";
            this.ma_mon_hoc.Width = 63;
            // 
            // ma_mon
            // 
            this.ma_mon.DataPropertyName = "ma_mon";
            this.ma_mon.HeaderText = "Mã Môn";
            this.ma_mon.MinimumWidth = 6;
            this.ma_mon.Name = "ma_mon";
            this.ma_mon.Width = 78;
            // 
            // ten_mon
            // 
            this.ten_mon.DataPropertyName = "ten_mon";
            this.ten_mon.HeaderText = "Tên Môn";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            this.ten_mon.Width = 83;
            // 
            // so_tin_chi
            // 
            this.so_tin_chi.DataPropertyName = "so_tin_chi";
            this.so_tin_chi.HeaderText = "Số Tín Chỉ";
            this.so_tin_chi.MinimumWidth = 6;
            this.so_tin_chi.Name = "so_tin_chi";
            this.so_tin_chi.Width = 90;
            // 
            // loai_mon
            // 
            this.loai_mon.DataPropertyName = "loai_mon";
            this.loai_mon.HeaderText = "Loại Môn";
            this.loai_mon.MinimumWidth = 6;
            this.loai_mon.Name = "loai_mon";
            this.loai_mon.Width = 84;
            // 
            // tong_so_buoi
            // 
            this.tong_so_buoi.DataPropertyName = "tong_so_buoi";
            this.tong_so_buoi.HeaderText = "Tổng Số Buổi";
            this.tong_so_buoi.MinimumWidth = 6;
            this.tong_so_buoi.Name = "tong_so_buoi";
            this.tong_so_buoi.Width = 84;
            // 
            // diem_toi_thieu_de_dat
            // 
            this.diem_toi_thieu_de_dat.DataPropertyName = "diem_toi_thieu_de_dat";
            this.diem_toi_thieu_de_dat.HeaderText = "Điểm Tối Thiểu Qua Môn";
            this.diem_toi_thieu_de_dat.MinimumWidth = 6;
            this.diem_toi_thieu_de_dat.Name = "diem_toi_thieu_de_dat";
            this.diem_toi_thieu_de_dat.Width = 145;
            // 
            // danh_sach_dau_diem
            // 
            this.danh_sach_dau_diem.DataPropertyName = "danh_sach_dau_diem";
            this.danh_sach_dau_diem.HeaderText = "Danh Sách Đầu Điểm";
            this.danh_sach_dau_diem.MinimumWidth = 6;
            this.danh_sach_dau_diem.Name = "danh_sach_dau_diem";
            this.danh_sach_dau_diem.Width = 121;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng Thái";
            this.trang_thai.MinimumWidth = 6;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Width = 94;
            // 
            // btnsuathongtinmonhoc
            // 
            this.btnsuathongtinmonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuathongtinmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuathongtinmonhoc.Location = new System.Drawing.Point(342, 21);
            this.btnsuathongtinmonhoc.Name = "btnsuathongtinmonhoc";
            this.btnsuathongtinmonhoc.Size = new System.Drawing.Size(200, 42);
            this.btnsuathongtinmonhoc.TabIndex = 21;
            this.btnsuathongtinmonhoc.Text = "Sửa Thông Tin Môn Học";
            this.btnsuathongtinmonhoc.UseVisualStyleBackColor = true;
            this.btnsuathongtinmonhoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoathongtinmonhoc
            // 
            this.btnxoathongtinmonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoathongtinmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoathongtinmonhoc.Location = new System.Drawing.Point(648, 21);
            this.btnxoathongtinmonhoc.Name = "btnxoathongtinmonhoc";
            this.btnxoathongtinmonhoc.Size = new System.Drawing.Size(200, 42);
            this.btnxoathongtinmonhoc.TabIndex = 22;
            this.btnxoathongtinmonhoc.Text = "Xóa Thông Tin Môn Học";
            this.btnxoathongtinmonhoc.UseVisualStyleBackColor = true;
            this.btnxoathongtinmonhoc.Click += new System.EventHandler(this.btnxoathongtinmonhoc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.groupBox3.Controls.Add(this.danhsachmondaxa);
            this.groupBox3.Controls.Add(this.btnxoathongtinmonhoc);
            this.groupBox3.Controls.Add(this.btnsuathongtinmonhoc);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Location = new System.Drawing.Point(2, 622);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1133, 80);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản Lý Môn Học";
            // 
            // danhsachmondaxa
            // 
            this.danhsachmondaxa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.danhsachmondaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachmondaxa.Location = new System.Drawing.Point(912, 21);
            this.danhsachmondaxa.Name = "danhsachmondaxa";
            this.danhsachmondaxa.Size = new System.Drawing.Size(200, 42);
            this.danhsachmondaxa.TabIndex = 23;
            this.danhsachmondaxa.Text = "Danh Sách Môn Đã Xóa";
            this.danhsachmondaxa.UseVisualStyleBackColor = true;
            this.danhsachmondaxa.Click += new System.EventHandler(this.danhsachmondaxa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(113, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "SEARCH : ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(257, 578);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(554, 37);
            this.txtTimKiem.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(837, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 27;
            this.button3.Text = "Tìm Kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1006, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // DanhSachMonHoc
            // 
            this.ClientSize = new System.Drawing.Size(1136, 691);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DanhSachMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Môn Học";
            this.Load += new System.EventHandler(this.DanhSachMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinmonhoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboLoaidaudiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttiledaudiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsuathongtinmonhoc;
        private System.Windows.Forms.Button btnxoathongtinmonhoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDauDiem;
        private System.Windows.Forms.Button danhsachmondaxa;
        private System.Windows.Forms.DataGridView dgvThongtinmonhoc;
        private System.Windows.Forms.TextBox txtTongSoBuoi;
        private System.Windows.Forms.Button btnsuadaudiem;
        private System.Windows.Forms.Button btnthemdaudiem;
        private System.Windows.Forms.Button btnxoadaudiem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mon_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_tin_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_so_buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_toi_thieu_de_dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn danh_sach_dau_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
