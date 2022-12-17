using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DeThiBLL
    {
        public List<DeThi> getDeThis()
        {
            return new DeThiDAL().getDeThis();
        }
        //public static List<DeThi> listMaDeThi(List<PhieuTaoDe> PTaoDe)
        //{
        //    //return new DeThiDAL().listMaDeThi(PTaoDe);
        //}
        public List<TTDeThi> getDeThi(string pMaDT)
        {
            return new DeThiDAL().getDeThi(pMaDT);
        }
        public static string  getMaPhieu(string pMaDT)
        {
            return new DeThiDAL().getMaPhieu(pMaDT);
        }
        public   string GetMaDeThi(string pMaPT)
        {
            return new DeThiDAL().GetMaDeThi(pMaPT);
        }
    }
}
