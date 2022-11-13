using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChuongBLL
    {
        public static List<Chuong> GetListChuongByMaMon(string maMon)
        {
            return new ChuongDAL().GetListChuongByMaMon(maMon);
        }
    }
}
