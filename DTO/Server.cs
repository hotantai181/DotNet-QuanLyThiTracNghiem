using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Server
    {
        private static string[] strConnection = Properties.Settings.Default.QL_ThiTracNghiemConnectionString.Split(';');

        public static string Name = strConnection[0].Split('=')[1];
        public static string Database = strConnection[1].Split('=')[1];
        public static string User = strConnection[2].Split('=')[1];
        public static string Password = strConnection[3].Split('=')[1];

    }
}
