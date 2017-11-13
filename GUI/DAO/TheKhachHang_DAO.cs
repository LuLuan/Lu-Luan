using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class TheKhachHang_DAO
  {
    public List<clsTheKhachHang> LayDanhSachTheKH()
    {
      List<clsTheKhachHang> lstTheKH = new List<clsTheKhachHang>();
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM TheKhachHang";

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader reader = cmd.ExecuteReader();

      while (reader.Read())
      {
        clsTheKhachHang theKH = new clsTheKhachHang();
        if (!reader.IsDBNull(0))
          theKH.MaThe = (string)reader[0];
        if (!reader.IsDBNull(1))
          theKH.MaKhachHang = (string)reader[1];
        if (!reader.IsDBNull(2))
          theKH.MaLoaiThe = (string)reader[2];
        if (!reader.IsDBNull(3))
          theKH.NgayDangKy = (DateTime)reader[3];
        if (!reader.IsDBNull(4))
          theKH.TrangThai = (bool)reader[4];

        lstTheKH.Add(theKH);
      }


      return lstTheKH;
    }



    public string LayMaTheKhachHang()
    {
      string query = "SELECT COUNT(*) FROM TheKhachHang";
      return ThaoTacDuLieu_DAO.ExecuteScalar(query).ToString();
    }

    public bool KiemTraKhachHangDaCoThe(string maKH)
    {
      string query = string.Format("SELECT COUNT(*) FROM TheKhachHang WHERE ma_khach_hang = '{0}' AND trang_thai = '{1}'", maKH, true);
      return ((int)ThaoTacDuLieu_DAO.ExecuteScalar(query) > 0);
    }

    public bool ThaoTacVoiDoiTuongTheKhachHang(clsTheKhachHang TKH, string command)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "";

      if (command == "Add")
        query = "INSERT INTO TheKhachHang(ma_the, ma_khach_hang, ma_loai_the, ngay_dang_ky, trang_thai) VALUES(@ma_the, @ma_khach_hang, @ma_loai_the, @ngay_dang_ky, @trang_thai)";
      else if (command == "Update")
        query = "UPDATE TheKhachHang SET ma_khach_hang = @ma_khach_hang, ma_loai_the = @ma_loai_the, ngay_dang_ky = @ngay_dang_ky, trang_thai = @trang_thai WHERE ma_the = @ma_the";

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      if(command == "Add" || command == "Update")
      {
        cmd.Parameters.AddWithValue("@ma_the", TKH.MaThe);
        cmd.Parameters.AddWithValue("@ma_khach_hang", TKH.MaKhachHang);
        cmd.Parameters.AddWithValue("@ma_loai_the", TKH.MaLoaiThe);
        cmd.Parameters.AddWithValue("@ngay_dang_ky", TKH.NgayDangKy);
        cmd.Parameters.AddWithValue("@trang_thai", TKH.TrangThai);

      }

      return (cmd.ExecuteNonQuery() > 0);
    }





  }
}
