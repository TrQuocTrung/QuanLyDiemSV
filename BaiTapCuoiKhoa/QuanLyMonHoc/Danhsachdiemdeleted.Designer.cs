namespace BaiTapCuoiKhoa.QuanLySinhVien
{
    partial class Danhsachdiemdeleted
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
            this.dgvdanhsachdiemdelete = new System.Windows.Forms.DataGridView();
            this.btnkhoiphucdiem = new System.Windows.Forms.Button();
            this.btnxoavinhviendiem = new System.Windows.Forms.Button();
            this.ma_thanh_phan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_mon_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_thanh_phan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ti_le = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachdiemdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsachdiemdelete
            // 
            this.dgvdanhsachdiemdelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachdiemdelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_thanh_phan,
            this.ma_mon_hoc,
            this.ten_mon,
            this.ten_thanh_phan,
            this.so_luong,
            this.ti_le,
            this.trang_thai});
            this.dgvdanhsachdiemdelete.Location = new System.Drawing.Point(2, 23);
            this.dgvdanhsachdiemdelete.Name = "dgvdanhsachdiemdelete";
            this.dgvdanhsachdiemdelete.RowHeadersWidth = 51;
            this.dgvdanhsachdiemdelete.RowTemplate.Height = 24;
            this.dgvdanhsachdiemdelete.Size = new System.Drawing.Size(797, 161);
            this.dgvdanhsachdiemdelete.TabIndex = 0;
            this.dgvdanhsachdiemdelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachdiemdelete_CellContentClick);
            // 
            // btnkhoiphucdiem
            // 
            this.btnkhoiphucdiem.Location = new System.Drawing.Point(46, 203);
            this.btnkhoiphucdiem.Name = "btnkhoiphucdiem";
            this.btnkhoiphucdiem.Size = new System.Drawing.Size(120, 36);
            this.btnkhoiphucdiem.TabIndex = 1;
            this.btnkhoiphucdiem.Text = "Khôi Phục Điểm";
            this.btnkhoiphucdiem.UseVisualStyleBackColor = true;
            this.btnkhoiphucdiem.Click += new System.EventHandler(this.btnkhoiphucdiem_Click);
            // 
            // btnxoavinhviendiem
            // 
            this.btnxoavinhviendiem.Location = new System.Drawing.Point(557, 203);
            this.btnxoavinhviendiem.Name = "btnxoavinhviendiem";
            this.btnxoavinhviendiem.Size = new System.Drawing.Size(123, 36);
            this.btnxoavinhviendiem.TabIndex = 2;
            this.btnxoavinhviendiem.Text = "Xóa Vĩnh Viễn";
            this.btnxoavinhviendiem.UseVisualStyleBackColor = true;
            this.btnxoavinhviendiem.Click += new System.EventHandler(this.btnxoavinhviendiem_Click);
            // 
            // ma_thanh_phan
            // 
            this.ma_thanh_phan.DataPropertyName = "ma_thanh_phan";
            this.ma_thanh_phan.HeaderText = "STT";
            this.ma_thanh_phan.MinimumWidth = 6;
            this.ma_thanh_phan.Name = "ma_thanh_phan";
            this.ma_thanh_phan.Width = 125;
            // 
            // ma_mon_hoc
            // 
            this.ma_mon_hoc.DataPropertyName = "ma_mon_hoc";
            this.ma_mon_hoc.HeaderText = "Mã Môn Học";
            this.ma_mon_hoc.MinimumWidth = 6;
            this.ma_mon_hoc.Name = "ma_mon_hoc";
            this.ma_mon_hoc.Width = 125;
            // 
            // ten_mon
            // 
            this.ten_mon.DataPropertyName = "ten_mon";
            this.ten_mon.HeaderText = "Tên Môn";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            this.ten_mon.Width = 125;
            // 
            // ten_thanh_phan
            // 
            this.ten_thanh_phan.DataPropertyName = "ten_thanh_phan";
            this.ten_thanh_phan.HeaderText = "Tên Thành Phần";
            this.ten_thanh_phan.MinimumWidth = 6;
            this.ten_thanh_phan.Name = "ten_thanh_phan";
            this.ten_thanh_phan.Width = 125;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số Lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 125;
            // 
            // ti_le
            // 
            this.ti_le.DataPropertyName = "ti_le";
            this.ti_le.HeaderText = "Tỉ Lệ";
            this.ti_le.MinimumWidth = 6;
            this.ti_le.Name = "ti_le";
            this.ti_le.Width = 125;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng Thái";
            this.trang_thai.MinimumWidth = 6;
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Width = 125;
            // 
            // Danhsachdiemdeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(803, 251);
            this.Controls.Add(this.btnxoavinhviendiem);
            this.Controls.Add(this.btnkhoiphucdiem);
            this.Controls.Add(this.dgvdanhsachdiemdelete);
            this.Name = "Danhsachdiemdeleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Điểm Đã Xóa";
            this.Load += new System.EventHandler(this.Danhsachdiemdeleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachdiemdelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsachdiemdelete;
        private System.Windows.Forms.Button btnkhoiphucdiem;
        private System.Windows.Forms.Button btnxoavinhviendiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_thanh_phan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mon_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_thanh_phan;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ti_le;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
    }
}