using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTaoDT
    {
        private string _maPhieu, _ngayLap, _trangThai;

        public string MaPhieu
        {
            get
            {
                return _maPhieu;
            }
            set
            {
                _maPhieu = value;
            }
        }
        public string NgayLap
        {
            get
            {
                return _ngayLap;
            }
            set
            {
                _ngayLap = value;
            }
        }
        public string TrangThai
        {
            get
            {
                return _trangThai;
            }
            set
            {
                _trangThai = value;
            }
        }
    }
}
