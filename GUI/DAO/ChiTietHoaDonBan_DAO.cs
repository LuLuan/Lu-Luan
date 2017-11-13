using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietHoaDonBan_DAO
    {
        public static bool AddChiTietHoaDonBan(clsChiTietHoaDonBan_DTO ChiTietHoaDonBan)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO ChiTietHoaDonBan VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", ChiTietHoaDonBan.MaHoaDonBan, ChiTietHoaDonBan.MaMonAn, ChiTietHoaDonBan.DonGia, ChiTietHoaDonBan.SoLuong, ChiTietHoaDonBan.GiamGia, ChiTietHoaDonBan.ThanhTien);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }
    }
}
