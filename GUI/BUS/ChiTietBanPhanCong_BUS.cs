using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
  public class ChiTietBanPhanCong_BUS
  {
    public bool ThemChiTietPhanCong(clsChiTietBanPhanCong_DTO chiTietBanPhanCong)
    {
      ChiTietBanPhanCong_DAO dao = new ChiTietBanPhanCong_DAO();
      return dao.ThemChiTietPhanCong(chiTietBanPhanCong);
    }

    public string LayMaTuDong()
    {
      ChiTietBanPhanCong_DAO dao = new ChiTietBanPhanCong_DAO();
      int number = int.Parse(dao.LayMaTuDong()) + 1;
      string ma = "CTBPC" + number;
      while (ma.Length < 10)
      {
        ma = ma.Insert(5, "0");
      }
      return ma;
    }

  }
}
