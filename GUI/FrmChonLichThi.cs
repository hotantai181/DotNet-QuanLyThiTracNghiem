using BLL;
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
    public partial class FrmChonLichThi : Form
    {
        private SinhVien sinhVien;
        private LichThi lichThi;
        private SinhVien_LichThi sv_lt;

        public FrmChonLichThi(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        public LichThi LichThi { get => lichThi; set => lichThi = value; }
        public SinhVien_LichThi Sv_lt { get => sv_lt; set => sv_lt = value; }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (cbbLichThi.Text != string.Empty)
            {
                FrmThiTracNghiem f = new FrmThiTracNghiem(sinhVien.Mssv, Sv_lt);
                this.Hide();
                f.Show();
            }
        }

        private void FrmChonLichThi_Load(object sender, EventArgs e)
        {
            try
            {
                LichThi = LichThiBLL.getLichThiByDate(DateTime.Today);
                Sv_lt = SinhVien_LichThiBLL.GetSinhVien_LichThi(LichThi.MaLichThi, sinhVien.Mssv);
                
                if (Sv_lt != null)
                    cbbLichThi.Items.Add(Sv_lt.LichThi.MonHoc.MaMonHoc.Trim() + " - " + Sv_lt.LichThi.MonHoc.TenMonHoc);
                else
                {
                    MessageBox.Show("Hôm nay bạn không có lịch thi");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hôm nay bạn không có lịch thi");
                this.Close();
            }
        }
    }
}
