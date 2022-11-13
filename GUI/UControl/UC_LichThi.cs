using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UControl
{
    public partial class UC_LichThi : UserControl
    {
        private SinhVien_LichThi sinhVienLichThi;
        public UC_LichThi(SinhVien_LichThi sinhVienLichThi)
        {
            InitializeComponent();

            SinhVienLichThi = sinhVienLichThi;

            lbMonHoc.AutoSize = true;
            lbMonHoc.MaximumSize = new Size(panel1.Size.Width, 0);
            lbMonHoc.Text = sinhVienLichThi.LichThi.MonHoc.TenMonHoc;
            lbPhong.Text = "Phòng: "+ sinhVienLichThi.LichThi.PhongThi.ToString();


            int hBD = sinhVienLichThi.LichThi.ThoiGianBD.Value.Hours;
            int mBD = sinhVienLichThi.LichThi.ThoiGianBD.Value.Minutes;

            int hKT = sinhVienLichThi.LichThi.ThoiGianKT.Value.Hours;
            int mKT = sinhVienLichThi.LichThi.ThoiGianKT.Value.Minutes;

            string strTime = hBD + ":" + mBD + " - " + hKT + ":" + mKT;

            lbThoiGian.Text = "Thời gian: "+ strTime;
        }

        public SinhVien_LichThi SinhVienLichThi { get => sinhVienLichThi; set => sinhVienLichThi = value; }

        private void lbMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void UC_LichThi_SizeChanged(object sender, EventArgs e)
        {
            lbMonHoc.AutoSize = true;
            lbMonHoc.MaximumSize = new Size(panel1.Size.Width, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
