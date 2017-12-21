using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsCaLamViec_DTO
  {
    /*
     *ma_ca_lam char(5)
     *ten_ca nvarchar(20)
     *thoi_gian_bat_dau time(7)
     *thoi_gian_ket_thuc time(7)
     *trang_thai bit
     * 
     */

    private string _MaCaLamViec;

    public string MaCaLamViec
    {
      get { return _MaCaLamViec; }
      set { _MaCaLamViec = value; }
    }
    private string _TenCaLamViec;

    public string TenCaLamViec
    {
      get { return _TenCaLamViec; }
      set { _TenCaLamViec = value; }
    }
    private DateTime _ThoiGianBatDau;

    public DateTime ThoiGianBatDau
    {
      get { return _ThoiGianBatDau; }
      set { _ThoiGianBatDau = value; }
    }
    private DateTime _ThoiGianKetThuc;

    public DateTime ThoiGianKetThuc
    {
      get { return _ThoiGianKetThuc; }
      set { _ThoiGianKetThuc = value; }
    }
    private bool _TrangThai;

    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }

  }
}
