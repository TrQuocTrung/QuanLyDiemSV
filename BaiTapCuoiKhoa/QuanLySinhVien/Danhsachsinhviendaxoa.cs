using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKhoa
{
    public partial class Danhsachsinhviendaxoa : Form
    {
        string Sqlconnect = "";
       ConnectDB DB = new ConnectDB();
        public Danhsachsinhviendaxoa()
        {
            InitializeComponent();
        }
        private void loadsinhvientt0()
        {
            Sqlconnect = DB.Getconnect();
            using(SqlConnection conn = new SqlConnection(Sqlconnect))
            {
                conn.Open();
                string query = "SELECT * FROM SinhVien WHERE trang_thai=0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);   
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVientt0.DataSource = dt;
            }
        }
        private void Danhsachsinhviendaxoa_Load(object sender, EventArgs e)
        {
            loadsinhvientt0();
        }

        private void btnkhoiphuc_Click(object sender, EventArgs e)
        {
            string selectedmasv = dgvSinhVientt0.SelectedRows[0].Cells["ma_sinh_vien_code"].Value.ToString();
            using(SqlConnection con = new SqlConnection(Sqlconnect))
            {
                con.Open();
                string query = "UPDATE SinhVien SET trang_thai=1 WHERE @ma_sinh_vien_code=ma_sinh_vien_code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ma_sinh_vien_code",selectedmasv);
                cmd.ExecuteNonQuery();
                loadsinhvientt0();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView hay không
            if (dgvSinhVientt0.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã sinh viên từ dòng được chọn
            string selectedmasv = dgvSinhVientt0.SelectedRows[0].Cells["ma_sinh_vien_code"].Value.ToString();

            using (SqlConnection con = new SqlConnection(Sqlconnect))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM SinhVien WHERE ma_sinh_vien_code = @ma_sinh_vien_code";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@ma_sinh_vien_code", selectedmasv);

                    // Thực hiện lệnh xóa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại DataGridView sau khi xóa thành công (tải lại danh sách sinh viên)
                        loadsinhvientt0(); // Gọi hàm này để tải lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để xóa. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        }
    }

