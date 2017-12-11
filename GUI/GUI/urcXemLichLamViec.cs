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

    private void urcXemLichLamViec_Load(object sender, EventArgs e)
    {

    }

    private void HienThiLichLamViec()
    {
      ChiTietBanPhanCong_BUS bus = new ChiTietBanPhanCong_BUS();

      string keyword = txtTimKiem.Text;
      DateTime dtFrom = DateTime.MinValue;
      DateTime dtTo = DateTime.MinValue;

      if(chbDateFrom.Checked)
      { 
        dtFrom = dtpFrom.Value;
        dtTo = dtpTo.Value;
      }
      List<clsChiTietBanPhanCong_DTO> lstLichLamViec = bus.LayLichLamViec(keyword, dtFrom, dtTo);
      dgvLichLamViec.AutoGenerateColumns = false;
      dgvLichLamViec.DataSource = lstLichLamViec;
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      HienThiLichLamViec();
    }

    private void dgvLichLamViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if(dgvLichLamViec.Columns[e.ColumnIndex].Name == "colHoTen")
      {
        List<clsNhanVien_DTO> lstNV = BUS.NhanVien_BUS.LayNhanVienTheoMa("");
        clsNhanVien_DTO dtoNV = lstNV.First(u=> u.MaNhanVien == e.Value.ToString());
        e.Value = dtoNV.HoTen;
      }
    }

    
  }
}
