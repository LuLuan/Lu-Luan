using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public partial class frmHoaDonNhap : Form
  {
    public frmHoaDonNhap()
    {
      InitializeComponent();
    }

    private void frmHoaDonNhap_Load(object sender, EventArgs e)
    {
      string maNhanVien = urcDangNhap.maNhanVien;
      
      DataTable dt = urcDanhSachNguyenLieu.dt;
      rptHoaDonNhap.LocalReport.ReportEmbeddedResource = "GUI.rptHoaDonNhap.rdlc";
      rptHoaDonNhap.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsHoaDonNhap", dt));

      //rptHoaDonNhap.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramMaNhanVien", maNhanVien));

      this.rptHoaDonNhap.RefreshReport();
    }

    private void rptHoaDonNhap_Load(object sender, EventArgs e)
    {

    }
  }
}
