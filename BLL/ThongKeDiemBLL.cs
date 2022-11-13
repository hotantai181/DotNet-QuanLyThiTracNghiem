using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ThongKeDiemBLL
    {
        public List<ThongKeDiemThi> getThongTinDiems_lop(string pMaMonHoc, string pMaLop, string pNienKhoa, string pHocKy)
        {
            return new ThongKeDiemDAL().getThongTinDiems_lop(pMaMonHoc, pMaLop, pNienKhoa, pHocKy);
        }

        public void exportExcel_Lop(string pTenMonHoc, string pTenLop, string pHocKy, string pNienKhoa, List<ThongKeDiemThi> pLstKQ)
        {
            List<String> data = new List<String>();
            data.Add(pTenMonHoc);
            data.Add(pTenLop);
            data.Add(pHocKy);
            data.Add(pNienKhoa);

           Reports<ThongKeDiemThi>.export(pLstKQ, "KetQuaLop", "ThongKeDiemThi_Lop", data);
        }
        public void exportExcel_PhongThi(string pTenMonHoc, string pPhongThi, string pHocKy, string pNienKhoa, string pNgayThi, List<ThongKeDiemThi> pLstKQ)
        {
            List<String> data = new List<String>();
            data.Add(pTenMonHoc);
            data.Add(pPhongThi);
            data.Add(pHocKy);
            data.Add(pNienKhoa);
            data.Add(pNgayThi);

            Reports<ThongKeDiemThi>.export(pLstKQ, "KetQuaPhongThi", "ThongKeDiemThi_PhongThi", data);
        }
        public List<string> getPhongThis(string pNgayThi)
        {
            return new ThongKeDiemDAL().getPhongThis(pNgayThi);
        }
        public List<ThongKeDiemThi> getThongTinDiems_phongThi(string pMaMonHoc, string pPhongThi, string pNienKhoa, string pHocKy, string pNgayThi)
        {
            return new ThongKeDiemDAL().getThongTinDiems_phongThi(pMaMonHoc, pPhongThi, pNienKhoa, pHocKy, pNgayThi);
        }
    }
}

