using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class TrangThaiBanPhanCong_DAO
  {
    public List<clsTrangThaiBanPhanCong_DTO> LayDSTrangThaiBPC()
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM TrangThaiBanPhanCong";
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      SqlDataReader reader = cmd.ExecuteReader();

      List<clsTrangThaiBanPhanCong_DTO> listTTBPC = new List<clsTrangThaiBanPhanCong_DTO>();
      while(reader.Read())
      {
        clsTrangThaiBanPhanCong_DTO TTBPC = new clsTrangThaiBanPhanCong_DTO();
        if (!reader.IsDBNull(0))
          TTBPC.MaTrangThaiBanPhanCong = (int)reader[0];
        if (!reader.IsDBNull(1))
          TTBPC.TenTrangThaiBanPhanCong = (string)reader[1];

        listTTBPC.Add(TTBPC);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return listTTBPC;
    }
  }
}
