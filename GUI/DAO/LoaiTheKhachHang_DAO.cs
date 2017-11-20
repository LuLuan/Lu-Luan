using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class LoaiTheKhachHang_DAO
  {
    public List<clsLoaiTheKhachHang> LayLoaiTheKhachHang()
    {
      List<clsLoaiTheKhachHang> lstLoaiTheKH = new List<clsLoaiTheKhachHang>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM LoaiTheKhachHang";

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader reader = cmd.ExecuteReader();

      while (reader.Read())
      {
        clsLoaiTheKhachHang loaiTheKH = new clsLoaiTheKhachHang();
        if (!reader.IsDBNull(0))
          loaiTheKH.MaLoaiThe = (string)reader[0];

        if (!reader.IsDBNull(1))
          loaiTheKH.TenLoaiTheKH = (string)reader[1];

        if (!reader.IsDBNull(2))
          loaiTheKH.GiamGia = (float)(double)reader[2];

        if (!reader.IsDBNull(3))
          loaiTheKH.DonViGiamGia = (string)reader[3];

        if (!reader.IsDBNull(4))
          loaiTheKH.TrangThai = (bool)reader[4];

        lstLoaiTheKH.Add(loaiTheKH);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstLoaiTheKH;
    }
  }
}
