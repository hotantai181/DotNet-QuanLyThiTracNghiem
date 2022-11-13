using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietDeThiDAL
    {
        public List<ChiTietDeThi> GetListCTDTByMaDe(string maDe)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                return db.ChiTietDeThis.Where(t => t.MaDe.Equals(maDe)).ToList();
            }
        }
    }
}
