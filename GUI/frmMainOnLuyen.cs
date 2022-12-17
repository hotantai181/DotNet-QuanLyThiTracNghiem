using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class frmMainOnLuyen : Form
    {
        private HocSinh sinhVien;

        public HocSinh SinhVien { get => sinhVien; set => sinhVien = value; }
        
        public frmMainOnLuyen(HocSinh sinhVien)
        {
            InitializeComponent();
            SinhVien = sinhVien;
           

        }

        public void ShowDeOn()
        {
            FrmMainSinhVien frmMainSinhVien = new FrmMainSinhVien(SinhVien);
            frmMainSinhVien.OpenChildForm(new OnLuyenThIThu(SinhVien));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnLuyenThIThu onluyen = new OnLuyenThIThu(SinhVien);
           
            onluyen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
              ShowDeOn();
            this.Hide();
        }
    }
}
