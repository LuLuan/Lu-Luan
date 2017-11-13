using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KichThuocMonAn_BUS
    {
        public static List<clsKichThuocMonAn_DTO> DSKichThuoc()
        {
            return DAO.KichThuocMonAn_DAO.LaydsKichThuoc();
        }
    }
}
