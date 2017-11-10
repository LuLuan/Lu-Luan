using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public  class ChiTietMonAn_BUS
    {
       public static List<clsChiTietMonAn_DTO> DSChiTietMonAn()
       {
           return DAO.MonAn_DAO.LayDSChiTietMonAn();
       }
    }
}
