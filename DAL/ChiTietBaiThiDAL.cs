using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietBaiThiDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();


        public bool UpdateTrangThai(string maKq, string pTrangThai)
        {
            try
            {
                var temp = db.ChiTietBaiThis.Where(t => t.MaKQ == maKq).SingleOrDefault();
                temp.TrangThai = pTrangThai;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
