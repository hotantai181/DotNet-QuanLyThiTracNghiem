using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class ChiTietDeThiBLL
    {
        public static List<ChiTietDeThi> GetListCTDTByMaDe(string maDe)
        {
            return new ChiTietDeThiDAL().GetListCTDTByMaDe(maDe);
        }
        public  int GetMaCTDeThi(string maDe)
        {
            return new ChiTietDeThiDAL().GetMaCTDeThi(maDe);
        }
   
    }
}
