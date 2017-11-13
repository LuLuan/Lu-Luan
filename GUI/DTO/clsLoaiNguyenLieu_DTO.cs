using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiNguyenLieu_DTO
    {
        /*
         * ma_loai_nguyen_lieu -char(6)
         * ten_loai_nguyen_lieu -nvarchar(150)
         * trang_thai           -bit
         */
        private string _MaLoaiNguyenLieu;

        public string MaLoaiNguyenLieu
        {
            get { return _MaLoaiNguyenLieu; }
            set { _MaLoaiNguyenLieu = value; }
        }
        private string _TenLoaiNguyenLieu;

        public string TenLoaiNguyenLieu
        {
            get { return _TenLoaiNguyenLieu; }
            set { _TenLoaiNguyenLieu = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
