using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CuaHang_DAO
    {

        public static bool UpdateCuaHang(clsCuaHang_DTO CH) //xóa món ăn
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE CuaHang Set ten_cua_hang = N'{0}', dia_chi = N'{1}', so_dien_thoai = N'{2}', passwifi = N'{3}', giay_phep_kinh_doanh = N'{4}' where ma_cua_hang = N'{5}' ", CH.TenCuaHang, CH.DiaChi, CH.SoDienThoai, CH.Passwifi, CH.GiayPhepKinhDoanh, CH.MaCuaHang);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }



        public static List<clsCuaHang_DTO> LaydsCuaHang()
        {
            List<clsCuaHang_DTO> dsCuaHang = new List<clsCuaHang_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("select * from CuaHang");
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsCuaHang_DTO itemCuaHangTinh = new clsCuaHang_DTO();
                if (!rddtMA.IsDBNull(0))
                    itemCuaHangTinh.MaCuaHang = (string)rddtMA[0];

                if (!rddtMA.IsDBNull(1))
                    itemCuaHangTinh.TenCuaHang = (string)rddtMA[1];

                if (!rddtMA.IsDBNull(2))
                    itemCuaHangTinh.Logo = (string)rddtMA[2];

                if (!rddtMA.IsDBNull(3))
                    itemCuaHangTinh.DiaChi = (string)rddtMA[3];

                if (!rddtMA.IsDBNull(4))
                    itemCuaHangTinh.SoDienThoai = (string)rddtMA[4];

                if (!rddtMA.IsDBNull(5))
                    itemCuaHangTinh.Passwifi = (string)rddtMA[5];

                if (!rddtMA.IsDBNull(6))
                    itemCuaHangTinh.GiayPhepKinhDoanh = (string)rddtMA[6];

                if (!rddtMA.IsDBNull(7))
                    itemCuaHangTinh.TrangThai = (bool)rddtMA[7];

                //
                dsCuaHang.Add(itemCuaHangTinh);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsCuaHang;
        }
    }
}
