using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MonHocDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();


        public List<MonHoc> GetMonHoc(string pMaMonHoc)
        {
            return db.MonHocs.Where(mh => mh.MaMonHoc == pMaMonHoc).ToList();
        }
        public List<MonHoc> GetMonHocs()
        {
            return db.MonHocs.ToList();
        }
        public  string getTenMH(string pMaPT)
        {
            var maMH = db.PhieuTaoDes
                .Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT))
                .Select(pt => pt.MaMonHoc).Single();
            return db.MonHocs.Where(mh => mh.MaMonHoc.Equals(maMH)).Select(mh => mh.TenMonHoc).Single();
        }
        public string getMaMonHoc(string pMaPT)
        {
            var maMH = db.PhieuTaoDes
                .Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT))
                .Select(pt => pt.MaMonHoc).Single();
            return db.MonHocs.Where(mh => mh.MaMonHoc.Equals(maMH)).Select(mh => mh.MaMonHoc).Single();
        }
    }
}
