using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
  public class TaiKhoan_DAO
  {
    public static bool KiemTraDangNhap_DAO(string TaiKhoan, string MatKhau)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string Query = string.Format("select count(*) from TaiKhoan where ma_dang_nhap ='{0}' and mat_khau='{1}'", TaiKhoan, MatKhau);
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(Query, con);
      int KiemTra = (int)cmd.ExecuteScalar();
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      if (KiemTra == 1)
        return true;
      return false;
    }

    public List<clsTaiKhoan_DTO> LayDanhSachTaiKhoan(string hoTenNV)
    {
      List<clsTaiKhoan_DTO> lstTaiKhoan = new List<clsTaiKhoan_DTO>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("SELECT ma_dang_nhap, mat_khau, ngay_tao, ma_quyen_dang_nhap, ma_khan_cap, trang_thai FROM TaiKhoan, NhanVien WHERE TaiKhoan.ma_dang_nhap = NhanVien.ma_nhan_vien AND NhanVien.ma_trang_thai_nhan_vien != 4 AND ho_ten LIKE N'%{0}%'", hoTenNV);
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader reader = cmd.ExecuteReader();

      while (reader.Read())
      {
        clsTaiKhoan_DTO taiKhoan = new clsTaiKhoan_DTO();
        if (!reader.IsDBNull(0))
          taiKhoan.MaDangNhap = (string)reader[0];
        if (!reader.IsDBNull(1))
          taiKhoan.MatKhau = (string)reader[1];
        if (!reader.IsDBNull(2))
          taiKhoan.NgayTao = (DateTime)reader[2];
        if (!reader.IsDBNull(3))
          taiKhoan.MaQuyenDangNhap = (string)reader[3];
        if (!reader.IsDBNull(4))
          taiKhoan.MaKhanCap = (string)reader[4];
        if (!reader.IsDBNull(5))
          taiKhoan.TrangThai = (bool)reader[5];

        lstTaiKhoan.Add(taiKhoan);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstTaiKhoan;
    }

    #region THÊM - XÓA - SỬA

    //public bool ThemTaiKhoan(clsTaiKhoan_DTO taiKhoan)
    //{
    //  SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
    //  string query = "INSERT INTO TaiKhoan(ma_dang_nhap, mat_khau, ngay_tao, ma_quyen_dang_nhap, ma_khan_cap, trang_thai)"
    //    +" VALUES(@ma_dang_nhap, @mat_khau, @ngay_tao, @ma_quyen_dang_nhap, @ma_khan_cap, @trang_thai)";
      
    //  SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
    //  cmd.Parameters.AddWithValue("@ma_dang_nhap", taiKhoan.MaDangNhap);
    //  cmd.Parameters.AddWithValue("@mat_khau", taiKhoan.MatKhau);
    //  cmd.Parameters.AddWithValue("@ngay_tao", taiKhoan.NgayTao);
    //  cmd.Parameters.AddWithValue("@ma_quyen_dang_nhap", taiKhoan.MaQuyenDangNhap);
    //  cmd.Parameters.AddWithValue("@ma_khan_cap", taiKhoan.MaKhanCap);
    //  cmd.Parameters.AddWithValue("@trang_thai", taiKhoan.TrangThai);

    //  //ThaoTacDuLieu_DAO.DongKetNoi(con);
    //  return (cmd.ExecuteNonQuery() > 0);
    //}

    public bool ThaoTacVoiTaiKhoan(clsTaiKhoan_DTO TK, string command)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";
      if (command == "Add")
      {
        query = "INSERT INTO TaiKhoan(ma_dang_nhap, mat_khau, ngay_tao, ma_quyen_dang_nhap, ma_khan_cap, trang_thai)"
        + " VALUES(@ma_dang_nhap, @mat_khau, @ngay_tao, @ma_quyen_dang_nhap, @ma_khan_cap, @trang_thai)";
      }
      else if (command == "Update")
        query = "UPDATE TaiKhoan SET mat_khau = @mat_khau, ngay_tao = @ngay_tao, ma_quyen_dang_nhap = @ma_quyen_dang_nhap, ma_khan_cap = @ma_khan_cap, trang_thai = @trang_thai WHERE ma_dang_nhap = @ma_dang_nhap";
      else if (command == "Delete")
        query = string.Format("UPDATE TaiKhoan SET trang_thai = {0} WHERE ma_dang_nhap = '{1}'", TK.TrangThai, TK.MaDangNhap);

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      if (command == "Add" || command == "Update")
      {
        cmd.Parameters.AddWithValue("@ma_dang_nhap", TK.MaDangNhap);
        cmd.Parameters.AddWithValue("@mat_khau", TK.MatKhau);
        cmd.Parameters.AddWithValue("@ngay_tao", TK.NgayTao);
        cmd.Parameters.AddWithValue("@ma_quyen_dang_nhap", TK.MaQuyenDangNhap);
        cmd.Parameters.AddWithValue("@ma_khan_cap", TK.MaKhanCap);
        cmd.Parameters.AddWithValue("@trang_thai", TK.TrangThai);
      }
      return (cmd.ExecuteNonQuery() > 0);
    }

    #endregion

    public bool XoaTaiKhoanKhiXoaNhanVien(string maNV)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("UPDATE TaiKhoan SET trang_thai = 'false' WHERE ma_dang_nhap = '{0}'", maNV);
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      return (cmd.ExecuteNonQuery() > 0);
    }

  }
}
