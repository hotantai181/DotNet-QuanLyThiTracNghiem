using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhoaDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();


        QLThiTracNghiemDataContext dataContext = new QLThiTracNghiemDataContext();
        public Khoa GetDepartment(string maKhoa)
        {
            return dataContext.Khoas.FirstOrDefault(k => k.MaKhoa.Equals(maKhoa));
        }
        public List<Khoa> GetDepartment()
        {
            return dataContext.Khoas.ToList();
        }
    }
}
