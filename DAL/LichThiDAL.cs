using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichThiDAL
    {
        public LichThi getLichThiByDate(DateTime date)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                return db.LichThis.Where(t => t.NgayThi.Value.Date == date.Date).FirstOrDefault();
            }
        }
    }
}
