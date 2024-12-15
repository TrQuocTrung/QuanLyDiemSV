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
    public partial class TaoLopHocTheoMon : Form
    {
        string ConnectionSQl = "";
        ConnectDB db = new ConnectDB();

        public TaoLopHocTheoMon()
        {
            ConnectionSQl = db.Getconnect();
            InitializeComponent();
            LoadDanhSachMonHoc();
            LoadDanhSachLopHoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string maLopCode = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            int siSo;

            // Kiểm tra nếu `si_so` có phải là số hợp lệ và nhỏ hơn hoặc bằng 40
            if (!int.TryParse(txtSiSo.Text, out siSo) || siSo > 40)
            {
                MessageBox.Show("Sĩ số phải là số nguyên và không vượt quá 40.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu đã chọn môn học trong ComboBox
            if (cboDanhsachmonhoc.SelectedItem is ComboBoxItem selectedMonHoc)
            {
                string maMon = selectedMonHoc.MaMon;

                using (SqlConnection conn = new SqlConnection(ConnectionSQl))
                {
                    try
                    {
                        conn.Open();

                        // Bắt đầu giao dịch
                        SqlTransaction transaction = conn.BeginTransaction();

                        // Chèn lớp học mới vào bảng LopHoc
                        string insertLopHocQuery = "INSERT INTO LopHoc (ma_lop_code, ten_lop, si_so, trang_thai) OUTPUT INSERTED.ma_lop VALUES (@maLopCode, @tenLop, @siSo, 1)";
                        SqlCommand insertLopHocCmd = new SqlCommand(insertLopHocQuery, conn, transaction);
                        insertLopHocCmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                        insertLopHocCmd.Parameters.AddWithValue("@tenLop", tenLop);
                        insertLopHocCmd.Parameters.AddWithValue("@siSo", siSo);

                        // Lấy ma_lop sau khi thêm lớp học
                        int maLop = (int)insertLopHocCmd.ExecuteScalar();

                        // Liên kết lớp học mới với môn học đã chọn trong bảng LopHoc_MonHoc
                        string insertLopHocMonHocQuery = "INSERT INTO LopHoc_MonHoc (ma_lop, ma_mon, trang_thai) VALUES (@maLop, @maMon, 1)";
                        SqlCommand insertLopHocMonHocCmd = new SqlCommand(insertLopHocMonHocQuery, conn, transaction);
                        insertLopHocMonHocCmd.Parameters.AddWithValue("@maLop", maLop);
                        insertLopHocMonHocCmd.Parameters.AddWithValue("@maMon", maMon);

                        insertLopHocMonHocCmd.ExecuteNonQuery();

                        // Xác nhận giao dịch
                        transaction.Commit();

                        MessageBox.Show("Thêm lớp học và liên kết với môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa dữ liệu trong các TextBox sau khi thêm thành công
                        txtMaLop.Clear();
                        txtTenLop.Clear();
                        txtSiSo.Value = 0;

                        // Cập nhật lại danh sách lớp học nếu cần
                        LoadDanhSachLopHoc();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoadDanhSachMonHoc()
        {
            string query = "SELECT ma_mon, ten_mon FROM MonHoc WHERE trang_thai = 1"; // Chọn các môn học đang hoạt động
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các mục hiện có trong ComboBox trước khi thêm mới
                    cboDanhsachmonhoc.Items.Clear();

                    // Kiểm tra xem có dữ liệu hay không
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị trong ComboBox.");
                        return;
                    }

                    while (reader.Read())
                    {
                        // Tạo một đối tượng có chứa ma_mon và ten_mon
                        string maMon = reader["ma_mon"].ToString();
                        string tenMon = reader["ten_mon"].ToString();

                        // Thêm item vào ComboBox với tên môn học làm hiển thị và ma_mon làm giá trị
                        cboDanhsachmonhoc.Items.Add(new ComboBoxItem(maMon, tenMon));
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

        // Lớp ComboBoxItem để lưu trữ ma_mon và ten_mon
        public class ComboBoxItem
        {
            public string MaMon { get; set; }
            public string TenMon { get; set; }

            public ComboBoxItem(string maMon, string tenMon)
            {
                MaMon = maMon;
                TenMon = tenMon;
            }

            public override string ToString()
            {
                return $"Tên Môn : {TenMon} Mã Môn : {MaMon}" ; // Chỉ hiển thị tên môn trong ComboBox
            }
        }



        private void LoadDanhSachLopHoc()
        {
            string query = @"
        SELECT 
            mh.ma_mon,
            mh.ten_mon,
            mh.so_tin_chi,
            lh.ma_lop_code,
            lh.ten_lop,
            lh.si_so
        FROM 
            LopHoc lh
        JOIN 
            LopHoc_MonHoc lhmh ON lh.ma_lop = lhmh.ma_lop
        JOIN 
            MonHoc mh ON lhmh.ma_mon = mh.ma_mon
        WHERE 
            lh.trang_thai = 1 AND lhmh.trang_thai = 1;";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.");
                    }

                    dgvDanhSachLopHoc.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải danh sách lớp học: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void TaoLopHocTheoMon_Load(object sender, EventArgs e)
        {
            dgvDanhSachLopHoc.SelectionChanged += dgvDanhSachLopHoc_SelectionChanged;
            LoadDanhSachMonHoc();
            LoadDanhSachLopHoc();
        }

        private void btnsualophoc_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu từ các TextBox
            string maLopCode = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            int siSo;

            // Kiểm tra nếu `si_so` có phải là số hợp lệ và nhỏ hơn hoặc bằng 40
            if (!int.TryParse(txtSiSo.Text, out siSo) || siSo > 40)
            {
                MessageBox.Show("Sĩ số phải là số nguyên và không vượt quá 40.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi truy vấn SQL để cập nhật lớp học
            string query = "UPDATE LopHoc SET ten_lop = @tenLop, si_so = @siSo WHERE ma_lop_code = @maLopCode";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);
                    cmd.Parameters.AddWithValue("@tenLop", tenLop);
                    cmd.Parameters.AddWithValue("@siSo", siSo);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa dữ liệu trong các TextBox sau khi cập nhật thành công
                        txtMaLop.Clear();
                        txtTenLop.Clear();
                        txtSiSo.Value = 0;
                        LoadDanhSachLopHoc();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp học với mã lớp đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoalophockhoimon_Click(object sender, EventArgs e)
        {

            // Lấy mã lớp từ TextBox
            string maLopCode = txtMaLop.Text;

            // Kiểm tra mã lớp không được để trống
            if (string.IsNullOrWhiteSpace(maLopCode))
            {
                MessageBox.Show("Vui lòng nhập mã lớp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi truy vấn SQL để cập nhật trạng thái xóa mềm của lớp học
            string query = "UPDATE LopHoc SET trang_thai = 0 WHERE ma_lop_code = @maLopCode";

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLopCode", maLopCode);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Lớp học đã được xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Xóa dữ liệu trong TextBox sau khi xóa thành công
                        txtMaLop.Clear();
                        LoadDanhSachLopHoc();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Lớp Học Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDanhSachLopHoc_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvDanhSachLopHoc.SelectedRows.Count > 0)
            {
                // Lấy hàng đang được chọn
                DataGridViewRow selectedRow = dgvDanhSachLopHoc.SelectedRows[0];

                // Kiểm tra và lấy giá trị từ các ô, đảm bảo dữ liệu không bị null
                string maLopCode = selectedRow.Cells["ma_lop_code"]?.Value?.ToString() ?? string.Empty;
                string tenLop = selectedRow.Cells["ten_lop"]?.Value?.ToString() ?? string.Empty;
                int siSo = selectedRow.Cells["si_so"] != null ? Convert.ToInt32(selectedRow.Cells["si_so"].Value) : 0;
                string maMon = selectedRow.Cells["ma_mon"]?.Value?.ToString() ?? string.Empty;

                // Hiển thị mã lớp, tên lớp và sĩ số vào các TextBox tương ứng
                txtMaLop.Text = maLopCode;
                txtTenLop.Text = tenLop;
                txtSiSo.Text = siSo.ToString();

                // Thiết lập ComboBox để chọn đúng môn học
                for (int i = 0; i < cboDanhsachmonhoc.Items.Count; i++)
                {
                    ComboBoxItem item = (ComboBoxItem)cboDanhsachmonhoc.Items[i];
                    if (item.MaMon == maMon) // Kiểm tra mã môn học trong ComboBox
                    {
                        cboDanhsachmonhoc.SelectedIndex = i; // Chọn mục trong ComboBox
                        break;
                    }
                }
            }
        }

        private void btnlophocdaxoa_Click(object sender, EventArgs e)
        {
            Danhsachlopdeleted ds = new Danhsachlopdeleted();
            ds.FormClosed += (s, agrs) => LoadDanhSachLopHoc();
            ds.ShowDialog();
        }

        private void cboDanhsachmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
