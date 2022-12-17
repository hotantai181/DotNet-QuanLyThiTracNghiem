using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSTaoDT : PhieuTaoDe
    {
        private Int64 _soCauHoi;
        private string _ma;

        public Int64 SoCauHoi
        {
            get
            {
                return _soCauHoi;
            }
            set
            {
                _soCauHoi = value;
            }
        }
        public string Ma
        {
            get
            {
                return _ma;
            }
            set
            {
                _ma = value;
            }
        }
    }
}
