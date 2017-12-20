using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
  public class ThaoTacDuLieu_DAO
  {

    //Huy
    private static string strCon = @"Data Source=MAYTINH-NN58F7H\SQLEXPRESS;Initial Catalog=QLCHTraSuaVaDoAnVat;Integrated Security=True";
    //Luân
    //private static string strCon = @"Data Source=LUAN\SQLEXPRESS;Initial Catalog=QLCHTraSuaVaDoAnVat;Integrated Security=True";
    public static SqlConnection TaoKetNoi()
    {
      SqlConnection con = new SqlConnection(strCon);
      con.Open();
      return con;
    }

    public static SqlCommand TruyVan(string Query, SqlConnection con)
    {
      SqlCommand cmd = new SqlCommand(Query, con);
      return cmd;
    }
    public static void DongKetNoi(SqlConnection con)
    {
      con.Close();
    }

    public static List<clsNhanVien_DTO> LayDanhSachNhanVien(string query, SqlConnection con)
    {
      List<clsNhanVien_DTO> lstNV = new List<clsNhanVien_DTO>();
      SqlCommand cmd = TruyVan(query, con);
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        clsNhanVien_DTO nhanVien = new clsNhanVien_DTO();
        if (!reader.IsDBNull(0))
          nhanVien.MaNhanVien = reader[0].ToString();
        if (!reader.IsDBNull(1))
          nhanVien.HoTen = reader[1].ToString();
        if (!reader.IsDBNull(2))
          nhanVien.AnhNhanVien = reader[2].ToString();
        if (!reader.IsDBNull(3))
          nhanVien.NgaySinh = (DateTime)reader[3];
        if (!reader.IsDBNull(4))
          nhanVien.GioiTinh = (bool)reader[4];
        if (!reader.IsDBNull(5))
          nhanVien.DiaChi = reader[5].ToString();
        if (!reader.IsDBNull(6))
          nhanVien.SoDienThoai = reader[6].ToString();
        if (!reader.IsDBNull(7))
          nhanVien.NgayBatDauLam = (DateTime)reader[7];
        if (!reader.IsDBNull(8))
          nhanVien.NgayThoiViec = (DateTime)reader[8];
        if (!reader.IsDBNull(9))
          nhanVien.MaChucVu = reader[9].ToString();
        if (!reader.IsDBNull(10))
          nhanVien.MaNguoiQuanLy = reader[10].ToString();
        if (!reader.IsDBNull(11))
          nhanVien.TrangThai = (int)reader[11];

        lstNV.Add(nhanVien);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);

      return lstNV;
    }


    public static object ExecuteScalar(string query)
    {
      SqlConnection con = TaoKetNoi();
      SqlCommand cmd = TruyVan(query, con);
      return cmd.ExecuteScalar();
    }

    public static bool ExecuteNonQuery(string query)
    {
      SqlConnection con = TaoKetNoi();
      SqlCommand cmd = TruyVan(query, con);
      return (cmd.ExecuteNonQuery() > 0);
    }


  }
}
