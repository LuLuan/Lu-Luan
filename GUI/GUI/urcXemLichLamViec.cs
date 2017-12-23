using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
  public partial class urcXemLichLamViec : UserControl
  {
    public urcXemLichLamViec()
    {
      InitializeComponent();
    }

    public void urcXemLichLamViec_Load(object sender, EventArgs e)
    {

    }

    private void HienThiLichLamViec()
    {
      ChiTietBanPhanCong_BUS bus = new ChiTietBanPhanCong_BUS();

      string keyword = txtTimKiem.Text;
      DateTime dtFrom = dtpFrom.Value;
      DateTime dtTo = dtpTo.Value;
      List<clsChiTietBanPhanCong_DTO> lstLichLamViec = bus.LayLichLamViec(keyword, dtFrom, dtTo);
      dgvLichLamViec.AutoGenerateColumns = false;
      dgvLichLamViec.DataSource = lstLichLamViec;
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      HienThiLichLamViec();
    }

    List<clsNhanVien_DTO> lstNV = BUS.NhanVien_BUS.LayNhanVienTheoMa("");
    clsNhanVien_DTO dtoNV;

    List<clsCaLamViec_DTO> lstCa = BUS.CaLamViec_BUS.LayDanhSachCaLamViec();
    clsCaLamViec_DTO dtoCa;

    List<clsTrangThaiBanPhanCong_DTO> lstTTBanPhanCong = BUS.TrangThaiBanPhanCong_BUS.LayDSTrangThaiBPC();
    clsTrangThaiBanPhanCong_DTO dtoTTBanPhanCong;
    

    private void dgvLichLamViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvLichLamViec.Rows.Count > 0)
      {
        if (dgvLichLamViec.Columns[e.ColumnIndex].Name == "colHoTen")
        {

          dtoNV = lstNV.First(u => u.MaNhanVien == e.Value.ToString());
          e.Value = dtoNV.HoTen;
        }

        if (dgvLichLamViec.Columns[e.ColumnIndex].Name == "colCa")
        {

          dtoCa = lstCa.First(u => u.MaCaLamViec == e.Value.ToString());
          e.Value = dtoCa.TenCaLamViec;
        }

        if (dgvLichLamViec.Columns[e.ColumnIndex].Name == "colTrangThai")
        {
          dtoTTBanPhanCong = lstTTBanPhanCong.First(u=>u.MaTrangThaiBanPhanCong == (int)e.Value);
          e.Value = dtoTTBanPhanCong.TenTrangThaiBanPhanCong;
          
        }

      }
    }


  }
}
