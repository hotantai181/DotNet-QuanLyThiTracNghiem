using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuongDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public List<Chuong> GetListChuongByMaMon(string MaMon)
        {
            return db.Chuongs.Where(t => t.MaMonHoc.Equals(MaMon)).ToList();
        }

        public List<Chuong> GetMaChuongByMaMon(string TenChuong)
        {
            return db.Chuongs.Where(t => t.MaChuong.Equals(TenChuong)).ToList();
        }
    }
}
