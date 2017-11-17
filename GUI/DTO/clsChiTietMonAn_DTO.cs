using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietMonAn_DTO
    {
        private string _MaMonAn;

        public string MaMonAn
        {
            get { return _MaMonAn; }
            set { _MaMonAn = value; }
        }
        private string _MaKichThuoc;

        public string MaKichThuoc
        {
            get { return _MaKichThuoc; }
            set { _MaKichThuoc = value; }
        }
        private float _GiaBan;

        public float GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
