using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Data.Common;

namespace GUI
{
    public partial class FrmNganHangCauHoi : Form
    {
        private GiaoVien giaoVien;
        private string maGV;
        private string maMon;
        List<MonHoc> listMonHoc;
        private string strMucDo, strDapAn;
        public FrmNganHangCauHoi(String maGV)
        {
            this.maGV = maGV;
            giaoVien = GiaoVienBLL.GetGiaoVien(maGV);
            InitializeComponent();
            strMucDo = "";

            strDapAn = "";
        }

        private void CheckMucDo()
        {
            if (rdoTrungBinh.Checked)
            {
                strMucDo = "Trung binh";
            }
            else if (rdoKho.Checked)
            {
                strMucDo = "Kho";
            }
            else if (rdoDe.Checked)
            {
                strMucDo = "De";
            }
        }
        private void CheckDapAn()
        {
            if (rdoBtnA.Checked)
            {
                strDapAn = "A";
            }
            else if (rdoBtnB.Checked)
            {
                strDapAn = "B";
            }
            else if (rdoBtnC.Checked)
            {
                strDapAn = "C";
            }
            else if (rdoBtnD.Checked)
            {
                strDapAn = "D";
            }
        }
        private void LoadMonHoc()
        {
            listMonHoc = MonHocBLL.GetMonHocs(cbbKhoa.SelectedValue.ToString());
            cbbMonHoc.Text = "";
            cbbMonHoc.DataSource = listMonHoc;
            cbbMonHoc.DisplayMember = "TenMonHoc";
            cbbMonHoc.ValueMember = "MaMonHoc";
            if (listMonHoc.Count > 1)
            {
                cbbMonHoc.SelectedIndex = 0;
            }
        }
        List<Khoa> listKhoa;
        private void LoadKhoa()
        {
            listKhoa = KhoaBLL.GetDepartment();

            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.ValueMember = "MaKhoa";
            cbbKhoa.DisplayMember = "TenKhoa";
            if (listKhoa.Count > 1)
            {
                cbbKhoa.SelectedIndex = 0;
            }
        }
        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMon = cbbKhoa.SelectedValue.ToString();

        }

        List<Chuong> listChuong;
        private void LoadChuong(string maMon)
        {
          
        }

        private void FrmNganHangCauHoi_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadMonHoc();

