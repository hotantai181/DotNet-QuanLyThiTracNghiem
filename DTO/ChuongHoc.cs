using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongHoc
    {
        private string _tenChuong;
        private int _maChuong;

        public string TenChuong
        {
            get
            {
                var splChuong = _tenChuong.Split(' ');

                return string.Format("{0} {1}", splChuong[0], splChuong[1]);
            }
            set => _tenChuong = value;
        }

        public int MaChuong
        {
            get => _maChuong;
            set => _maChuong = value;
        }
    }
}
