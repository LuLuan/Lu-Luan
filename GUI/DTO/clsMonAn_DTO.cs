using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsMonAn_DTO
    {
        private string _MaMonAn;

        public string MaMonAn
        {
            get { return _MaMonAn; }
            set { _MaMonAn = value; }
        }
        private string _TenMonAn;

        public string TenMonAn
        {
            get { return _TenMonAn; }
            set { _TenMonAn = value; }
        }
        private string _AnhMonAn;

        public string AnhMonAn
        {
            get { return _AnhMonAn; }
            set { _AnhMonAn = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private string _MaLoaiMon;

        public string MaLoaiMon
        {
            get { return _MaLoaiMon; }
            set { _MaLoaiMon = value; }
        }
        private string _MaDonViTinh;

        public string MaDonViTinh
        {
            get { return _MaDonViTinh; }
            set { _MaDonViTinh = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
