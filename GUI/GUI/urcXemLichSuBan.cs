using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
  public partial class urcXemLichSuBan : UserControl
  {
    public urcXemLichSuBan()
    {
      InitializeComponent();
    }
    List<clsHoaDonBan> lstHoaDon = BUS.HoaDonBan_BUS.LayDanhSachHoaDon("", "");
    private void urcXemLichSuBan_Load(object sender, EventArgs e)
    {
      LoadHoaDon();

      txtTongTien.Text = string.Format("{0:0,0 VNĐ}",TinhTongTienBanHang());
    }
    private void LoadHoaDon()
    {
      dgvDSHD.AutoGenerateColumns = false;
      dgvDSHD.DataSource = lstHoaDon;
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
      string from = dtFrom.Value.ToString();
      string to = dtTo.Value.ToString();
      lstHoaDon = BUS.HoaDonBan_BUS.LayDanhSachHoaDon(from, to);
      urcXemLichSuBan_Load(sender, e);


    }
    
    private float TinhTongTienBanHang()
    {
      float tongTien = 0;
      foreach (clsHoaDonBan item in lstHoaDon)
      {
        tongTien += item.TongTien;
      }

      return tongTien;
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }


  }
}
