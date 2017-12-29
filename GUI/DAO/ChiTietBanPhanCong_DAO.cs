using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace DAO
{
  public class ChiTietBanPhanCong_DAO
  {

    public bool ThemChiTietPhanCong(clsChiTietBanPhanCong_DTO chiTietBanPhanCong)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "INSERT INTO ChiTietBanPhanCong VALUES(@ma_ban_ghi, @ma_nhan_vien, @ma_ca_lam_viec, @ngay_lam_viec, @nhan_vien_tao, @ngay_them, @co_mat, @nghi_co_phep, @trang_thai)";

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      cmd.Parameters.AddWithValue("@ma_ban_ghi", chiTietBanPhanCong.MaBanGhi);
      cmd.Parameters.AddWithValue("@ma_nhan_vien", chiTietBanPhanCong.MaNhanVien);
      cmd.Parameters.AddWithValue("@ma_ca_lam_viec", chiTietBanPhanCong.MaCaLamViec);
      cmd.Parameters.AddWithValue("@ngay_lam_viec", chiTietBanPhanCong.NgayLamViec.ToString("MM-dd-yyyy"));
      cmd.Parameters.AddWithValue("@nhan_vien_tao", chiTietBanPhanCong.NhanVienTao);
      cmd.Parameters.AddWithValue("@ngay_them", chiTietBanPhanCong.NgayThem.ToString("yyyy-MM-dd"));
      cmd.Parameters.AddWithValue("@co_mat", chiTietBanPhanCong.CoMat);
      cmd.Parameters.AddWithValue("@nghi_co_phep", chiTietBanPhanCong.NghiCoPhep);
      cmd.Parameters.AddWithValue("@trang_thai", chiTietBanPhanCong.TrangThai);

      return (cmd.ExecuteNonQuery() > 0);
    }


    public string LayMaTuDong()
    {
      return ThaoTacDuLieu_DAO.ExecuteScalar("SELECT COUNT(*) FROM ChiTietBanPhanCong").ToString();
    }

    public List<clsChiTietBanPhanCong_DTO> LayLichLamViec(string maNV, DateTime dtFrom, DateTime dtTo)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM ChiTietBanPhanCong WHERE trang_thai != 6 AND ma_nhan_vien = @ma_nhan_vien AND ngay_lam_viec >= @ngay_lam_viec_tu AND ngay_lam_viec <= @ngay_lam_viec_den ORDER BY ngay_lam_viec DESC, ma_ca_lam_viec";

      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      cmd.Parameters.AddWithValue("@ma_nhan_vien",maNV);
      cmd.Parameters.AddWithValue("@ngay_lam_viec_tu", dtFrom.ToString("yyyy-MM-dd"));
      cmd.Parameters.AddWithValue("@ngay_lam_viec_den", dtTo.ToString("yyyy-MM-dd"));

      List<clsChiTietBanPhanCong_DTO> lstCTBPC = new List<clsChiTietBanPhanCong_DTO>();
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        clsChiTietBanPhanCong_DTO CTBPC = new clsChiTietBanPhanCong_DTO();
        if (!reader.IsDBNull(0))
          CTBPC.MaBanGhi = (string)reader["ma_ban_ghi"];
        if (!reader.IsDBNull(1))
          CTBPC.MaNhanVien = (string)reader["ma_nhan_vien"];
        if (!reader.IsDBNull(2))
          CTBPC.MaCaLamViec = (string)reader["ma_ca_lam_viec"];
        if (!reader.IsDBNull(3))
          CTBPC.NgayLamViec = (DateTime)reader["ngay_lam_viec"];
        if (!reader.IsDBNull(4))
          CTBPC.NhanVienTao = (string)reader["nhan_vien_tao"];
        if (!reader.IsDBNull(5))
          CTBPC.NgayThem = (DateTime)reader["ngay_them"];
        if (!reader.IsDBNull(6))
          CTBPC.CoMat = (Boolean)reader["co_mat"];
        if (!reader.IsDBNull(7))
          CTBPC.NghiCoPhep = (Boolean)reader["nghi_co_phep"];
        if (!reader.IsDBNull(8))
          CTBPC.TrangThai = (int)reader["trang_thai"];

        lstCTBPC.Add(CTBPC);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstCTBPC;

    }


    // urcDanhSachPhanCong
    public List<clsChiTietBanPhanCong_DTO> LayDSPCTheoNgayVaCa(DateTime ngay, string ca, string loaiNgay)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = "SELECT * FROM ChiTietBanPhanCong WHERE trang_thai != 6";
      if (loaiNgay == "ngayThem")
        query += " AND ngay_them = CONVERT(date, @ngay)";
      else if (loaiNgay == "ngayLam")
        query += " AND ngay_lam_viec = CONVERT(date, @ngay)";
      if (ca != "")
        query += " AND ma_ca_lam_viec = @ca";
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);

      cmd.Parameters.AddWithValue("@ngay", ngay);
      if (ca != "")
        cmd.Parameters.AddWithValue("@ca", ca);

      List<clsChiTietBanPhanCong_DTO> lstCTBPC = new List<clsChiTietBanPhanCong_DTO>();
      SqlDataReader reader = cmd.ExecuteReader();
      while(reader.Read())
      {
        clsChiTietBanPhanCong_DTO CTBPC = new clsChiTietBanPhanCong_DTO();
        if (!reader.IsDBNull(0))
          CTBPC.MaBanGhi = (string)reader["ma_ban_ghi"];
        if (!reader.IsDBNull(1))
          CTBPC.MaNhanVien = (string)reader["ma_nhan_vien"];
        if (!reader.IsDBNull(2))
          CTBPC.MaCaLamViec = (string)reader["ma_ca_lam_viec"];
        if (!reader.IsDBNull(3))
          CTBPC.NgayLamViec = (DateTime)reader["ngay_lam_viec"];
        if (!reader.IsDBNull(4))
          CTBPC.NhanVienTao = (string)reader["nhan_vien_tao"];
        if (!reader.IsDBNull(5))
          CTBPC.NgayThem = (DateTime)reader["ngay_them"];
        if (!reader.IsDBNull(6))
          CTBPC.CoMat = (Boolean)reader["co_mat"];
        if (!reader.IsDBNull(7))
          CTBPC.NghiCoPhep = (Boolean)reader["nghi_co_phep"];
        if (!reader.IsDBNull(8))
          CTBPC.TrangThai = (int)reader["trang_thai"];

        lstCTBPC.Add(CTBPC);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return lstCTBPC;
    }

    public bool Update(string maBanGhi, int trangThai)
    {
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("UPDATE ChiTietBanPhanCong SET trang_thai = {0} WHERE ma_ban_ghi = '{1}'", trangThai, maBanGhi);
      SqlCommand cmd = new SqlCommand(query, con);

      return (cmd.ExecuteNonQuery() > 0);
    }
    

  }
}
