using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNguyenLieu_DTO
    {
        private string _MaNguyenLieu;

        public string MaNguyenLieu
        {
            get { return _MaNguyenLieu; }
            set { _MaNguyenLieu = value; }
        }
        private string _TenNguyenLieu;

        public string TenNguyenLieu
        {
            get { return _TenNguyenLieu; }
            set { _TenNguyenLieu = value; }
        }
        private float _TongSoLuong;

        public float TongSoLuong
        {
            get { return _TongSoLuong; }
            set { _TongSoLuong = value; }
        }
        private string _DonViTinh;

        public string DonViTinh
        {
            get { return _DonViTinh; }
            set { _DonViTinh = value; }
        }
        private string _MaLoaiNguyenLieu;

        public string MaLoaiNguyenLieu
        {
            get { return _MaLoaiNguyenLieu; }
            set { _MaLoaiNguyenLieu = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
