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
  public partial class urcQLKhachHang : UserControl
  {
    public urcQLKhachHang()
    {
      InitializeComponent();
    }

    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;


    urcDanhSachKhachHang urcDanhSachKhachHang = new urcDanhSachKhachHang();
    urcDanhSachTheKhachHang urcDanhSachTheKhachHang = new urcDanhSachTheKhachHang();
    urcThemKhachHang urcThemKhachHang = new urcThemKhachHang();
    private void CaiDatPanelMenu(Button btn)
    {

      if (btn.Name == btnXemDSKH.Name)
      {
        urcDanhSachTheKhachHang.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachKhachHang"))
        {
          pnlContainer.Controls.Add(urcDanhSachKhachHang);
          urcDanhSachKhachHang.Dock = DockStyle.Fill;
        }
        urcDanhSachKhachHang.Visible = true;
      }

      else if (btn.Name == btnXemDSTheKH.Name)
      {
        urcDanhSachKhachHang.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachTaiKhoan"))
        {
          pnlContainer.Controls.Add(urcDanhSachTheKhachHang);
          urcDanhSachTheKhachHang.Dock = DockStyle.Fill;
        }
        urcDanhSachTheKhachHang.Visible = true;
      }

      else if(btn.Name == btnThemKhachHang.Name)
      {
        if (!pnlContainer.Controls.ContainsKey("urcThemKhachHang"))
        {
          pnlContainer.Controls.Add(urcThemKhachHang);
          urcThemKhachHang.BackColor = Color.White;
          urcThemKhachHang.Top = 50;
          urcThemKhachHang.Left = 200;
        }
        urcThemKhachHang.BringToFront();
      }
    }

    

    private void urcQLKhachHang_Load(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSKH);
    }

    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }



    private void btnXemDSKH_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSKH);
      urcDanhSachKhachHang.urcDanhSachKhachHang_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnXemDSTheKH_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSTheKH);
      urcDanhSachTheKhachHang.urcDanhSachTheKhachHang_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnThemKhachHang_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnThemKhachHang);
      //if (isClickedbtnMoMenu == true)
      //    btnMoMenu_Click(sender, e);
    }



    bool isClickedbtnMoMenu = false;

    private void btnMoMenu_Click(object sender, EventArgs e)
    {
      timerMenu_Tick(sender, e);
    }

    private void timerMenu_Tick(object sender, EventArgs e)
    {
      timerMenu.Start();
      if (isClickedbtnMoMenu == false)
      {
        if (pnlMenu.Width < 210)
        {
          pnlMenu.Size = new Size(pnlMenu.Width + 10, pnlMenu.Height);
          pnlContainer.Location = new Point(pnlContainer.Location.X - 10, 40);
          pnlTieuDe.Location = new Point(pnlTieuDe.Location.X - 10, 0);
          pnlMenu.Location = new Point(pnlMenu.Location.X - 10, 0);

          if (pnlMenu.Width >= 210)
          {
            timerMenu.Stop();
            isClickedbtnMoMenu = true;
          }
        }
      }

      if (isClickedbtnMoMenu == true)
      {
        if (pnlMenu.Width > 40)
        {
          pnlMenu.Location = new Point(pnlMenu.Location.X + 10, 0);
          pnlContainer.Location = new Point(pnlContainer.Location.X + 10, 40);
          pnlTieuDe.Location = new Point(pnlTieuDe.Location.X + 10, 0);
          pnlMenu.Size = new Size(pnlMenu.Width - 10, pnlMenu.Height);

          if (pnlMenu.Width <= 40)
          {
            timerMenu.Stop();
            isClickedbtnMoMenu = false;
          }
        }
      }
    }

    

    










  }
}
