using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            cbbServer.DataSource = config.GetServerName();
            cbbServer.DisplayMember = "ServerName";
        }

        private void cbbDb_DropDown(object sender, EventArgs e)
        {
            cbbDb.DataSource = config.GetDBName(cbbServer.Text, txtUser.Text, txtPass.Text);
            cbbDb.DisplayMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.SaveConfig(cbbServer.Text, txtUser.Text, txtPass.Text, cbbDb.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
