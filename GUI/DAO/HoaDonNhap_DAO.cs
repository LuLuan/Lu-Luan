﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAO
{
  public class HoaDonNhap_DAO
  {
    public static bool AddHoaDonNhap(clsHoaDonNhap_DTO HoaDonNhap)
    {
      //(ma_hoa_don_ban, ma_nhan_vien, ngay_lap_hoa_don, tong_tien, tien_dua, tien_thoi, giao_hang, ma_khach_hang, trang_thai)
      string temp = HoaDonNhap.NgayTaoHoaDon.ToString("MM-dd-yyyy hh:mm:ss");
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      //string query = string.Format("INSERT INTO HoaDonNhap VALUES (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", HoaDonNhap.MaHoaDon, HoaDonNhap.MaNhanVien, temp, HoaDonNhap.TongTien, HoaDonNhap.TienDua, HoaDonNhap.TienThoi, HoaDonNhap.GiaoHang, HoaDonNhap.MaKhachHang, HoaDonNhap.TrangThai);
      string query = "INSERT INTO HoaDonNhap VALUES(@ma_hoa_don_nhap, @ma_nhan_vien,@ngay_tao_hoa_don, @tong_tien_phai_tra, @trang_thai)";
      //, @ngay_lap_hoa_don
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      cmd.Parameters.AddWithValue("@ma_hoa_don_nhap", HoaDonNhap.MaHoaDon);
      cmd.Parameters.AddWithValue("@ma_nhan_vien", HoaDonNhap.MaNhanVien);
      cmd.Parameters.AddWithValue("@ngay_tao_hoa_don", temp);
      cmd.Parameters.AddWithValue("@tong_tien_phai_tra", HoaDonNhap.TongTien);
      cmd.Parameters.AddWithValue("@trang_thai", HoaDonNhap.TrangThai);
      int ketqua = cmd.ExecuteNonQuery();
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return (ketqua == 1) ? true : false;
    }

    public static int SoLuongHoaDonNhap()
    {
      string query = string.Format("select count(*) from HoaDonNhap ");
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      int TongSP = int.Parse(cmd.ExecuteScalar().ToString());
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return TongSP;
    }




    public static List<clsHoaDonNhap_DTO> LayDanhSachHoaDonNhap(string From, string To)
    {
      List<clsHoaDonNhap_DTO> lstHD = new List<clsHoaDonNhap_DTO>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM HoaDonNhap";
      if (From != "" && To != "")
      {
        query += " where ngay_tao_hoa_don >= @from and ngay_tao_hoa_don <= @to ";
      }

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      if (From != "" && To != "")
      {
        cmd.Parameters.AddWithValue("@from", DateTime.Parse(From).ToString("MM-dd-yyyy hh:mm:ss"));
        cmd.Parameters.AddWithValue("@to", DateTime.Parse(To).ToString("MM-dd-yyyy hh:mm:ss"));
      }

      SqlDataReader reader = cmd.ExecuteReader();

      while (reader.Read())
      {
        clsHoaDonNhap_DTO HD = new clsHoaDonNhap_DTO();

        if (!reader.IsDBNull(0))
          HD.MaHoaDon = (string)reader["ma_hoa_don_nhap"];
        if (!reader.IsDBNull(1))
          HD.MaNhanVien = (string)reader["ma_nhan_vien"];
        if (!reader.IsDBNull(2))
          HD.NgayTaoHoaDon = (DateTime)reader["ngay_tao_hoa_don"];
        if (!reader.IsDBNull(3))
          HD.TongTien = (float)(double)reader["tong_tien_phai_tra"];
        if (!reader.IsDBNull(4))
          HD.TrangThai = (bool)reader["trang_thai"];

        lstHD.Add(HD);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstHD;

    }






  }
}
