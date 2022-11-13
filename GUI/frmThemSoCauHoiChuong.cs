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
    public partial class frmThemSoCauHoiChuong : Form
    {
        public List<Chuong> lstChuong;
        public string maPhieuTaoDe;
        public string kq;
        private PhieuTaoBLL bus_pt = new PhieuTaoBLL();
        public string maChuong = string.Empty;
        public string maPt_c = string.Empty;
        public int soCauHoi;
        public int tongCauHoiConLai;
        private bool isUpdate = true;

        public frmThemSoCauHoiChuong()
        {
            InitializeComponent();
        }

        private void frmThemSoCauHoiChuong_Load(object sender, EventArgs e)
        {
            cboChuong.DataSource = lstChuong;
            cboChuong.ValueMember = "MaChuong";
            cboChuong.DisplayMember = "TenChuong";

            if (maChuong == string.Empty)
            {
                drvMucDo.Rows.Add(1, "Dễ", 0);
                drvMucDo.Rows.Add(1, "Trung bình", 0);
                drvMucDo.Rows.Add(1, "Khó", 0);
            }
            else // thực hiện cập nhật
            {
                cboChuong.Enabled = false;
                cboChuong.SelectedValue = int.Parse(maChuong);

                txtSoLuongCauHoi.Text = soCauHoi.ToString();

                ckPhanLoai.Checked = true;

                drvMucDo.Rows.Clear();
                new PhieuTaoBLL().getMaMucDo(int.Parse(maPt_c)).ForEach(item => {
                    drvMucDo.Rows.Add(1, item.MucDo1, item.SoCau);
                });
            }

            drvMucDo.ClearSelection();
        }

        private void ckPhanLoai_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckPhanLoai.Checked)
            {
                drvMucDo.Rows.Clear();
            } else
            {
                drvMucDo.Rows.Clear();

                drvMucDo.Rows.Add(1, "Dễ", 0);
                drvMucDo.Rows.Add(1, "Trung bình", 0);
                drvMucDo.Rows.Add(1, "Khó", 0);
            }

            groupBox1.Enabled = ckPhanLoai.Checked;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtSoLuongCauHoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số câu hỏi của chương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                txtSoLuongCauHoi.Focus();
                return;
            }
            if (maChuong != string.Empty)
            {
                new PhieuTaoBLL().remove_phieuTaoDe_chuong(int.Parse(maPt_c));
            }
            int tongSoCau = int.Parse(txtSoLuongCauHoi.Text.Trim());
            int soCauDe = tongSoCau / 2;
            int soCauTb = (tongSoCau * 3) / 10;
            int soCauKho = tongSoCau - soCauDe - soCauTb;

            if (ckPhanLoai.Checked)
            {
                soCauDe = int.Parse(drvMucDo[2, 0].Value.ToString());
                soCauTb = int.Parse(drvMucDo[2, 1].Value.ToString());
                soCauKho = int.Parse(drvMucDo[2, 2].Value.ToString());
            }
            if (cboChuong.SelectedValue == null)
            {
                MessageBox.Show("Thông tin chương không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            // lưu csdl

            // phieutaode_chuong
            bus_pt.add_phieuTao_chuong(new PhieuTaoDe_Chuong
            {
                MaPhieuTaoDe = maPhieuTaoDe,
                MaChuong = int.Parse(cboChuong.SelectedValue.ToString()),
                SoLuongCau = int.Parse(txtSoLuongCauHoi.Text.Trim())
            });

            // lấy mã phieutaode_chuong
            int ma_phieutaode_chuong = bus_pt.getMaPT_chuong(); // err

            // mức độ câu hỏi

            // mức độ dễ
            bus_pt.add_mucDo_chuong(new MucDo
            {
                MaPTD_C = ma_phieutaode_chuong,
                MucDo1 = "De",
                SoCau = soCauDe
            });

            // mức độ trung bình
            bus_pt.add_mucDo_chuong(new MucDo
            {
                MaPTD_C = ma_phieutaode_chuong,
                MucDo1 = "Trung binh",
                SoCau = soCauTb
            });

            // mức độc khóa
            bus_pt.add_mucDo_chuong(new MucDo
            {
                MaPTD_C = ma_phieutaode_chuong,
                MucDo1 = "Kho",
                SoCau = soCauKho
            });

            if (maChuong != string.Empty)
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Dispose();
        }
        private void drvMucDo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvMucDo.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void drvMucDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var Digit = drvMucDo[e.ColumnIndex, e.RowIndex].Value.ToString();

            if (txtSoLuongCauHoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số câu hỏi của chương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                drvMucDo[e.ColumnIndex, e.RowIndex].Value = 0;
                drvMucDo.ClearSelection();
                txtSoLuongCauHoi.Focus();
                return;
            }

            try
            {
                int n = int.Parse(Digit);
                if (n < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                int tongSoCau = int.Parse(txtSoLuongCauHoi.Text.Trim());

                int soCauDe = int.Parse(drvMucDo[e.ColumnIndex, 0].Value.ToString());
                int soCauTb = int.Parse(drvMucDo[e.ColumnIndex, 1].Value.ToString());
                int soCauKho = int.Parse(drvMucDo[e.ColumnIndex, 2].Value.ToString());
                if (tongSoCau - (soCauTb + soCauDe + soCauKho) < 0)
                {
                    MessageBox.Show("Đã vượt số câu yêu cầu. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    drvMucDo[e.ColumnIndex, e.RowIndex].Value = 0;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                drvMucDo[e.ColumnIndex, e.RowIndex].Value = 0;
            }

        }

        private void txtSoLuongCauHoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSoLuongCauHoi.Focus();
                e.Handled = true;
            }

            ckPhanLoai.Checked = false;
        }

        private void txtSoLuongCauHoi_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongCauHoi.Text == string.Empty)
                return;
            if (maChuong != string.Empty && isUpdate)
            {
                isUpdate = false;
                tongCauHoiConLai += soCauHoi;
                return;
            }
            if (tongCauHoiConLai - int.Parse(txtSoLuongCauHoi.Text.Trim()) < 0)
            {
                MessageBox.Show("Số lượng câu hỏi đã vượt yêu cầu đặt. Vui nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSoLuongCauHoi.SelectAll();
            }

        }

        private void drvMucDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboChuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
