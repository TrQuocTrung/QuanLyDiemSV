namespace BaiTapCuoiKhoa.QuanLyLopHoc
{
    partial class DanhSachSinhVienDaXoaKhoiLop
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
            this.dssinhviendaxoa = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnxoavinhvien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhviendaxoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dssinhviendaxoa
            // 
            this.dssinhviendaxoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssinhviendaxoa.Location = new System.Drawing.Point(1, 26);
            this.dssinhviendaxoa.Name = "dssinhviendaxoa";
            this.dssinhviendaxoa.RowHeadersWidth = 51;
            this.dssinhviendaxoa.RowTemplate.Height = 24;
            this.dssinhviendaxoa.Size = new System.Drawing.Size(798, 362);
            this.dssinhviendaxoa.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(72, 405);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(191, 33);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi Phục Sinh Viên Vào Lớp";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnxoavinhvien
            // 
            this.btnxoavinhvien.Location = new System.Drawing.Point(442, 405);
            this.btnxoavinhvien.Name = "btnxoavinhvien";
            this.btnxoavinhvien.Size = new System.Drawing.Size(191, 33);
            this.btnxoavinhvien.TabIndex = 2;
            this.btnxoavinhvien.Text = "Xóa Vĩnh Viễn Sinh Viên";
            this.btnxoavinhvien.UseVisualStyleBackColor = true;
            // 
            // DanhSachSinhVienDaXoaKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoavinhvien);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dssinhviendaxoa);
            this.Name = "DanhSachSinhVienDaXoaKhoiLop";
            this.Text = "Danh Sách Sinh Viên Đã Xóa";
            this.Load += new System.EventHandler(this.DanhSachSinhVienDaXoaKhoiLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhviendaxoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dssinhviendaxoa;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnxoavinhvien;
    }
}