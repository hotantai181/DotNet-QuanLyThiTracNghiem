using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmRestore : Form
    {
        public FrmRestore()
        {
            InitializeComponent();
        }

        private void txtPathFile_TextChanged(object sender, EventArgs e)
        {
            btnRestore.Enabled = txtPathFile.Text.Trim().Length > 0;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File (*.bak)|*.bak";
            ofd.Multiselect = false;

            ofd.CheckFileExists = true;

            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = ofd.FileName;
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Restore dbRestore = new Restore() { Database = DTO.Server.Database, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(txtPathFile.Text, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(new Server(new ServerConnection(DTO.Server.Name, DTO.Server.User, DTO.Server.Password)));
            }
            catch (Exception ex)
            {

            }
        }
        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Khôi phục thành công");

            txtPathFile.BeginInvoke(new Action(() => txtPathFile.Clear()));
            progressBar.BeginInvoke(new Action(() =>
            {
                progressBar.Value = 0;
                progressBar.Update();
            }));
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.BeginInvoke(new Action(() =>
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            }));
        }

        private void FrmRestore_Load(object sender, EventArgs e)
        {

        }
    }
}
