using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
  public class HoaDonNhap_BUS
  {
    public static bool AddHoaDonNhap(clsHoaDonNhap_DTO HoaDonNhap)
    {
      return DAO.HoaDonNhap_DAO.AddHoaDonNhap(HoaDonNhap);
    }
    public static int SoLuongHoaDonNhap()
    {
      return DAO.HoaDonNhap_DAO.SoLuongHoaDonNhap();
    }

    public static List<clsHoaDonNhap_DTO> LayDanhSachHoaDonNhap(string From, string To)
    {
      return DAO.HoaDonNhap_DAO.LayDanhSachHoaDonNhap(From, To);
    }
  }
}
