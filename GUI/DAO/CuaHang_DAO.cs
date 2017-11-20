using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class CuaHang_DAO
  {
    public static List<clsCuaHang_DTO> LaydsCuaHang()
    {
      List<clsCuaHang_DTO> dsCuaHang = new List<clsCuaHang_DTO>();

      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("select * from CuaHang");
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader rddtMA = cmd.ExecuteReader();
      while (rddtMA.Read())
      {
        clsCuaHang_DTO itemCuaHangTinh = new clsCuaHang_DTO();
        if (!rddtMA.IsDBNull(0))
          itemCuaHangTinh.MaCuaHang = (string)rddtMA[0];

        if (!rddtMA.IsDBNull(1))
          itemCuaHangTinh.TenCuaHang = (string)rddtMA[1];

        if (!rddtMA.IsDBNull(2))
          itemCuaHangTinh.Logo = (string)rddtMA[2];

        if (!rddtMA.IsDBNull(3))
          itemCuaHangTinh.DiaChi= (string)rddtMA[3];

        if (!rddtMA.IsDBNull(4))
          itemCuaHangTinh.SoDienThoai = (string)rddtMA[4];

        if (!rddtMA.IsDBNull(5))
          itemCuaHangTinh.Passwifi = (string)rddtMA[5];

        if (!rddtMA.IsDBNull(6))
          itemCuaHangTinh.GiayPhepKinhDoanh = (string)rddtMA[6];

        if (!rddtMA.IsDBNull(7))
          itemCuaHangTinh.TrangThai = (bool)rddtMA[7];

        //
        dsCuaHang.Add(itemCuaHangTinh);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return dsCuaHang;
    }
  }
}
