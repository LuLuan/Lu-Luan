﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
  public class NhanVien_BUS
  {
    public static List<clsNhanVien_DTO> LayNhanVienTheoMa(string maNhanVien)
    {
      NhanVien_DAO dao = new NhanVien_DAO();
      return dao.LayNhanVienTheoMa(maNhanVien);
    }

    public List<clsNhanVien_DTO> TimKiemNhanVien(string hoTen, string maChucVu, int gioiTinh, int trangThai)
    {
      NhanVien_DAO dao = new NhanVien_DAO();
      return dao.TimKiemNhanVien(hoTen, maChucVu, gioiTinh, trangThai);
    }

    public string LayMaNhanVien()
    {
      NhanVien_DAO dao = new NhanVien_DAO();
      int number = int.Parse(dao.LayMaNhanVien()) + 1;
      string maNV;
      if (number < 10)
        maNV = "N0000" + number;
      else if (number >= 10 && number < 100)
        maNV = "N000" + number;
      else if (number >= 100 && number < 1000)
        maNV = "N00" + number;
      else if (number >= 1000 && number < 10000)
        maNV = "N0" + number;
      else maNV = "N" + number;

      return maNV;

    }

    public bool ThaoTacVoiDoiTuongNhanVien(clsNhanVien_DTO nhanVien, string command)
    {
      NhanVien_DAO dao = new NhanVien_DAO();
      return dao.ThaoTacVoiDoiTuongNhanVien(nhanVien, command);
    }

    //public void ThemNhanVienVoid(clsNhanVien_DTO nhanVien)
    //{
    //  NhanVien_DAO dao = new NhanVien_DAO();
    //  dao.ThemNhanVienVoid(nhanVien);
    //}





  }
}
