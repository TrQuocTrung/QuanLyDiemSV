using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapCuoiKhoa
{
    public partial class DanhSachSinhVien : Form
    {
        ConnectDB db = new ConnectDB();
        string ConnectionSQl;

        string gioitinh = "";
        
        public DanhSachSinhVien()
        {
            ConnectionSQl = db.Getconnect();
            InitializeComponent();
            Loadssinhvien();
            //KiemTraKetNoi();
        }
        private void checkedlist()
        {
            using(SqlConnection connection = new SqlConnection(ConnectionSQl))
            {
                connection.Open();
                String query = "DBCC CHECKIDENT ('SinhVien',RESEED,0);";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
        /*private void KiemTraKetNoi()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionSQl))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Kết nối cơ sở dữ liệu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu thất bại: " + ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }*/
        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            Loadssinhvien();
        }
        private void Loadssinhvien()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string query = "SELECT * FROM SinhVien WHERE trang_thai=1";
                SqlDataAdapter da = new SqlDataAdapter(query,ConnectionSQl);
                DataTable dt= new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;

            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
           

            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioitinh = "Nữ";
            }
            else if (rdoKhac.Checked)
            {
                gioitinh = "Khác";
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn giới tính cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                
                if (dgvSinhVien.Rows.Count == 0) { checkedlist(); }
                string sql = @"INSERT INTO SinhVien(ma_sinh_vien_code, ho_ten, email, so_dien_thoai, chuyen_nganh, gioi_tinh, ngay_sinh, dia_chi, khoa_hoc, so_can_cuoc) 
                       VALUES (@ma_sinh_vien_code, @ho_ten, @email, @so_dien_thoai, @chuyen_nganh, @gioitinh, @ngay_sinh, @dia_chi, @khoa_hoc, @so_can_cuoc)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Assign parameters with values from the form inputs
                cmd.Parameters.AddWithValue("@ma_sinh_vien_code", txtMaSinhVien.Text);
                cmd.Parameters.AddWithValue("@ho_ten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@so_dien_thoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@chuyen_nganh", cboChuyenNganh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@dia_chi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@khoa_hoc", cboKhoaHoc.Text);
                cmd.Parameters.AddWithValue("@so_can_cuoc", txtSoCanCuoc.Text);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Loadssinhvien();

            }
        }
        private void clear()
        {
            txtMaSinhVien.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            cboChuyenNganh.Text = "";
            txtDiaChi.Text = "";
            cboKhoaHoc.Text = "";
            txtSoCanCuoc.Text = "";
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Determine the selected gender
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioitinh = "Nữ";
            }
            else if (rdoKhac.Checked)
            {
                gioitinh = "Khác";
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn giới tính cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve the selected student's ID from the DataGridView
            string selectedMaSinhVien = dgvSinhVien.SelectedRows[0].Cells["ma_sinh_vien_code"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                string sql = @"UPDATE SinhVien 
                       SET ma_sinh_vien_code = @ma_sinh_vien_code ,
                           ho_ten = @ho_ten, 
                           email = @email, 
                           so_dien_thoai = @so_dien_thoai, 
                           chuyen_nganh = @chuyen_nganh, 
                           gioi_tinh = @gioitinh, 
                           ngay_sinh = @ngay_sinh, 
                           dia_chi = @dia_chi, 
                           khoa_hoc = @khoa_hoc, 
                           so_can_cuoc = @so_can_cuoc 
                       WHERE ma_sinh_vien_code = @ma_sinh_vien_code";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Assign parameters with values from the form inputs
                cmd.Parameters.AddWithValue("@ma_sinh_vien_code", selectedMaSinhVien);
                cmd.Parameters.AddWithValue("@ho_ten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@so_dien_thoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@chuyen_nganh", cboChuyenNganh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@dia_chi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@khoa_hoc", cboKhoaHoc.Text);
                cmd.Parameters.AddWithValue("@so_can_cuoc", txtSoCanCuoc.Text);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Loadssinhvien(); 
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Ensure a student is selected in the DataGridView
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve the selected student's ID from the DataGridView
            string selectedMaSinhVien = dgvSinhVien.SelectedRows[0].Cells["ma_sinh_vien_code"].Value.ToString();

            // Confirm deletion
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Using block for database connection
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                string sql = @"UPDATE SinhVien SET trang_thai=0 WHERE ma_sinh_vien_code =@ma_sinh_vien_code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma_sinh_vien_code", selectedMaSinhVien);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Loadssinhvien(); 
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = "%"+txtTimKiem.Text.Trim()+"%";


            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                // SQL query that searches across all relevant columns
                string query = @"SELECT * FROM SinhVien 
                         WHERE CAST(ma_sinh_vien AS NVARCHAR(50)) LIKE @searchText
                            OR ma_sinh_vien LIKE @searchText
                            OR ma_sinh_vien_code LIKE @searchText
                            OR ho_ten LIKE @searchText 
                            OR ma_sinh_vien LIKE @searchText 
                            OR email LIKE @searchText 
                            OR so_dien_thoai LIKE @searchText 
                            OR chuyen_nganh LIKE @searchText 
                            OR gioi_tinh LIKE @searchText
                            OR CAST(ngay_sinh AS NVARCHAR) LIKE @searchText
                            OR dia_chi LIKE @searchText 
                            OR CAST(khoa_hoc AS NVARCHAR) LIKE @searchText 
                            OR so_can_cuoc LIKE @searchText";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
            {
                
                Loadssinhvien();
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn đầu tiên
                DataGridViewRow selectedRow = dgvSinhVien.SelectedRows[0];

                // Lấy dữ liệu từ các cột và gán vào các điều khiển trên form
                txtMaSinhVien.Text = selectedRow.Cells["ma_sinh_vien_code"].Value.ToString();
                txtHoTen.Text = selectedRow.Cells["ho_ten"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtSoDienThoai.Text = selectedRow.Cells["so_dien_thoai"].Value.ToString();
                cboChuyenNganh.Text = selectedRow.Cells["chuyen_nganh"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["ngay_sinh"].Value);
                txtDiaChi.Text = selectedRow.Cells["dia_chi"].Value.ToString();
                cboKhoaHoc.Text = selectedRow.Cells["khoa_hoc"].Value.ToString();
                txtSoCanCuoc.Text = selectedRow.Cells["so_can_cuoc"].Value.ToString();

                // Xử lý hiển thị giới tính
                string gioiTinh = selectedRow.Cells["gioi_tinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    rdoNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    rdoNu.Checked = true;
                else if (gioiTinh == "Khác")
                    rdoKhac.Checked = true;
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Danhsachsinhviendaxoa dssvdx = new Danhsachsinhviendaxoa();                
            dssvdx.FormClosed += (s, args) => Loadssinhvien();
            dssvdx.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
