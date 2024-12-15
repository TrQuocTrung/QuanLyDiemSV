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
    public partial class DanhSachDiemSinhVienDeleted : Form
    {
        private string maLopCode;
        private string maMonCode;
        ConnectDB DB = new ConnectDB();
        String ConnectionSQl;
        public DanhSachDiemSinhVienDeleted(string maLopCode, string maMonCode)
        {
            InitializeComponent();
            ConnectionSQl = DB.Getconnect();
            this.maLopCode = maLopCode;
            this.maMonCode = maMonCode;

            // Gọi hàm tải danh sách điểm đã xóa
            LoadDeletedScores();
        }

        private void LoadDeletedScores()
        {
            string query = @"
    SELECT 
        ds.ma_sinh_vien_code AS [Mã Sinh Viên], 
        sv.ho_ten AS [Họ và Tên], 
        STRING_AGG(CONCAT(ds.ten_thanh_phan, ': ', ds.diem), ' | ') WITHIN GROUP (ORDER BY ds.ten_thanh_phan) AS [Điểm Chi Tiết]
    FROM Diem_SinhVien ds
    INNER JOIN SinhVien sv ON ds.ma_sinh_vien_code = sv.ma_sinh_vien_code
    WHERE 
        ds.ma_lop_code = @maLopCode 
        AND ds.ma_mon_code = @maMonCode 
        AND ds.trang_thai = 0
    GROUP BY ds.ma_sinh_vien_code, sv.ho_ten
    ORDER BY ds.ma_sinh_vien_code";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewDeletedScores.DataSource = dt;

                        // Tự động điều chỉnh độ rộng cột
                        dataGridViewDeletedScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Cho phép ngắt dòng nội dung để hiển thị rõ ràng
                        dataGridViewDeletedScores.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridViewDeletedScores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else
                    {
                        MessageBox.Show("Không có điểm đã xóa để hiển thị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDeletedScores.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách điểm đã xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DanhSachDiemSinhVienDeleted_Load(object sender, EventArgs e)
        {

        }

        private void btnkhoiphucdiem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedScores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hoặc nhiều sinh viên cần khôi phục điểm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    foreach (DataGridViewRow row in dataGridViewDeletedScores.SelectedRows)
                    {
                        // Lấy thông tin từ hàng đã chọn
                        string maSinhVienCode = row.Cells["Mã Sinh Viên"].Value.ToString();

                        // Câu lệnh cập nhật trạng thái điểm
                        string query = @"
                UPDATE Diem_SinhVien
                SET trang_thai = 1
                WHERE ma_sinh_vien_code = @maSinhVienCode
                AND ma_lop_code = @maLopCode
                AND ma_mon_code = @maMonCode
                AND trang_thai = 0";

                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);
                        cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                        cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Khôi phục điểm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách điểm đã xóa sau khi khôi phục
                    LoadDeletedScores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi khôi phục điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaVinhVien_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedScores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hoặc nhiều điểm cần xóa vĩnh viễn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn các điểm đã chọn không?",
                                                "Xác Nhận",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionSQl))
                {
                    try
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        foreach (DataGridViewRow row in dataGridViewDeletedScores.SelectedRows)
                        {
                            string maSinhVienCode = row.Cells["Mã Sinh Viên"].Value.ToString();
                            string tenThanhPhan = row.Cells["Loại Điểm"].Value.ToString();

                            string query = @"
                    DELETE FROM Diem_SinhVien
                    WHERE ma_sinh_vien_code = @maSinhVienCode
                    AND ma_lop_code = @maLopCode
                    AND ma_mon_code = @maMonCode
                    AND ten_thanh_phan = @tenThanhPhan";

                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);
                            cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                            cmd.Parameters.AddWithValue("@maMonCode", maMonCode);
                            cmd.Parameters.AddWithValue("@tenThanhPhan", tenThanhPhan);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Xóa vĩnh viễn điểm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại danh sách điểm đã xóa sau khi xóa vĩnh viễn
                        LoadDeletedScores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa vĩnh viễn điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
