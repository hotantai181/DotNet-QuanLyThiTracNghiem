using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVien_LichThiBLL
    {
        public static SinhVien_LichThi GetSinhVien_LichThi(int maLichThi, string maSv)
        {
            return new SinhVien_LichThiDAL().GetSinhVien_LichThi(maLichThi, maSv);
        }
        public static List<SinhVien_LichThi> GetListSinhVienLichThi(string maSv, DateTime date)
        {
            return new SinhVien_LichThiDAL().GetListSinhVienLichThi(maSv, date);
        }
        public static bool UpdateTrangThai(int maSv_Lt, bool trangThai){
            return new SinhVien_LichThiDAL().UpdateTrangThai(maSv_Lt, trangThai);
        }
        public static List<SinhVien_LichThi> GetListSinhVienLichThi(string maSv, bool status)
        {
            return new SinhVien_LichThiDAL().GetListSinhVienLichThi(maSv, status);
        }
    }
}
