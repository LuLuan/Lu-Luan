using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
  public partial class frmPhieuHoaDon : Form
  {
    public frmPhieuHoaDon()
    {
      InitializeComponent();
    }
    public delegate void TatHoaDon(bool isCLose);
    public TatHoaDon tathoadon;
    List<clsCuaHang_DTO> lstCuaHang = BUS.CuaHang_BUS.LaydsCuaHang();
    private void frmPhieuHoaDon_Load(object sender, EventArgs e)
    {
      

      DataTable dt = urcBanHang.dt;
      //  MessageBox.Show(dt.Rows.Count.ToString());
      rptChiTietHoaDon.LocalReport.ReportEmbeddedResource = "GUI.rptPhieuHoaDon.rdlc";
      rptChiTietHoaDon.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsChiTietHoaDonBan", dt));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramTenCH", lstCuaHang[0].TenCuaHang, false));
      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramMaHoaDon", urcThanhToan.MaHD, false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramDiaChiCH", lstCuaHang[0].DiaChi, false));
      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramPassWifi", lstCuaHang[0].Passwifi, false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramTenNhanVien", FrmMain.TenNhanVien, false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramSoDienThoaiCH", lstCuaHang[0].SoDienThoai, false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramTongTien", String.Format("{0:C0}", float.Parse( urcBanHang.tongtien.ToString())), false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramTienMat", String.Format("{0:C0}", float.Parse(urcThanhToan.tienmat)), false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramTienTraLai", String.Format("{0:C0}", float.Parse( urcThanhToan.tientralai)), false));

      this.rptChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paramVAT", String.Format("{0:C0}", float.Parse(urcThanhToan.VAT)), false));

      this.rptChiTietHoaDon.RefreshReport();
    }

    private void btnHoanTat_Click(object sender, EventArgs e)
    {
      if (tathoadon != null)
      {
        tathoadon(true);
      }
    }
  }
}
