using BLL;
using DTO;
using GUI.UControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThiTracNghiem : Form
    {
        private int maCauHoi = 0;
        private HocSinh sinhVien;
        private int counter = 60;
        private Timer aTimer;
       
        private  string maHS;

        private List<ChiTietBaiThi> ltBaiThi;
        string made;
        string maphieu;
        int? tglambai;

        public FrmThiTracNghiem(string massv, string maDeThi)
        {
            InitializeComponent();
            made = maDeThi;
            maHS = massv;
            ltBaiThi = new List<ChiTietBaiThi>();
            sinhVien = HocSinhBLL.GetSinhVien(massv);
            
        }
            
        private void FrmThiTracNghiem_Load(object sender, EventArgs e)
        {
            lbCauHoi.MaximumSize = new Size(pnDe.Width, 0);
           
            lblDeThi.Text = "Mã Đề: " + made;
            maphieu = DeThiBLL.getMaPhieu(made);
            lbelmonhoc.Text = "Môn Học: " + String.Format(MonHocBLL.getTenMH(maphieu));
            tglambai = PhieuTaoBLL.getTGLamBai(maphieu);
            counter = counter * (int)tglambai;
            LoadInfoSinhVien();
            LoadCauHoi();
            runTime();
        }

        private void runTime()
        {
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(aTimer_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();

            setCountDownTime(counter);
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {   
            counter--;
            if (counter == 0)
                aTimer.Stop();
            setCountDownTime(counter);
        }
        private void setCountDownTime(int counter)
        {
            int hour, minute, second;
            hour = counter / 3600;
            minute = counter % 3660 / 60;
            second = counter % 3600 % 60;
            if (hour == 0)
            {
                lbThoiGianConLai.Text = string.Format("Thời gian còn lại: {0}:{1}", minute, second);
            }
            else lbThoiGianConLai.Text = string.Format("Thời gian còn lại: {0}:{1}:{2}", hour, minute, second);

            if (hour == 0 && minute == 5 && second == 0)
            {
                MessageBox.Show("Còn 5 phút nữa bài thi sẽ tự động lưu và thoát khỏi form làm bài");
            }

            if (hour == 0 && minute == 0 && second == 0)
            {
                KiemTraBaiLam();
                try
                {
                    BaiThiBLL.InsertBaiThi(ltBaiThi);
                    ChiTietBaiThiBLL.UpdateTrangThai(maHS, "Đã hoàn thành");
                    MessageBox.Show("Hết giờ làm bìa. Nộp bài thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TinhDiem();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Hết giờ làm bìa. Nộp bài không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void pnDe_SizeChanged(object sender, EventArgs e)
        {
            lbCauHoi.MaximumSize = new Size(pnDe.Width, 0);
        }
        private void LoadInfoSinhVien()
        {
            lbNgaySinh.Text = sinhVien.NgaySinh.Value.Date.ToString("dd/MM/yyyy");
            lbHoTen.Text = sinhVien.HoTen;
            lbCMND.Text = sinhVien.CMND_CCCD;
        }

        private void SelectCauHoiUI()
        {
            foreach (Control item in pnCauHoi.Controls)
            {
                if (item.GetType() == typeof(UCCauHoiThi))
                {
                    UCCauHoiThi uc = (UCCauHoiThi)item;
                    maCauHoi = uc.MaCauHoi;
                    uc.BackColor = Color.Transparent;
                    if (maCauHoi == uc.MaCauHoi)
                    {
                        uc.rdoBtnA.Click += RdoBtnUcCauHoi_Click;
                        uc.rdoBtnB.Click += RdoBtnUcCauHoi_Click;
                        uc.rdoBtnC.Click += RdoBtnUcCauHoi_Click;
                        uc.rdoBtnD.Click += RdoBtnUcCauHoi_Click;
                    }
                }
            }
        }

        private void RdoBtnUcCauHoi_Click(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (maCauHoi == int.Parse(rdo.Tag.ToString()))
                SelectAnswer(rdo.Text.ToString());
        }

        private void LoadCauHoi()
        {
            var ltCauHoi = CauHoiBLL.GetListCauHoi(made);

            int i = ltCauHoi.Count();
            foreach (var item in ltCauHoi)
            {
                UCCauHoiThi uc = new UCCauHoiThi(item, i);

                uc.Dock = DockStyle.Top;

                if (i == 1)
                {
                    LoadDataItem(item, uc.Index);
                    uc.BackColor = Color.Yellow;
                }

                uc.lbCau.Click += (o, e) =>
                {
                    ResetRadioButton();
                    SelectCauHoiUI();
                    SelectAnswer(uc.SelectedAnswer());
                    LoadDataItem(item, uc.Index);
                    uc.BackColor = Color.Yellow;

                };
                pnCauHoi.Controls.Add(uc);
                i--;
            }
        }

        private void LoadDataItem(CauHoi item, int index)
        {
            lbIndex.Text = "Câu " + index;
            lbCauHoi.Text = item.CauHoi1;
            rdoBtnA.Text = item.DapAnA;
            rdoBtnB.Text = item.DapAnB;
            rdoBtnC.Text = item.DapAnC;
            rdoBtnD.Text = item.DapAnD;
            maCauHoi = item.MaCauHoi;
        }
        private void SelectAnswer(string txtAndwer)
        {
            if (txtAndwer == null) return;
            else if (txtAndwer.Equals("A"))
                rdoBtnA.Checked = true;
            else if (txtAndwer.Equals("B"))
                rdoBtnB.Checked = true;
            else if (txtAndwer.Equals("C"))
                rdoBtnC.Checked = true;
            else if (txtAndwer.Equals("D"))
                rdoBtnD.Checked = true;
        }
        private void ResetRadioButton()
        {
            foreach (Control item in pnNoiDung.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    RadioButton rdoBtn = (RadioButton)item;
                    rdoBtn.Checked = false;
                }
            }
        }
        public void SelectedAnswer()
        {
            string temp = string.Empty;
            if (rdoBtnB.Checked)
                temp = "B";
            else if (rdoBtnC.Checked)
                temp = "C";
            else if (rdoBtnD.Checked)
                temp = "D";
            else if (rdoBtnA.Checked)
                temp = "A";

            foreach (Control item in pnCauHoi.Controls)
            {
                if (item.GetType() == typeof(UCCauHoiThi))
                {
                    UCCauHoiThi uc = (UCCauHoiThi)item;
                    if (maCauHoi == uc.MaCauHoi)
                    {
                        uc.SetSelectedAnswer(temp);
                        uc.DaLam = true;
                        break;
                    }

                }
            }
        }

        private void rdoBtn_Click(object sender, EventArgs e)
        {
            SelectedAnswer();
        }

        private void rdoDaLam_Click(object sender, EventArgs e)
        {
            if (rdoDaLam.Checked)
            {
                foreach (Control item in pnCauHoi.Controls)
                {
                    item.Visible = true;
                    if (item.GetType() == typeof(UCCauHoiThi))
                    {
                        UCCauHoiThi uc = (UCCauHoiThi)item;
                        if (!uc.DaLam)
                        {
                            item.Visible = false;
                        }
                    }
                }
            }
        }

        private void rdoBtnChuaLam_Click(object sender, EventArgs e)
        {
            if (rdoBtnChuaLam.Checked)
            {
                foreach (Control item in pnCauHoi.Controls)
                {
                    item.Visible = true;
                    if (item.GetType() == typeof(UCCauHoiThi))
                    {
                        UCCauHoiThi uc = (UCCauHoiThi)item;
                        if (uc.DaLam)
                        {
                            item.Visible = false;
                        }
                    }
                }
            }
        }

        private void rdoBtnTatCa_Click(object sender, EventArgs e)
        {
            if (rdoBtnTatCa.Checked)
            {
                foreach (Control item in pnCauHoi.Controls)
                {
                    if (item.GetType() == typeof(UCCauHoiThi))
                    {
                        item.Visible = true;
                    }
                }
            }
        }


        private void KiemTraBaiLam()
        {
            foreach (Control item in pnCauHoi.Controls)
            {
                if (item.GetType() == typeof(UCCauHoiThi))
                {
                    UCCauHoiThi uc = (UCCauHoiThi)item;
                    string trangThai = "Sai";
                    if (uc.SelectedAnswer() == null)
                    {
                        trangThai = "Sai";
                    }
                    else if (uc.SelectedAnswer().Equals(string.Empty))
                    {
                        trangThai = "Chưa làm";
                    }
                    else if (uc.Cauhoi.DapAnDung.Equals(uc.SelectedAnswer()))
                    {
                        trangThai = "Đúng";
                    }

                    ChiTietBaiThi bai = new ChiTietBaiThi
                    {
                        CauHoi = uc.Cauhoi.MaCauHoi,
                        CauTraLoi = uc.SelectedAnswer(),
                        TrangThai = trangThai,
                    };
                    ltBaiThi.Add(bai);
                }
            }
        }
        private void TinhDiem()
        {
            int soCauDung = 0;
            int soChuaLam = 0;
            int soCauSai = 0;

            // Kiem tra so cau dung, sai, chua lam
            foreach (ChiTietBaiThi baiThi in ltBaiThi)
            {
                if (baiThi.TrangThai.Equals("Đúng")) soCauDung++;
                else if (baiThi.TrangThai.Equals("Chưa làm")) soChuaLam++;
                else if (baiThi.TrangThai.Equals("Sai")) soCauSai++;
            }
            float diemMoiCau = 10f / ltBaiThi.Count;
            float diem = diemMoiCau * (float)soCauDung;
            // Add ket qua bai thi
            KetQuaBaiThi kq = new KetQuaBaiThi
            {
                MaKQ = "a",
                Diem = diem,
                MaHS = maHS,
                MaDe = made,
            };
            KetQuaBaiThiBLL.InsertKetQua(kq);

            // Thong Tin Sau Thi Xong
            textBox1.Text = (soCauSai+ soCauDung + soChuaLam).ToString();
            textBox2.Text = (soCauDung).ToString();
            textBox3.Text = (soCauSai).ToString();
            textBox4.Text = (diem).ToString();
            // dt
            DataTable dt = new DataTable("Ketqua");
            dt.Columns.Add("CAU", typeof(int));
            dt.Columns.Add("DADT", typeof(string));
            dt.Columns.Add("DABC", typeof(string));
            dt.Columns.Add("KQ", typeof(string));
            int i = 40;
            foreach (Control item in pnCauHoi.Controls)
            {
               
                if (item.GetType() == typeof(UCCauHoiThi))
                {
                    UCCauHoiThi uc = (UCCauHoiThi)item;
                    string trangThaidata = "Sai";
                    if (uc.SelectedAnswer() == null)
                    {
                        trangThaidata = "Sai";
                    }
                    else if (uc.SelectedAnswer().Equals(string.Empty))
                    {
                        trangThaidata = "Chưa làm";
                    }
                    else if (uc.Cauhoi.DapAnDung.Equals(uc.SelectedAnswer()))
                    {
                        trangThaidata = "Đúng";
                    }
                    DataRow row = dt.NewRow();
                    row["CAU"] = i;
                    row["DADT"] = uc.Cauhoi.DapAnDung;
                    row["DABC"] = uc.SelectedAnswer();
                    row["KQ"] = trangThaidata;
                    dt.Rows.Add(row);
                }
                i--;
            }
            DataSet dtSet = new DataSet();

            // Add custTable to the DataSet.
            dtSet.Tables.Add(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            NopBai();
        }
        private void NopBai()
        {
            KiemTraBaiLam();

            int i = 0;
            foreach (ChiTietBaiThi bai in ltBaiThi)
            {
                if (bai.TrangThai.Equals("Chưa làm"))
                {
                    i++;
                }
            }
            string str = "Bạn có chắc muốn nộp bài không";
            if (i > 0)
            {
                str = "Có " + i + " câu chưa làm. Bạn có muốn nộp luôn hay hông";
            }
            if (MessageBox.Show(str, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BaiThiBLL.InsertBaiThi(ltBaiThi);
                    MessageBox.Show("Nộp bài thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TinhDiem();
                }
                catch
                {
                    MessageBox.Show("Nộp bài không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rdoBtnC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
