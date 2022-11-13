using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVien_MonHocBLL
    {
        public static SinhVien_MonHoc getSinhVienMonHoc(string massv, string maMH)
        {
            return new SinhVien_MonHocDAL().getSinhVienMonHoc(massv, maMH);
        }

    }
}
