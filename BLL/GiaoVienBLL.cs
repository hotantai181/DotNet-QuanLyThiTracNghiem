using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiaoVienBLL
    {
        public static GiaoVien GetGiaoVien(string maGV)
        {
            return new GiaoVienDAL().GetGiaoVien(maGV);
        }
        public static bool CheckUsername(string maGV)
        {
            return new GiaoVienDAL().CheckUsername(maGV);   
        }
        public static GiaoVien CheckPassword(string maGV, string pass)
        {
            return new GiaoVienDAL().CheckPassword(maGV, pass);
        }


    }
}
