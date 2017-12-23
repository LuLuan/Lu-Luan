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
    urcChiTietBanPhanCong urcChiTietPhanCong = new urcChiTietBanPhanCong();
    

    private void urcQLPhanCong_Load(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnPhanCong);
    }

    private void CaiDatPanelMenu(Button btn)
    {
      if (btn.Name == btnPhanCong.Name)
      {
        urcChiTietPhanCong.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachPhanCong"))
        {
          pnlContainer.Controls.Add(urcDanhSachPhanCong);
          urcDanhSachPhanCong.Dock = DockStyle.Fill;
        }
        urcDanhSachPhanCong.Visible = true;
      }

      else if (btn.Name == btnChamCong.Name)
      {
        urcDanhSachPhanCong.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcDanhSachTaiKhoan"))
        {
          pnlContainer.Controls.Add(urcChiTietPhanCong);
          urcChiTietPhanCong.Dock = DockStyle.Fill;
        }
        urcChiTietPhanCong.Visible = true;
      }
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

    private void btnMoMenu_Click(object sender, EventArgs e)
    {
      timerMenu_Tick(sender, e);
    }

    private void btnPhanCong_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnPhanCong);
      urcDanhSachPhanCong.urcDanhSachPhanCong_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnChamCong_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnChamCong);
      urcChiTietPhanCong.urcChiTietBanPhanCong_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    



    


    bool isClickedbtnMoMenu = false;
    private void timerMenu_Tick(object sender, EventArgs e)
    {
      timerMenu.Start();
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

    

    


    

    



  }
}
