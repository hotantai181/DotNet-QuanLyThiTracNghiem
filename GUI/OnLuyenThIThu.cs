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

namespace GUI
{
    public partial class OnLuyenThIThu : Form
    {
        private HocSinh sinhVien;

        public HocSinh SinhVien { get => sinhVien; set => sinhVien = value; }

        public OnLuyenThIThu(HocSinh sinhVien)
        {
            this.sinhVien = sinhVien;
            InitializeComponent();
        }

        private void OnLuyenThIThu_Load(object sender, EventArgs e)
        {

        }
    }
}
