using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class clsDonViTinh_DTO
    {
        private string _MaDonViTinh;

        public string MaDonViTinh
        {
            get { return _MaDonViTinh; }
            set { _MaDonViTinh = value; }
        }
        private string _TenDonViTinh;

        public string TenDonViTinh
        {
            get { return _TenDonViTinh; }
            set { _TenDonViTinh = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
