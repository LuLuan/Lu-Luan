using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsTrangThaiBanPhanCong_DTO
  {
    /* ma_trang_thai_bpc int
     * ten_trang_thai nvarchar(50)
    */

    private int _MaTrangThaiBanPhanCong;

    public int MaTrangThaiBanPhanCong
    {
      get { return _MaTrangThaiBanPhanCong; }
      set { _MaTrangThaiBanPhanCong = value; }
    }

    private string _TenTrangThaiBanPhanCong;

    public string TenTrangThaiBanPhanCong
    {
      get { return _TenTrangThaiBanPhanCong; }
      set { _TenTrangThaiBanPhanCong = value; }
    }
  }
}
