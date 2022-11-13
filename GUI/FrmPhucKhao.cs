using BLL;
using DTO;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace GUI
{
    public partial class FrmPhucKhao : Form
    {
        private SinhVien _sinhVien;
        private List<BaiThi> baiThis;
        public FrmPhucKhao()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchSV();
            dgvMonHoc.DataSource = null;
            dgvBaiThi.DataSource = null;
            grbChiTiet.Visible = false;
            btnInFile.Enabled = false;
        }
        private void searchSV()
        {
            if (txtTimKiem.Text.Trim() != string.Empty)
            {
                dgvSinhVien.DataSource = SinhVienBLL.searchSinhVien(txtTimKiem.Text);
            }
            else dgvSinhVien.DataSource = null;
        }

        private void FrmPhucKhao_Load(object sender, EventArgs e)
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvMonHoc.AutoGenerateColumns = false;
            dgvBaiThi.AutoGenerateColumns = false;
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                string strMssv = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
                _sinhVien = SinhVienBLL.GetSinhVien(strMssv);

                var items = from s in SinhVien_LichThiBLL.GetListSinhVienLichThi(_sinhVien.Mssv, true)
                            select new
                            {
                                s.MaSVLT,
                                s.LichThi.MaMonHoc,
                                s.LichThi.MonHoc.TenMonHoc,
                                s.LichThi.NgayThi,
                                s.LichThi.PhongThi,
                                s.MaDe,
                            };

                dgvMonHoc.DataSource = items.ToList();
            }
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                int strMaSVLT = int.Parse(dgvMonHoc.CurrentRow.Cells[0].Value.ToString());
                string strMaMonHoc = dgvMonHoc.CurrentRow.Cells[1].Value.ToString();
                baiThis = BaiThiBLL.GetListBaiThi(strMaSVLT);
                TinhDiem();
                grbChiTiet.Visible = true;
                var items = from c in baiThis
                            select new
                            {
                                c.NganHangCauHoi.CauHoi,
                                c.NganHangCauHoi.DapAnA,
                                c.NganHangCauHoi.DapAnB,
                                c.NganHangCauHoi.DapAnC,
                                c.NganHangCauHoi.DapAnD,
                                c.NganHangCauHoi.DapAnDung,
                                c.CauTraLoi,
                                c.TrangThai
                            };

                dgvBaiThi.DataSource = items.ToList();
            }
        }
        private void TinhDiem()
        {
            int soCauDung = 0;
            int soChuaLam = 0;
            int soCauSai = 0;

            foreach (BaiThi baiThi in baiThis)
            {
                if (baiThi.TrangThai.Trim().Equals("Đúng")) soCauDung++;
                else if (baiThi.TrangThai.Trim().Equals("Chưa làm")) soChuaLam++;
                else if (baiThi.TrangThai.Trim().Equals("Sai")) soCauSai++;
            }
            float diemMoiCau = 10f / baiThis.Count;
            float diem = diemMoiCau * (float)soCauDung;

            lbSCauDung.Text = "Số câu đúng: " + soCauDung;
            lbDiem.Text = "Điểm: " + Math.Round(diem, 2);
            lbSCauSai.Text = "Số câu sai: " + soCauSai;
            lbSChuaLam.Text = "Số câu chưa làm: " + soChuaLam;
            if(baiThis.Count > 0)
                btnInFile.Enabled = true;
        }

        private void btnInFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonHoc.CurrentRow != null)
                {
                  
                    string strMaDe = dgvMonHoc.CurrentRow.Cells[5].Value.ToString();
                    string monHoc = dgvMonHoc.CurrentRow.Cells[2].Value.ToString();

                    new MyReports().exportDocument(strMaDe, monHoc, baiThis);
                }
                MessageBox.Show("Xuất ra file thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Xuất ra file thất bại \n Error: "+ex);
            }
        }

        private void dgvBaiThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
