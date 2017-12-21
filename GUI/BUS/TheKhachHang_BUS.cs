using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
  public class TheKhachHang_BUS
  {
    public List<clsTheKhachHang> LayDanhSachTheKH(string maThe, string tenKH)
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      return dao.LayDanhSachTheKHH(maThe, tenKH);
    }

    public string LayTenKhacHangQuaMaThe(string maThe)
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      return dao.LayTenKhacHangQuaMaThe(maThe);
    }


    public string LayMaTheKhachHang()
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      int number = int.Parse(dao.LayMaTheKhachHang()) + 1;
      int length = 10;
      string str = "";
      for (int i = 0; i < length - number.ToString().Length; i++ )
      {
        str += "0";
      } 
      return (str += number.ToString());
    }

    public bool ThaoTacVoiDoiTuongTheKhachHang(clsTheKhachHang TKH, string command)
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      return dao.ThaoTacVoiDoiTuongTheKhachHang(TKH, command);
    }

    public bool KiemTraKhachHangDaCoThe(string maKH)
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      return dao.KiemTraKhachHangDaCoThe(maKH); 

    }

    public bool Xoa(string maKH)
    {
      TheKhachHang_DAO dao = new TheKhachHang_DAO();
      return dao.Xoa(maKH);
    }




  }
}
