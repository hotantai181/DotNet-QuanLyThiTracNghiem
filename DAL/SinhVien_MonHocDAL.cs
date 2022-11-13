using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVien_MonHocDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public SinhVien_MonHoc getSinhVienMonHoc(string massv, string maMH)
        {
            return db.SinhVien_MonHocs.Where(t => t.MaMonHoc.Equals(maMH) && t.Mssv.Equals(massv)).FirstOrDefault();
        }
    }
}
