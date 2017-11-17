using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucNang_BUS
    {
        public static List<clsChucNang_DTO> LayChucNangTheoMaNhanVien(string maNhanVien)
        {
            //ChucNang_DAO dao = new ChucNang_DAO();
            return DAO.ChucNang_DAO.LayChucNangTheoMaNhanVien(maNhanVien);
        }
    }
}
