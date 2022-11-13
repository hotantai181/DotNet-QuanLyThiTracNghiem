using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KetQuaBaiThiBLL
    {
        public static bool InsertKetQua(KetQuaBaiThi ketQua)
        {
            return new KetQuaBaiThiDAL().InsertKetQua(ketQua);
        }
    }
}
