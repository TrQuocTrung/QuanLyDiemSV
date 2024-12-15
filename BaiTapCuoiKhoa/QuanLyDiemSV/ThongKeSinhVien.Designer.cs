namespace BaiTapCuoiKhoa.QuanLyDiemSV
{
    partial class ThongKeSinhVien
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
            this.dgvThongKeSinhVien = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKeSinhVien
            // 
            this.dgvThongKeSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeSinhVien.Location = new System.Drawing.Point(1, 74);
            this.dgvThongKeSinhVien.Name = "dgvThongKeSinhVien";
            this.dgvThongKeSinhVien.RowHeadersWidth = 51;
            this.dgvThongKeSinhVien.RowTemplate.Height = 24;
            this.dgvThongKeSinhVien.Size = new System.Drawing.Size(799, 338);
            this.dgvThongKeSinhVien.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(229, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(353, 41);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "       ";
            // 
            // ThongKeSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvThongKeSinhVien);
            this.Name = "ThongKeSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Sinh Viên";
            this.Load += new System.EventHandler(this.ThongKeSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKeSinhVien;
        private System.Windows.Forms.Label lblStatus;
    }
}