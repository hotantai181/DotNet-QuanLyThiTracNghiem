using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HocSinhBLL
    {
        public static HocSinh GetSinhVien(string maSv)
        {
            return new HocSinhDAL().GetSinhVien(maSv);
        }
        public static List<HocSinh> searchSinhVien(string maSv)
        {
            return new HocSinhDAL().searchSinhVien(maSv);
        }
        public static List<HocSinh> SearchSinhViens(string maSV, int limit)
        {
            return new HocSinhDAL().SearchSinhViens(maSV, limit);
        }
        public static bool checkUsername(string username)
        {
            return new HocSinhDAL().checkUsername(username);
        }

        public static HocSinh checkPassword(string username, string pass)
        {
            return new HocSinhDAL().checkPassword(username, pass);
        }
        public static List<HocSinh> SearchSinhViensByLop(string malop, int limit)
        {
            return new HocSinhDAL().SearchSinhViensByLop(malop, limit);
        }
        public static bool InsertAll(List<HocSinh> sinhviens)
        {
            return new HocSinhDAL().InsertAll(sinhviens);
        }
        public static bool AddHocSinh(HocSinh hs)
        {
            return new HocSinhDAL().AddHocSinh(hs);
        }
    }
}