using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;

using System.Globalization;

using DTO;
namespace DAL
{
    public  class CauHoiDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public List<CauHoi> GetListCauHoi(string maDe)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                List<ChiTietDeThi> dsMaCauHoi = db.ChiTietDeThis.Where(t => t.MaDe.Equals(maDe)).ToList();
                List<CauHoi> temp = new List<CauHoi>();
                foreach(var item in dsMaCauHoi)
                {
                    var result = db.CauHois.Where(t => t.MaCauHoi == item.MaCauHoi).FirstOrDefault();
                    temp.Add(result);
                }
                return temp;
            }
        }
        public bool InsertAll(List<CauHoi> nganHangCauHois)
        {
            try
            {
                using (var db = new QLThiTracNghiemDataContext())
                {
                    db.CauHois.InsertAllOnSubmit(nganHangCauHois);
                    db.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
        public bool AddCauHoi(CauHoi cauHoi)
        {
            try
            {
                db.CauHois.InsertOnSubmit(cauHoi);

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CauHoi> GetListCHTuCTDeThi( string pmaDe)
        {
            List<ChiTietDeThi> b = db.ChiTietDeThis.Where(n => n.MaDe.Equals(pmaDe)).ToList();
            List<CauHoi> temp = new List<CauHoi>();
            foreach (var item in b)
            {
                var result = db.CauHois.Where(t => t.MaCauHoi == item.MaCauHoi).FirstOrDefault();
                temp.Add(result);
            }
            return temp;
        }

        public   List<CauHoiDT> GetListCauHoiChuong(string maChuong)
        {

            return
                 db.CauHois.Where(t => t.MaChuong.Equals(maChuong))
                   .Select(pt => new CauHoiDT
                   {
                       MaCauHoi = pt.MaCauHoi,
                       CauHoi = pt.CauHoi1,
                       DapAnA = pt.DapAnA,
                       DapAnB = pt.DapAnB,
                       DapAnC = pt.DapAnC,
                       DapAnD = pt.DapAnD,
                       DapAnDung = pt.DapAnDung,
                       MucDo = pt.MucDo,
                   }).ToList();
        }

        public int MaCauHoi(string pCauHoi)
        {
            CauHoi cauHoi = db.CauHois.Where(t => t.CauHoi1.Equals(pCauHoi)).FirstOrDefault();
            return cauHoi.MaCauHoi;
        }
        public List<CauHoiDaChon> GetCauHoiDaChons()
        {
            return db.CauHois.Select(pt => new CauHoiDaChon
            {
                CauHoi = pt.CauHoi1,
               
                MucDo  = pt.MucDo,
            }).ToList();
        }
    }
}
