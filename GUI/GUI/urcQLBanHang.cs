﻿using System;
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
    public partial class urcQLBanHang : UserControl
    {
        public urcQLBanHang()
        {
            InitializeComponent();
        }
        public delegate void NhanPhimHome(bool bolPhimHome);
        public NhanPhimHome bolNhanPhimHome;


        urcBanHang urcBanHang = new urcBanHang();
        //urcDanhSachSanPham urcDanhSachSanPham = new urcDanhSachSanPham();

        
        private void CaiDatPanelMenu(Button btn)
        {
            //if (btn.Name == btnXemDSNV.Name)
            //{
            //    urcDanhSachSanPham.Visible = false;
            //    if (!pnlContainer.Controls.ContainsKey("urcBanHang"))
            //    {
            //        pnlContainer.Controls.Add(urcBanHang);
            //        urcDanhSachSanPham.Visible = true;
            //        urcDanhSachSanPham.Dock = DockStyle.Fill;
            //    }
            //    else
            //    {
            //        urcDanhSachSanPham.Visible = true;
            //    }
            //}

            //else if(btn.Name == btnXemDSTK.Name)
            //{
            //    //urcDanhSachSanPham.Visible = false;
            //    //urcDanhSachTaiKhoan.Visible = true;
            //    //if (!pnlContainer.Controls.ContainsKey("urcDanhSachTaiKhoan"))
            //    //{
            //    //    pnlContainer.Controls.Add(urcDanhSachTaiKhoan);
            //    //    urcDanhSachTaiKhoan.Visible = true;
            //    //    urcDanhSachTaiKhoan.Dock = DockStyle.Fill;
            //    //}
            //    //else
            //    //{
            //    //    urcDanhSachTaiKhoan.Visible = true;
            //    //}
            //}
        }

        private void urcQLNhanVien_Load(object sender, EventArgs e)
        {
          pnlContainer.Controls.Add(urcBanHang);
        }

        //private void btnXemDSNV_Click(object sender, EventArgs e)
        //{
        //    CaiDatPanelMenu(btnXemDSNV);
        //    if(isClickedbtnMoMenu == true)
        //        btnMoMenu_Click(sender, e);
        //}

        //private void btnXemDSTK_Click(object sender, EventArgs e)
        //{
        //    CaiDatPanelMenu(btnXemDSTK);
        //    if (isClickedbtnMoMenu == true)
        //        btnMoMenu_Click(sender, e);
        //}

        //private void btnThemNhanVien_Click(object sender, EventArgs e)
        //{
        //    CaiDatPanelMenu(btnThemNhanVien);
        //    if (!pnlContainer.Controls.ContainsKey("urcBanHang"))
        //    {
        //        pnlContainer.Controls.Add(urcBanHang);
        //        urcBanHang.BackColor = Color.White;
        //        urcBanHang.Top = 100;
        //        urcBanHang.Left = 300;
        //    }
        //    urcBanHang.BringToFront();
        //    if (isClickedbtnMoMenu == true)
        //        btnMoMenu_Click(sender, e);
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
            if (bolNhanPhimHome !=null)
            {
                bolNhanPhimHome(true);
            }
        }

        
    }
}
