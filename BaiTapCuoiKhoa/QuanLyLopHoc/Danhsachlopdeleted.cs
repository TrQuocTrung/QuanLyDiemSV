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
    public partial class Danhsachlopdeleted : Form
    {
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();
        public Danhsachlopdeleted()
        {
            ConnectionSQl = db.Getconnect(); 
            InitializeComponent();
            loaddanhsachlopdeleted();
           
        }

        private void btnkhoiphuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học của hàng được chọn
            String maLop = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ma_lop_code"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để cập nhật trạng thái của môn học thành 0 (đã xóa mềm)
                string query = "UPDATE LopHoc SET trang_thai = 1 WHERE ma_lop_code = @ma_lop_code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_lop_code", maLop);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Khôi Phục Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loaddanhsachlopdeleted();
                    }
                    else
                    {
                        MessageBox.Show("Khôi Phục Thất Bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoavinhvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đầu điểm cần xóa vĩnh viễn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xác nhận với người dùng trước khi xóa vĩnh viễn
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn đầu điểm này? Hành động này không thể hoàn tác!",
                                                         "Xác nhận xóa vĩnh viễn",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
            {
                return; // Người dùng chọn "No", hủy bỏ việc xóa
            }

            // Lấy mã thành phần điểm của hàng được chọn
            String maLop = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ma_lop_code"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để xóa vĩnh viễn đầu điểm
                string query = "DELETE FROM LopHoc WHERE ma_lop_code = @ma_lop_code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_lop_code", maLop);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa vĩnh viễn lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loaddanhsachlopdeleted();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vĩnh viễn lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loaddanhsachlopdeleted()
        {

            string query = "SELECT ma_lop_code, ten_lop, si_so FROM LopHoc WHERE trang_thai = 0";
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Không có lớp học nào đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách lớp học đã bị xóa: " + ex.Message);
                }
            }
        }

        private void Danhsachlopdeleted_Load(object sender, EventArgs e)
        {
            loaddanhsachlopdeleted();
        }
    }
}
