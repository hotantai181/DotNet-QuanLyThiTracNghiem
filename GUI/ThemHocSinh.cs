using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Data.Common;
namespace GUI
{
    public partial class ThemHocSinh : Form
    {
        public ThemHocSinh()
        {
            InitializeComponent();
        }
        ErrorProvider error = new ErrorProvider();
        private void label6_Click(object sender, EventArgs e)
        {

        }
        string gioiTinh;
        private void checkGioiTinh()
        {
            if (rdbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkGioiTinh();
            if (textBox1.Text.Trim() == string.Empty)
            {
                error.SetError(textBox1, "Không được để trống");
                return;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                error.SetError(textBox2, "Không được để trống"); return;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                error.SetError(textBox3, "Không được để trống"); return;
            }
            if (textBox5.Text.Trim() == string.Empty)
            {
                error.SetError(textBox5, "Không được để trống"); return;
            }
            if (gioiTinh.Equals(""))
            {
                MessageBox.Show("Phải chọn giới tính"); return;
            }


            HocSinh hocSinh = new HocSinh
            {
                Mssv = textBox1.Text,
                HoTen = textBox2.Text,
                NgaySinh = DateTime.Parse(textBox3.Text),
                GioiTinh = gioiTinh,
                Email = textBox5.Text,

            };
            if (HocSinhBLL.AddHocSinh(hocSinh))
            {
                MessageBox.Show("Thêm học sinh thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }
    }
}
