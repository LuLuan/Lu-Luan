using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ChucVu_DAO
    {
        public List<clsChucVu_DTO> LayDanhSachChucVu()
        {
            List<clsChucVu_DTO> dsChucVu = new List<clsChucVu_DTO>();
            
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string cauTruyVan = string.Format("SELECT * FROM ChucVu WHERE trang_thai = {0}", 1);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(cauTruyVan, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clsChucVu_DTO chucVu = new clsChucVu_DTO();
                if(!reader.IsDBNull(0))
                    chucVu.MaChucVu = (string)reader["ma_chuc_vu"];
                if (!reader.IsDBNull(1))
                    chucVu.TenChucVu = (string)reader["ten_chuc_vu"];
                if (!reader.IsDBNull(2))
                    chucVu.TrangThai = (bool)reader["trang_thai"];
                dsChucVu.Add(chucVu);
            }
            return dsChucVu;
        }
    }
}
