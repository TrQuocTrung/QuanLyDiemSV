using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKhoa.QuanLyLopHoc
{
    public partial class DanhSachSinhVienDaXoaKhoiLop : Form
    {
        private int maLop;

     
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();
        public DanhSachSinhVienDaXoaKhoiLop(int maLop)
        {
            ConnectionSQl = db.Getconnect();
            InitializeComponent();
            this.maLop = maLop;
            LoadDanhSachSinhVienDaXoa();
        }
        private void LoadDanhSachSinhVienDaXoa()
        {
            string query = @"
                SELECT sv.ma_sinh_vien, sv.ho_ten, sv.ma_sinh_vien_code, sv.email, sv.so_dien_thoai, 
                       sv.chuyen_nganh, sv.gioi_tinh, sv.ngay_sinh, sv.dia_chi, sv.khoa_hoc, sv.so_can_cuoc
                FROM SinhVien sv
                JOIN LopHoc_SinhVien lhs ON sv.ma_sinh_vien = lhs.ma_sinh_vien
                WHERE lhs.ma_lop = @maLop AND lhs.trang_thai = 0";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLop", this.maLop);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        dssinhviendaxoa.DataSource = dt;
                    }
                    else
                    {
                        dssinhviendaxoa.DataSource = null;
                        MessageBox.Show("Không có sinh viên nào đã xóa trong lớp học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách sinh viên đã xóa: " + ex.Message);
                }
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {

            if (dssinhviendaxoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách sinh viên đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dssinhviendaxoa.SelectedRows[0];
            int maSinhVien = Convert.ToInt32(selectedRow.Cells["ma_sinh_vien"].Value);

            // Câu lệnh SQL để khôi phục sinh viên vào lớp bằng cách cập nhật `trang_thai` thành `1` trong bảng `LopHoc_SinhVien`
            string updateQuery = "UPDATE LopHoc_SinhVien SET trang_thai = 1 WHERE ma_lop = @maLop AND ma_sinh_vien = @maSinhVien";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@maLop", this.maLop);
                    updateCmd.Parameters.AddWithValue("@maSinhVien", maSinhVien);

                    conn.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Khôi phục sinh viên vào lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Tải lại danh sách sinh viên đã xóa sau khi khôi phục
                        LoadDanhSachSinhVienDaXoa();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục sinh viên vào lớp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DanhSachSinhVienDaXoaKhoiLop_Load(object sender, EventArgs e)
        {

        }
    }
}
