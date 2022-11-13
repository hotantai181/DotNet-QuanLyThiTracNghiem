using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LopDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public List<Lop> getLops(string pMaKhoa)
        {
            return db.Lops.Where(l => l.MaKhoa == pMaKhoa).ToList();
        }
    }
}
