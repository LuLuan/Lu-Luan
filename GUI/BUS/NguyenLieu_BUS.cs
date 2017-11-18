using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class NguyenLieu_BUS
    {
       public static List<clsNguyenLieu_DTO> DSNguyenLieu(string ChuoiTimKiem)
       {
           return DAO.NguyenLieu_DAO.LaydsNguyenLieu(ChuoiTimKiem);
       }
       public static bool InsertNguyenLieu(clsNguyenLieu_DTO NguyenLieu)
       {
           return DAO.NguyenLieu_DAO.InsertNguyenLieu(NguyenLieu);
       }
          public static bool UpdateNguyenLieu(clsNguyenLieu_DTO NguyenLieu)
       {
           return DAO.NguyenLieu_DAO.UpdateNguyenLieu(NguyenLieu);
       }
    }
}
