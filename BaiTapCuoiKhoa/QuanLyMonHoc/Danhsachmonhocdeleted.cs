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

namespace BaiTapCuoiKhoa
{
    public partial class Danhsachmonhocdeleted : Form
    {
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();
        public Danhsachmonhocdeleted()
        {
            ConnectionSQl = db.Getconnect();
            InitializeComponent();
        }
        public void loadmonhocfalse()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                string query = @"
            SELECT 
                mh.ma_mon_hoc,
                mh.ma_mon,
                mh.ten_mon,
                mh.so_tin_chi,
                mh.loai_mon,
                mh.tong_so_buoi,
                mh.diem_toi_thieu_de_dat,
               STRING_AGG(
            tp.ten_thanh_phan + N' Đầu Điểm : ' + CAST(tp.so_luong AS NVARCHAR(5)) + 
            N' Tỉ Lệ : ' + CAST(tp.ti_le AS NVARCHAR(5)) + N' %', 
            N', ') AS danh_sach_dau_diem,
                mh.trang_thai
            FROM  
                MonHoc AS mh
            LEFT JOIN 
                ThanhPhanDiem AS tp ON mh.ma_mon_hoc = tp.ma_mon_hoc 
            WHERE 
                mh.trang_thai = 0
            GROUP BY
                mh.ma_mon_hoc,
                mh.ma_mon,
                mh.ten_mon,
                mh.so_tin_chi,
                mh.loai_mon,
                mh.tong_so_buoi,
                mh.diem_toi_thieu_de_dat,
                mh.trang_thai";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán DataTable vào DataGridView
                dgvThongtinmonhoc.DataSource = dt;
            }
        }
        private void Danhsachmonhocdeleted_Load(object sender, EventArgs e)
        {
            loadmonhocfalse();
        }

        private void btnkhoiphuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học của hàng được chọn
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để cập nhật trạng thái của môn học thành 0 (đã xóa mềm)
                string query = "UPDATE MonHoc SET trang_thai = 1 WHERE ma_mon_hoc = @ma_mon_hoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Khôi Phục Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loadmonhocfalse();
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
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xác nhận với người dùng trước khi xóa vĩnh viễn
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn môn học này? Hành động này không thể hoàn tác!",
                                                         "Xác nhận xóa vĩnh viễn",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
            {
                return; // Người dùng chọn "No", hủy bỏ việc xóa
            }

            // Lấy mã môn học của hàng được chọn
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu lệnh SQL để xóa vĩnh viễn môn học
                string query = "DELETE FROM MonHoc WHERE ma_mon_hoc = @ma_mon_hoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa vĩnh viễn môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loadmonhocfalse();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vĩnh viễn môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
