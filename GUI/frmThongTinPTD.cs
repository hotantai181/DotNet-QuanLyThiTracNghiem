using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmThongTinPTD : Form
    {
        PhieuTaoBLL bus_phieuTao = new PhieuTaoBLL();

        private string maMH = string.Empty;

        public string MaPhieu = string.Empty;
        public frmThongTinPTD()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThongTinPTD_Load(object sender, EventArgs e)
        {
            if (MaPhieu == string.Empty)
            {
                MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Dispose();
            }

            // thông tin phiếu tạo đề 
            PhieuTaoDe phieuTaoDe = bus_phieuTao.get_tt_phieuTao(MaPhieu);

            txtMaPhieu.Text = phieuTaoDe.MaPhieuTaoDe;
            txtNgayLap.Text = string.Format("{0:dd/MM/yyyy}", phieuTaoDe.NgayLap);
            txtSoLuongCauHoi.Text = phieuTaoDe.SoCauHoi.ToString();
            txtSoLuongDe.Text = phieuTaoDe.SoLuongDe.ToString();
            txtTgianLamBai.Text = phieuTaoDe.ThoiGianLamBai.ToString();
            txtTrangThai.Text = phieuTaoDe.TrangThai;

            txtKhoa.Text = MonHocBLL.GetKhoa(phieuTaoDe.MaMonHoc)[0].TenKhoa;

            MonHoc mh = MonHocBLL.GetMonHoc(phieuTaoDe.MaMonHoc)[0];
            txtMonHoc.Text = mh.TenMonHoc;
            maMH = mh.MaMonHoc;

            drvSoLuongCauHoi.DataSource = bus_phieuTao.getDS_cauHoi(phieuTaoDe.MaPhieuTaoDe);
        }

        private void drvSoLuongCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // sửa thông tin số câu ở mỗi chương
            frmThongTinMucDoCau frm = new frmThongTinMucDoCau();
            frm.lstChuong = bus_phieuTao.getDs_cauHoi_conLai(maMH, string.Empty);
            frm.maPhieuTaoDe = txtMaPhieu.Text;
            frm.maChuong = drvSoLuongCauHoi.CurrentRow.Cells["MaChuong"].Value.ToString();
            frm.maPt_c = drvSoLuongCauHoi.CurrentRow.Cells["Ma"].Value.ToString(); // mã phiếu tạo chương
            frm.soCauHoi = int.Parse(drvSoLuongCauHoi.CurrentRow.Cells["SoLuong"].Value.ToString());

            frm.ShowDialog();
        }

        private void drvSoLuongCauHoi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvSoLuongCauHoi.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnThongTinChung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drvSoLuongCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
