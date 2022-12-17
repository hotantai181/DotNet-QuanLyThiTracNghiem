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

        public List<Lop> getLops(string pMaLop)
        {
            return db.Lops.Where(l => l.MaLop == pMaLop).ToList();
        }
    }
}
