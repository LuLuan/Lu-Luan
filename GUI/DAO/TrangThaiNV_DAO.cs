using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class TrangThaiNV_DAO
    {
        public List<clsTrangThaiNV_DTO> LayDSTrangThaiNhanVien()
        {
            List<clsTrangThaiNV_DTO> dsTrangThaiNV = new List<clsTrangThaiNV_DTO>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string cauTruyVan = "SELECT * FROM TrangThaiNhanVien";
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(cauTruyVan, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                clsTrangThaiNV_DTO trangThaiNV = new clsTrangThaiNV_DTO();
                if (!reader.IsDBNull(0))
                    trangThaiNV.MaTrangThaiNV = (int)reader[0];
                if (!reader.IsDBNull(1))
                    trangThaiNV.TenTrangThaiNV = (string)reader[1];
                
                dsTrangThaiNV.Add(trangThaiNV);
            }

            return dsTrangThaiNV;
        }
    }
}
