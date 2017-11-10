using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiMonAn_DTO
    {
        private string _MaLoaiMonAn;

        public string MaLoaiMonAn
        {
            get { return _MaLoaiMonAn; }
            set { _MaLoaiMonAn = value; }
        }
        private string _MaNhomMonAn;

        public string MaNhomMonAn
        {
            get { return _MaNhomMonAn; }
            set { _MaNhomMonAn = value; }
        }
        private string _TenLoaiMonAn;

        public string TenLoaiMonAn
        {
            get { return _TenLoaiMonAn; }
            set { _TenLoaiMonAn = value; }
        }
    }
}
