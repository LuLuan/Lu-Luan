using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsThanhPhanMonAn_DTO
    {
        //    ma_mon_an        str
        //    ma_nguyen_lieu   str
        //    so_luong         char
        //    don_vi           str
        private string _MaMonAn;

        public string MaMonAn
        {
            get { return _MaMonAn; }
            set { _MaMonAn = value; }
        }
        private string _MaNguyenLieu;

        public string MaNguyenLieu
        {
            get { return _MaNguyenLieu; }
            set { _MaNguyenLieu = value; }
        }
        private float _SoLuong;

        public float SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _DonVi;

        public string DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
        }

            

    }
}
