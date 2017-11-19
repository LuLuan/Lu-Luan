using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhaCungCap_DTO
    {
        /*
         * ma_nha_cung_cap -char(6)
         * ten_nha_cung_cap -nvarchar(30)
         * dia_chi -nvarchar(30)
         * so_dien_thoai -varchar(15)
         * trang_thai -bit
         */
        private string _MaNhaCungCap;

        public string MaNhaCungCap
        {
            get { return _MaNhaCungCap; }
            set { _MaNhaCungCap = value; }
        }
        private string _TenNhaCungCap;

        public string TenNhaCungCap
        {
            get { return _TenNhaCungCap; }
            set { _TenNhaCungCap = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _SoDienThoai;

        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
