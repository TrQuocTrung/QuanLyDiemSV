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

namespace BaiTapCuoiKhoa.QuanLyDiemSV
{
    public partial class ThongKeSinhVien : Form
    {
        private string ConnectionSQl; // Chuỗi kết nối cơ sở dữ liệu
        private string maLopCode;    // Mã lớp từ form chính
        private string maMonCode;    // Mã môn từ form chính

        public ThongKeSinhVien(string maLopCode, string maMonCode)
        {
            InitializeComponent();
            ConnectionSQl = new ConnectDB().Getconnect(); // Khởi tạo kết nối
            this.maLopCode = maLopCode;
            this.maMonCode = maMonCode;
        }

        private void ThongKeSinhVien_Load(object sender, EventArgs e)
        {
            // Gọi hàm LoadSinhVienQuaMon với mã lớp và mã môn được truyền từ form chính
            if (!string.IsNullOrEmpty(maLopCode) && !string.IsNullOrEmpty(maMonCode))
            {
                LoadSinhVienQuaMon(maLopCode, maMonCode);
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách vì thiếu thông tin lớp hoặc môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close(); // Đóng form nếu không có đủ dữ liệu
            }
        }
        private void LoadSinhVienQuaMon(string maLopCode, string maMonCode)
        {
            string query = @"
        SELECT 
            sv.ma_sinh_vien_code AS [Mã Sinh Viên],
            sv.ho_ten AS [Họ và Tên],
            kqmh.tong_diem AS [Tổng Điểm],
            kqmh.diem_toi_thieu AS [Điểm Tối Thiểu],
            CASE 
                WHEN kqmh.qua_mon = 1 THEN N'Đã Qua'
                ELSE N'Chưa Qua'
            END AS [Trạng Thái]
        FROM KetQuaMonHoc kqmh
        INNER JOIN SinhVien sv ON kqmh.ma_sinh_vien_code = sv.ma_sinh_vien_code
        WHERE 
            kqmh.ma_lop_code = @maLopCode
            AND kqmh.ma_mon_code = @maMonCode
        ORDER BY sv.ma_sinh_vien_code";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    // Tạo SqlCommand để thực thi truy vấn
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open(); // Mở kết nối
                    da.Fill(dt); // Điền dữ liệu vào DataTable

                    // Kiểm tra và hiển thị kết quả
                    if (dt.Rows.Count > 0)
                    {
                        dgvThongKeSinhVien.DataSource = dt;

                        // Tự động điều chỉnh độ rộng cột
                        dgvThongKeSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Cho phép ngắt dòng nội dung để hiển thị rõ ràng
                        dgvThongKeSinhVien.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dgvThongKeSinhVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Cập nhật thông báo trạng thái
                        lblStatus.Text = $"Tìm thấy {dt.Rows.Count} sinh viên trong lớp và môn học.";
                    }
                    else
                    {
                        MessageBox.Show("Không có sinh viên nào qua môn để hiển thị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvThongKeSinhVien.DataSource = null;
                        lblStatus.Text = "Không có dữ liệu để hiển thị.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách sinh viên qua môn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

