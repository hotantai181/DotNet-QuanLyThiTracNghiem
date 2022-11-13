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

        public void InsertBaiThi(List<BaiThi> baiThis)
        {
            using (var db = new QLThiTracNghiemDataContext())
            {
                db.BaiThis.InsertAllOnSubmit(baiThis);
                db.SubmitChanges();
            }
        }

        public List<BaiThi> GetListBaiThi(int maSvLT)
        {
            QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
            return db.BaiThis.Where(t => (int)t.MaSVLT == maSvLT).ToList();
        }
    }
}
