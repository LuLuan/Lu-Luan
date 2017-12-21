using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
  public class CaLamViec_BUS
  {
    public static List<clsCaLamViec_DTO> LayDanhSachCaLamViec()
    {
      CaLamViec_DAO dao = new CaLamViec_DAO();
      return dao.LayDanhSachCaLamViec();
    }
  }
}
