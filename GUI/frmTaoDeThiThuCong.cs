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
    public partial class frmTaoDeThiThuCong : Form
    {
        PhieuTaoBLL bus_phieuTao = new PhieuTaoBLL();
        DeThiBLL deThiBLL = new DeThiBLL();
        ChiTietDeThiBLL  chiTietDethiBLL = new ChiTietDeThiBLL();
        CauHoiBLL cauHoi = new CauHoiBLL();
        private string _maMonHoc,_maPT;

        List<CauHoiDaChon> ch = new List<CauHoiDaChon>();   
        public string MaMonHoc
        {
            get { return _maMonHoc; }
            set { _maMonHoc = value; }
        }
        public string pMaPT
        {
            get { return _maPT; }
            set { _maPT = value; }

        }
        string chuong = "";
        public frmTaoDeThiThuCong()
        {
            InitializeComponent();
        }
        public frmTaoDeThiThuCong(string MaMonHoc,string pMaPT) : this()
        {
           
            _maMonHoc = MaMonHoc;
            _maPT = pMaPT;
            label3.Text = _maMonHoc;
            label4.Text = _maPT;
            comboBox1.DataSource = ChuongBLL.GetListChuongByMaMon(_maMonHoc);
            comboBox1.DisplayMember = "TenChuong";
            comboBox1.ValueMember = "MaChuong";
            string s = comboBox1.SelectedValue.ToString();
            loadCauHoiTheoChuong(s);
            chuong = s;
           

        }
        public void frmTaoDeThiThuCong_Load(object sender, EventArgs e)
        {
       
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedValue.ToString();
            loadCauHoiTheoChuong(s);
        }
        DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn();
        public void loadCauHoiTheoChuong(string maChuong)
        {
            dataGridView1.DataSource = CauHoiBLL.GetListCauHoiChuong(maChuong);
        }
        private void btnXN_Click(object sender, EventArgs e)
        {
            _maPT = pMaPT;
            

            // Tao De Thi //
            bus_phieuTao.taoDeThi(label4.Text);
            // Tao Ma Chi Tiet De Thi//
           

            // Lay Ma DE Thi


            string maDeThi = deThiBLL.GetMaDeThi(label4.Text);


            // Lay 1 Ma Chi Tiet DE THi Tu Dataa
           
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["Check"].Value?.ToString() == null)
                {
                }    
                else
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Check"].Value.ToString()).Equals(true))
                    {
                        int macau = int.Parse(dataGridView1.Rows[i].Cells["MaCau"].Value.ToString());
                        ChiTietDeThi ctdt = new ChiTietDeThi();
                        ctdt.MaDe = maDeThi;
                        ctdt.MaCauHoi =macau;
                        bus_phieuTao.taoCTDeThiThuCong(label4.Text, ctdt);
                      
                    }
                }
            }
            loadCauHoiDaChon();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maDeThi = deThiBLL.GetMaDeThi(label4.Text);
            bus_phieuTao.ranDomCTDeThiConLai(maDeThi,label4.Text);
            MessageBox.Show("Tạo đề thành công");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadCauHoiDaChon()
        {
            string maDeThi = deThiBLL.GetMaDeThi(label4.Text);
            int maCTDT = chiTietDethiBLL.GetMaCTDeThi(maDeThi);
            dataGridView2.DataSource=  cauHoi.GetListCHTuCTDeThi(maDeThi);
           
        }
    }
}
