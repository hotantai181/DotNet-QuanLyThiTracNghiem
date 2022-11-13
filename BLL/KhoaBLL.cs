using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhoaBLL
    {
        public static List<Khoa> GetDepartment()
        {
            return new KhoaDAL().GetDepartment();
        }
        public static Khoa Khoa(string maKhoa)
        {
            return new KhoaDAL().GetDepartment(maKhoa);
        }
    }
}
