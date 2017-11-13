using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietHoaDonBan_DTO
    {
        /*
         * ma_hoa_don_ban --char(10);
         * ma_mon_an-char(5);
         * don_gia-float
         * so_luong-float
         * giam_gia-float
         * thanh_tien-float
         * */
        private string _MaHoaDonBan;

        public string MaHoaDonBan
        {
            get { return _MaHoaDonBan; }
            set { _MaHoaDonBan = value; }
        }
        private string _MaMonAn;

        public string MaMonAn
        {
            get { return _MaMonAn; }
            set { _MaMonAn = value; }
        }
        private float _DonGia;

        public float DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private float _SoLuong;

        public float SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private float _GiamGia;

        public float GiamGia
        {
            get { return _GiamGia; }
            set { _GiamGia = value; }
        }
        private float _ThanhTien;

        public float ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
        
    }
}
