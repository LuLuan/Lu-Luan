using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTaiKhoan_DTO
    {
        private string _MaDangNhap;

        public string MaDangNhap
        {
            get { return _MaDangNhap; }
            set { _MaDangNhap = value; }
        }

        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }


        private DateTime _NgayTao;

        public DateTime NgayTao
        {
            get { return _NgayTao; }
            set { _NgayTao = value; }
        }


        private string _MaQuyenDangNhap;

        public string MaQuyenDangNhap
        {
            get { return _MaQuyenDangNhap; }
            set { _MaQuyenDangNhap = value; }
        }


        private string _MaKhanCap;

        public string MaKhanCap
        {
            get { return _MaKhanCap; }
            set { _MaKhanCap = value; }
        }


        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
