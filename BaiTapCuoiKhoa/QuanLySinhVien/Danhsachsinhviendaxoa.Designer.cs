namespace BaiTapCuoiKhoa
{
    partial class Danhsachsinhviendaxoa
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
            this.dgvSinhVientt0 = new System.Windows.Forms.DataGridView();
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
            this.btnkhoiphuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVientt0)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVientt0
            // 
            this.dgvSinhVientt0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVientt0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSinhVientt0.ColumnHeadersHeight = 29;
            this.dgvSinhVientt0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvSinhVientt0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSinhVientt0.Location = new System.Drawing.Point(-2, 0);
            this.dgvSinhVientt0.Name = "dgvSinhVientt0";
            this.dgvSinhVientt0.ReadOnly = true;
            this.dgvSinhVientt0.RowHeadersWidth = 51;
            this.dgvSinhVientt0.Size = new System.Drawing.Size(976, 250);
            this.dgvSinhVientt0.TabIndex = 1;
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
            // btnkhoiphuc
            // 
            this.btnkhoiphuc.Location = new System.Drawing.Point(116, 273);
            this.btnkhoiphuc.Name = "btnkhoiphuc";
            this.btnkhoiphuc.Size = new System.Drawing.Size(85, 42);
            this.btnkhoiphuc.TabIndex = 2;
            this.btnkhoiphuc.Text = "Khôi Phục";
            this.btnkhoiphuc.UseVisualStyleBackColor = true;
            this.btnkhoiphuc.Click += new System.EventHandler(this.btnkhoiphuc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa Vĩnh Viễn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Danhsachsinhviendaxoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(972, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkhoiphuc);
            this.Controls.Add(this.dgvSinhVientt0);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Danhsachsinhviendaxoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên Đã Xóa";
            this.Load += new System.EventHandler(this.Danhsachsinhviendaxoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVientt0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVientt0;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sinh_vien_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyen_nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_can_cuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.Button btnkhoiphuc;
        private System.Windows.Forms.Button button1;
    }
}