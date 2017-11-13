using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
   public  class LoaiMonAn_DAO
    {
       public static List<clsLoaiMonAn_DTO> LaydsLoaiMonAn()
       {
           List<clsLoaiMonAn_DTO> dsLoaiMonAn = new List<clsLoaiMonAn_DTO>();

           SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
           string query = string.Format("select * from LoaiMonAn");
           SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
           SqlDataReader rddtMA = cmd.ExecuteReader();
           while (rddtMA.Read())
           {
               clsLoaiMonAn_DTO itemLoaiMonAn = new clsLoaiMonAn_DTO();
               if (!rddtMA.IsDBNull(0))
               itemLoaiMonAn.MaLoaiMonAn = (string)rddtMA[0];
               if (!rddtMA.IsDBNull(2))
               itemLoaiMonAn.TenLoaiMonAn = (string)rddtMA[2];
               if (!rddtMA.IsDBNull(1))
               itemLoaiMonAn.MaNhomMonAn = (string)rddtMA[1];

               //
               dsLoaiMonAn.Add(itemLoaiMonAn);
           }
           ThaoTacDuLieu_DAO.DongKetNoi(con);
           return dsLoaiMonAn;
       }

    }
}
