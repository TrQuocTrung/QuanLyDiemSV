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

namespace BaiTapCuoiKhoa.QuanLySinhVien
{
    public partial class Danhsachdiemdeleted : Form
    {
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();
        public Danhsachdiemdeleted()
        {
            ConnectionSQl = db.Getconnect();
            
            InitializeComponent();
        }
        public void loaddsdiemfalse()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                string query = @"
        SELECT 
            tp.ma_thanh_phan,
            tp.ma_mon_hoc,
            mh.ten_mon,
            tp.ten_thanh_phan,
            tp.so_luong,
            tp.ti_le,
            tp.trang_thai
        FROM 
            ThanhPhanDiem AS tp
        LEFT JOIN 
            MonHoc AS mh ON tp.ma_mon_hoc = mh.ma_mon_hoc
        WHERE 
            tp.trang_thai = 0"; // Lọc đầu điểm có trạng thái là 0 (đã xóa mềm)

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán DataTable vào DataGridView
                dgvdanhsachdiemdelete.DataSource = dt;
            }
        }
        private void danhsachdiemdelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Danhsachdiemdeleted_Load(object sender, EventArgs e)
        {
            loaddsdiemfalse();
        }

        private void btnkhoiphucdiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvdanhsachdiemdelete.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đầu điểm cần khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã thành phần điểm của hàng được chọn
            int maThanhPhan = Convert.ToInt32(dgvdanhsachdiemdelete.SelectedRows[0].Cells["ma_thanh_phan"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để cập nhật trạng thái của điểm thành 1 (khôi phục)
                string query = "UPDATE ThanhPhanDiem SET trang_thai = 1 WHERE ma_thanh_phan = @ma_thanh_phan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_thanh_phan", maThanhPhan);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Khôi phục đầu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loaddsdiemfalse();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục đầu điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoavinhviendiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvdanhsachdiemdelete.SelectedRows.Count == 0)
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
            int maThanhPhan = Convert.ToInt32(dgvdanhsachdiemdelete.SelectedRows[0].Cells["ma_thanh_phan"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để xóa vĩnh viễn đầu điểm
                string query = "DELETE FROM ThanhPhanDiem WHERE ma_thanh_phan = @ma_thanh_phan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_thanh_phan", maThanhPhan);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa vĩnh viễn đầu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loaddsdiemfalse();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vĩnh viễn đầu điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
