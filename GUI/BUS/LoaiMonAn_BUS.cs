using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
  public   class LoaiMonAn_BUS
    {

        public static List<clsLoaiMonAn_DTO> DSLoaiMonAn()
        {
            return DAO.LoaiMonAn_DAO.LaydsLoaiMonAn();
        }

    }
}
