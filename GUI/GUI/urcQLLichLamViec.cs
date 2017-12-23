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
  public partial class urcQLLichLamViec : UserControl
  {
    public urcQLLichLamViec()
    {
      InitializeComponent();
    }

    urcXemLichLamViec urcXemLichLamViec = new urcXemLichLamViec();

    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;



    private void CaiDatPanelMenu(Button btn)
    {

      if (btn.Name == btnXemLichLamViec.Name)
      {
        //urcDanhSachTheKhachHang.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcXemLichLamViec"))
        {
          pnlContainer.Controls.Add(urcXemLichLamViec);
          urcXemLichLamViec.Dock = DockStyle.Fill;
        }
        urcXemLichLamViec.Visible = true;
      }
    }


    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }

    private void btnXemLichLamViec_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemLichLamViec);
      urcXemLichLamViec.urcXemLichLamViec_Load(sender, e);
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void urcQLLichLamViec_Load(object sender, EventArgs e)
    {
      this.pnlContainer.Controls.Add(urcXemLichLamViec);
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
  