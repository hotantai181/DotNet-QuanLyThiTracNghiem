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
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class FrmTaoPhieu : Form
    {
        PhieuTaoBLL bus_phieuTao = new PhieuTaoBLL();
        private string _maGV = "GV01"; // lấy frm đăng nhập
        private bool _isChange = false;
        private int tongSoCauConLai;
        private GiaoVien gv;

        public FrmTaoPhieu()
        {
            InitializeComponent();

            gv = GiaoVienBLL.GetGiaoVien(_maGV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmTaoPhieu_Load(object sender, EventArgs e)
        {
            _isChange = btnLuu.Enabled = pnThongTinChung.Enabled = pnThongTinPhieu.Enabled = false;

            drvDSPhieu.DataSource = bus_phieuTao.getPhieuTaos(_maGV);
            drvDSPhieu.ClearSelection();
            
            clear();
        }

        private void clear()
        {
            txtMaPhieu.Clear();
            txtNgayLap.Clear();
            txtSoLuongCauHoi.Clear();
            txtSoLuongDe.Clear();
            txtTgianLamBai.Clear();
            txtTrangThai.Clear();
            cboMonHoc.Text = string.Empty;

            cboMonHoc.DataSource = null;

            if (drvSoLuongCauHoi.Rows.Count > 0)
            {
                drvSoLuongCauHoi.DataSource = null;

                drvSoLuongCauHoi.Columns.Add("SoLuong", "Số câu hỏi");
                drvSoLuongCauHoi.Columns["SoLuong"].DataPropertyName = "SoCauHoi";


                drvSoLuongCauHoi.Columns.Add("Ma", "Ma");
                drvSoLuongCauHoi.Columns["Ma"].DataPropertyName = "Ma";
                drvSoLuongCauHoi.Columns["Ma"].Visible = false;

                drvSoLuongCauHoi.Columns.Add("MaChuong", "Ma chuong");
                drvSoLuongCauHoi.Columns["MaChuong"].DataPropertyName = "MaChuong";
                drvSoLuongCauHoi.Columns["MaChuong"].Visible = false;

            }
        }

        public void loadMonHoc()
        {
            cboMonHoc.DataSource = MonHocBLL.GetMonHocs();
            cboMonHoc.DisplayMember = "TenMonHoc";
            cboMonHoc.ValueMember = "MaMonHoc";
        }
        private void drvDSPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // thông tin phiếu tạo đề 
            PhieuTaoDe phieuTaoDe = bus_phieuTao.get_tt_phieuTao(drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString());

            txtMaPhieu.Text = phieuTaoDe.MaPhieuTaoDe;
            txtNgayLap.Text = string.Format("{0:dd/MM/yyyy}", phieuTaoDe.NgayLap);
            txtSoLuongCauHoi.Text = phieuTaoDe.SoCauHoi.ToString();
            txtSoLuongDe.Text = phieuTaoDe.SoLuongDe.ToString();
            txtTgianLamBai.Text = phieuTaoDe.ThoiGianLamBai.ToString();
            txtTrangThai.Text = phieuTaoDe.TrangThai;

            tongSoCauConLai = phieuTaoDe.SoCauHoi ?? 0;

           

            cboMonHoc.DataSource = MonHocBLL.GetMonHoc(phieuTaoDe.MaMonHoc);
            cboMonHoc.DisplayMember = "TenMonHoc";
            cboMonHoc.ValueMember = "MaMonHoc";

            //drvSoLuongCauHoi.DataSource = bus_phieuTao.getDS_cauHoi(phieuTaoDe.MaPhieuTaoDe);

            //// cập nhật tổng số lượng câu còn lại
            // tongSoCauConLai -= Int32.Parse(bus_phieuTao.getDS_cauHoi(phieuTaoDe.MaPhieuTaoDe).Sum(i => i.SoCauHoi).ToString());

            _isChange = btnLuu.Enabled = pnThongTinChung.Enabled = pnThongTinPhieu.Enabled = false;
        }

        private void drvSoLuongCauHoi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvSoLuongCauHoi.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (_isChange)
            {
                if (MessageBox.Show("Bạn có muốn tạo mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    return;
            }

            clear();

            pnThongTinPhieu.Enabled = pnThongTinChung.Enabled = true;


            loadMonHoc();
            // mã phiếu tạo
            txtMaPhieu.Text = bus_phieuTao.getNewMaPhieu();

            // ngày lập (mặc định ngày hiện tại)
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            btnLuu.Enabled = true;
            _isChange = true;
            
        }

        private void checkNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập kí số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Handled = true;
                (sender as TextBox).Focus();
            }
        }

       

        private void reLoad()
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoLuongCauHoi.Text.Trim().Length == 0 ||
                txtSoLuongDe.Text.Trim().Length == 0 ||
                txtTgianLamBai.Text.Trim().Length == 0 ||
                cboMonHoc.Text.Trim().Length == 0
                )
            {
                MessageBox.Show("Vui lòng đầy đủ thông tin phiếu tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            // kiểm số lượng đề > 0
            if (int.Parse(txtSoLuongDe.Text.Trim()) == 0)
            {
                MessageBox.Show("Số lượng đề phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            // kiểm số lượng câu > 0
            if (int.Parse(txtSoLuongCauHoi.Text.Trim()) == 0)
            {
                MessageBox.Show("Số lượng câu hỏi phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            // phiếu đã tồn tại
            if (bus_phieuTao.get_tt_phieuTao(txtMaPhieu.Text) != null)
            {
                if (bus_phieuTao.change_phieuTao(new PhieuTaoDe
                {
                    MaPhieuTaoDe = txtMaPhieu.Text,
                    SoLuongDe = int.Parse(txtSoLuongDe.Text.Trim()),
                    SoCauHoi = int.Parse(txtSoLuongCauHoi.Text.Trim()),
                    ThoiGianLamBai = int.Parse(txtTgianLamBai.Text.Trim()),
                    MaMonHoc = cboMonHoc.SelectedValue.ToString(),
                    TrangThai = string.Empty
                }))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.OnLoad(e);
                }
                return;
            }

            // phiếu chưa được tạo
            if (bus_phieuTao.add_phieuTao(new PhieuTaoDe
            {
                MaPhieuTaoDe = txtMaPhieu.Text,
                NgayLap = DateTime.ParseExact(txtNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                SoLuongDe = int.Parse(txtSoLuongDe.Text.Trim()),
                SoCauHoi = int.Parse(txtSoLuongCauHoi.Text.Trim()),
                ThoiGianLamBai = int.Parse(txtTgianLamBai.Text.Trim()),
                MaMonHoc = cboMonHoc.SelectedValue.ToString(),
                TrangThai = txtTrangThai.Text,
                MaGiaoVien = _maGV
            }))
            {
                MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.OnLoad(e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // thực hiện xóa phiếu
            if (bus_phieuTao.remove_phieuTaoDe(drvDSPhieu.CurrentRow.Cells["MaPhieu"].Value.ToString()))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.OnLoad(e);
            }
            else
            {
                MessageBox.Show("Không thế xóa được. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void drvSoLuongCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void contentmnu_Opening(object sender, CancelEventArgs e)
        {
            chỉnhSửaToolStripMenuItem.Enabled = !txtTrangThai.Text.Trim().Equals("Đã xác nhận") && !_isChange && !txtMaPhieu.Text.Trim().Equals(string.Empty);

            thêmSốCâuHỏiChươngToolStripMenuItem.Enabled = pnThongTinPhieu.Enabled && bus_phieuTao.get_tt_phieuTao(txtMaPhieu.Text) != null;

            sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Enabled =
                xóaSốCâuHỏiChươngToolStripMenuItem.Enabled = pnThongTinPhieu.Enabled && drvSoLuongCauHoi.CurrentRow != null;
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = pnThongTinChung.Enabled = pnThongTinPhieu.Enabled = true;

            var valMonHoc = cboMonHoc.SelectedValue;
            cboMonHoc.DataSource = MonHocBLL.GetMonHocs();
            cboMonHoc.DisplayMember = "TenMonHoc";
            cboMonHoc.ValueMember = "MaMonHoc";
            cboMonHoc.SelectedValue = valMonHoc;
        }

        private void thêmSốCâuHỏiChươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                return;
            }

            //frmThemSoCauHoiChuong frm = new frmThemSoCauHoiChuong();
            //frm.lstChuong = bus_phieuTao.getDs_cauHoi_conLai(cboMonHoc.SelectedValue.ToString(), txtMaPhieu.Text);
            //frm.maPhieuTaoDe = txtMaPhieu.Text;
            //frm.tongCauHoiConLai = tongSoCauConLai;
            //frm.ShowDialog();

            reLoad();
        }

        private void xóaSốCâuHỏiChươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            //    return;

            //if (bus_phieuTao.remove_phieuTaoDe_chuong(int.Parse(drvSoLuongCauHoi.CurrentRow.Cells["Ma"].Value.ToString())))
            //{
            //    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            //    reLoad();

            //}
        }
    }
}
