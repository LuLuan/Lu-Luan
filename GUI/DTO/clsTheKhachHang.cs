using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTheKhachHang
    {
        private string _MaThe;
        public string MaThe
        {
            get { return _MaThe; }
            set { _MaThe = value; }
        }

        private string _MaKhachHang;
        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }

        private string _MaLoaiThe;
        public string MaLoaiThe
        {
            get { return _MaLoaiThe; }
            set { _MaLoaiThe = value; }
        }

        private DateTime _NgayDangKy;
        public DateTime NgayDangKy
        {
            get { return _NgayDangKy; }
            set { _NgayDangKy = value; }
        }

        private bool _TrangThai;
        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
