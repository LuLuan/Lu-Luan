using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsHoaDonBan
  {
    /*
     * ma_hoa_don_ban --char(10)
     * ma_nhan_vien-char(6)
     * ngay_lap_hoa_don-datetime
     * tong_tien-float
     * tien_dua-float
     * tien_thoi-float
     * VAT float
     * giao_hang-bit
     * ma_khach_hang-char(6)
     * trang_thai-bit
     * 
     * */
    private string _MaHoaDon;

    public string MaHoaDon
    {
      get { return _MaHoaDon; }
      set { _MaHoaDon = value; }
    }
    private string _MaNhanVien;

    public string MaNhanVien
    {
      get { return _MaNhanVien; }
      set { _MaNhanVien = value; }
    }
    private DateTime _NgayLapHoaDon;

    public DateTime NgayLapHoaDon
    {
      get { return _NgayLapHoaDon; }
      set { _NgayLapHoaDon = value; }
    }
    private float _TongTien;

    public float TongTien
    {
      get { return _TongTien; }
      set { _TongTien = value; }
    }
    private float _TienDua;

    public float TienDua
    {
      get { return _TienDua; }
      set { _TienDua = value; }
    }
    private float _TienThoi;

    public float TienThoi
    {
      get { return _TienThoi; }
      set { _TienThoi = value; }
    }

    private float _VAT;

    public float VAT
    {
      get { return _VAT; }
      set { _VAT = value; }
    }

    private bool _GiaoHang;

    public bool GiaoHang
    {
      get { return _GiaoHang; }
      set { _GiaoHang = value; }
    }
    private string _MaKhachHang;

    public string MaKhachHang
    {
      get { return _MaKhachHang; }
      set { _MaKhachHang = value; }
    }
    private bool _TrangThai;

    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }
  }
}
