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
  public partial class urcQLDoanhThu : UserControl
  {
    public urcQLDoanhThu()
    {
      InitializeComponent();
    }
    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;


    //urcCongThucMonAn urcCongThucMonAn = new urcCongThucMonAn();
    //urcDanhSachNguyenLieu urcDanhSachNguyenLieu = new urcDanhSachNguyenLieu();
    //urcDanhSachLoaiNguyenLieu urcDanhSachLoaiNguyenLieu = new urcDanhSachLoaiNguyenLieu();

    //urcXemLichSuBan urcXemLichSuBan = new urcXemLichSuBan();

    urcXemLichSuBan urcXemLichSuBan = new urcXemLichSuBan();
    urcXemLichSuNhap urcXemLichSuNhap = new urcXemLichSuNhap();

    private void CaiDatPanelMenu(Button btn)
    {
      if (btn.Name == btnXemDSNV.Name)
      {
        urcXemLichSuNhap.Visible = false;
        if (!pnlContainer.Controls.ContainsKey("urcXemLichSuBan"))
        {
          pnlContainer.Controls.Add(urcXemLichSuBan);
          urcXemLichSuBan.Visible = true;
          urcXemLichSuBan.Dock = DockStyle.Fill;
        }
        else
        {
          urcXemLichSuBan.Visible = true;
        }
      }

      else if (btn.Name == btnXemDSTK.Name)
      {
        urcXemLichSuBan.Visible = false;
        urcXemLichSuNhap.Visible = true;
        if (!pnlContainer.Controls.ContainsKey("urcXemLichSuNhap"))
        {
          pnlContainer.Controls.Add(urcXemLichSuNhap);
          urcXemLichSuNhap.Visible = true;
          urcXemLichSuNhap.Dock = DockStyle.Fill;
        }
        else
        {
          urcXemLichSuNhap.Visible = true;
        }
      }
    }

    private void urcQLNhanVien_Load(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSNV);

    }

    private void btnXemDSNV_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSNV);
      urcXemLichSuBan.BringToFront();
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    private void btnXemDSTK_Click(object sender, EventArgs e)
    {
      CaiDatPanelMenu(btnXemDSTK);
      urcXemLichSuNhap.BringToFront();
      if (isClickedbtnMoMenu == true)
        btnMoMenu_Click(sender, e);
    }

    //private void btnThemNhanVien_Click(object sender, EventArgs e)
    //{
    //  CaiDatPanelMenu(btnThemNhanVien);

    //  if (!pnlContainer.Controls.ContainsKey("urcNhaCungCap"))
    //  {
    //    pnlContainer.Controls.Add(urcNhaCungCap);
    //    urcNhaCungCap.BackColor = Color.White;
    //    urcNhaCungCap.Top = 0;
    //    urcNhaCungCap.Left = 0;
    //  }
    //  urcNhaCungCap.BringToFront();
    //  if (isClickedbtnMoMenu == true)
    //    btnMoMenu_Click(sender, e);
    //}

    bool isClickedbtnMoMenu = false;
    private void timerMenu_Tick(object sender, EventArgs e)
    {
      timerMenu.Start();
      if (isClickedbtnMoMenu == false)
      {
        if (pnlMenu.Width < 210)
        {
          pnlMenu.Size = new Size(pnlMenu.Width + 10, pnlMenu.Height);
          pnlContainer.Location = new Point(pnlContainer.Location.X - 10, 40);//tét chạy ra bình thu
          pnlMenu.Location = new Point(pnlMenu.Location.X - 10, 0);
          // Trượt cái pnlThongTinNhanVien ấy
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
          pnlMenu.Location = new Point(pnlMenu.Location.X + 10, 0); // userconttrol trước
          pnlContainer.Location = new Point(pnlContainer.Location.X + 10, 40);
          pnlMenu.Size = new Size(pnlMenu.Width - 10, pnlMenu.Height); // Menu sau //mà cũng như nhay à. 
          //tại vì mày để ý, khi Usercontrol trượt từ bên trái vào, thì bên trái nó kiểu như render lại mấy cái control (datagridview,...) bên trong,
          //nên nó giật giật

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
