using BaiTapCuoiKhoa.QuanLySinhVien;
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
    public partial class DanhSachMonHoc : Form
    {
        ConnectDB DB = new ConnectDB();
        String ConnectionSQl;

        public DanhSachMonHoc()
        {
            ConnectionSQl = DB.Getconnect();
            InitializeComponent();
            loadmonhoctrue();
        }
        private void cleardata()
        {
            // Xóa trắng các trường nhập liệu sau khi thêm
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            cboPhanLoai.SelectedIndex = -1;
            txtTongSoBuoi.Clear();
            txtDiemToiThieuPass.Clear();
            cboLoaidaudiem.SelectedIndex = -1;
            txtSoDauDiem.Clear();
            txttiledaudiem.Clear();
        }
        public void loadmonhoctrue()
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
             tp.ten_thanh_phan + N' Đầu Điểm : ' + CAST(tp.so_luong AS NVARCHAR(10)) + 
             N' Tỉ Lệ : ' + CAST(tp.ti_le AS NVARCHAR(10)) + N' %', 
             N' ; ') AS danh_sach_dau_diem,
         mh.trang_thai
     FROM  
         MonHoc AS mh
     LEFT JOIN 
         ThanhPhanDiem AS tp ON mh.ma_mon_hoc = tp.ma_mon_hoc AND tp.trang_thai = 1
     WHERE 
         mh.trang_thai = 1
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSoTinChi_Click(object sender, EventArgs e)
        {

        }

        private void lblTenMon_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhsachmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            loadmonhoctrue();
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Lấy thông tin từ các điều khiển nhập liệu
                string maMon = txtMaMon.Text;
                string tenMon = txtTenMon.Text;
                int soTinChi = int.Parse(txtSoTinChi.Text);
                string loaiMon = cboPhanLoai.SelectedItem.ToString();
                int tongSoBuoi = int.Parse(txtTongSoBuoi.Text);
                decimal diemToiThieuDeDat = decimal.Parse(txtDiemToiThieuPass.Text);

                // Thêm dữ liệu vào bảng MonHoc và lấy lại ma_mon_hoc vừa tạo
                string queryMonHoc = @"
            INSERT INTO MonHoc (
                ma_mon, 
                ten_mon, 
                so_tin_chi, 
                loai_mon, 
                tong_so_buoi, 
                diem_toi_thieu_de_dat, 
                trang_thai
            ) VALUES (
                @ma_mon, 
                @ten_mon, 
                @so_tin_chi, 
                @loai_mon, 
                @tong_so_buoi,                   
                @diem_toi_thieu_de_dat, 
                1
            );
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmdMonHoc = new SqlCommand(queryMonHoc, conn);

                cmdMonHoc.Parameters.AddWithValue("@ma_mon", maMon);
                cmdMonHoc.Parameters.AddWithValue("@ten_mon", tenMon);
                cmdMonHoc.Parameters.AddWithValue("@so_tin_chi", soTinChi);
                cmdMonHoc.Parameters.AddWithValue("@loai_mon", loaiMon);
                cmdMonHoc.Parameters.AddWithValue("@tong_so_buoi", tongSoBuoi);
                cmdMonHoc.Parameters.AddWithValue("@diem_toi_thieu_de_dat", diemToiThieuDeDat);

                try
                {
                    // Lưu môn học và lấy mã môn học mới tạo
                    int maMonHocMoi = Convert.ToInt32(cmdMonHoc.ExecuteScalar());

                    if (maMonHocMoi > 0)
                    {
                        // Sau khi thêm thành công vào bảng MonHoc, thêm các đầu điểm vào bảng ThanhPhanDiem
                        string tenThanhPhan = cboLoaidaudiem.SelectedItem?.ToString() ?? "";
                        int soLuong = int.Parse(txtSoDauDiem.Text);
                        decimal tiLe = decimal.Parse(txttiledaudiem.Text);

                        string queryThanhPhanDiem = @"
                    INSERT INTO ThanhPhanDiem (
                        ma_mon_hoc,
                        ten_thanh_phan,
                        so_luong,
                        ti_le,
                        trang_thai
                    ) VALUES (
                        @ma_mon_hoc,
                        @ten_thanh_phan,
                        @so_luong,
                        @ti_le,
                        1
                    );";

                        SqlCommand cmdThanhPhanDiem = new SqlCommand(queryThanhPhanDiem, conn);
                        cmdThanhPhanDiem.Parameters.AddWithValue("@ma_mon_hoc", maMonHocMoi);
                        cmdThanhPhanDiem.Parameters.AddWithValue("@ten_thanh_phan", tenThanhPhan);
                        cmdThanhPhanDiem.Parameters.AddWithValue("@so_luong", soLuong);
                        cmdThanhPhanDiem.Parameters.AddWithValue("@ti_le", tiLe);

                        int resultThanhPhanDiem = cmdThanhPhanDiem.ExecuteNonQuery();

                        if (resultThanhPhanDiem > 0)
                        {
                            MessageBox.Show("Lưu thông tin môn học và các thành phần điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu thông tin môn học thành công, nhưng lưu thành phần điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Gọi lại hàm loadmonhoctrue để tải lại dữ liệu vào DataGridView
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học của hàng được chọn
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Lấy thông tin từ các điều khiển nhập liệu để thực hiện cập nhật
                string maMon = txtMaMon.Text;
                string tenMon = txtTenMon.Text;
                int soTinChi = int.Parse(txtSoTinChi.Text);
                string loaiMon = cboPhanLoai.SelectedItem.ToString();
                int tongSoBuoi = int.Parse(txtTongSoBuoi.Text);
                decimal diemToiThieuDeDat = decimal.Parse(txtDiemToiThieuPass.Text);

                // Câu lệnh SQL để cập nhật thông tin môn học
                string query = @"
            UPDATE MonHoc
            SET 
                ma_mon = @ma_mon,
                ten_mon = @ten_mon,
                so_tin_chi = @so_tin_chi,
                loai_mon = @loai_mon,
                tong_so_buoi = @tong_so_buoi,
                diem_toi_thieu_de_dat = @diem_toi_thieu_de_dat
            WHERE 
                ma_mon_hoc = @ma_mon_hoc";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Gán các giá trị từ điều khiển vào tham số SQL
                cmd.Parameters.AddWithValue("@ma_mon", maMon);
                cmd.Parameters.AddWithValue("@ten_mon", tenMon);
                cmd.Parameters.AddWithValue("@so_tin_chi", soTinChi);
                cmd.Parameters.AddWithValue("@loai_mon", loaiMon);
                cmd.Parameters.AddWithValue("@tong_so_buoi", tongSoBuoi);
                cmd.Parameters.AddWithValue("@diem_toi_thieu_de_dat", diemToiThieuDeDat);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvThongtinmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvThongtinmonhoc_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvThongtinmonhoc.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvThongtinmonhoc.SelectedRows[0];

                // Gán dữ liệu từ hàng được chọn vào các TextBox
                txtMaMon.Text = selectedRow.Cells["ma_mon"].Value?.ToString();
                txtTenMon.Text = selectedRow.Cells["ten_mon"].Value?.ToString();
                txtSoTinChi.Text = selectedRow.Cells["so_tin_chi"].Value?.ToString();
                cboPhanLoai.SelectedItem = selectedRow.Cells["loai_mon"].Value?.ToString();
                txtTongSoBuoi.Text = selectedRow.Cells["tong_so_buoi"].Value?.ToString();
                txtDiemToiThieuPass.Text = selectedRow.Cells["diem_toi_thieu_de_dat"].Value?.ToString();

                // Lấy mã môn học và tải danh sách các thành phần điểm
                int maMonHoc = Convert.ToInt32(selectedRow.Cells["ma_mon_hoc"].Value);
                LoadDanhSachThanhPhanDiem(maMonHoc);

                // Chọn mục đầu tiên trong danh sách và tải thông tin điểm
                if (cboLoaidaudiem.Items.Count > 0)
                {
                    cboLoaidaudiem.SelectedIndex = 0; // Chọn mục đầu tiên
                    LoadThongTinDiem(); // Hiển thị thông tin điểm cho loại đầu điểm đầu tiên
                }
            }
        }
        private void LoadDanhSachThanhPhanDiem(int maMonHoc)
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm lại
            cboLoaidaudiem.Items.Clear();

            // Thêm các loại đầu điểm mặc định
            cboLoaidaudiem.Items.Add("Điểm Lab");
            cboLoaidaudiem.Items.Add("Điểm Quiz");
            cboLoaidaudiem.Items.Add("Điểm Assignment");
            cboLoaidaudiem.Items.Add("Điểm Thi");

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();
                string query = "SELECT DISTINCT ten_thanh_phan FROM ThanhPhanDiem WHERE ma_mon_hoc = @ma_mon_hoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);

                SqlDataReader reader = cmd.ExecuteReader();

                // Đọc các loại điểm từ cơ sở dữ liệu và thêm vào ComboBox (nếu chưa có)
                while (reader.Read())
                {
                    string tenThanhPhan = reader["ten_thanh_phan"].ToString();
                    if (!cboLoaidaudiem.Items.Contains(tenThanhPhan)) // Đảm bảo không bị trùng
                    {
                        cboLoaidaudiem.Items.Add(tenThanhPhan);
                    }
                }
                reader.Close();
            }

            // Thiết lập loại đầu điểm mặc định là mục đầu tiên
            if (cboLoaidaudiem.Items.Count > 0)
            {
                cboLoaidaudiem.SelectedIndex = 0; // Chọn mục đầu tiên
                LoadThongTinDiem(); // Hiển thị thông tin điểm cho loại đầu điểm đầu tiên
            }
        }

        private void cboLoaidaudiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinDiem();
        }
        private void LoadThongTinDiem()
        {
            if (cboLoaidaudiem.SelectedItem == null || dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                txtSoDauDiem.Clear();
                txttiledaudiem.Clear();
                return;
            }

            // Lấy mã môn học và loại thành phần điểm hiện tại
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);
            string tenThanhPhan = cboLoaidaudiem.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();
                string query = "SELECT so_luong, ti_le FROM ThanhPhanDiem WHERE ma_mon_hoc = @ma_mon_hoc AND ten_thanh_phan = @ten_thanh_phan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);
                cmd.Parameters.AddWithValue("@ten_thanh_phan", tenThanhPhan);

                SqlDataReader reader = cmd.ExecuteReader();

                // Nếu có dữ liệu, hiển thị vào TextBox, nếu không thì xóa trắng TextBox
                if (reader.Read())
                {
                    txtSoDauDiem.Text = reader["so_luong"].ToString();
                    txttiledaudiem.Text = reader["ti_le"].ToString();
                }
                else
                {
                    txtSoDauDiem.Clear();
                    txttiledaudiem.Clear();
                }
                reader.Close();
            }
        }

        private void btnxoathongtinmonhoc_Click(object sender, EventArgs e)
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
                string query = "UPDATE MonHoc SET trang_thai = 0 WHERE ma_mon_hoc = @ma_mon_hoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa Thông Tin Môn Học Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu trên DataGridView
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thông Tin Môn Học Thất Bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void danhsachmondaxa_Click(object sender, EventArgs e)
        {
            Danhsachmonhocdeleted ds = new Danhsachmonhocdeleted();
            ds.FormClosed += (s, args) => loadmonhoctrue();
            ds.ShowDialog();

        }

        private void btnthemdaudiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học để thêm đầu điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học từ hàng được chọn trong DataGridView
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            // Lấy thông tin từ các ô nhập liệu
            string tenThanhPhan = cboLoaidaudiem.SelectedItem?.ToString() ?? "";
            int soLuong = int.Parse(txtSoDauDiem.Text);
            decimal tiLe = decimal.Parse(txttiledaudiem.Text);

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu truy vấn SQL để thêm đầu điểm vào cơ sở dữ liệu
                string query = @"
            INSERT INTO ThanhPhanDiem (
                ma_mon_hoc,
                ten_thanh_phan,
                so_luong,
                ti_le,
                trang_thai
            ) VALUES (
                @ma_mon_hoc,
                @ten_thanh_phan,
                @so_luong,
                @ti_le,
                1
            );";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Gán các giá trị vào tham số SQL
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);
                cmd.Parameters.AddWithValue("@ten_thanh_phan", tenThanhPhan);
                cmd.Parameters.AddWithValue("@so_luong", soLuong);
                cmd.Parameters.AddWithValue("@ti_le", tiLe);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm đầu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới DataGridView để hiển thị dữ liệu mới
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đầu điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsuadaudiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học để sửa đầu điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học từ hàng được chọn trong DataGridView
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            // Kiểm tra xem loại đầu điểm đã được chọn trong ComboBox chưa
            if (cboLoaidaudiem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại đầu điểm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy thông tin từ các ô nhập liệu
            string tenThanhPhan = cboLoaidaudiem.SelectedItem.ToString();
            int soLuong;
            decimal tiLe;

            // Kiểm tra và chuyển đổi giá trị nhập vào từ TextBox
            if (!int.TryParse(txtSoDauDiem.Text, out soLuong))
            {
                MessageBox.Show("Số đầu điểm phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txttiledaudiem.Text, out tiLe))
            {
                MessageBox.Show("Tỉ lệ phải là một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu truy vấn SQL để cập nhật đầu điểm trong cơ sở dữ liệu
                string query = @"
        UPDATE ThanhPhanDiem
        SET so_luong = @so_luong,
            ti_le = @ti_le
        WHERE ma_mon_hoc = @ma_mon_hoc AND ten_thanh_phan = @ten_thanh_phan";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Gán các giá trị vào tham số SQL
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);
                cmd.Parameters.AddWithValue("@ten_thanh_phan", tenThanhPhan);
                cmd.Parameters.AddWithValue("@so_luong", soLuong);
                cmd.Parameters.AddWithValue("@ti_le", tiLe);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa đầu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới DataGridView để hiển thị dữ liệu mới
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Sửa đầu điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoadaudiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvThongtinmonhoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa đầu điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy mã môn học từ hàng được chọn trong DataGridView
            int maMonHoc = Convert.ToInt32(dgvThongtinmonhoc.SelectedRows[0].Cells["ma_mon_hoc"].Value);

            // Kiểm tra xem loại đầu điểm đã được chọn trong ComboBox chưa
            if (cboLoaidaudiem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại đầu điểm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy thông tin loại đầu điểm
            string tenThanhPhan = cboLoaidaudiem.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Câu truy vấn SQL để cập nhật trạng thái của đầu điểm thành 0 (xóa mềm)
                string query = @"
        UPDATE ThanhPhanDiem
        SET trang_thai = 0
        WHERE ma_mon_hoc = @ma_mon_hoc AND ten_thanh_phan = @ten_thanh_phan";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Gán các giá trị vào tham số SQL
                cmd.Parameters.AddWithValue("@ma_mon_hoc", maMonHoc);
                cmd.Parameters.AddWithValue("@ten_thanh_phan", tenThanhPhan);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa đầu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới DataGridView để hiển thị dữ liệu mới
                        loadmonhoctrue();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đầu điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Danhsachdiemdeleted ds = new Danhsachdiemdeleted();
            ds.FormClosed += (s, agrs) => loadmonhoctrue();
            ds.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox
            string searchKeyword = txtTimKiem.Text.Trim();

            // Nếu từ khóa trống, hiển thị toàn bộ danh sách
            if (string.IsNullOrEmpty(searchKeyword))
            {
                loadmonhoctrue(); // Hiển thị lại toàn bộ danh sách
                return;
            }

            // Thực hiện tìm kiếm theo từ khóa
            using (SqlConnection conn = new SqlConnection(ConnectionSQl))
            {
                conn.Open();

                // Tạo câu truy vấn SQL với điều kiện tìm kiếm
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
                N'; ') AS danh_sach_dau_diem,
            mh.trang_thai
        FROM  
            MonHoc AS mh
        LEFT JOIN 
            ThanhPhanDiem AS tp ON mh.ma_mon_hoc = tp.ma_mon_hoc AND tp.trang_thai = 1
        WHERE 
            mh.trang_thai = 1 AND 
            (mh.ma_mon_hoc LIKE '%' + @search + '%' OR
             mh.ma_mon LIKE '%' + @search + '%' OR
             mh.ten_mon LIKE '%' + @search + '%' OR
             mh.so_tin_chi LIKE '%' + @search + '%' OR
             mh.loai_mon LIKE '%' + @search + '%' OR
             mh.tong_so_buoi LIKE '%' + @search + '%' OR
             mh.diem_toi_thieu_de_dat LIKE '%' + @search + '%')
        GROUP BY
            mh.ma_mon_hoc,
            mh.ma_mon,
            mh.ten_mon,
            mh.so_tin_chi,
            mh.loai_mon,
            mh.tong_so_buoi,               
            mh.diem_toi_thieu_de_dat,
            mh.trang_thai";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", searchKeyword);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán DataTable vào DataGridView
                dgvThongtinmonhoc.DataSource = dt;
            }
        }
    }
}
