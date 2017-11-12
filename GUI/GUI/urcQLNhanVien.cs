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
  public partial class urcQLNhanVien : UserControl
  {
    public urcQLNhanVien()
    {
      InitializeComponent();
    }
    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;


    urcDanhSachNhanVien urcDanhSachNhanVien = new urcDanhSachNhanVien();
    urcDanhSachTaiKhoan urcDanhSachTaiKhoan = new urcDanhSachTaiKhoan();
    urcThemNhanVien urcThemNhanVien = new urcThemNhanVien();


    private void CaiDatPanelMenu(Button btn)
    {
      if (btn.Name == btnXemDSNV.Name)
      {
        urcDanhSachTaiKhoan.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachNhanVien"))
        {
          pnlContainer.Controls.Add(urcDanhSachNhanVien);
          urcDanhSachNhanVien.Dock = DockStyle.Fill;
        }
        urcDanhSachNhanVien.Visible = true;
      }

      else if (btn.Name == btnXemDSTheKH.Name)
      {
        urcDanhSachNhanVien.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachTaiKhoan"))
        {
          pnlContainer.Controls.Add(urcDanhSachTaiKhoan);
          urcDanhSachTaiKhoan.Dock = DockStyle.Fill;
        }
        urcDanhSachTaiKhoan.Visible = true;
      }
      else if (btn.Name == btnThemNhanVien.Name)
      {
        if (!pnlContainer.Controls.ContainsKey("urcThemNhanVien"))
        {
          pnlContainer.Controls.Add(urcThemNhanVien);
          urcThemNhanVien.BackColor = Color.White;
          urcThemNhanVien.Top = 50;
          urcThemNhanVien.Left = 200;
        }
        urcThemNhanVien.BringToFront();
      }
    }


    private void urcQLNhanVien_Load(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSNV);
    }

    private void btnXemDSNV_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSNV);
      urcDanhSachNhanVien.urcDanhSachNhanVien_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnXemDSTK_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSTheKH);
      urcDanhSachNhanVien.urcDanhSachNhanVien_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnThemNhanVien_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnThemNhanVien);


      //if (isClickedbtnMoMenu == true)
      //    btnMoMenu_Click(sender, e);
    }



    bool isClickedbtnMoMenu = false; // Xác định xem trượt menu hay chưa

    private void timerMenu_Tick(object sender, EventArgs e)
    {
      timerMenu.Start();
      if (isClickedbtnMoMenu == false)
      {
        if (pnlMenu.Width < 210)
        {
          pnlMenu.Size = new Size(pnlMenu.Width + 10, pnlMenu.Height); // chay ra
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


      if (isClickedbtnMoMenu == true) // chạy vô
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



    private void btnMoMenu_Click(object sender, EventArgs e)
    {
      timerMenu_Tick(sender, e);
    }



    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }













  }
}
