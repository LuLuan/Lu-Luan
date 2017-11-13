using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiTheKhachHang
    {
        private string _MaLoaiThe;
        public string MaLoaiThe
        {
            get { return _MaLoaiThe; }
            set { _MaLoaiThe = value; }
        }

        private string _TenTheKH;
        public string TenTheKH
        {
            get { return _TenTheKH; }
            set { _TenTheKH = value; }
        }

        private int _HanSuDung;
        public int HanSuDung
        {
            get { return _HanSuDung; }
            set { _HanSuDung = value; }
        }

        private string _DonViHSD;
        public string DonViHSD
        {
            get { return _DonViHSD; }
            set { _DonViHSD = value; }
        }

        private float _PhanTramGiamGia;
        public float PhanTramGiamGia
        {
            get { return _PhanTramGiamGia; }
            set { _PhanTramGiamGia = value; }
        }

        private bool _TrangThai;
        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
