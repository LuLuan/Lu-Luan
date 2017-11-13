using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsQuyenDangNhap_DTO
  {
    private string _MaQuyenDangNhap;

    public string MaQuyenDangNhap
    {
      get { return _MaQuyenDangNhap; }
      set { _MaQuyenDangNhap = value; }
    }

    private string _TenQuyenDangNhap;

    public string TenQuyenDangNhap
    {
      get { return _TenQuyenDangNhap; }
      set { _TenQuyenDangNhap = value; }
    }

    private bool _TrangThai;

    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }
  }
}
