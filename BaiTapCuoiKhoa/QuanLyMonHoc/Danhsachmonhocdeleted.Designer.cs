namespace BaiTapCuoiKhoa
{
    partial class Danhsachmonhocdeleted
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
            this.dgvThongtinmonhoc = new System.Windows.Forms.DataGridView();
            this.btnkhoiphuc = new System.Windows.Forms.Button();
            this.btnxoavinhvien = new System.Windows.Forms.Button();
            this.ma_mon_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongtinmonhoc
            // 
            this.dgvThongtinmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvThongtinmonhoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongtinmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mon_hoc,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvThongtinmonhoc.Location = new System.Drawing.Point(1, 41);
            this.dgvThongtinmonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThongtinmonhoc.Name = "dgvThongtinmonhoc";
            this.dgvThongtinmonhoc.RowHeadersWidth = 51;
            this.dgvThongtinmonhoc.RowTemplate.Height = 24;
            this.dgvThongtinmonhoc.Size = new System.Drawing.Size(845, 172);
            this.dgvThongtinmonhoc.TabIndex = 1;
            // 
            // btnkhoiphuc
            // 
            this.btnkhoiphuc.Location = new System.Drawing.Point(74, 229);
            this.btnkhoiphuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkhoiphuc.Name = "btnkhoiphuc";
            this.btnkhoiphuc.Size = new System.Drawing.Size(68, 32);
            this.btnkhoiphuc.TabIndex = 2;
            this.btnkhoiphuc.Text = "Khôi Phục";
            this.btnkhoiphuc.UseVisualStyleBackColor = true;
            this.btnkhoiphuc.Click += new System.EventHandler(this.btnkhoiphuc_Click);
            // 
            // btnxoavinhvien
            // 
            this.btnxoavinhvien.Location = new System.Drawing.Point(428, 226);
            this.btnxoavinhvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoavinhvien.Name = "btnxoavinhvien";
            this.btnxoavinhvien.Size = new System.Drawing.Size(98, 40);
            this.btnxoavinhvien.TabIndex = 3;
            this.btnxoavinhvien.Text = "Xóa Vĩnh Viễn";
            this.btnxoavinhvien.UseVisualStyleBackColor = true;
            this.btnxoavinhvien.Click += new System.EventHandler(this.btnxoavinhvien_Click);
            // 
            // ma_mon_hoc
            // 
            this.ma_mon_hoc.DataPropertyName = "ma_mon_hoc";
            this.ma_mon_hoc.HeaderText = "STT";
            this.ma_mon_hoc.Name = "ma_mon_hoc";
            this.ma_mon_hoc.Width = 53;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ma_mon";
            this.Column2.HeaderText = "Mã môn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten_mon";
            this.Column3.HeaderText = "Tên môn";
            this.Column3.Name = "Column3";
            this.Column3.Width = 74;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "so_tin_chi";
            this.Column4.HeaderText = "Số tín chỉ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "loai_mon";
            this.Column5.HeaderText = "Loại môn";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tong_so_buoi";
            this.Column6.HeaderText = "Tổng số buổi học";
            this.Column6.Name = "Column6";
            this.Column6.Width = 89;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "diem_toi_thieu_de_dat";
            this.Column7.HeaderText = "Điểm đạt tối thiểu";
            this.Column7.Name = "Column7";
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "danh_sach_dau_diem";
            this.Column8.HeaderText = "Danh sách đầu điểm";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "trang_thai";
            this.Column9.HeaderText = "Trạng thái";
            this.Column9.Name = "Column9";
            this.Column9.Width = 74;
            // 
            // Danhsachmonhocdeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(847, 271);
            this.Controls.Add(this.btnxoavinhvien);
            this.Controls.Add(this.btnkhoiphuc);
            this.Controls.Add(this.dgvThongtinmonhoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Danhsachmonhocdeleted";
            this.Text = "Danh Sách Môn Đã Xóa";
            this.Load += new System.EventHandler(this.Danhsachmonhocdeleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinmonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongtinmonhoc;
        private System.Windows.Forms.Button btnkhoiphuc;
        private System.Windows.Forms.Button btnxoavinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mon_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}