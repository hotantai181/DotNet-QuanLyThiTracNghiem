using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichThiBLL
    {
        public static LichThi getLichThiByDate(DateTime date)
        {
            return new LichThiDAL().getLichThiByDate(date);
        }
    }
}
