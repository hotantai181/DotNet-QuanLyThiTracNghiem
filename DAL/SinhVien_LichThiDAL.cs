using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVien_LichThiDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public SinhVien_LichThi GetSinhVien_LichThi(int maLichThi, string maSv)
        {
            var temp = db.SinhVien_LichThis.Where(t => t.MaLichThi == maLichThi && t.Mssv.Equals(maSv) && t.LichThi.NgayThi.Value == DateTime.Today && t.TrangThai == false).FirstOrDefault();
            return temp;
        }
        public List<SinhVien_LichThi> GetListSinhVienLichThi(string maSv, bool status)
        {
            var temp = db.SinhVien_LichThis.Where(t => t.Mssv.Equals(maSv) && t.TrangThai == status).ToList();
            return temp;
        }
        public List<SinhVien_LichThi> GetListSinhVienLichThi(string maSv, DateTime date)
        {
            var sinhvien_lichthi = db.SinhVien_LichThis.Where(t => t.Mssv.Equals(maSv) && t.LichThi.NgayThi >= MondayOfWeek(date) && t.LichThi.NgayThi <= MondayOfWeek(date).AddDays(6)).OrderBy(t=>t.LichThi.NgayThi).ToList();
            return sinhvien_lichthi;
        }

        public bool UpdateTrangThai(int maSv_Lt, bool trangThai)
        {
            try
            {
                var temp = db.SinhVien_LichThis.Where(t => t.MaSVLT == maSv_Lt).SingleOrDefault();
                temp.TrangThai = trangThai;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;   
            }
        }

        public static DateTime MondayOfWeek(DateTime date)
        {
            var dayOfWeek = date.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Sunday)
            {
                return date.AddDays(-6);
            }

            int offset = dayOfWeek - DayOfWeek.Monday;
            return date.AddDays(-offset);
        }
    }
}
