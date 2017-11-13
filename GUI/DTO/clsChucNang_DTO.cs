using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChucNang_DTO
    {
        private string _MaChucNang;

        public string MaChucNang
        {
            get { return _MaChucNang; }
            set { _MaChucNang = value; }
        }
        private string _TenChucNang;

        public string TenChucNang
        {
            get { return _TenChucNang; }
            set { _TenChucNang = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

    }
}
