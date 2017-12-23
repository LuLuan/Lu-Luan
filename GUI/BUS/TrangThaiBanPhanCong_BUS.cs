using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
  public class TrangThaiBanPhanCong_BUS
  {
    public static List<clsTrangThaiBanPhanCong_DTO> LayDSTrangThaiBPC()
    {
      TrangThaiBanPhanCong_DAO dao = new TrangThaiBanPhanCong_DAO();
      return dao.LayDSTrangThaiBPC();
    }
    
  }
}
