using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaiThiDAL
    {

        public void InsertBaiThi(List<ChiTietBaiThi> baiThis)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                db.ChiTietBaiThis.InsertAllOnSubmit(baiThis);
                db.SubmitChanges();
            }
        }

        public List<ChiTietBaiThi> GetListBaiThi(int maSvLT)
        {
            QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
            return db.ChiTietBaiThis.Where(t => (int)t.MaBaiThi == maSvLT).ToList();
        }
    }
}
