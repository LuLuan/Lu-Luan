﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
  public class NhanVien_DAO
  {

    public List<clsNhanVien_DTO> LayNhanVienTheoMa(string maNhanVien)
    {
      List<clsNhanVien_DTO> lstNhanVien = new List<clsNhanVien_DTO>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";
      if (maNhanVien != "")
        query = string.Format("select * from NhanVien where ma_nhan_vien ='{0}'", maNhanVien);
      else query = string.Format("select * from NhanVien where ma_trang_thai_nhan_vien != {0}", 4);
      //SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      return ThaoTacDuLieu_DAO.LayDanhSachNhanVien(query, con);
      //ThaoTacDuLieu_DAO.DongKetNoi(con);
      //return lstNhanVien;
    }

    public List<clsNhanVien_DTO> TimKiemNhanVien(string hoTen, string maChucVu, int gioiTinh, int trangThai)
    {
      List<clsNhanVien_DTO> lstNhanVien = new List<clsNhanVien_DTO>();

      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("SELECT * FROM NhanVien WHERE ho_ten LIKE N'%{0}%' AND ma_chuc_vu LIKE '%{1}%'", hoTen, maChucVu);
      if (gioiTinh == 0 || gioiTinh == 1)
        query += string.Format(" AND gioi_tinh = {0}", gioiTinh);
      if (trangThai == 1 || trangThai == 2 || trangThai == 3 || trangThai == 4)
        query += string.Format(" AND ma_trang_thai_nhan_vien = {0}", trangThai);

      return ThaoTacDuLieu_DAO.LayDanhSachNhanVien(query, con);
      //return lstNhanVien;
    }

    public string LayMaNhanVien()
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT COUNT(*) FROM NhanVien";
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      string maNV = cmd.ExecuteScalar().ToString();

      return maNV;
    }


    #region THÊM - XÓA - SỬA

    public bool ThaoTacVoiDoiTuongNhanVien(clsNhanVien_DTO nhanVien, string command)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";
      if (command == "Add")
        query = "INSERT INTO NhanVien(ma_nhan_vien, ho_ten, anh_nhan_vien, ngay_sinh, gioi_tinh, dia_chi, so_dien_thoai, ngay_bat_dau_lam, ma_chuc_vu, ma_trang_thai_nhan_vien)"
        + " VALUES(@ma_nhan_vien, @ho_ten, @anh_nhan_vien, @ngay_sinh, @gioi_tinh, @dia_chi, @so_dien_thoai, @ngay_bat_dau_lam, @ma_chuc_vu, @ma_trang_thai_nhan_vien)";

      else if (command == "Update")
        query = "UPDATE NhanVien SET"
          + " ho_ten = @ho_ten, anh_nhan_vien = @anh_nhan_vien, ngay_sinh = @ngay_sinh, gioi_tinh = @gioi_tinh, dia_chi = @dia_chi, so_dien_thoai = @so_dien_thoai, ngay_bat_dau_lam = @ngay_bat_dau_lam, ma_chuc_vu = @ma_chuc_vu, ma_trang_thai_nhan_vien = @ma_trang_thai_nhan_vien"
          + " WHERE ma_nhan_vien = @ma_nhan_vien";
      else if (command == "Delete")
        query = string.Format("UPDATE NhanVien SET ma_trang_thai_nhan_vien = {0} WHERE ma_nhan_vien = '{1}'", nhanVien.TrangThai, nhanVien.MaNhanVien);
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      if(command == "Add" || command == "Update")
      { 
        cmd.Parameters.AddWithValue("@ma_nhan_vien", nhanVien.MaNhanVien);
        cmd.Parameters.AddWithValue("@ho_ten", nhanVien.HoTen);
        cmd.Parameters.AddWithValue("@anh_nhan_vien", nhanVien.AnhNhanVien);
        cmd.Parameters.AddWithValue("@ngay_sinh", nhanVien.NgaySinh);
        cmd.Parameters.AddWithValue("@gioi_tinh", nhanVien.GioiTinh);
        cmd.Parameters.AddWithValue("@dia_chi", nhanVien.DiaChi);
        cmd.Parameters.AddWithValue("@so_dien_thoai", nhanVien.SoDienThoai);
        cmd.Parameters.AddWithValue("@ngay_bat_dau_lam", nhanVien.NgayBatDauLam);
        cmd.Parameters.AddWithValue("@ma_chuc_vu", nhanVien.MaChucVu);
        cmd.Parameters.AddWithValue("@ma_trang_thai_nhan_vien", nhanVien.TrangThai);
      }

      return (cmd.ExecuteNonQuery() > 0);
    }

    //public void ThemNhanVienVoid(clsNhanVien_DTO nhanVien)
    //{
    //  SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
    //  string query = "INSERT INTO NhanVien(ma_nhan_vien, ho_ten, ngay_sinh) VALUES(@ma_nhan_vien, @ho_ten, @ngay_sinh)";
    //  //return ThaoTacDuLieu_DAO.ExcuteNonQuery(query);
    //  SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

    //  cmd.Parameters.AddWithValue("@ma_nhan_vien", nhanVien.MaNhanVien);
    //  cmd.Parameters.AddWithValue("@ho_ten", nhanVien.HoTen);
    //  cmd.Parameters.AddWithValue("@ngay_sinh", nhanVien.NgaySinh);
    //  cmd.ExecuteNonQuery();
    //}

    #endregion








  }
}
