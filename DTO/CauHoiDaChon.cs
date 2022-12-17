using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

using System.Globalization;

using DTO;
namespace DTO
{
    public class CauHoiDaChon
    {
        private string _cauHoi1, _MucDo;
        private int _chuong;
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public string CauHoi
        {
            get
            {
                return _cauHoi1;
            }
            set
            {
                _cauHoi1 = value;
            }
        }
      
        public Int32 Chuong
        {
            get
            {
                return _chuong;
            }
            set
            {
                _chuong = value;
            }
        }
        public string MucDo
        {
            get
            {
                return _MucDo;
            }
            set
            {
                _MucDo = value;
            }
        }
        //public List<CauHoiDaChon> GetListCauHoiChuong()
        //{

        //    return
        //         db.CauHois
        //           .Select(pt => new CauHoiDaChon
        //           {
        //               CauHoi = pt.CauHoi1,
                      
        //               MucDo = pt.MucDo,
        //           });
        //}
    }
}
