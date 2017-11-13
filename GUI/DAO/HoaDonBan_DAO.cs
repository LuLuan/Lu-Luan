using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class HoaDonBan_DAO
    {
        public static bool AddHoaDonBan(clsHoaDonBan HoaDonBan)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO HoaDonBan(ma_hoa_don_ban, ma_nhan_vien, ngay_lap_hoa_don, tong_tien, tien_dua,tien_thoi,giao_hang,ma_khach_hang,trang_thai) VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", HoaDonBan.MaHoaDon, HoaDonBan.MaNhanVien, HoaDonBan.NgayLapHoaDon, HoaDonBan.TongTien, HoaDonBan.TienDua, HoaDonBan.TienThoi, HoaDonBan.GiaoHang, HoaDonBan.MaKhachHang, HoaDonBan.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }
        public static int SoLuongHoaDonBan()
        {
            string query = string.Format("select count(*) from HoaDonBan ");
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int TongSP = int.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return TongSP;
        }


    }
}
