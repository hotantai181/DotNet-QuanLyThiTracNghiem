using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DeThiDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();        
        public List<DeThi> listgetDeThi(string pMaDT)
        {
            return db.DeThis.Where(dt => dt.MaDe == pMaDT).ToList();
        }
        //public List<DeThi> getDeThi(string pMaDT)
        //{
        //    return db.DeThis.Where(t => t.MaDe.Equals(pMaDT)).ToList();
        //}
        public List<DeThi> getDeThis()
        {
            return db.DeThis.ToList();
        }
        //public List<DeThi> listMaDeThi(List<PhieuTaoDe> PTaoDe) 
        //{
        //    //return db.DeThis.Where(dt=> dt.MaPhieuTaoDe.Equals(PTaoDe.Select(dv=>dv.MaPhieuTaoDe).FirstOrDefault())).ToList();
        //}
        public string getMaPhieu(string pMaDT)
        {
            DeThi ttpt = db.DeThis.Where(pt => pt.MaDe.Equals(pMaDT)).FirstOrDefault();
            string maphieu = ttpt.MaPhieuTaoDe;
            return maphieu;

        }
        public  string GetMaDeThi(string pMaPT)
        {
            DeThi dt = db.DeThis.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).FirstOrDefault();
           
            return dt.MaDe;
        }
        public List<TTDeThi> getDeThi(string pMaDT)
        {
            return db.ChiTietDeThis.
                Where(ctdt => ctdt.MaDe.Equals(pMaDT))
                .Join(
                    db.CauHois,
                    ctdt => ctdt.MaCauHoi,
                    ch => ch.MaCauHoi,
                    (ctdt, ch) => new TTDeThi
                    {
                        CauHoi = ch.CauHoi1,
                        DA_a = ch.DapAnA,
                        DA_b = ch.DapAnB,
                        DA_c = ch.DapAnC,
                        DA_d = ch.DapAnD,
                    }
                ).ToList();
        }
    }
}
