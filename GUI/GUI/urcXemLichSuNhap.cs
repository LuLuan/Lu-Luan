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
  public partial class urcXemLichSuNhap : UserControl
  {
    public urcXemLichSuNhap()
    {
      InitializeComponent();
    }

    private void urcXemLichSuNhap_Load(object sender, EventArgs e)
    {
      LoadDatagridviewHoaDonNhap();
    }

    private void LoadDatagridviewHoaDonNhap()
    {
      List<clsHoaDonNhap_DTO> lstHDN = BUS.HoaDonNhap_BUS.LayDanhSachHoaDonNhap("", "");
      dgvDSHDNhap.AutoGenerateColumns = false;
      dgvDSHDNhap.DataSource = lstHDN;
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
      LoadDatagridviewHoaDonNhap();
    }
  }
}
