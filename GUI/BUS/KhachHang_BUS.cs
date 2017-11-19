using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
  public class KhachHang_BUS
  {
    public List<clsKhachHang_DTO> LayDanhSachKhachHang(string hoTen, int trangThai)
    {
      KhachHang_DAO dao = new KhachHang_DAO();
      return dao.LayDanhSachKhachHang(hoTen, trangThai);
    }

    public string LayMaKhachHang()
    {
      KhachHang_DAO dao = new KhachHang_DAO();
      int number = int.Parse(dao.LayMaKhachHang()) + 1;
      string maKH;
      if (number < 10)
        maKH = "KH000" + number;
      else if (number >= 10 && number < 100)
        maKH = "KH00" + number;
      else if (number >= 100 && number < 1000)
        maKH = "KH0" + number;
      else maKH = "KH" + number;

      return maKH;
    }

    public bool ThaoTacVoiKhachHang(clsKhachHang_DTO KH, string command)
    {
      KhachHang_DAO dao = new KhachHang_DAO();
      return dao.ThaoTacVoiKhachHangg(KH, command);
    }

    public bool Xoa(string maKH)
    {
      KhachHang_DAO dao = new KhachHang_DAO();
      return dao.Xoa(maKH);
    }

  }
}
