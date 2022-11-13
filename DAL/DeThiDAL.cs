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
        public List<TTDeThi> getDeThi(string pMaDT)
        {
            return db.ChiTietDeThis.
                Where(ctdt => ctdt.MaDe.Equals(pMaDT))
                .Join(
                    db.NganHangCauHois,
                    ctdt => ctdt.MaCauHoi,
                    ch => ch.MaCauHoi,
                    (ctdt, ch) => new TTDeThi
                    {
                        CauHoi = ch.CauHoi,
                        DA_a = ch.DapAnA,
                        DA_b = ch.DapAnB,
                        DA_c = ch.DapAnC,
                        DA_d = ch.DapAnD,
                    }
                ).ToList();
        }
    }
}
