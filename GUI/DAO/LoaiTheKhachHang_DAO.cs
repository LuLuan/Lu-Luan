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

            while(reader.Read())
            {
                clsLoaiTheKhachHang loaiTheKH = new clsLoaiTheKhachHang();
                if (!reader.IsDBNull(0))
                    loaiTheKH.MaLoaiThe = (string)reader[0];

                if (!reader.IsDBNull(1))
                    loaiTheKH.TenTheKH = (string)reader[1];

                if (!reader.IsDBNull(2))
                    loaiTheKH.HanSuDung = (int)reader[2];

                if (!reader.IsDBNull(3))
                    loaiTheKH.DonViHSD = (string)reader[3];

                if (!reader.IsDBNull(4))
                    loaiTheKH.PhanTramGiamGia = (float)(double)reader[4];

                if (!reader.IsDBNull(5))
                    loaiTheKH.TrangThai = (bool)reader[5];

                lstLoaiTheKH.Add(loaiTheKH);
            }

            return lstLoaiTheKH;
        }
    }
}
