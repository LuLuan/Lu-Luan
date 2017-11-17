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
      cmd.Parameters.AddWithValue("@ngay_lam_viec", chiTietBanPhanCong.NgayLamViec);
      cmd.Parameters.AddWithValue("@nhan_vien_tao", chiTietBanPhanCong.NhanVienTao);
      cmd.Parameters.AddWithValue("@ngay_them", chiTietBanPhanCong.NgayThem);
      cmd.Parameters.AddWithValue("@co_mat", chiTietBanPhanCong.CoMat);
      cmd.Parameters.AddWithValue("@co_mat", chiTietBanPhanCong.NghiCoPhep);
      cmd.Parameters.AddWithValue("@trang_thai", chiTietBanPhanCong.TrangThai);

      return (cmd.ExecuteNonQuery() > 0);
    }


    public string LayMaTuDong()
    {
      return ThaoTacDuLieu_DAO.ExecuteScalar("SELECT COUNT(*) FROM ChiTietBanPhanCong").ToString();
    }

  }
}
