using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TrangThaiNV_BUS
    {
        public List<clsTrangThaiNV_DTO> LayDanhSachTrangThaiNhanVien()
        {
            TrangThaiNV_DAO dao = new TrangThaiNV_DAO();
            return dao.LayDSTrangThaiNhanVien();
        }
    }
}
