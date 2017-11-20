using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsCuaHang_DTO
  {
    /*
     * ma_cua_hang char 10
     * ten_cua_hang nvarchar(50)
     * dia_chi nvarchar(200)
     * so_dien_thoai char(15)
     * giay_phep_kinh_doanh nvarchar(20)
     * trang_thai bit
     * 
     * 
     
     */
    private string _Passwifi;

    public string Passwifi
    {
      get { return _Passwifi; }
      set { _Passwifi = value; }
    }

    private string _MaCuaHang;

    public string MaCuaHang
    {
      get { return _MaCuaHang; }
      set { _MaCuaHang = value; }
    }
    private string _TenCuaHang;

    public string TenCuaHang
    {
      get { return _TenCuaHang; }
      set { _TenCuaHang = value; }
    }


    private string _Logo;

    public string Logo
    {
      get { return _Logo; }
      set { _Logo = value; }
    }

    private string _DiaChi;

    public string DiaChi
    {
      get { return _DiaChi; }
      set { _DiaChi = value; }
    }
    private string _SoDienThoai;

    public string SoDienThoai
    {
      get { return _SoDienThoai; }
      set { _SoDienThoai = value; }
    }
    private string _GiayPhepKinhDoanh;

    public string GiayPhepKinhDoanh
    {
      get { return _GiayPhepKinhDoanh; }
      set { _GiayPhepKinhDoanh = value; }
    }
    private bool _TrangThai;

    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }



  }
}
