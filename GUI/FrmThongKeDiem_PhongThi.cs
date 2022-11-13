using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThongKeDiem_PhongThi : Form
    {
        private int _nienKhoa = 2003;
        private List<ThongKeDiemThi> lstKq;
        public FrmThongKeDiem_PhongThi()
        {
            InitializeComponent();
        }

        private void FrmThongKeDiem_PhongThi_Load(object sender, EventArgs e)
        {
            List<string> lstNienKhoa = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                lstNienKhoa.Add(String.Format("{0}-{1}", _nienKhoa + i, _nienKhoa + i + 1));
            }
            cboNiemKhoa.DataSource = lstNienKhoa;
            cboNiemKhoa.Text = String.Empty;
            cboPhong.DataSource = new ThongKeDiemBLL().getPhongThis(txtNgayThi.Text);
            cboPhong.Text = String.Empty;

            cboMon.DataSource = MonHocBLL.GetMonHocs_LichThi(txtNgayThi.Text);
            cboMon.ValueMember = "MaMonHoc";
            cboMon.DisplayMember = "TenMonHoc";
            cboMon.Text = String.Empty;
        }

        private void txtNgayThi_ValueChanged(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new ThongKeDiemBLL().exportExcel_PhongThi(cboMon.Text, cboPhong.Text, cboHocKy.Text, cboNiemKhoa.Text, txtNgayThi.Text, lstKq);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool _ckErr = false;
            if (string.IsNullOrEmpty(cboNiemKhoa.Text))
            {
                errorProvider.SetError(lbNienKhoa, "Vui lòng nhập niên khóa!");
                _ckErr = true;
            }
            if (string.IsNullOrEmpty(cboHocKy.Text))
            {
                errorProvider.SetError(lbHocKi, "Vui lòng nhập học kỳ!");
                _ckErr = true;
            }
            if (string.IsNullOrEmpty(cboMon.Text))
            {
                errorProvider.SetError(lbMon, "Vui lòng nhập môn học!");
                _ckErr = true;
            }
            if (string.IsNullOrEmpty(cboPhong.Text))
            {
                errorProvider.SetError(lbPhong, "Vui lòng nhập phòng thi!");
                _ckErr = true;
            }

            if (_ckErr) return;

            lstKq = new ThongKeDiemBLL().getThongTinDiems_phongThi(
                cboMon.SelectedValue.ToString(),
                cboPhong.Text,
                cboNiemKhoa.Text,
                cboHocKy.Text,
                txtNgayThi.Text);
            dataGridViewTT.DataSource = lstKq;
        }

        private void dataGridViewTT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewTT.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            if (lstKq != null)
                lstKq[e.RowIndex].Stt = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewTT_DataSourceChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = dataGridViewTT.Rows.Count != 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
