using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class KhachHang_DAO
    {
        public List<clsKhachHang_DTO> LayDanhSachKhachHang(string hoTen, int trangThai)
        {
            List<clsKhachHang_DTO> lstKH = new List<clsKhachHang_DTO>();
            SqlConnection conn = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("SELECT * FROM KhachHang WHERE ten_khach_hang LIKE N'%{0}%'", hoTen);
            if (trangThai != -1)
                query += string.Format(" AND trang_thai = {0}", trangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                clsKhachHang_DTO KH = new clsKhachHang_DTO();
                if (!reader.IsDBNull(0))
                    KH.MaKhachHang = (string)reader[0];
                if (!reader.IsDBNull(1))
                    KH.TenKhachHang = (string)reader[1];
                if (!reader.IsDBNull(2))
                    KH.GioiTinh = (bool)reader[2];
                if (!reader.IsDBNull(3))
                    KH.NgaySinh = (DateTime)reader[3];
                if (!reader.IsDBNull(4))
                    KH.Email = (string)reader[4];
                if (!reader.IsDBNull(5))
                    KH.SoDienThoai = (string)reader[5];
                if (!reader.IsDBNull(6))
                    KH.DiaChi = (string)reader[6];
                if (!reader.IsDBNull(7))
                    KH.TrangThai = (bool)reader[7];

                lstKH.Add(KH);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(conn);
            return lstKH;
        }
    }
}
