using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsKichThuocMonAn_DTO
    {
        private string _MaKichThuoc;

        public string MaKichThuoc
        {
            get { return _MaKichThuoc; }
            set { _MaKichThuoc = value; }
        }
        private string _TenKichThuoc;

        public string TenKichThuoc
        {
            get { return _TenKichThuoc; }
            set { _TenKichThuoc = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
