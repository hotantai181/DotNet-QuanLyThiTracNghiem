using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoiDT 
    {
        private string _cauHoi1, _dapAnA, _dapAnB, _dapAnC,_dapAnD, _dapAnDung,_MucDo;
        private int _maCauHoi;
        public int MaCauHoi
        {
            get
            {
                return _maCauHoi;
            }
            set
            {
                _maCauHoi = value;
            }
        }
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
        public string DapAnA
        {
            get
            {
                return _dapAnA;
            }
            set
            {
                _dapAnA = value;
            }
        }
        public string DapAnB
        {
            get
            {
                return _dapAnB;
            }
            set
            {
                _dapAnB = value;
            }
        }
        public string DapAnC
        {
            get
            {
                return _dapAnC;
            }
            set
            {
                _dapAnC = value;
            }
        }
        public string DapAnD
        {
            get
            {
                return _dapAnD;
            }
            set
            {
                _dapAnD = value;
            }
        }
        public string DapAnDung
        {
            get
            {
                return _dapAnDung;
            }
            set
            {
                _dapAnDung = value;
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
    }
}
