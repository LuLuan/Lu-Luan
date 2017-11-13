using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuyenDangNhap_BUS
    {
        public static List<clsQuyenDangNhap_DTO> LayQuyenDangNhapTheoMaNV(string maNhanVien)
        {
            return DAO.QuyenDangNhap_DAO.LayQuyenDangNhapTheoMaNV(maNhanVien);
        }

        public List<clsQuyenDangNhap_DTO> LayQuyenDangNhapTheoMaQDN(string maQDN)
        {
            QuyenDangNhap_DAO dao = new QuyenDangNhap_DAO();
            return dao.LayQuyenDangNhapTheoMaQDN(maQDN);
        }
    }
}
