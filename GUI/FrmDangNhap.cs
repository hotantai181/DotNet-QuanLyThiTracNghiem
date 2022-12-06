using BLL;
using DTO;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        ErrorProvider error = new ErrorProvider();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == string.Empty)
            {
                error.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
                return;
            }
            if (txtMatKhau.Text.Trim() == string.Empty)
            {
                error.SetError(txtMatKhau, "Mật khẩu không được để trống");
                return;
            }

            Form f;
            if (rdoBtnSinhVien.Checked)
            {
                if (HocSinhBLL.checkUsername(txtTenDangNhap.Text))
                {
                    var sinhVien = HocSinhBLL.checkPassword(txtTenDangNhap.Text, txtMatKhau.Text);
                    if (sinhVien != null)
                    {
                        f = new FrmMainSinhVien(sinhVien);
                    }
                    else
                    {
                        error.SetError(txtMatKhau, "Mật khẩu không chính xác");
                        return;
                    }
                }
                else
                {
                    error.SetError(txtTenDangNhap, "Tên đăng nhập không chính xác");
                    return;
                }
            }
            else
            {
                if (GiaoVienBLL.CheckUsername(txtTenDangNhap.Text))
                {
                    var giaoVien = GiaoVienBLL.CheckPassword(txtTenDangNhap.Text, txtMatKhau.Text);
                    if (giaoVien != null)
                    {
                        
                        f = new FrmMain(giaoVien);

                    }
                    else
                    {
                        error.SetError(txtMatKhau, "Mật khẩu không chính xác");
                        return;
                    }
                }
                else
                {
                    error.SetError(txtTenDangNhap, "Tên đăng nhập không chính xác");
                    return;
                }
            }    
            if (f != null)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            int result = config.Check_Config();
            if (result == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                FrmCauHinh f = new FrmCauHinh();
                f.ShowDialog();
            }else if (result == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp.");
                FrmCauHinh f = new FrmCauHinh();
                f.ShowDialog();
            }

            rdoBtnSinhVien.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 1),
                new Point(2000, 100),
                Color.FromArgb(255, 132, 96, 139),
                Color.FromArgb(255, 224, 165, 117));

            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, 2000, 1000);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 1),
                new Point(2000, 100),
                Color.FromArgb(255, 222, 106, 122),
                Color.FromArgb(255, 224, 165, 113));

            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, 2000, 1000);
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 1),
                new Point(2000, 100),
                Color.FromArgb(255, 255, 255, 255),
                Color.FromArgb(255, 255, 255, 255));

            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 30, 50, 80, 2);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
