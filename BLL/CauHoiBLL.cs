using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CauHoiBLL
    {
        public static List<CauHoi> GetListCauHoi(string maDe)
        {
            return new CauHoiDAL().GetListCauHoi(maDe);
        }
        public static bool InsertAll(List<CauHoi> nganHangCauHois)
        {
            return new CauHoiDAL().InsertAll(nganHangCauHois);
        }
        public  static List<CauHoiDT> GetListCauHoiChuong(string maChuong)
        {
            return new CauHoiDAL().GetListCauHoiChuong(maChuong);
        }
        public static bool AddCauHoi(CauHoi cauHoi)
        {
            return new CauHoiDAL().AddCauHoi(cauHoi);
        }
        public static List<CauHoiDaChon> GetCauHoiDaChons()
        {
            return new CauHoiDAL().GetCauHoiDaChons();
        }
        public int MaCauHoi(string pCauHoi)
        {
            return new CauHoiDAL().MaCauHoi(pCauHoi);
        }
        public List<CauHoi> GetListCHTuCTDeThi(string pmaDe)
        {
            return new CauHoiDAL().GetListCHTuCTDeThi( pmaDe);
        }
    }
}
