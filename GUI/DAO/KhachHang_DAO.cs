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

      while (reader.Read())
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


    public string LayMaKhachHang()
    {
      string query = "SELECT COUNT(*) FROM KhachHang";
      return ThaoTacDuLieu_DAO.ExecuteScalar(query).ToString();
    }


    #region Thêm Xóa Sửa Khách Hàng:

    public bool ThaoTacVoiKhachHang(clsKhachHang_DTO KH, string command)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";

      if (command == "Add")
        query = "INSERT INTO KhachHang (ma_khach_hang, ten_khach_hang, gioi_tinh, ngay_sinh, so_dien_thoai, dia_chi, trang_thai) VALUES (@ma, @ten, @gioiTinh, @ngaySinh, @sdt, @diaChi, @trangThai)";
      else if (command == "Update")
        query = "UPDATE KhachHang SET ten_khach_hang = @ten, gioi_tinh = @gioiTinh, ngay_sinh = @ngaySinh, so_dien_thoai = @sdt, dia_chi = @diaChi, trang_thai = @trangThai WHERE ma_khach_hang = @ma";
      //else if (command == "Delete")
      //  query += string.Format("UPDATE KhachHang SET trang_thai = {0} WHERE ma_khach_hang = '{1}'", KH.TrangThai, KH.MaKhachHang);

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      if(command == "Add" || command == "Update")
      {
        cmd.Parameters.AddWithValue("@ma", KH.MaKhachHang);
        cmd.Parameters.AddWithValue("@ten", KH.TenKhachHang);
        cmd.Parameters.AddWithValue("@gioiTinh", KH.GioiTinh);
        cmd.Parameters.AddWithValue("@ngaySinh", KH.NgaySinh);
        cmd.Parameters.AddWithValue("@sdt", KH.SoDienThoai);
        cmd.Parameters.AddWithValue("@diaChi", KH.DiaChi);
        cmd.Parameters.AddWithValue("@trangThai", KH.TrangThai);
      }


      return (cmd.ExecuteNonQuery() > 0);
    }

    #endregion


  }
}
