using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmXemLichThi : Form
    {
        private DateTime date;
        private SinhVien sinhVien;

        public DateTime Date { get => date; set => date = value; }

        public FrmXemLichThi(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmXemLichThi_Load(object sender, EventArgs e)
        {
            Date = dtpToDay.Value;
            SetDateForThu();
            LoadLichHoc(Date);
        }


        public DateTime MondayOfWeek(DateTime date)
        {
            var dayOfWeek = date.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Sunday)
            {
                return date.AddDays(-6);
            }

            int offset = dayOfWeek - DayOfWeek.Monday;
            return date.AddDays(-offset);
        }
        private void SetDateForThu()
        {
            DateTime mondayOfWeek = MondayOfWeek(dtpToDay.Value);
            lbThu2.Text = "Thứ 2 \n " + mondayOfWeek.ToShortDateString();
            lbThu3.Text = "Thứ 3 \n " + mondayOfWeek.AddDays(1).ToShortDateString();
            lbThu4.Text = "Thứ 4 \n " + mondayOfWeek.AddDays(2).ToShortDateString();
            lbThu5.Text = "Thứ 5 \n " + mondayOfWeek.AddDays(3).ToShortDateString();
            lbThu6.Text = "Thứ 6 \n " + mondayOfWeek.AddDays(4).ToShortDateString();
            lbThu7.Text = "Thứ 7 \n " + mondayOfWeek.AddDays(5).ToShortDateString();
            lbThuCN.Text = "Chủ nhật \n " + mondayOfWeek.AddDays(6).ToShortDateString();

            tlpLichThi.Controls.Add(panel13, 7, 0);
            tlpLichThi.Controls.Add(panel12, 6, 0);
            tlpLichThi.Controls.Add(panel11, 5, 0);
            tlpLichThi.Controls.Add(panel10, 4, 0);
            tlpLichThi.Controls.Add(panel9, 3, 0);
            tlpLichThi.Controls.Add(panel8, 2, 0);
            tlpLichThi.Controls.Add(panel7, 1, 0);
            tlpLichThi.Controls.Add(panel6, 0, 3);
            tlpLichThi.Controls.Add(panel5, 0, 2);
            tlpLichThi.Controls.Add(panel4, 0, 0);
            tlpLichThi.Controls.Add(panel14, 0, 1);
        }

        private void dtpToDay_ValueChanged(object sender, EventArgs e)
        {
            date = dtpToDay.Value;
            tlpLichThi.Controls.Clear();
            SetDateForThu();
            LoadLichHoc(date);
        }

        private void LoadLichHoc(DateTime mDate)
        {
            int col = 7;
            int row = 3;

            List<SinhVien_LichThi> list = SinhVien_LichThiBLL.GetListSinhVienLichThi(sinhVien.Mssv, mDate);

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {

                    int intDate = j - 1;
                    String strMDate = MondayOfWeek(mDate).AddDays(intDate).ToLongDateString();

                    SinhVien_LichThi sv_lt = list.Where(t => t.LichThi.NgayThi.Value.ToLongDateString().Equals(strMDate)).FirstOrDefault();

                    if (sv_lt != null)
                    {
                        UControl.UC_LichThi ucLichThi = new UControl.UC_LichThi(sv_lt);
                        ucLichThi.Dock = DockStyle.Fill;

                        if (sv_lt.LichThi.ThoiGianBD.Value.Hours >= 18 && i == 3)
                            tlpLichThi.Controls.Add(ucLichThi, j, i);
                        else if (sv_lt.LichThi.ThoiGianBD.Value.Hours >= 12 && sv_lt.LichThi.ThoiGianKT.Value.Hours < 18 && i == 2)
                            tlpLichThi.Controls.Add(ucLichThi, j, i);
                        else if(sv_lt.LichThi.ThoiGianBD.Value.Hours >= 7 && sv_lt.LichThi.ThoiGianKT.Value.Hours < 12 && i == 1)
                            tlpLichThi.Controls.Add(ucLichThi, j, i);
                        else continue;
                    }
                }
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rectangle = e.CellBounds;
            rectangle.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.Raised, Border3DSide.All); // 3D border
            ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Red, ButtonBorderStyle.Dotted); // dotted border
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            dtpToDay.Value = MondayOfWeek(date).AddDays(-7);
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            dtpToDay.Value = MondayOfWeek(date).AddDays(7);
        }

        private void btnHienTai_Click(object sender, EventArgs e)
        {
            dtpToDay.Value = DateTime.Now;
        }
    }
}

