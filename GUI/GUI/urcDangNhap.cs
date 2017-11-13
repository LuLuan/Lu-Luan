using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class urcDangNhap : UserControl
    {
        public delegate void GetKetQuaDangNhap(bool bolKetQuaDN);
        public delegate void GetThongTinNV(List<clsNhanVien_DTO> bolKetQuaDN);
        public delegate void GetQuyenDangNhap(List<clsQuyenDangNhap_DTO> lstQuyenDN);
        public static string strMaNhanVien ="";

        public GetKetQuaDangNhap LayKetQuaDangNhap;
        public GetThongTinNV LayThongTinNV;
        public GetQuyenDangNhap LayQuyenDangNhap;
        // public delegate void GetChucNangNV(List<clsChucNang_DTO> lstChucNang);
        //public GetChucNangNV LayChucNangNV;
        //public delegate void GetMaNhanVien(string MaNhanVien);
        // public GetMaNhanVien LayMaNhanVien;
        public urcDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;



            if (KiemTraDangNhap(TaiKhoan, MatKhau))
            {
                if (LayKetQuaDangNhap != null && LayThongTinNV != null)
                {
                    strMaNhanVien = TaiKhoan;
                    List<clsNhanVien_DTO> lstTTNV = BUS.NhanVien_BUS.LayNhanVienTheoMa(TaiKhoan);
                    //List<clsQuyenDangNhap_DTO> lstQDN = BUS.TaiKhoan_BUS.LayQuyenDangNhap(TaiKhoan);
                    List<clsQuyenDangNhap_DTO> lstQDN = BUS.QuyenDangNhap_BUS.LayQuyenDangNhapTheoMaNV(TaiKhoan);
                    LayKetQuaDangNhap(true);
                    LayThongTinNV(lstTTNV);
                    LayQuyenDangNhap(lstQDN);
                  //  this.Visible = false;
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                lbMKSai.Visible = true;
            }
        }
        public bool KiemTraDangNhap(string TaiKhoan, string MatKhau)
        {
            return BUS.TaiKhoan_BUS.KiemTraDangNhap_BUS(TaiKhoan, MatKhau);
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            lbMKSai.Visible = false;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            lbMKSai.Visible = false;
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void urcDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Text = "ql123";
            txtTaiKhoan.Text = "N00022";
        }
    }
}
