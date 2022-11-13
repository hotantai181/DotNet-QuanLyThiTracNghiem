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
using BLL;

namespace GUI
{
    public partial class frmTaoDeThi : Form
    {
        PhieuTaoBLL bus_phieuTao = new PhieuTaoBLL();
        private bool isValid = false;

        private const string MESSAGE_PHIEU_KHONGHOPLE = "Không hợp lệ";
        private const string MESSAGE_PHIEU_HOPLE = "Đã xác nhận";

        public frmTaoDeThi()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            string maPT = drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString();
            // tạo đề thi
            bus_phieuTao.taoDeThi(maPT);

            // tạo chi tiết cho từng đề thi
            bus_phieuTao.taoCTDeThi(maPT);

            // cập nhật trạng thái
            bus_phieuTao.capNhatTrangThai(maPT, "Đã xác nhận");

            this.OnLoad(e);
        }

        private void frmTaoDeThi_Load(object sender, EventArgs e)
        {
            drvDSPhieu.DataSource = bus_phieuTao.getPhieuTaos_NgayLap(txtTimePicker.Text);
            drvDSPhieu.ClearSelection();

            btnTaoDe.Enabled = false;
        }

        private void txtTimePicker_ValueChanged(object sender, EventArgs e)
        {
            drvDSPhieu.DataSource = bus_phieuTao.getPhieuTaos_NgayLap(txtTimePicker.Text);
            drvDSPhieu.ClearSelection();

            btnTaoDe.Enabled = false;
        }

        private void drvDSPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isValid = false;

            string _trangThai = drvDSPhieu.CurrentRow.Cells["TrangThai"].Value.ToString();

            if (_trangThai != string.Empty) return;

            try
            {
                bus_phieuTao.kiemTraPhieuTao(drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString());

                btnTaoDe.Enabled = _trangThai == string.Empty;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                isValid = true;
            }
        }

        private void drvDSPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmThongTinPTD frm = new frmThongTinPTD();
            frm.MaPhieu = drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString();

            frm.ShowDialog();
        }

        private void yêuCầuChỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cập nhật trạng thái của phiếu (không hợp lệ)
            bus_phieuTao.capNhatTrangThai(
                drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString(),
                MESSAGE_PHIEU_KHONGHOPLE);

            this.OnLoad(e);
        }

        private void refresh(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void contextMenuStrip_Opening_1(object sender, CancelEventArgs e)
        {
            yêuCầuChỉnhSửaToolStripMenuItem.Enabled = isValid;
        }

        private void drvDSPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
