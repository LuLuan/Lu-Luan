using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiNguyenLieu_BUS
    {
        public static List<clsLoaiNguyenLieu_DTO> DSLoaiNguyenLieu(string ChuoiTimKiem)
        {
            return DAO.LoaiNguyenLieu_DAO.LayDSLoaiNguyenLieu(ChuoiTimKiem);
        }
        public static bool InsertLoaiNguyenLieu(clsLoaiNguyenLieu_DTO NguyenLieu)
        {
            return DAO.LoaiNguyenLieu_DAO.InsertLoaiNguyenLieu(NguyenLieu);
        }

    }
}
