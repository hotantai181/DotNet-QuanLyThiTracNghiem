using DTO;
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
    public partial class OnLuyenThIThu : Form
    {
        private HocSinh sinhVien;
        List<MonHoc> listMonHoc;

        public HocSinh SinhVien { get => sinhVien; set => sinhVien = value; }

        public OnLuyenThIThu(HocSinh sinhVien)
        {
            this.sinhVien = sinhVien;
            InitializeComponent();
        }

        private void OnLuyenThIThu_Load(object sender, EventArgs e)
        {

            LoadMonHoc();
            loadBoDeOn();
        }
        private void LoadMonHoc()
        {
     
          
        }

        List<PhieuTaoDe> listPTD;
        List<DeThi> listDETHi;
        private void loadBoDeOn()
        {
            
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FrmThiTracNghiem frmthi = new FrmThiTracNghiem(SinhVien.Mssv,comboBox2.SelectedValue.ToString());
            //this.Hide();
            //frmthi.Show();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadBoDeOn();
        }
    }
}
