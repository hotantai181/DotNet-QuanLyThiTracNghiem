using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NganHangCauHoiDAL
    {
        public List<NganHangCauHoi> GetListCauHoi(string maDe)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                List<ChiTietDeThi> dsMaCauHoi = db.ChiTietDeThis.Where(t => t.MaDe.Equals(maDe)).ToList();
                List<NganHangCauHoi> temp = new List<NganHangCauHoi>();
                foreach(var item in dsMaCauHoi)
                {
                    var result = db.NganHangCauHois.Where(t => t.MaCauHoi == item.MaCauHoi).FirstOrDefault();
                    temp.Add(result);
                }
                return temp;
            }
        }
        public bool InsertAll(List<NganHangCauHoi> nganHangCauHois)
        {
            try
            {
                using (var db = new QLThiTracNghiemDataContext())
                {
                    db.NganHangCauHois.InsertAllOnSubmit(nganHangCauHois);
                    db.SubmitChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
