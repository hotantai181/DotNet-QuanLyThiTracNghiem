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
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public List<ChiTietDeThi> GetListCTDTByMaDe(string maDe)
        {
             return db.ChiTietDeThis.Where(t => t.MaDe.Equals(maDe)).ToList();
            
        }   
        public int GetMaCTDeThi (string maDe)
        {
            ChiTietDeThi ctdt =db.ChiTietDeThis.Where(t => t.MaDe.Equals(maDe)).FirstOrDefault();
            return ctdt.MaChiTietDeThi;
        }

    }
}
