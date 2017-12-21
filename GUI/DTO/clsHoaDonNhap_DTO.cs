using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHoaDonNhap_DTO
    {
        //ma_hoa_don_nhap
        //    ma_nhan_vien
        //    ngay_tao_hoa_don    
        //    tong_tien_phai_tra
        //    trang_thai
        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        private string _MaNhanVien;

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        private DateTime _NgayTaoHoaDon;

        public DateTime NgayTaoHoaDon
        {
            get { return _NgayTaoHoaDon; }
            set { _NgayTaoHoaDon = value; }
        }
        private float _TongTien;

        public float TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
