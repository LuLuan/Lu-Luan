using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class TheKhachHang_DAO
    {
        public List<clsTheKhachHang> LayDanhSachTheKH()
        {
            List<clsTheKhachHang> lstTheKH = new List<clsTheKhachHang>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = "SELECT * FROM TheKhachHang";

            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                clsTheKhachHang theKH = new clsTheKhachHang();
                if (!reader.IsDBNull(0))
                    theKH.MaThe = (string)reader[0];
                if (!reader.IsDBNull(1))
                    theKH.MaKhachHang = (string)reader[1];
                if (!reader.IsDBNull(2))
                    theKH.MaLoaiThe = (string)reader[2];
                if (!reader.IsDBNull(3))
                    theKH.NgayDangKy= (DateTime)reader[3];
                if (!reader.IsDBNull(4))
                    theKH.TrangThai = (bool)reader[4];

                lstTheKH.Add(theKH);
            }


            return lstTheKH;
        }
    }
}
