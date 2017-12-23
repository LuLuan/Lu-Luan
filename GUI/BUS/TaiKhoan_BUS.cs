using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
  public class TaiKhoan_BUS
  {
    public static bool KiemTraDangNhap_BUS(string TaiKhoan, string MatKhau)
    {
      return DAO.TaiKhoan_DAO.KiemTraDangNhap_DAO(TaiKhoan, MatKhau);
    }

    public static bool DoiMatKhau(string maDangNhap, string matKhauMoi)
    {
      return DAO.TaiKhoan_DAO.DoiMatKhau(maDangNhap, matKhauMoi);
    }

    public List<clsTaiKhoan_DTO> LayDanhSachTaiKhoan(string hoTenNV)
    {
      TaiKhoan_DAO dao = new TaiKhoan_DAO();
      return dao.LayDanhSachTaiKhoan(hoTenNV);
    }


    public bool ThaoTacVoiTaiKhoan(clsTaiKhoan_DTO TK, string command)
    {
      TaiKhoan_DAO dao = new TaiKhoan_DAO();
      return dao.ThaoTacVoiTaiKhoan(TK, command);
    }

    public bool XoaTaiKhoanKhiXoaNhanVien(string maNV)
    {
      TaiKhoan_DAO dao = new TaiKhoan_DAO();
      return dao.XoaTaiKhoanKhiXoaNhanVien(maNV);
    }

  }
}
