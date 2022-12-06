using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HocSinhDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public HocSinh GetSinhVien(string maSV)
        {
            return db.HocSinhs.Where(t => t.Mssv.Equals(maSV)).FirstOrDefault();
        }

        public List<HocSinh> searchSinhVien(string maSv)
        {
            return db.HocSinhs.Where(t => t.Mssv.Contains(maSv)).Take(5).ToList();
        }
        public List<HocSinh> SearchSinhViens(string maSV, int limit)
        {
            return db.HocSinhs.Where(t => t.Mssv.Contains(maSV)).Take(limit).ToList();
        }
        public bool checkUsername(string username)
        {
            if (db.HoSinhs.Where(t => t.Mssv.Equals(username)).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }

        public SinhVien checkPassword(string username, string pass)
        {
          
            var sv = db.HocSinhs.Where(t => t.Mssv.Equals(username) && t.MatKhau.Equals(pass)).FirstOrDefault();
            if (sv != null)
            {
                return sv;
            }
            return null;
        }
        public List<HocSinh> SearchSinhViensByLop(string malop, int limit)
        {
            return db.HocSinhs.Where(t => t.MaLop.Contains(malop)).Take(limit).ToList();
        }
        public bool InsertAll(List<HocSinh> sinhviens)
        {
            try
            {
                using (var db = new QLThiTracNghiemDataContext())
                {
                    db.HocSinhs.InsertAllOnSubmit(sinhviens);
                    db.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
