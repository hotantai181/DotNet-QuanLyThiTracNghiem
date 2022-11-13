using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMainSinhVien : Form
    {

        bool isLogout = false;
        private SinhVien sinhVien;

        public SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        public FrmMainSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();
            SinhVien = sinhVien;
            mnHome.PerformClick();
        }
        private void OpenChildForm(Form childForm)
        {
            if (MdiChildren.Length > 0)
            {
                foreach (var child in MdiChildren)
                {
                    child.Close();
                }
            }
            this.Text = childForm.Text;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        private void mnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongTinSinhVien(SinhVien));
        }

        private void mnXemLichThi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmXemLichThi(sinhVien));
        }

        private void mnThi_Click(object sender, EventArgs e)
        {

            FrmChonLichThi f = new FrmChonLichThi(sinhVien);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FrmMainSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isLogout)
                Application.Exit();
        }

        private void FrmMainSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isLogout = true;
                this.Close();
            }
        }
    }
}
