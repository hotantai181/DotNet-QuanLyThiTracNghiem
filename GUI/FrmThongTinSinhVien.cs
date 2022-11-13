using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThongTinSinhVien : Form
    {
        private SinhVien sinhVien;

        public SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        public FrmThongTinSinhVien(SinhVien sinhVien)
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
            txtMssv.Text = SinhVien.Mssv;
            txtHoTen.Text = SinhVien.HoTen;
            txtCMND.Text = SinhVien.CMND_CCCD;
            txtGioiTinh.Text = SinhVien.GioiTinh;
            txtNgaySinh.Text = SinhVien.NgaySinh.ToString();
            txtLop.Text = SinhVien.Lop.TenLop;
            txtDiaChi.Text = SinhVien.DiaChi;
            txtSDT.Text = SinhVien.Sdt;
            txtEmail.Text = SinhVien.Email;
        }

        private void txtNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
