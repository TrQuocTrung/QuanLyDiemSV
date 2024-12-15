using BaiTapCuoiKhoa.QuanLyDiemSV;
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
    public partial class QuanLyDiemSinhVienTheoLopHoc : Form
    {
        ConnectDB DB = new ConnectDB();
        String ConnectionSQl;

       
        public QuanLyDiemSinhVienTheoLopHoc()
        {
            ConnectionSQl = DB.Getconnect();
            InitializeComponent();
            LoadDanhSachMonHoc();
            cboLoaidaudiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhsachlop.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void LoadDiemSVTheoLop(string maLopCode, string maMonCode)
        {
            string query = @"
SELECT 
    sv.ma_sinh_vien_code AS [Mã Sinh Viên],
    sv.ho_ten AS [Họ và Tên],
    STRING_AGG(CONCAT(ds.ten_thanh_phan, ': ', ds.diem), CHAR(13) + CHAR(10)) AS [Điểm Chi Tiết]
FROM 
    SinhVien sv
INNER JOIN Diem_SinhVien ds ON sv.ma_sinh_vien_code = ds.ma_sinh_vien_code
INNER JOIN LopHoc lh ON ds.ma_lop_code = lh.ma_lop_code
INNER JOIN MonHoc mh ON ds.ma_mon_code = mh.ma_mon
WHERE 
    ds.ma_lop_code = @maLopCode 
    AND ds.ma_mon_code = @maMonCode
    AND sv.trang_thai = 1
    AND ds.trang_thai = 1
GROUP BY 
    sv.ma_sinh_vien_code, sv.ho_ten
ORDER BY 
    sv.ma_sinh_vien_code";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    // Khởi tạo SqlCommand với query và connection
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Truyền tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                    // Sử dụng SqlDataAdapter để lấy dữ liệu
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Mở kết nối và thực hiện truy vấn
                    conn.Open();
                    da.Fill(dt);

                    // Kiểm tra dữ liệu và hiển thị
                    if (dt.Rows.Count > 0)
                    {
                        dgv_danhsachdiemsinhvien.DataSource = dt;

                        // Tự động điều chỉnh độ rộng cột
                        dgv_danhsachdiemsinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Cập nhật trạng thái
                        lblstatuslop.Text = $"Tìm thấy {dt.Rows.Count} sinh viên trong lớp.";
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_danhsachdiemsinhvien.DataSource = null;
                        lblstatuslop.Text = "Không có dữ liệu.";
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi chi tiết
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách điểm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đảm bảo kết nối luôn được đóng
                    conn.Close();
                }
            }
        }


        private void LoadDanhSachMonHoc()
        {
             string query = "SELECT ma_mon, ten_mon FROM MonHoc WHERE trang_thai = 1";
    using (SqlConnection conn = new SqlConnection(ConnectionSQl))
    {
        try
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cboDanhSachMon.Items.Clear();

            if (!reader.HasRows)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong ComboBox.");
                return;
            }

            while (reader.Read())
            {
                string maMon = reader["ma_mon"].ToString();
                string tenMon = reader["ten_mon"].ToString();
                cboDanhSachMon.Items.Add(new ComboBoxItemMonHoc(maMon, tenMon));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
        }

        private void loaddanhsachsinhvientheolop(string maLopCode, string maMonCode)
        { // Truy vấn SQL
            string query = @"
    SELECT 
        sv.ma_sinh_vien_code AS [Mã Sinh Viên], 
        sv.ho_ten AS [Họ Tên]
    FROM 
        SinhVien sv
    INNER JOIN LopHoc_SinhVien lhs ON sv.ma_sinh_vien = lhs.ma_sinh_vien
    INNER JOIN LopHoc lh ON lhs.ma_lop = lh.ma_lop
    INNER JOIN LopHoc_MonHoc lhmh ON lh.ma_lop = lhmh.ma_lop
    INNER JOIN MonHoc mh ON lhmh.ma_mon = mh.ma_mon
    WHERE 
        lh.ma_lop_code = @maLopCode 
        AND mh.ma_mon = @maMonCode
        AND sv.trang_thai = 1
        AND lhs.trang_thai = 1";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Truyền tham số vào câu truy vấn
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                    // Khởi tạo DataAdapter và DataTable để nhận dữ liệu
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Mở kết nối và điền dữ liệu vào DataTable
                    conn.Open();
                    adapter.Fill(dt);

                    // Kiểm tra dữ liệu và hiển thị
                    if (dt.Rows.Count > 0)
                    {
                        dgvSinhVien.DataSource = dt;

                        // Tự động điều chỉnh độ rộng cột
                        dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Không có sinh viên nào trong lớp và môn học đã chọn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSinhVien.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đảm bảo kết nối luôn được đóng
                    conn.Close();
                }
            }
        }
        // Lớp ComboBoxItem để lưu trữ ma_mon và ten_mon
        // Lớp ComboBoxItemMonHoc cho ComboBox cboDanhSachMon (Mã Môn và Tên Môn)
        public class ComboBoxItemMonHoc
        {
            public string MaMon { get; set; }
            public string TenMon { get; set; }

            public ComboBoxItemMonHoc(string maMon, string tenMon)
            {
                MaMon = maMon;
                TenMon = tenMon;
            }

            public override string ToString()
            {
                return $"Mã Môn: {MaMon} - Tên Môn: {TenMon}";
            }
        }
        public class ComboBoxItemLopHoc
        {
            public string MaLop { get; set; }
            public string TenLop { get; set; }

            public ComboBoxItemLopHoc(string maLop, string tenLop)
            {
                MaLop = maLop;
                TenLop = tenLop;
            }

            public override string ToString()
            {
                return $"Mã Lớp: {MaLop} - Tên Lớp: {TenLop}";
            }
        }

        private void QuanLyDiemSinhVienTheoLopHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonHoc();           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDanhSachLoaiDauDiem(string maMon)
        {
            string query = @"
                SELECT ten_thanh_phan 
                FROM ThanhPhanDiem tp
                JOIN MonHoc mh ON tp.ma_mon_hoc = mh.ma_mon_hoc
                WHERE mh.ma_mon = @maMon AND tp.trang_thai = 1";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maMon", maMon);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cboLoaidaudiem.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không có loại đầu điểm nào cho môn học này.");
                        return;
                    }

                    while (reader.Read())
                    {
                        string tenThanhPhan = reader["ten_thanh_phan"].ToString();
                        cboLoaidaudiem.Items.Add(tenThanhPhan); // Thêm chuỗi trực tiếp
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách loại đầu điểm: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void cboLoaidaudiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
            {
                string maMon = selectedMon.MaMon;
                string tenThanhPhan = cboLoaidaudiem.SelectedItem.ToString();

                // Xóa tất cả các cột và dữ liệu cũ trong dataGridViewDiem
                dataGridViewDiem.DataSource = null; // Nếu dùng DataSource
                dataGridViewDiem.Rows.Clear();     // Nếu dữ liệu được thêm bằng Rows
                dataGridViewDiem.Columns.Clear(); // Xóa tất cả các cột

                // Load lại đầu điểm cho môn học
                LoadDauDiemChoMonHoc(maMon, tenThanhPhan);

                // Câu truy vấn để lấy số lượng của loại đầu điểm đã chọn
                string query = @"
        SELECT so_luong
        FROM ThanhPhanDiem
        WHERE ma_mon_hoc = (SELECT ma_mon_hoc FROM MonHoc WHERE ma_mon = @maMon)
        AND ten_thanh_phan = @tenThanhPhan
        AND trang_thai = 1";

                using (SqlConnection conn = new SqlConnection(ConnectionSQl))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@maMon", maMon);
                        cmd.Parameters.AddWithValue("@tenThanhPhan", tenThanhPhan);
                        conn.Open();

                        // Lấy số lượng đầu điểm
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtsoluongdaudiem.Text = result.ToString(); // Hiển thị số lượng trong txtsoluongdaudiem
                        }
                        else
                        {
                            txtsoluongdaudiem.Text = "0"; // Hiển thị 0 nếu không tìm thấy
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lấy số lượng đầu điểm: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học hợp lệ.");
            }
        }

        // Hàm để load danh sách lớp theo mã môn
        private void LoadDanhSachLopTheoMon(string maMon)
        {

            string query = @"
    SELECT lh.ma_lop_code, lh.ten_lop 
    FROM LopHoc lh
    INNER JOIN LopHoc_MonHoc lhmh ON lh.ma_lop = lhmh.ma_lop
    INNER JOIN MonHoc mh ON lhmh.ma_mon = mh.ma_mon
    WHERE mh.ma_mon = @maMon AND lh.trang_thai = 1 AND mh.trang_thai = 1";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maMon", maMon);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cboDanhsachlop.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không có lớp học nào thuộc môn này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    while (reader.Read())
                    {
                        // Lấy dữ liệu mã lớp code và tên lớp
                        string maLopCode = reader["ma_lop_code"].ToString();
                        string tenLop = reader["ten_lop"].ToString();

                        // Thêm vào ComboBox
                        cboDanhsachlop.Items.Add(new ComboBoxItemLopHoc(maLopCode, tenLop));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cboDanhSachMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
            {
                string maMon = selectedMon.MaMon;

                // Load danh sách lớp cho môn đã chọn
                LoadDanhSachLopTheoMon(maMon);

                // Xóa danh sách đầu điểm trước khi chọn lớp
                cboLoaidaudiem.Items.Clear();
                txtsoluongdaudiem.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học hợp lệ.");
            }
        }

        private void cboDanhsachlop_SelectedIndexChanged(object sender, EventArgs e)
        { // Kiểm tra nếu lớp và môn học đã được chọn hợp lệ
            if (cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop && cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
            {
                // Lấy mã lớp và mã môn từ ComboBoxItem
                string maLopCode = selectedLop.MaLop; // Lấy mã lớp code từ ComboBoxItem
                string maMonCode = selectedMon.MaMon; // Lấy mã môn code từ ComboBoxItem
                string tenLop = selectedLop.TenLop;  // Lấy tên lớp từ ComboBoxItem
                
                // Cập nhật trạng thái label với tên lớp
                lblstatuslop.Text = "Danh sách sinh viên trong lớp: " + tenLop;

                // Xóa danh sách đầu điểm cũ trước khi nạp mới
                cboLoaidaudiem.Items.Clear();

                // Load danh sách loại đầu điểm cho môn học đã chọn
                LoadDanhSachLoaiDauDiem(maMonCode);

                // Load danh sách sinh viên trong lớp và môn học đã chọn
                loaddanhsachsinhvientheolop(maLopCode, maMonCode);
                LoadDiemSVTheoLop(maLopCode, maMonCode);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp học và môn học hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      

        //Load đầu điểm môn học 
        private void LoadDauDiemChoMonHoc(string maMon, string selectedThanhPhan = null)
        {

            string query = @"
        SELECT DISTINCT tp.ten_thanh_phan, tp.so_luong
     FROM ThanhPhanDiem tp
     JOIN MonHoc mh ON tp.ma_mon_hoc = mh.ma_mon_hoc
     WHERE mh.ma_mon = @maMon AND tp.trang_thai = 1";

            if (!string.IsNullOrEmpty(selectedThanhPhan))
            {
                query += " AND tp.ten_thanh_phan = @selectedThanhPhan";
            }

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maMon", maMon);
                    if (!string.IsNullOrEmpty(selectedThanhPhan))
                    {
                        cmd.Parameters.AddWithValue("@selectedThanhPhan", selectedThanhPhan);
                    }

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa dữ liệu cũ
                    dataGridViewDiem.Rows.Clear();
                    dataGridViewDiem.Columns.Clear();

                    // Chỉ thêm cột "Tên Thành Phần" và "Điểm"
                    dataGridViewDiem.Columns.Add("ten_thanh_phan", "Tên Thành Phần");
                    dataGridViewDiem.Columns.Add("diem", "Điểm");

                    while (reader.Read())
                    {
                        string tenThanhPhan = reader["ten_thanh_phan"].ToString();
                        int soLuong = reader["so_luong"] != DBNull.Value ? Convert.ToInt32(reader["so_luong"]) : 1;

                        // Thêm dòng theo số lượng yêu cầu
                        for (int i = 0; i < soLuong; i++)
                        {
                            dataGridViewDiem.Rows.Add(tenThanhPhan, ""); // Mỗi dòng sẽ chứa tên thành phần và một ô trống cho điểm
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
        //Control xử Lý người dùng //
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboDanhSachMon.SelectedItem == null || cboDanhsachlop.SelectedItem == null || cboLoaidaudiem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học, Lớp, và Loại đầu điểm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin cần thiết
            var selectedStudentRow = dgvSinhVien.SelectedRows[0];
            string maSinhVienCode = selectedStudentRow.Cells["Mã Sinh Viên"].Value.ToString();
            string maLopCode = ((ComboBoxItemLopHoc)cboDanhsachlop.SelectedItem).MaLop;
            string maMonCode = ((ComboBoxItemMonHoc)cboDanhSachMon.SelectedItem).MaMon;
            string tenThanhPhan = cboLoaidaudiem.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridViewDiem.Rows)
                    {
                        if (row.Cells["diem"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["diem"].Value.ToString()))
                        {
                            float diem;
                            if (!float.TryParse(row.Cells["diem"].Value.ToString(), out diem))
                            {
                                MessageBox.Show("Điểm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }

                            // Câu lệnh thêm điểm vào bảng Diem_SinhVien
                            string insertQuery = @"
                        INSERT INTO Diem_SinhVien (ma_sinh_vien_code, ma_lop_code, ma_mon_code, ten_thanh_phan, diem, trang_thai)
                        VALUES (@maSinhVienCode, @maLopCode, @maMonCode, @tenThanhPhan, @diem, 1)";

                            SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);
                            cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                            cmd.Parameters.AddWithValue("@maMonCode", maMonCode);
                            cmd.Parameters.AddWithValue("@tenThanhPhan", tenThanhPhan);
                            cmd.Parameters.AddWithValue("@diem", diem);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Thêm điểm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDiemSVTheoLop(maLopCode, maMonCode); // Tải lại dữ liệu sau khi thêm điểm
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsuadeimsinhvien_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu điểm để sửa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridViewDiem.Rows)
                    {
                        // Kiểm tra nếu dòng không phải là dòng mới hoặc bị xóa
                        if (row.IsNewRow || row.Cells["Loại Điểm"].Value == null || row.Cells["Điểm"].Value == null)
                            continue;

                        string loaiDiem = row.Cells["Loại Điểm"].Value.ToString();
                        string diemStr = row.Cells["Điểm"].Value.ToString();

                        if (!float.TryParse(diemStr, out float diem) || diem < 0 || diem > 100)
                        {
                            MessageBox.Show($"Điểm không hợp lệ ở mục '{loaiDiem}'. Vui lòng nhập số từ 0 đến 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        // Cập nhật điểm trong bảng Diem_SinhVien
                        string updateQuery = @"
                UPDATE Diem_SinhVien
                SET diem = @diem
                WHERE ma_sinh_vien_code = @maSinhVienCode
                AND ma_lop_code = @maLopCode
                AND ma_mon_code = @maMonCode
                AND ten_thanh_phan = @loaiDiem
                AND trang_thai = 1";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@diem", diem);
                        cmd.Parameters.AddWithValue("@maSinhVienCode", dgvSinhVien.SelectedRows[0].Cells["Mã Sinh Viên"].Value.ToString());
                        cmd.Parameters.AddWithValue("@maLopCode", ((ComboBoxItemLopHoc)cboDanhsachlop.SelectedItem).MaLop);
                        cmd.Parameters.AddWithValue("@maMonCode", ((ComboBoxItemMonHoc)cboDanhSachMon.SelectedItem).MaMon);
                        cmd.Parameters.AddWithValue("@loaiDiem", loaiDiem);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu
                    string maSinhVienCode = dgvSinhVien.SelectedRows[0].Cells["Mã Sinh Viên"].Value.ToString();
                    string maLopCode = ((ComboBoxItemLopHoc)cboDanhsachlop.SelectedItem).MaLop;
                    string maMonCode = ((ComboBoxItemMonHoc)cboDanhSachMon.SelectedItem).MaMon;

                    // Tải lại cả hai DataGridView
                    LoadDiemSinhVien(maSinhVienCode, maLopCode, maMonCode); // Tải lại DataGridViewDiem
                    LoadDiemSVTheoLop(maLopCode, maMonCode); // Tải lại dgv_danhsachdiemsinhvien
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi khi sửa điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoadiemsinhvien_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu chưa chọn sinh viên
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên cần xóa điểm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin sinh viên được chọn
            string maSinhVienCode = dgvSinhVien.SelectedRows[0].Cells["Mã Sinh Viên"].Value?.ToString();
            if (string.IsNullOrEmpty(maSinhVienCode))
            {
                MessageBox.Show("Không thể lấy thông tin sinh viên. Vui lòng chọn lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu cần xóa điểm cụ thể từ dataGridViewDiem
            if (dataGridViewDiem.SelectedRows.Count > 0)
            {
                // Xóa mềm điểm cụ thể từ dataGridViewDiem
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mềm điểm này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tenThanhPhan = dataGridViewDiem.SelectedRows[0].Cells["Loại Điểm"].Value?.ToString();

                    if (string.IsNullOrEmpty(tenThanhPhan))
                    {
                        MessageBox.Show("Không thể xác định loại điểm. Vui lòng chọn lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(ConnectionSQl))
                    {
                        try
                        {
                            string updateQuery = @"
                    UPDATE Diem_SinhVien
                    SET trang_thai = 0
                    WHERE ma_sinh_vien_code = @maSinhVienCode
                    AND ten_thanh_phan = @tenThanhPhan";

                            SqlCommand cmd = new SqlCommand(updateQuery, conn);
                            cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);
                            cmd.Parameters.AddWithValue("@tenThanhPhan", tenThanhPhan);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa mềm điểm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Tải lại dataGridViewDiem
                                if (cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop &&
                                    cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
                                {
                                    string maLopCode = selectedLop.MaLop;
                                    string maMonCode = selectedMon.MaMon;
                                    LoadDiemSinhVien(maSinhVienCode, maLopCode, maMonCode);
                                    LoadDiemSVTheoLop(maLopCode, maMonCode); // Tải lại danh sách tổng
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy điểm để xóa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa mềm điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Xóa mềm tất cả điểm của sinh viên
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa  tất cả điểm của sinh viên này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionSQl))
                    {
                        try
                        {
                            string updateQuery = @"
                    UPDATE Diem_SinhVien
                    SET trang_thai = 0
                    WHERE ma_sinh_vien_code = @maSinhVienCode";

                            SqlCommand cmd = new SqlCommand(updateQuery, conn);
                            cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa mềm toàn bộ điểm của sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Tải lại danh sách
                                if (cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop &&
                                    cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
                                {
                                    string maLopCode = selectedLop.MaLop;
                                    string maMonCode = selectedMon.MaMon;
                                    LoadDiemSVTheoLop(maLopCode, maMonCode); // Tải lại danh sách tổng
                                }

                                // Xóa dữ liệu trên dataGridViewDiem
                                dataGridViewDiem.DataSource = null;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy điểm để xóa mềm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa mềm điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra nếu hàng được chọn là hợp lệ
            if (e.RowIndex >= 0 && dgvSinhVien.Columns.Contains("Mã Sinh Viên"))
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // Lấy mã sinh viên từ cột "Mã Sinh Viên"
                string maSinhVienCode = row.Cells["Mã Sinh Viên"].Value?.ToString();

                if (!string.IsNullOrEmpty(maSinhVienCode))
                {
                    // Cập nhật trạng thái
                    lblstatussv.Text = $"Đang hiển thị điểm của sinh viên: {row.Cells["Họ Tên"].Value}";

                    // Lấy mã lớp và mã môn từ các ComboBox
                    if (cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon &&
                        cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop)
                    {
                        string maMonCode = selectedMon.MaMon;
                        string maLopCode = selectedLop.MaLop;

                        // Gọi hàm để hiển thị điểm của sinh viên trên DataGridViewDiem
                        LoadDiemSinhVien(maSinhVienCode, maLopCode, maMonCode);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn lớp và môn học trước khi xem điểm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin mã sinh viên. Vui lòng chọn lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void LoadDiemSinhVien(string maSinhVienCode, string maLopCode, string maMonCode)
        {
            string query = @"
        SELECT 
            ds.ten_thanh_phan AS [Loại Điểm], 
            ds.diem AS [Điểm]
        FROM Diem_SinhVien ds
        WHERE 
            ds.ma_sinh_vien_code = @maSinhVienCode 
            AND ds.ma_lop_code = @maLopCode 
            AND ds.ma_mon_code = @maMonCode 
            AND ds.trang_thai = 1
        ORDER BY ds.ten_thanh_phan";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maSinhVienCode", maSinhVienCode);
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@maMonCode", maMonCode);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu trên DataGridViewDiem
                        dataGridViewDiem.DataSource = dt;
                        dataGridViewDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu điểm của sinh viên này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDiem.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải điểm của sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridViewDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblstatus_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các cột và dữ liệu cũ trong dataGridViewDiem
            dataGridViewDiem.DataSource = null; // Nếu dùng DataSource
            dataGridViewDiem.Rows.Clear();     // Nếu dữ liệu được thêm bằng Rows
            dataGridViewDiem.Columns.Clear(); // Xóa tất cả các cột
        }

        private void btndsdiemsvdeleted_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ComboBox lớp và môn đã được chọn
            if (cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop &&
                cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon)
            {
                string maLopCode = selectedLop.MaLop;
                string maMonCode = selectedMon.MaMon;

                // Tạo form mới để hiển thị danh sách điểm đã xóa
                DanhSachDiemSinhVienDeleted dssvdx = new DanhSachDiemSinhVienDeleted(maLopCode, maMonCode);

                // Khi form con đóng, tải lại danh sách điểm
                dssvdx.FormClosed += (s, args) => LoadDiemSVTheoLop(maLopCode, maMonCode);

                // Hiển thị form con
                dssvdx.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học và môn học trước khi xem danh sách điểm đã xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndssvpassmon_Click(object sender, EventArgs e)
        {
            if (cboDanhSachMon.SelectedItem is ComboBoxItemMonHoc selectedMon &&
        cboDanhsachlop.SelectedItem is ComboBoxItemLopHoc selectedLop)
            {
                string maLopCode = selectedLop.MaLop;
                string maMonCode = selectedMon.MaMon;

                // Mở form ThongKeSinhVien với mã lớp và mã môn
                ThongKeSinhVien thongKeForm = new ThongKeSinhVien(maLopCode, maMonCode);
                thongKeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cả lớp học và môn học.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

} 
    
    
