using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 1),
                new Point(2000, 100),
                Color.FromArgb(255, 132, 96, 139),
                Color.FromArgb(255, 224, 165, 117));

            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, 2000, 1000);
        }

        private void btnQLNganHangCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {

        }
    }
}