            if (cbbMonHoc.SelectedValue != null)
            {
                maMon = cbbMonHoc.SelectedValue.ToString();

                LoadChuong(maMon);
            }
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMon = cbbKhoa.SelectedValue.ToString();
            LoadChuong(maMon);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadFileExcel();
        }

        private void cbbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadMonHoc();
            if (cbbMonHoc.SelectedValue != null)
            {
                maMon = cbbMonHoc.SelectedValue.ToString();

                LoadChuong(maMon);
            }

        }

        private void cbbMonHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null)
            {
                maMon = cbbMonHoc.SelectedValue.ToString();

                LoadChuong(maMon);
            }
        }
        ErrorProvider error = new ErrorProvider();
      

        private void resetForm()
        {
            cbbKhoa.SelectedIndex = 0;
            cbbMonHoc.SelectedIndex = 0;
            rdoTrungBinh.Checked = false;
            rdoKho.Checked = false;
            rdoDe.Checked = false;
            rdoBtnA.Checked = false;
            rdoBtnB.Checked = false;
            rdoBtnC.Checked = false;
            rdoBtnD.Checked = false;

            txtA.Text = txtB.Text = txtC.Text = txtD.Text = txtNoiDung.Text = string.Empty;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void lvChuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void ReadFileExcel()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.xlsx, *.xls)|*.xlsx;*.xls";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;


                string kn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" + selectedFileName + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";

                using (OleDbConnection con = new OleDbConnection(kn))
                {
                    con.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [Sheet1$]", con);
                    DataSet exDataSet = new DataSet();
                    adapter.Fill(exDataSet);

                    DataTable db = exDataSet.Tables[0];
                    List<NganHangCauHoi> nganHangCauHois = new List<NganHangCauHoi>();

                    foreach (DataRow r in db.Rows)
                    {
                        try
                        {
                            nganHangCauHois.Add(new NganHangCauHoi
                            {
                                CauHoi = r[0].ToString(),
                                DapAnA = r[1].ToString(),
                                DapAnB = r[2].ToString(),
                                DapAnC = r[3].ToString(),
                                DapAnD = r[4].ToString(),
                                DapAnDung = r[5].ToString(),
                                MucDo = r[6].ToString(),
                                MaMonHoc = r[7].ToString(),
                                MaChuong = int.Parse(r[8].ToString()),
                                MaGiaoVien = r[9].ToString()
                            });
                        }
                        catch
                        {
                            continue;
                        }
                    }


                    foreach (var item in nganHangCauHois)
                    {
                        dgvDanhSachCauHoi.Rows.Add(
                            item.CauHoi,
                            item.DapAnA,
                            item.DapAnB,
                            item.DapAnC,
                            item.DapAnD,
                            item.DapAnDung,
                            item.MucDo,
                            item.MaMonHoc,
                            item.MaChuong,
                            item.MaGiaoVien
                            );
                    }
                    btnLuu.Enabled = true;
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoBtnA_Click(object sender, EventArgs e)
        {
            changeRadioButton(sender);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            CheckMucDo();
            CheckDapAn();

            if (txtNoiDung.Text.Trim() == string.Empty)
            {
                error.SetError(txtNoiDung, "Nội dung câu hỏi không được để trống");
                return;
            }
            if (txtA.Text.Trim() == string.Empty)
            {
                error.SetError(txtA, "Không được để trống"); return;
            }
            if (txtB.Text.Trim() == string.Empty)
            {
                error.SetError(txtB, "Không được để trống"); return;
            }
            if (txtC.Text.Trim() == string.Empty)
            {
                error.SetError(txtC, "Không được để trống"); return;
            }
            if (txtD.Text.Trim() == string.Empty)
            {
                error.SetError(txtD, "Không được để trống"); return;
            }
            if (strMucDo.Equals(""))
            {
                MessageBox.Show("Phải chọn mức độ"); return;
            }
            if (strDapAn.Equals(""))
            {
                MessageBox.Show("Phải chọn đáp án đúng"); return;
            }
        

            NganHangCauHoi nganHangCauHoi = new NganHangCauHoi
            {
                CauHoi = txtNoiDung.Text,
                DapAnA = txtA.Text,
                DapAnB = txtB.Text,
                DapAnC = txtC.Text,
                DapAnD = txtD.Text,
                DapAnDung = strDapAn,
                MucDo = strMucDo,
                MaMonHoc = cbbMonHoc.SelectedValue.ToString(),
                MaGiaoVien = giaoVien.MaGiaoVien.ToString(),
            
            };

            dgvDanhSachCauHoi.Rows.Add(
                nganHangCauHoi.CauHoi, 
                nganHangCauHoi.DapAnA, 
                nganHangCauHoi.DapAnB, 
                nganHangCauHoi.DapAnC, 
                nganHangCauHoi.DapAnD, 
                nganHangCauHoi.DapAnDung,
                nganHangCauHoi.MucDo,
                nganHangCauHoi.MaMonHoc,
                nganHangCauHoi.MaChuong,
                nganHangCauHoi.MaGiaoVien 
                );
            btnLuu.Enabled = true;
            resetForm();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            ReadFileExcel();    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lưu lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<NganHangCauHoi> listNganHang = new List<NganHangCauHoi>();
                foreach (DataGridViewRow r in dgvDanhSachCauHoi.Rows)
                {
                    try
                    {
                        listNganHang.Add(new NganHangCauHoi
                        {
                            CauHoi = r.Cells[0].Value.ToString(),
                            DapAnA = r.Cells[1].Value.ToString(),
                            DapAnB = r.Cells[2].Value.ToString(),
                            DapAnC = r.Cells[3].Value.ToString(),
                            DapAnD = r.Cells[4].Value.ToString(),
                            DapAnDung = r.Cells[5].Value.ToString(),
                            MucDo = r.Cells[6].Value.ToString(),
                            MaMonHoc = r.Cells[7].Value.ToString(),
                            MaChuong = int.Parse(r.Cells[8].Value.ToString()),
                            MaGiaoVien = r.Cells[9].Value.ToString()
                        });
                    }
                    catch
                    {
                        continue;
                    }
                }

                if (NganHangCauHoiBLL.InsertAll(listNganHang))
                {
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                    dgvDanhSachCauHoi.Rows.Clear();
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void dgvDanhSachCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachCauHoi_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachCauHoi.Rows.Count > 0)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            resetForm();
        }

        public void changeRadioButton(object sender)
        {
            foreach (Control control in gbDapAn.Controls)
            {
                foreach (Control ctChild in control.Controls)
                {
                    if (ctChild.GetType() == typeof(RadioButton))
                    {
                        RadioButton rdo = (RadioButton)ctChild;
                        rdo.Checked = false;
                    }
                }
            }
            RadioButton rdoBtn = (RadioButton)sender;
            rdoBtn.Checked = true;
        }
    }
}

