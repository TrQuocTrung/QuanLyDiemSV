namespace BaiTapCuoiKhoa.QuanLyLopHoc
{
    partial class Danhsachlopdeleted
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
            this.btnkhoiphuc = new System.Windows.Forms.Button();
            this.btnxoavinhvien = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_lop_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkhoiphuc
            // 
            this.btnkhoiphuc.Location = new System.Drawing.Point(71, 233);
            this.btnkhoiphuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkhoiphuc.Name = "btnkhoiphuc";
            this.btnkhoiphuc.Size = new System.Drawing.Size(88, 28);
            this.btnkhoiphuc.TabIndex = 1;
            this.btnkhoiphuc.Text = "Khôi Phục";
            this.btnkhoiphuc.UseVisualStyleBackColor = true;
            this.btnkhoiphuc.Click += new System.EventHandler(this.btnkhoiphuc_Click);
            // 
            // btnxoavinhvien
            // 
            this.btnxoavinhvien.Location = new System.Drawing.Point(404, 233);
            this.btnxoavinhvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoavinhvien.Name = "btnxoavinhvien";
            this.btnxoavinhvien.Size = new System.Drawing.Size(88, 28);
            this.btnxoavinhvien.TabIndex = 2;
            this.btnxoavinhvien.Text = "Xóa Vĩnh Viễn";
            this.btnxoavinhvien.UseVisualStyleBackColor = true;
            this.btnxoavinhvien.Click += new System.EventHandler(this.btnxoavinhvien_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_lop_code,
            this.ten_lop,
            this.si_so});
            this.dataGridView1.Location = new System.Drawing.Point(1, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 166);
            this.dataGridView1.TabIndex = 3;
            // 
            // ma_lop_code
            // 
            this.ma_lop_code.DataPropertyName = "ma_lop_code";
            this.ma_lop_code.HeaderText = "Mã lớp";
            this.ma_lop_code.Name = "ma_lop_code";
            // 
            // ten_lop
            // 
            this.ten_lop.DataPropertyName = "ten_lop";
            this.ten_lop.HeaderText = "Tên lớp";
            this.ten_lop.Name = "ten_lop";
            // 
            // si_so
            // 
            this.si_so.DataPropertyName = "si_so";
            this.si_so.HeaderText = "Sĩ số";
            this.si_so.Name = "si_so";
            // 
            // Danhsachlopdeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(604, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxoavinhvien);
            this.Controls.Add(this.btnkhoiphuc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Danhsachlopdeleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học Đã Xóa";
            this.Load += new System.EventHandler(this.Danhsachlopdeleted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnkhoiphuc;
        private System.Windows.Forms.Button btnxoavinhvien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_so;
    }
}