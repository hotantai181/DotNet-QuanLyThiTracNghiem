using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LopBLL
    {
        public static List<Lop> getLops(string pMaKhoa)
        {
            return new LopDAL().getLops(pMaKhoa);
        }
    }
}
