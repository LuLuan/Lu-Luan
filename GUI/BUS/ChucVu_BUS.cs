using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVu_BUS
    {
        public List<clsChucVu_DTO> LayDanhSachChucVu()
        {
            ChucVu_DAO dao = new ChucVu_DAO();
            return dao.LayDanhSachChucVu();
        }
    }
}
