using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThongTinSinhVien : Form
    {
        private HocSinh sinhVien;

        public HocSinh SinhVien { get => sinhVien; set => sinhVien = value; }

        public FrmThongTinSinhVien(HocSinh sinhVien)
        {
            InitializeComponent();
            SinhVien = sinhVien;
        }

        private void FrmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void T_Click(object sender, EventArgs e)
        {

        }
        private void SetData()
        {
            textBox3.Text = SinhVien.Mssv;
            textBox4.Text = SinhVien.HoTen;
            textBox5.Text = SinhVien.CMND_CCCD;
            textBox10.Text = SinhVien.GioiTinh;
            string st = sinhVien.NgaySinh.ToString();
            textBox11.Text = String.Format("{0:dd/MM/yyyy}",st);
            //textBox6.Text = SinhVien.Lop.TenLop;
            textBox7.Text = SinhVien.DiaChi;
            textBox8.Text = SinhVien.Sdt;
            textBox9.Text = SinhVien.Email;
            textBox1.Text = SinhVien.MatKhau;
        }

        private void txtNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

        }
    }
}
