using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class SaoLuu_PhucHoiBLL
    {
        public bool saoLuu(string path)
        {
            Backup bkpDBFull = new Backup();

            bkpDBFull.Action = BackupActionType.Database;

            bkpDBFull.Database = DTO.Server.Database;

            bkpDBFull.Devices.AddDevice(path, DeviceType.File);
            bkpDBFull.BackupSetName = "Adventureworks database Backup";
            bkpDBFull.BackupSetDescription = "Adventureworks database - Full Backup";
            

            bkpDBFull.ExpirationDate = DateTime.Today.AddDays(10);

            bkpDBFull.Initialize = false;


            bkpDBFull.PercentComplete += CompletionStatusInPercent;
            bkpDBFull.Complete += Backup_Completed;


            bkpDBFull.SqlBackup(new Server(new ServerConnection(DTO.Server.Name, DTO.Server.User, DTO.Server.Password)));

            return true;
        }
        private static void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            
        }
        private static void Backup_Completed(object sender, ServerMessageEventArgs args)
        {
            MessageBox.Show("Sao lưu thành công");
        }
        private static void Restore_Completed(object sender, ServerMessageEventArgs args)
        {
            
        }
    }
}
