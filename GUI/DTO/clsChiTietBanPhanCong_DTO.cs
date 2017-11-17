using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class clsChiTietBanPhanCong_DTO
  {


    /*
     * 
     * ma_ban_ghi char(10)
     * ma_nhan_vien char(6)
     * ma_ca_lam_viec char(5)
     * ngay_lam_viec datetime
     * nhan_vien_tao char6
     * ngay_them Datetime
     * 
     * 
     * co_mat bit
     * nghi_co_phep bit
     * trang_thai bit
     */


    private string _MaBanGhi;

    public string MaBanGhi
    {
      get { return _MaBanGhi; }
      set { _MaBanGhi = value; }
    }
    
    private string _MaNhanVien;

    public string MaNhanVien
    {
      get { return _MaNhanVien; }
      set { _MaNhanVien = value; }
    }

    private string _MaCaLamViec;

    public string MaCaLamViec
    {
      get { return _MaCaLamViec; }
      set { _MaCaLamViec = value; }
    }


    private DateTime _NgayLamViec;

    public DateTime NgayLamViec
    {
      get { return _NgayLamViec; }
      set { _NgayLamViec = value; }
    }


    private string _NhanVienTao;

    public string NhanVienTao
    {
      get { return _NhanVienTao; }
      set { _NhanVienTao = value; }
    }

    private DateTime _NgayThem;

    public DateTime NgayThem
    {
      get { return _NgayThem; }
      set { _NgayThem = value; }
    }



    private bool _CoMat;

    public bool CoMat
    {
      get { return _CoMat; }
      set { _CoMat = value; }
    }

    private bool _NghiCoPhep;

    public bool NghiCoPhep
    {
      get { return _NghiCoPhep; }
      set { _NghiCoPhep = value; }
    }

    private bool _TrangThai;

    public bool TrangThai
    {
      get { return _TrangThai; }
      set { _TrangThai = value; }
    }



  }
}
