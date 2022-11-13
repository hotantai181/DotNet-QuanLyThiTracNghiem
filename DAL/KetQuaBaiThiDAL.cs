using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetQuaBaiThiDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public bool InsertKetQua(KetQuaBaiThi ketQua)
        {
            try
            {
                db.KetQuaBaiThis.InsertOnSubmit(ketQua);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
