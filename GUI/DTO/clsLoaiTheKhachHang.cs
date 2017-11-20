using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  /*
   * ma_loai_the char 10
   * ten_loai_the_khach_hang nvarchar 30
   * giam_gia float
   * don_vi_giam_gia nvarchar 20
   * trang_thai bit
   */
  public class clsLoaiTheKhachHang
  {
    private string _MaLoaiThe;
    public string MaLoaiThe
    {
      get { return _MaLoaiThe; }
      set { _MaLoaiThe = value; }
    }

    private string _TenLoaiTheKH;
    public string TenLoaiTheKH
    {
      get { return _TenLoaiTheKH; }
      set { _TenLoaiTheKH = value; }
    }

    

    private float _GiamGia;
    public float GiamGia
    {
      get { return _GiamGia; }
      set { _GiamGia = value; }
    }

    private string _DonViGiamGia;
    public string DonViGiamGia
    {
      get { return _DonViGiamGia; }
      set { _DonViGiamGia = value; }
    }


    private bool _TrangThai;
    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }
  }
}
