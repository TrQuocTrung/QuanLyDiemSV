using BaiTapCuoiKhoa.QuanLyLopHoc;
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
    public partial class ThemSinhVienVaoLop : Form
    {
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();
        public ThemSinhVienVaoLop()
        {
            ConnectionSQl = db.Getconnect();
            InitializeComponent();
            danhsachmonhoc.SelectionChanged += danhsachmonhoc_SelectionChanged;
            danhsachlophoc.SelectionChanged += danhsachlophoc_SelectionChanged;
        }
        private void LoadDanhSachMonHoc()
        {
            string query = "SELECT ma_mon, ten_mon FROM MonHoc WHERE trang_thai = 1"; // Chỉ tải các môn học đang hoạt động

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
                        danhsachmonhoc.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không có môn học nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách môn học: " + ex.Message);
                }
            }
        }
        private void LoadDanhSachLopHoc(string maMonHoc)
        {
             // Cập nhật truy vấn với tên cột chính xác là `ma_mon`
    string query = @"
    SELECT lh.ma_lop, lh.ma_lop_code, lh.ten_lop, lh.si_so
    FROM LopHoc lh
    JOIN LopHoc_MonHoc lhm ON lh.ma_lop = lhm.ma_lop
    JOIN MonHoc mh ON lhm.ma_mon = mh.ma_mon
    WHERE mh.ma_mon = @maMonHoc AND lh.trang_thai = 1 AND lhm.trang_thai = 1";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maMonHoc", maMonHoc);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView nếu có kết quả
                        danhsachlophoc.DataSource = dt;
                    }
                    else
                    {
                        // Không có lớp học cho môn này, đặt nguồn dữ liệu của DataGridView thành null
                        danhsachlophoc.DataSource = null;
                        MessageBox.Show("Không có lớp học nào cho môn học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách lớp học: " + ex.Message);
                }
            }
        }
        private void LoadDanhSachSinhVien()
        {
            string query = "SELECT ma_sinh_vien, ho_ten, ma_sinh_vien_code, email, so_dien_thoai, chuyen_nganh, gioi_tinh, ngay_sinh, dia_chi, khoa_hoc, so_can_cuoc FROM SinhVien WHERE trang_thai = 1";

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
                        dssinhvien.DataSource = dt;
                    }
                    else
                    {
                        dssinhvien.DataSource = null;
                        MessageBox.Show("Không có sinh viên nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách sinh viên: " + ex.Message);
                }
            }
        }
        //(Tùy chọn) Tải Danh Sách Sinh Viên Trong Lớp Khi Chọn Lớp
        private void LoadDanhSachSinhVienTheoLop(int maLop)
        {
            string query = @"
        SELECT sv.ma_sinh_vien, sv.ho_ten, sv.ma_sinh_vien_code, sv.email, sv.so_dien_thoai, 
               sv.chuyen_nganh, sv.gioi_tinh, sv.ngay_sinh, sv.dia_chi, sv.khoa_hoc, sv.so_can_cuoc
        FROM SinhVien sv
        JOIN LopHoc_SinhVien lhs ON sv.ma_sinh_vien = lhs.ma_sinh_vien
        WHERE lhs.ma_lop = @maLop AND sv.trang_thai = 1 AND lhs.trang_thai = 1";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLop", maLop); // Sử dụng ma_lop để lọc sinh viên theo lớp
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        danhsachsinhvientronglop.DataSource = dt;
                    }
                    else
                    {
                        danhsachsinhvientronglop.DataSource = null;
                        MessageBox.Show("Không có sinh viên nào trong lớp này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách sinh viên theo lớp: " + ex.Message);
                }
            }
        }

        private void ThemSinhVienVaoLop_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonHoc();
            // Tải danh sách sinh viên (tất cả sinh viên) khi form tải lên
            LoadDanhSachSinhVien();
        }

        private void danhsachmonhoc_SelectionChanged(object sender, EventArgs e)
        {
            if (danhsachmonhoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = danhsachmonhoc.SelectedRows[0];
                string maMonHoc = selectedRow.Cells["ma_mon"].Value.ToString();

                // Gọi phương thức để tải danh sách lớp học dựa vào mã môn
                LoadDanhSachLopHoc(maMonHoc);
            }
        }

        private void danhsachlophoc_SelectionChanged(object sender, EventArgs e)
        {
            if (danhsachlophoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = danhsachlophoc.SelectedRows[0];

                // Lấy `ma_lop` từ dòng được chọn trong `danhsachlophoc`
                if (selectedRow.Cells["ma_lop"].Value != null)
                {
                    int maLop = Convert.ToInt32(selectedRow.Cells["ma_lop"].Value);
                    LoadDanhSachSinhVienTheoLop(maLop);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã lớp trong dòng được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong dssinhvien hay không
            if (dssinhvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã sinh viên từ hàng được chọn trong dssinhvien
            DataGridViewRow selectedSinhVienRow = dssinhvien.SelectedRows[0];
            int maSinhVien = Convert.ToInt32(selectedSinhVienRow.Cells["ma_sinh_vien"].Value);

            // Kiểm tra xem có hàng nào được chọn trong `danhsachlophoc` để lấy `maLop`
            if (danhsachlophoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ danh sách lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedLopRow = danhsachlophoc.SelectedRows[0];
            int maLop = Convert.ToInt32(selectedLopRow.Cells["ma_lop"].Value);

            // Kiểm tra xem sinh viên đã tồn tại trong lớp chưa
            string checkQuery = "SELECT COUNT(*) FROM LopHoc_SinhVien WHERE ma_lop = @maLop AND ma_sinh_vien = @maSinhVien";
            string insertQuery = "INSERT INTO LopHoc_SinhVien (ma_lop, ma_sinh_vien, trang_thai) VALUES (@maLop, @maSinhVien, 1)";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra nếu sinh viên đã tồn tại trong lớp
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@maLop", maLop);
                        checkCmd.Parameters.AddWithValue("@maSinhVien", maSinhVien);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Sinh viên này đã có trong lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Thêm sinh viên vào lớp
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@maLop", maLop);
                        insertCmd.Parameters.AddWithValue("@maSinhVien", maSinhVien);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sinh viên vào lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Cập nhật danh sách sinh viên trong lớp sau khi thêm
                            LoadDanhSachSinhVienTheoLop(maLop);
                        }
                        else
                        {
                            MessageBox.Show("Thêm sinh viên vào lớp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoasinhvienkhoilop_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có hàng nào được chọn trong `danhsachsinhvientronglop` hay không
            if (danhsachsinhvientronglop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách sinh viên trong lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã sinh viên từ hàng được chọn trong `danhsachsinhvientronglop`
            DataGridViewRow selectedSinhVienRow = danhsachsinhvientronglop.SelectedRows[0];
            int maSinhVien = Convert.ToInt32(selectedSinhVienRow.Cells["ma_sinh_vien1"].Value);

            // Kiểm tra xem có hàng nào được chọn trong `danhsachlophoc` để lấy `maLop`
            if (danhsachlophoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ danh sách lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedLopRow = danhsachlophoc.SelectedRows[0];
            int maLop = Convert.ToInt32(selectedLopRow.Cells["ma_lop"].Value);

            // Câu lệnh cập nhật `trang_thai` của sinh viên trong lớp thành `0` thay vì xóa hoàn toàn
            string updateQuery = "UPDATE LopHoc_SinhVien SET trang_thai = 0 WHERE ma_lop = @maLop AND ma_sinh_vien = @maSinhVien";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@maLop", maLop);
                    updateCmd.Parameters.AddWithValue("@maSinhVien", maSinhVien);

                    conn.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sinh viên khỏi lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật danh sách sinh viên trong lớp sau khi cập nhật `trang_thai`
                        LoadDanhSachSinhVienTheoLop(maLop);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên khỏi lớp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy mã lớp hiện tại từ DataGridView hoặc biến lưu mã lớp đang chọn
           
                DataGridViewRow selectedRow = danhsachlophoc.SelectedRows[0];
                int maLop = Convert.ToInt32(selectedRow.Cells["ma_lop"].Value); // Giả sử cột "ma_lop" tồn tại

                // Khởi tạo form DanhSachSinhVienDaXoaKhoiLop và truyền mã lớp vào
                DanhSachSinhVienDaXoaKhoiLop ds = new DanhSachSinhVienDaXoaKhoiLop(maLop);

                // Đăng ký sự kiện FormClosed để tải lại danh sách sinh viên theo lớp khi form này đóng
                ds.FormClosed += (s, args) => LoadDanhSachSinhVienTheoLop(maLop);

                ds.ShowDialog();
            

        }
    }
}
