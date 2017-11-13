using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTrangThaiNV_DTO
    {
        private int _MaTrangThaiNV;

        public int MaTrangThaiNV
        {
            get { return _MaTrangThaiNV; }
            set { _MaTrangThaiNV = value; }
        }
        private string _TenTrangThaiNV;

        public string TenTrangThaiNV
        {
            get { return _TenTrangThaiNV; }
            set { _TenTrangThaiNV = value; }
        }
    }
}
