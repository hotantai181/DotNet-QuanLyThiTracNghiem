using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public  class MonHocDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext(); 

        public List<MonHoc> GetMonHocs(string pMaKhoa)
        {
            return db.MonHocs.Where(mh => mh.MaKhoa == pMaKhoa).ToList();
        }
        public List<MonHoc> GetMonHoc(string pMaMonHoc)
        {
            return db.MonHocs.Where(mh => mh.MaMonHoc == pMaMonHoc).ToList();
        }
        public string getTenMH(string pMaPT)
        {
            var maMH = db.PhieuTaoDes
                .Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT))
                .Select(pt => pt.MaMonHoc).Single();
            return db.MonHocs.Where(mh => mh.MaMonHoc.Equals(maMH)).Select(mh => mh.TenMonHoc).Single();
        }

        public List<MonHoc> GetMonHocs_LichThi(string pNgayThi)
        {
            return db.LichThis.Where(lt => lt.NgayThi == DateTime.ParseExact(pNgayThi, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .Select(lt => lt.MonHoc).ToList();
        }

        public List<Khoa> GetKhoa(string pMaMonHoc)
        {
            return db.Khoas
                .Where(k => k.MaKhoa.Equals(db.MonHocs.Where(mh => mh.MaMonHoc.Equals(pMaMonHoc)).Single().MaKhoa))
                .ToList();
        }
    }
}
