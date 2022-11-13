using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiaoVienDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GiaoVien GetGiaoVien(string maGV)
        {
            return db.GiaoViens.Where(t => t.MaGiaoVien.Equals(maGV)).FirstOrDefault();
        }

        public bool CheckUsername(string maGV)
        {
            var item = db.GiaoViens.Where(t => t.MaGiaoVien.Equals(maGV)).FirstOrDefault();
            return item != null;
        }
        public GiaoVien CheckPassword(string maGV, string pass)
        {
            var item = db.GiaoViens.Where(t => t.MaGiaoVien.Equals(maGV) && t.MatKhau.Equals(pass)).FirstOrDefault();
            return item;
        }
    }
}
