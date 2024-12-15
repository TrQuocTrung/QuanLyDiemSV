using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKhoa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien dssv = new DanhSachSinhVien();
            this.Hide();
            dssv.ShowDialog();
            this.Show();
        }

        private void btndanhsachmonhoc_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc dsmh = new DanhSachMonHoc();
            this.Hide();
            dsmh.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaoLopHocTheoMon tltmh = new TaoLopHocTheoMon();    
            this.Hide();
            tltmh.ShowDialog(); 
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemSinhVienVaoLop addclass = new ThemSinhVienVaoLop();
            this.Hide();
            addclass.ShowDialog();
            this.Show();
        }

        private void btnquanlydiemsinhvien_Click(object sender, EventArgs e)
        {
            QuanLyDiemSinhVienTheoLopHoc qldiem = new QuanLyDiemSinhVienTheoLopHoc();
            this.Hide();
            qldiem.ShowDialog();
            this.Show();
        }
    }
}
