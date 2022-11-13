using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SinhVienDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public SinhVien GetSinhVien(string maSV)
        {
            return db.SinhViens.Where(t => t.Mssv.Equals(maSV)).FirstOrDefault();
        }

        public List<SinhVien> searchSinhVien(string maSv)
        {
            return db.SinhViens.Where(t => t.Mssv.Contains(maSv)).Take(5).ToList();
        }
        public List<SinhVien> SearchSinhViens(string maSV, int limit)
        {
            return db.SinhViens.Where(t => t.Mssv.Contains(maSV)).Take(limit).ToList();
        }
        public bool checkUsername(string username)
        {
            if (db.SinhViens.Where(t => t.Mssv.Equals(username)).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }

        public SinhVien checkPassword(string username, string pass)
        {
          
            var sv = db.SinhViens.Where(t => t.Mssv.Equals(username) && t.MatKhau.Equals(pass)).FirstOrDefault();
            if (sv != null)
            {
                return sv;
            }
            return null;
        }
        public List<SinhVien> SearchSinhViensByLop(string malop, int limit)
        {
            return db.SinhViens.Where(t => t.MaLop.Contains(malop)).Take(limit).ToList();
        }
        public bool InsertAll(List<SinhVien> sinhviens)
        {
            try
            {
                using (var db = new QLThiTracNghiemDataContext())
                {
                    db.SinhViens.InsertAllOnSubmit(sinhviens);
                    db.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
