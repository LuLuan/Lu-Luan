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
            //(ma_hoa_don_ban, ma_nhan_vien, ngay_lap_hoa_don, tong_tien, tien_dua, tien_thoi, giao_hang, ma_khach_hang, trang_thai)
            string temp = HoaDonBan.NgayLapHoaDon.ToString("MM-dd-yyyy hh:mm:ss");
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            //string query = string.Format("INSERT INTO HoaDonBan VALUES (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", HoaDonBan.MaHoaDon, HoaDonBan.MaNhanVien, temp, HoaDonBan.TongTien, HoaDonBan.TienDua, HoaDonBan.TienThoi, HoaDonBan.GiaoHang, HoaDonBan.MaKhachHang, HoaDonBan.TrangThai);
            string query = "INSERT INTO HoaDonBan VALUES(@ma_hoa_don_ban, @ma_nhan_vien,@ngay_lap_hoa_don, @tong_tien, @tien_dua, @tien_thoi, @VAT, @giao_hang, @ma_khach_hang, @trang_thai)";
            //, @ngay_lap_hoa_don
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            cmd.Parameters.AddWithValue("@ma_hoa_don_ban", HoaDonBan.MaHoaDon);
            cmd.Parameters.AddWithValue("@ma_nhan_vien", HoaDonBan.MaNhanVien);
            cmd.Parameters.AddWithValue("@ngay_lap_hoa_don", temp);
            cmd.Parameters.AddWithValue("@tong_tien", HoaDonBan.TongTien);
            cmd.Parameters.AddWithValue("@tien_dua",HoaDonBan.TienDua);
            cmd.Parameters.AddWithValue("@tien_thoi", HoaDonBan.TienThoi);
            cmd.Parameters.AddWithValue("@VAT", HoaDonBan.VAT);
            cmd.Parameters.AddWithValue("@giao_hang", HoaDonBan.GiaoHang);
            cmd.Parameters.AddWithValue("@ma_khach_hang", HoaDonBan.MaKhachHang);
            cmd.Parameters.AddWithValue("@trang_thai", HoaDonBan.TrangThai);
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
