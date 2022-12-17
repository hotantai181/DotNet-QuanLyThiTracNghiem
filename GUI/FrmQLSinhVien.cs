using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmQLSinhVien : Form
    {
        List<Lop> listLop;
        string masv;
        public FrmQLSinhVien()
        {
            InitializeComponent(); 
            
            dgvDSSV.DataSource = HocSinhBLL.SearchSinhViens("", 60);
        }

        private void txtMssv_TextChanged(object sender, EventArgs e)
        {
            masv = txtMssv.Text;
            dgvDSSV.DataSource = HocSinhBLL.SearchSinhViens(masv, 60);
        }

        private void LoadLop()
        {
            listLop = LopBLL.getLops(cbbKhoa.SelectedValue.ToString());
            cbbLop.Text = "";
            cbbLop.DataSource = listLop;
            cbbLop.DisplayMember = "MaLop";
            cbbLop.ValueMember = "MaLop";
            if (listLop.Count > 1)
            {
                cbbLop.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFileExcel();
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

                    System.Data.DataTable db = exDataSet.Tables[0];
                    dgvDSSV.DataSource = db;
                    List<HocSinh> sinhvien = new List<HocSinh>();

                    foreach (DataRow r in db.Rows)
                    {
                        try
                        {
                            sinhvien.Add(new HocSinh
                            {
                                Mssv = r[0].ToString(),
                                HoTen = r[1].ToString(),
                                MaLop = r[2].ToString(),
                                GioiTinh = r[3].ToString(),
                                Email = r[4].ToString(),
                                MatKhau = (123).ToString(),
                            });
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    if (MessageBox.Show("Sinh viên đã được tải lên! Bạn có muốn lưu vào cơ sở dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (HocSinhBLL.InsertAll(sinhvien))
                        {
                            MessageBox.Show("Lưu thành công!");
                        }
                        else MessageBox.Show("Lưu thất bại!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportFile();
        }

        private void ExportFile()
        {
            //if (dgvDSSV.Rows.Count > 0)
            //{
            //    ApplicationClass XcelApp = new ApplicationClass();
            //    XcelApp.Application.Workbooks.Add(Type.Missing);
            //    for (int i = 1; i < dgvDSSV.Columns.Count + 1; i++)
            //    {
            //        XcelApp.Cells[1, i] = dgvDSSV.Columns[i - 1].HeaderText;
            //    }
            //    for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dgvDSSV.Columns.Count; j++)
            //        {
            //            XcelApp.Cells[i + 2, j + 1] = dgvDSSV.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    XcelApp.Columns.AutoFit();
            //    XcelApp.Visible = true;
            //}
        }

        private void FrmQLSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void cbbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void cbbLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string malop = cbbLop.SelectedValue.ToString();
            dgvDSSV.DataSource = HocSinhBLL.SearchSinhViensByLop(malop, 40);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ReadFileExcel();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lưu lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<HocSinh> sinhViens = new List<HocSinh>();
                foreach (DataGridViewRow r in dgvDSSV.Rows)
                {
                    try
                    {
                        sinhViens.Add(new HocSinh
                        {
                            HoTen = r.Cells[0].Value.ToString(),
                            MaLop = r.Cells[1].Value.ToString(),
                            DiaChi = r.Cells[2].Value.ToString(),
                            CMND_CCCD = r.Cells[3].Value.ToString(),
                            GioiTinh = r.Cells[4].Value.ToString(),
                            Sdt = r.Cells[5].Value.ToString(),
                            Email = r.Cells[6].Value.ToString(),
                            MatKhau = r.Cells[7].Value.ToString(),
                        });
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            ThemHocSinh ths = new ThemHocSinh();
            ths.ShowDialog();
        }
    }
}
