using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public  class MonAn_BUS
    {
       public static List<clsMonAn_DTO> DSMonAn(string ChuoiTimKiem)
       {
           return DAO.MonAn_DAO.LayDSMonAn(ChuoiTimKiem);
       }
       public static bool UpMonAn(clsMonAn_DTO MonAn)
       {
           return DAO.MonAn_DAO.UpMonAn(MonAn);
       }
       public static bool UpCTMonAn(clsChiTietMonAn_DTO CTMonAn, string MaKichThuocCu)
       {
           return DAO.MonAn_DAO.UpChiTietMonAn(CTMonAn,MaKichThuocCu);
       }
      
       
    }
}
