using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBLL
    {
        public static SinhVien GetSinhVien(string maSv)
        {
            return new SinhVienDAL().GetSinhVien(maSv);
        }
        public static List<SinhVien> searchSinhVien(string maSv)
        {
            return new SinhVienDAL().searchSinhVien(maSv);
        }
        public static List<SinhVien> SearchSinhViens(string maSV, int limit)
        {
            return new SinhVienDAL().SearchSinhViens(maSV, limit);
        }
        public static bool checkUsername(string username)
        {
            return new SinhVienDAL().checkUsername(username);
        }

        public static SinhVien checkPassword(string username, string pass)
        {
            return new SinhVienDAL().checkPassword(username, pass);
        }
        public static List<SinhVien> SearchSinhViensByLop(string malop, int limit)
        {
            return new SinhVienDAL().SearchSinhViensByLop(malop, limit);
        }
        public static bool InsertAll(List<SinhVien> sinhviens)
        {
            return new SinhVienDAL().InsertAll(sinhviens);
        }
    }
}
