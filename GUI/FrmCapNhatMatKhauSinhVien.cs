using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCapNhatMatKhauSinhVien : Form
    {
        string masv;
        public FrmCapNhatMatKhauSinhVien()
        {
            InitializeComponent();
            dgvDSSV.AutoGenerateColumns = false;
        }
        string message = "Bạn có muốn cấp lại mật khẩu của mã sinh viên là: ";
      

        private void txtMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            masv = txtMssv.Text;
            DialogResult result;
            result = MessageBox.Show(message + "'" + txtMssv.Text.Trim() + "'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                SinhVienBLL.GetSinhVien(masv);
                MessageBox.Show("Mật khẩu mới là '" + txtMssv.Text.Trim() + "'", "Thông báo");
            }
        }

        private void dgvDSSV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dgvDSSV.Rows)
            {
                string mssv = item.Cells[0].Value.ToString();
                txtMssv.Text = mssv;
            }
        }

        private void txtMssv_TextChanged_1(object sender, EventArgs e)
        {
            masv = txtMssv.Text;
            dgvDSSV.DataSource = SinhVienBLL.SearchSinhViens(masv, 6);
        }
    }
}
