using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsQuyenDangNhap_DTO
    {
        //private string ma_quyen_dang_nhap;

        //public string Ma_quyen_dang_nhap
        //{
        //    get { return ma_quyen_dang_nhap; }
        //    set { ma_quyen_dang_nhap = value; }
        //}
        //private string ten_quyen_dang_nhap;

        //public string Ten_quyen_dang_nhap
        //{
        //    get { return ten_quyen_dang_nhap; }
        //    set { ten_quyen_dang_nhap = value; }
        //}
        //private bool trang_thai;

        //public bool Trang_thai
        //{
        //    get { return trang_thai; }
        //    set { trang_thai = value; }
        //}
        /// <summary>
        /// 
        /// </summary>
        private string _MaQuyenDangNhap;

        public string MaQuyenDangNhap
        {
            get { return _MaQuyenDangNhap; }
            set { _MaQuyenDangNhap = value; }
        }

        private string _TenQuyenDangNhap;

        public string TenQuyenDangNhap
        {
            get { return _TenQuyenDangNhap; }
            set { _TenQuyenDangNhap = value; }
        }

        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
