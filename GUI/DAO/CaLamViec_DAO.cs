using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class CaLamViec_DAO
  {


    public List<clsCaLamViec_DTO> LayDanhSachCaLamViec()
    {
      List<clsCaLamViec_DTO> lstCa = new List<clsCaLamViec_DTO>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM CaLamViec";
      SqlCommand cmd = new SqlCommand(query, con);
      SqlDataReader reader = cmd.ExecuteReader();

      while(reader.Read())
      {
        clsCaLamViec_DTO ca = new clsCaLamViec_DTO();

        if (!reader.IsDBNull(0))
          ca.MaCaLamViec = (string)reader["ma_ca_lam"];
        if (!reader.IsDBNull(1))
          ca.TenCaLamViec = (string)reader["ten_ca"];
        if (!reader.IsDBNull(2))
          ca.ThoiGianBatDau = DateTime.Parse(reader["thoi_gian_bat_dau"].ToString());
        if (!reader.IsDBNull(3))
          ca.ThoiGianKetThuc = DateTime.Parse(reader["thoi_gian_ket_thuc"].ToString());
        if (!reader.IsDBNull(4))
          ca.TrangThai = (bool)reader["trang_thai"];

        lstCa.Add(ca);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstCa;
    }

  }
}
