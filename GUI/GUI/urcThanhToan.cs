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
    public partial class urcThanhToan : UserControl
    {
        public urcThanhToan()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        string MaNhanVien = "";
        public delegate void XuLyUI(bool isApear);
        public XuLyUI xulyui;
=======
        string MaNhanVien = urcDangNhap.strMaNhanVien;
        public delegate void XuLyUI(bool isApear);
        public delegate void XuLyTaoThanhCongHoaDon(bool isAddOK);
        public XuLyUI xulyui;
        public XuLyTaoThanhCongHoaDon xulytaothanhconghoadon;
>>>>>>> 38685e361bee85e4892fd054845db2ff2c79ca49
        private float tongtien = urcBanHang.tongtien;
        private void btnHuyBoThanhToan_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            if (xulyui!=null)
            {
                xulyui(false);
            }
        }
        private string TaoRaMaMoi(int iSoLuongMa)
        {
            string MaNL = "";
            iSoLuongMa += 1;

            // int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
            if (iSoLuongMa < 10)
                MaNL = "HDB000000" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 100)
                MaNL = "HDB00000" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 1000)
                MaNL = "HDB0000" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 10000)
                MaNL = "HDB000" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 100000)
                MaNL = "HDB00" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 1000000)
                MaNL = "HDB0" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 10000000)
                MaNL = "HDB" + iSoLuongMa.ToString();
            else if (iSoLuongMa >= 9999999)
                MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

            return MaNL;
        }
<<<<<<< HEAD
        void LayMaNhanVien( List<clsNhanVien_DTO> clsNV)
        {
            MaNhanVien = clsNV[0].MaNhanVien.ToString();
        }
=======

>>>>>>> 38685e361bee85e4892fd054845db2ff2c79ca49
        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            if (ckbXuatHoaDon.Checked)
            {
<<<<<<< HEAD
                //Make something
            }
            urcDangNhap urcDN = new urcDangNhap();
            urcDN.LayThongTinNV = new urcDangNhap.GetThongTinNV(LayMaNhanVien);
=======
                //Make something- when make reporting
            }
            //
            if (txtTienKhachDua.Text == "") return;
            urcDangNhap urcDN = new urcDangNhap();      
>>>>>>> 38685e361bee85e4892fd054845db2ff2c79ca49
            clsHoaDonBan HoaDon = new clsHoaDonBan();
            HoaDon.MaHoaDon = TaoRaMaMoi(BUS.HoaDonBan_BUS.SoLuongHoaDonBan());
            HoaDon.MaNhanVien = MaNhanVien;
            HoaDon.NgayLapHoaDon = DateTime.Now;
            HoaDon.TongTien = tongtien;
            HoaDon.TienDua = float.Parse(txtTienKhachDua.Text);
            HoaDon.TienThoi = float.Parse(txtTienTraLai.Text);
            if (ckbGiaoHang.Checked)
<<<<<<< HEAD
            {
                HoaDon.GiaoHang = true;
            }
            else
                HoaDon.GiaoHang = false;
           
            HoaDon.MaKhachHang = "!!!!!";
            HoaDon.TrangThai = true;

            if (BUS.HoaDonBan_BUS.AddHoaDonBan(HoaDon))
            {
                MessageBox.Show("Tạo thành công Hóa đơn");
                this.Parent.Controls.Remove(this);
                if (xulyui != null)
                {
                    xulyui(false);
                }
            }

            


=======
                HoaDon.GiaoHang = true;
            else
                HoaDon.GiaoHang = false;
            HoaDon.MaKhachHang = "!!!!!";
            HoaDon.TrangThai = true;
            //
            DataTable dt = urcBanHang.dt;
            clsChiTietHoaDonBan_DTO ChiTietHoaDon = new clsChiTietHoaDonBan_DTO();
            ChiTietHoaDon.MaHoaDonBan = HoaDon.MaHoaDon;
            ChiTietHoaDon.GiamGia = 1;
            
          
           // MessageBox.Show(HoaDon.MaHoaDon + " - " + HoaDon.MaNhanVien + " - " + HoaDon.NgayLapHoaDon.ToString() + " - " + HoaDon.TongTien + " - " + HoaDon.TienDua + " - " + HoaDon.TienThoi + " - " + HoaDon.GiaoHang.ToString() + " - " + HoaDon.MaKhachHang + " - " + HoaDon.TrangThai); return;
            if (BUS.HoaDonBan_BUS.AddHoaDonBan(HoaDon))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    ChiTietHoaDon.MaMonAn = row[4].ToString();
                    ChiTietHoaDon.DonGia = float.Parse(row[1].ToString());
                    ChiTietHoaDon.SoLuong = float.Parse(row[2].ToString());
                    ChiTietHoaDon.ThanhTien = float.Parse(row[3].ToString());
                    if (!BUS.ChiTietHoaDonBan_BUS.AddChiTietHoaDonBan(ChiTietHoaDon))
                    {
                        MessageBox.Show("Lỗi thêm chi tiết hóa đơn");
                    }
                }
                //
                MessageBox.Show("Tạo thành công Hóa đơn");
                this.Parent.Controls.Remove(this);
                if (xulyui != null)
                    xulyui(false);
                if (xulytaothanhconghoadon!=null)
                    xulytaothanhconghoadon(true);
                
            }
>>>>>>> 38685e361bee85e4892fd054845db2ff2c79ca49
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
           
            if (txtTienKhachDua.Text!="")
            {
                float tienkhachdua = float.Parse(txtTienKhachDua.Text);
                txtTienTraLai.Text = (tienkhachdua - tongtien).ToString();
            }
<<<<<<< HEAD
          
        }
=======
            else
            {
                txtTienTraLai.Text = "";
            }
          
        }

        private void ckbKhachHangVangLai_CheckedChanged(object sender, EventArgs e)
        {
            if ( ckbKhachHangVangLai.Checked)
            {
                txtMaKhachHang.Enabled = false;
                txtMaKhachHang.Text = "";
            }
            else
            {
                txtMaKhachHang.Enabled = true;
            }
        }

        private void urcThanhToan_Load(object sender, EventArgs e)
        {

            txtMaNhanVien.Text = FrmMain.TenNhanVien;
            
        }


        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
>>>>>>> 38685e361bee85e4892fd054845db2ff2c79ca49
    }
}
