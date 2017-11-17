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
    public partial class frmPhieuHoaDon : Form
    {
        public frmPhieuHoaDon()
        {
            InitializeComponent();
        }
        public delegate void TatHoaDon(bool isCLose);
        public TatHoaDon tathoadon;
        private void frmPhieuHoaDon_Load(object sender, EventArgs e)
        {
           
            DataTable dt = urcBanHang.dt;
          //  MessageBox.Show(dt.Rows.Count.ToString());
            rptChiTietHoaDon.LocalReport.ReportEmbeddedResource = "GUI.rptPhieuHoaDon.rdlc";
            rptChiTietHoaDon.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsChiTietHoaDonBan", dt));
            this.rptChiTietHoaDon.RefreshReport();
            
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (tathoadon!=null)
            {
                tathoadon(true);
            }
        }
    }
}
