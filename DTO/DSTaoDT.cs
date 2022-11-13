using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSTaoDT : ChuongHoc
    {
        private int? _soCauHoi;
        private int? _ma;

        public int? SoCauHoi
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
        public int? Ma
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
