using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThongKeDiem_Lop : Form
    {
        private int _nienKhoa = 2003;
        private List<ThongKeDiemThi> lstKq;
        public FrmThongKeDiem_Lop()
        {
            InitializeComponent();
        }

        private void FrmThongKeDiem_Load(object sender, EventArgs e)
        {
            List<string> lstNienKhoa = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                lstNienKhoa.Add(String.Format("{0}-{1}", _nienKhoa + i, _nienKhoa + i + 1));
            }
            cboNiemKhoa.DataSource = lstNienKhoa;
            cboNiemKhoa.Text = String.Empty;

            List<Khoa> dsKhoa = KhoaBLL.GetDepartment();
            dsKhoa.Add(new Khoa { MaKhoa = String.Empty, TenKhoa = String.Empty });
            cboKhoa.DataSource = dsKhoa;
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.SelectedIndex = dsKhoa.Count - 1;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.Text == String.Empty)
                return;

            cboLop.DataSource = LopBLL.getLops(cboKhoa.SelectedValue.ToString());
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
            cboLop.Text = String.Empty;

            cboMon.DataSource = MonHocBLL.GetMonHocs(cboKhoa.SelectedValue.ToString());
            cboMon.ValueMember = "MaMonHoc";
            cboMon.DisplayMember = "TenMonHoc";
            cboMon.Text = String.Empty;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool _ckErr = false;
            if (string.IsNullOrEmpty(cboKhoa.Text))
            {
                errorProvider.SetError(lbKhoa, "Vui lòng nhập khoa!");
                _ckErr = true;
            }
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
            if (string.IsNullOrEmpty(cboLop.Text))
            {
                errorProvider.SetError(lbLop, "Vui lòng nhập lớp!");
                _ckErr = true;
            }

            if (_ckErr) return;

            lstKq = new ThongKeDiemBLL().getThongTinDiems_lop(
                cboMon.SelectedValue.ToString(),
                cboLop.SelectedValue.ToString(),
                cboNiemKhoa.Text,
                cboHocKy.Text);
            dataGridViewTT.DataSource = lstKq;
        }
        private void dataGridViewTT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewTT.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            if (lstKq != null)
                lstKq[e.RowIndex].Stt = (e.RowIndex + 1).ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new ThongKeDiemBLL().exportExcel_Lop(cboMon.Text, cboLop.SelectedValue.ToString(), cboHocKy.Text, cboNiemKhoa.Text, lstKq);
        }

        private void dataGridViewTT_DataSourceChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = dataGridViewTT.Rows.Count != 0;
        }

        private void dataGridViewTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
