using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhanVien_DTO
    {
        private string _MaNhanVien;

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _AnhNhanVien;


        public string AnhNhanVien
        {
            get { return _AnhNhanVien; }
            set { _AnhNhanVien = value; }
        }
        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private bool _GioiTinh;

        public bool GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
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
        private DateTime _NgayBatDauLam;

        public DateTime NgayBatDauLam
        {
            get { return _NgayBatDauLam; }
            set { _NgayBatDauLam = value; }
        }
        private DateTime? _NgayThoiViec;

        public DateTime? NgayThoiViec
        {
            get { return _NgayThoiViec; }
            set { _NgayThoiViec = value; }
        }
        private string _MaChucVu;

        public string MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        private string _MaNguoiQuanLy;

        public string MaNguoiQuanLy
        {
            get { return _MaNguoiQuanLy; }
            set { _MaNguoiQuanLy = value; }
        }
        private int _TrangThai;

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
