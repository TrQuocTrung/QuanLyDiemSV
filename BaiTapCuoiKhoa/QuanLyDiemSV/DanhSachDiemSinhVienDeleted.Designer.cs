namespace BaiTapCuoiKhoa.QuanLyDiemSV
{
    partial class DanhSachDiemSinhVienDeleted
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
            this.dataGridViewDeletedScores = new System.Windows.Forms.DataGridView();
            this.btnkhoiphucdiem = new System.Windows.Forms.Button();
            this.btnXoaVinhVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeletedScores
            // 
            this.dataGridViewDeletedScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletedScores.Location = new System.Drawing.Point(2, 59);
            this.dataGridViewDeletedScores.Name = "dataGridViewDeletedScores";
            this.dataGridViewDeletedScores.RowHeadersWidth = 51;
            this.dataGridViewDeletedScores.RowTemplate.Height = 24;
            this.dataGridViewDeletedScores.Size = new System.Drawing.Size(798, 350);
            this.dataGridViewDeletedScores.TabIndex = 0;
            // 
            // btnkhoiphucdiem
            // 
            this.btnkhoiphucdiem.Location = new System.Drawing.Point(106, 424);
            this.btnkhoiphucdiem.Name = "btnkhoiphucdiem";
            this.btnkhoiphucdiem.Size = new System.Drawing.Size(116, 42);
            this.btnkhoiphucdiem.TabIndex = 1;
            this.btnkhoiphucdiem.Text = "Khôi Phục Điểm";
            this.btnkhoiphucdiem.UseVisualStyleBackColor = true;
            this.btnkhoiphucdiem.Click += new System.EventHandler(this.btnkhoiphucdiem_Click);
            // 
            // btnXoaVinhVien
            // 
            this.btnXoaVinhVien.Location = new System.Drawing.Point(541, 424);
            this.btnXoaVinhVien.Name = "btnXoaVinhVien";
            this.btnXoaVinhVien.Size = new System.Drawing.Size(107, 42);
            this.btnXoaVinhVien.TabIndex = 2;
            this.btnXoaVinhVien.Text = "Xóa Vĩnh Viễn";
            this.btnXoaVinhVien.UseVisualStyleBackColor = true;
            this.btnXoaVinhVien.Click += new System.EventHandler(this.btnXoaVinhVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Điểm Sinh Viên Đã Xóa";
            // 
            // DanhSachDiemSinhVienDeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaVinhVien);
            this.Controls.Add(this.btnkhoiphucdiem);
            this.Controls.Add(this.dataGridViewDeletedScores);
            this.Name = "DanhSachDiemSinhVienDeleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Điểm Sinh Viên Đã Xóa";
            this.Load += new System.EventHandler(this.DanhSachDiemSinhVienDeleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeletedScores;
        private System.Windows.Forms.Button btnkhoiphucdiem;
        private System.Windows.Forms.Button btnXoaVinhVien;
        private System.Windows.Forms.Label label1;
    }
}