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
    public partial class frmHienThiDT : Form
    {
        public frmHienThiDT()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string[]> data = new List<string[]>();

            data.Add(new string[] { "MaDe", "MonHoc" });
            data.Add(new string[] {
                drvDeThi.CurrentRow.Cells["MaDe"].Value.ToString(),
                new MonHocBLL().getTenMH(drvDeThi.CurrentRow.Cells["MaPhieuTaoDe"].Value.ToString())
            }); // data

            new Reports<DeThi>().export_word(drvDeThi.CurrentRow.Cells["MaDe"].Value.ToString(), data);
        }

        private void frmHienThiDT_Load(object sender, EventArgs e)
        {
            drvDeThi.DataSource = new DeThiBLL().getDeThis();

            drvDeThi.ClearSelection();
        }
        private void drvDeThi_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvDeThi.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void drvDeThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
