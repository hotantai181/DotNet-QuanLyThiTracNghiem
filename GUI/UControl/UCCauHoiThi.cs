using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UControl
{
    public partial class UCCauHoiThi : UserControl
    {
        private NganHangCauHoi cauhoi;
        private int index;
        private int maCauHoi;
        private bool daLam;


        public int Index { get => index; set => index = value; }
        public int MaCauHoi { get => maCauHoi; set => maCauHoi = value; }
        public bool DaLam { get => daLam; set => daLam = value; }
        public NganHangCauHoi Cauhoi { get => cauhoi; set => cauhoi = value; }

        public UCCauHoiThi(NganHangCauHoi cauhoi, int index)
        {
            this.Cauhoi = cauhoi;
            this.Index = index;
            this.DaLam = false;
            this.MaCauHoi = cauhoi.MaCauHoi;
            InitializeComponent();
        }

        public string SelectedAnswer()
        {
            string temp = string.Empty;
            if (rdoBtnB.Checked)
                temp = "B";
            else if (rdoBtnC.Checked)
                temp = "C";
            else if (rdoBtnD.Checked)
                temp = "D";
            else if (rdoBtnA.Checked)
                temp = "A";
            return temp;
        }

        public string GetResult()
        {
            string temp = string.Empty;
            if (rdoBtnB.Checked)
                temp = cauhoi.DapAnB;
            else if (rdoBtnC.Checked)
                temp = cauhoi.DapAnC;
            else if (rdoBtnD.Checked)
                temp = cauhoi.DapAnD;
            else if (rdoBtnA.Checked)
                temp = cauhoi.DapAnD;
            return temp;
        }

        public void SetSelectedAnswer(string txtAndwer)
        {
            if (txtAndwer.Equals("A"))
                rdoBtnA.Checked = true;
            else if (txtAndwer.Equals("B"))
                rdoBtnB.Checked = true;
            else if (txtAndwer.Equals("C"))
                rdoBtnC.Checked = true;
            else if (txtAndwer.Equals("D"))
                rdoBtnD.Checked = true;
            else return;
        }
        private void UCCauHoiThi_Load(object sender, EventArgs e)
        {
            lbCau.Text = "Câu " + Index;
            rdoBtnA.Tag = rdoBtnB.Tag = rdoBtnC.Tag = rdoBtnD.Tag = maCauHoi;
        }

        private void lbCau_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoBtnA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnB.Checked)
                DaLam = true;
            else if (rdoBtnC.Checked)
                DaLam = true;
            else if (rdoBtnD.Checked)
                DaLam = true;
            else if (rdoBtnA.Checked)
                DaLam = true;
        }
    }
}
