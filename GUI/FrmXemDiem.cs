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
    public partial class FrmXemDiem : Form
    {
        public FrmXemDiem(int soCauDung, int soCauSai, int SoCauChuaLam, float diem)
        {
            InitializeComponent();
            lbSoCauDung.Text = soCauDung + " câu";
            lbSoCauSai.Text = soCauSai + " câu";
            lbSoCauChuaLam.Text = SoCauChuaLam + " câu"; 
            lbTongDiem.Text = "Tổng điểm: "+diem + " điểm";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {

        }
    }
}
