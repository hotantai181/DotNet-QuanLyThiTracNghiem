using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuTaoBLL
    {
        public List<PhieuTaoDT> getPhieuTaos(string pMaGiaoVien)
        {
            return new PhieuTaoDAL().getPhieuTaos(pMaGiaoVien).ToList();
        }
        public List<PhieuTaoDT> getPhieuTaos_NgayLap(string pNgayLap)
        {
            return new PhieuTaoDAL().getPhieuTaos_NgayLap(pNgayLap).ToList();
        }
        public PhieuTaoDe get_tt_phieuTao(string pMaPhieu)
        {
            return new PhieuTaoDAL().get_tt_phieuTao(pMaPhieu);
        }
        public bool add_phieuTao(PhieuTaoDe pt)
        {
            return new PhieuTaoDAL().add_phieuTao(pt);
        }
      
        public bool change_phieuTao(PhieuTaoDe pPhieuTao)
        {
            return new PhieuTaoDAL().change_phieuTao(pPhieuTao);
        }


        public static int? getTGLamBai(string pMaPhieu)
        {
            return new PhieuTaoDAL().getTGLamBai(pMaPhieu);
        }


        public int countPhieus()
        {
            return new PhieuTaoDAL().getPhieuTaos().Count;
        }

        public string getNewMaPhieu()
        {
            return string.Format("PH{0:00}", countPhieus() + 1);
        }

        public bool remove_phieuTaoDe(string pMaPTD)
        {
            return new PhieuTaoDAL().remove_phieuTaoDe(pMaPTD);
        }

        //----------------------------------------------------------

        public void kiemTraPhieuTao(string pMaPT)
        {
            try
            {
                new PhieuTaoDAL().kiemTraPhieuTao(pMaPT);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool taoDeThiThuCong(string pMaPT)
        {
            return new PhieuTaoDAL().taoDeThiThuCong(pMaPT);
        }
        public bool taoCTDeThiThuCong(string pMaPT,ChiTietDeThi ctdt)
        {
            return new PhieuTaoDAL().taoCTDeThiThuCong(pMaPT, ctdt);
        }
        public bool capNhatTrangThai(string pMaPT, string pMessage)
        {
            return new PhieuTaoDAL().capNhatTrangThai(pMaPT, pMessage);
        }

        public bool taoDeThi(string pMaPT)
        {
            return new PhieuTaoDAL().taoDeThi(pMaPT);
        }

        public bool taoCTDeThi(string pMaPT)
        {
            return new PhieuTaoDAL().taoCTDeThi(pMaPT);
        }


        public bool ranDomCTDeThiConLai(string pMaDe,string pMaPhieuTao)
        {
            return new PhieuTaoDAL().ranDomCTDThiConLai(pMaDe,pMaPhieuTao);
        }
    }
}