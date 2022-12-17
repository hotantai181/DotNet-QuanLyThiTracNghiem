using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaiThiBLL
    {
        public static void InsertBaiThi(List<ChiTietBaiThi> baiThis)
        {
            new BaiThiDAL().InsertBaiThi(baiThis);
        }
        public static List<ChiTietBaiThi> GetListBaiThi(int maSvLT)
        {
            return new BaiThiDAL().GetListBaiThi(maSvLT);
        }
    }
}
