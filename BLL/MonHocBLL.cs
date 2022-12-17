using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class MonHocBLL
    {
     
        public static List<MonHoc> GetMonHoc(string pMaMonHoc)
        {
            return new MonHocDAL().GetMonHoc(pMaMonHoc);
        }
        public static string getTenMH(string pMaPT)
        {
            return new MonHocDAL().getTenMH(pMaPT);
        }
        public static List<MonHoc> GetMonHocs()
        {
            return new MonHocDAL().GetMonHocs();
        }
        public static string getMaMonHoc(string pMaPT)
        {
            return new MonHocDAL().getMaMonHoc(pMaPT);
        }
  
        
    }
}
