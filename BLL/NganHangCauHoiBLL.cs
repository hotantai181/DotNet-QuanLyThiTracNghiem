using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NganHangCauHoiBLL
    {
        public static List<NganHangCauHoi> GetListCauHoi(string maDe)
        {
            return new NganHangCauHoiDAL().GetListCauHoi(maDe);
        }
        public static bool InsertAll(List<NganHangCauHoi> nganHangCauHois)
        {
            return new NganHangCauHoiDAL().InsertAll(nganHangCauHois);
        }
    }
}
