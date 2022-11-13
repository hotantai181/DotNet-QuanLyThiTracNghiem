using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDiemThi
    {
        private String _hoTen;
        private double? _diem;
        private String _mssv;
        private String _ngSinh;
        private String _lop;
        private String _stt;

        public ThongKeDiemThi()
        {

        }

        public double? Diem { get => _diem; set => _diem = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string Mssv { get => _mssv; set => _mssv = value; }
        public string NgSinh { get => _ngSinh; set => _ngSinh = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public string Stt { get => _stt; set => _stt = value; }
    }
}
