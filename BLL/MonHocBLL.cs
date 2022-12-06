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
        public static List<MonHoc> GetMonHocs(string pMaKhoa)
        {
            return new MonHocDAL().GetMonHocs(pMaKhoa);
        }
        public static List<MonHoc> GetMonHoc(string pMaMonHoc)
        {
            return new MonHocDAL().GetMonHoc(pMaMonHoc);
        }
        public string getTenMH(string pMaPT)
        {
            return new MonHocDAL().getTenMH(pMaPT);
        }
        public static List<Khoa> GetKhoa(string pMaMonHoc)
        {
            return new MonHocDAL().GetKhoa(pMaMonHoc);
        }
        
    }
}
