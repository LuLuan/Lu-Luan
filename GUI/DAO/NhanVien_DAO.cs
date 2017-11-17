using System;
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
      return ThaoTacDuLieu_DAO.LayDanhSachNhanVien(query, con);
    }

    public List<clsNhanVien_DTO> LayDanhSachNhanVienCoChonLoc(string hoTen, string maChucVu, int gioiTinh, int trangThai, int trangThai2)
    {
      List<clsNhanVien_DTO> lstNhanVien = new List<clsNhanVien_DTO>();

      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("SELECT * FROM NhanVien WHERE ho_ten LIKE N'%{0}%' AND ma_chuc_vu LIKE '%{1}%'", hoTen, maChucVu);
      if (gioiTinh == 0 || gioiTinh == 1)
        query += string.Format(" AND gioi_tinh = {0}", gioiTinh);
      if (trangThai == 1 || trangThai == 2 || trangThai == 3 || trangThai == 4)
        query += string.Format(" AND ma_trang_thai_nhan_vien = {0}", trangThai);
      if (trangThai2 != -1)
        query += string.Format(" AND ma_trang_thai_nhan_vien = {0} OR ma_trang_thai_nhan_vien = {1}", trangThai, trangThai2);

      return ThaoTacDuLieu_DAO.LayDanhSachNhanVien(query, con);
    }
    



    public string LayMaNhanVien()
    {
      //SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT COUNT(*) FROM NhanVien";
      //SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      //string maNV = cmd.ExecuteScalar().ToString();
      return ThaoTacDuLieu_DAO.ExecuteScalar(query).ToString();
    }

    public List<clsNhanVien_DTO> LayNhanVienTheoTenHoacMaa(string ten, string ma)
    {
      List<clsNhanVien_DTO> lstNhanVien = new List<clsNhanVien_DTO>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("select * from NhanVien where ho_ten LIKE N'%{0}%' OR ma_nhan_vien ='{1}' ", ten, ma);
      return ThaoTacDuLieu_DAO.LayDanhSachNhanVien(query, con);
    }






    #region THÊM - XÓA - SỬA

    public bool ThaoTacVoiDoiTuongNhanVien(clsNhanVien_DTO nhanVien, string command)
    {
      //ngay_thoi_viec = @ngay_thoi_viec,
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";
      if (command == "Add")
        query = "INSERT INTO NhanVien(ma_nhan_vien, ho_ten, anh_nhan_vien, ngay_sinh, gioi_tinh, dia_chi, so_dien_thoai, ngay_bat_dau_lam, ngay_thoi_viec, ma_chuc_vu, ma_trang_thai_nhan_vien)"
        + " VALUES(@ma_nhan_vien, @ho_ten, @anh_nhan_vien, @ngay_sinh, @gioi_tinh, @dia_chi, @so_dien_thoai, @ngay_bat_dau_lam, @ngay_thoi_viec, @ma_chuc_vu, @ma_trang_thai_nhan_vien)";

      else if (command == "Update")
        query = "UPDATE NhanVien SET"
          + " ho_ten = @ho_ten, anh_nhan_vien = @anh_nhan_vien, ngay_sinh = @ngay_sinh, gioi_tinh = @gioi_tinh, dia_chi = @dia_chi, so_dien_thoai = @so_dien_thoai, ngay_bat_dau_lam = @ngay_bat_dau_lam, ngay_thoi_viec = @ngay_thoi_viec, ma_chuc_vu = @ma_chuc_vu, ma_trang_thai_nhan_vien = @ma_trang_thai_nhan_vien"
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
        if (nhanVien.NgayThoiViec == null)
          cmd.Parameters.AddWithValue("@ngay_thoi_viec", DBNull.Value);
        else cmd.Parameters.AddWithValue("@ngay_thoi_viec", nhanVien.NgayThoiViec);
        cmd.Parameters.AddWithValue("@ma_chuc_vu", nhanVien.MaChucVu);
        cmd.Parameters.AddWithValue("@ma_trang_thai_nhan_vien", nhanVien.TrangThai);
      }

      return (cmd.ExecuteNonQuery() > 0);
    }

    #endregion








  }
}
