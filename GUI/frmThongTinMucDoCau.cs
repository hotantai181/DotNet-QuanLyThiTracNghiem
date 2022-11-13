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
    public partial class frmThongTinMucDoCau : Form
    {
        public List<Chuong> lstChuong;
        public string maPhieuTaoDe;
        public string kq;
        private PhieuTaoBLL bus_pt = new PhieuTaoBLL();
        public string maChuong = string.Empty;
        public string maPt_c = string.Empty;
        public int soCauHoi;

        public frmThongTinMucDoCau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThongTinMucDoCau_Load(object sender, EventArgs e)
        {
            cboChuong.DataSource = lstChuong;
            cboChuong.ValueMember = "MaChuong";
            cboChuong.DisplayMember = "TenChuong";

            cboChuong.Enabled = false;
            cboChuong.SelectedValue = int.Parse(maChuong);

            txtSoLuongCauHoi.Text = soCauHoi.ToString();

            new PhieuTaoBLL().getMaMucDo(int.Parse(maPt_c)).ForEach(item =>
            {
                drvMucDo.Rows.Add(1, item.MucDo1, item.SoCau);
            });

            drvMucDo.ClearSelection();
        }

        private void drvMucDo_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvMucDo.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void txtSoLuongCauHoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
