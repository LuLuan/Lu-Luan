using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public partial class urcQLPhanCong : UserControl
  {
    public urcQLPhanCong()
    {
      InitializeComponent();
    }
    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;


    urcDanhSachPhanCong urcDanhSachPhanCong = new urcDanhSachPhanCong();

    private void urcQLPhanCong_Load(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSPC);
    }

    private void CaiDatPanelMenu(Button btn)
    {
      if (btn.Name == btnXemDSPC.Name)
      {
        //urcDanhSachTaiKhoan.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachPhanCong"))
        {
          pnlContainer.Controls.Add(urcDanhSachPhanCong);
          urcDanhSachPhanCong.Dock = DockStyle.Fill;
        }
        urcDanhSachPhanCong.Visible = true;
      }

      //else if (btn.Name == btnXemDSTheKH.Name)
      //{
      //  urcDanhSachNhanVien.Visible = false;
      //  if (!pnlContainer.Controls.ContainsKey("urcDanhSachTaiKhoan"))
      //  {
      //    pnlContainer.Controls.Add(urcDanhSachTaiKhoan);
      //    urcDanhSachTaiKhoan.Dock = DockStyle.Fill;
      //  }
      //  urcDanhSachTaiKhoan.Visible = true;
      //}
      //else if (btn.Name == btnThemNhanVien.Name)
      //{
      //  if (!pnlContainer.Controls.ContainsKey("urcThemNhanVien"))
      //  {
      //    pnlContainer.Controls.Add(urcThemNhanVien);
      //    urcThemNhanVien.BackColor = Color.White;
      //    urcThemNhanVien.Top = 50;
      //    urcThemNhanVien.Left = 200;
      //  }
      //  urcThemNhanVien.BringToFront();
      //}
    }


























    #region

    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }

    #endregion

    private void btnXemDSPC_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSPC);
    }

    

    



  }
}
