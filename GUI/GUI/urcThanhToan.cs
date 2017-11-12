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

        string MaNhanVien = "";
        public delegate void XuLyUI(bool isApear);
        public XuLyUI xulyui;
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
        void LayMaNhanVien( List<clsNhanVien_DTO> clsNV)
        {
            MaNhanVien = clsNV[0].MaNhanVien.ToString();
        }
        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            if (ckbXuatHoaDon.Checked)
            {
                //Make something
            }
            urcDangNhap urcDN = new urcDangNhap();
            urcDN.LayThongTinNV = new urcDangNhap.GetThongTinNV(LayMaNhanVien);
            clsHoaDonBan HoaDon = new clsHoaDonBan();
            HoaDon.MaHoaDon = TaoRaMaMoi(BUS.HoaDonBan_BUS.SoLuongHoaDonBan());
            HoaDon.MaNhanVien = MaNhanVien;
            HoaDon.NgayLapHoaDon = DateTime.Now;
            HoaDon.TongTien = tongtien;
            HoaDon.TienDua = float.Parse(txtTienKhachDua.Text);
            HoaDon.TienThoi = float.Parse(txtTienTraLai.Text);
            if (ckbGiaoHang.Checked)
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

            


        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
           
            if (txtTienKhachDua.Text!="")
            {
                float tienkhachdua = float.Parse(txtTienKhachDua.Text);
                txtTienTraLai.Text = (tienkhachdua - tongtien).ToString();
            }
          
        }
    }
}
