using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace BUS
{
  public class HoaDonBan_BUS
  {
    public static bool AddHoaDonBan(clsHoaDonBan HoaDonBan)
    {
      return DAO.HoaDonBan_DAO.AddHoaDonBan(HoaDonBan);
    }
    //đếm sl hóa đơn bán
    public static int SoLuongHoaDonBan()
    {
      return DAO.HoaDonBan_DAO.SoLuongHoaDonBan();
    }

    public static List<clsHoaDonBan> LayDanhSachHoaDon(string From, string To)
    {
      return DAO.HoaDonBan_DAO.LayDanhSachHoaDon(From,To);
    }
  }
}
