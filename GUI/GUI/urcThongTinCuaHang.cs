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
    public partial class urcThongTinCuaHang : UserControl
    {
        public urcThongTinCuaHang()
        {
            InitializeComponent();
        }
        List<clsCuaHang_DTO> lstCuaHang;
        Utilities utl = new Utilities();
        private void urcThongTinCuaHang_Load(object sender, EventArgs e)
        {
            HienThiThongTinCH();
            TrangThaiControl(false);
        }

        private void HienThiThongTinCH()
        {
            lstCuaHang = BUS.CuaHang_BUS.LaydsCuaHang();
            picLogo.Image = Image.FromFile(lstCuaHang[0].Logo);
            txtTenCuaHang.Text = lstCuaHang[0].TenCuaHang.Trim();
            txtGPKD.Text = lstCuaHang[0].GiayPhepKinhDoanh.Trim();
            txtDiaChi.Text = lstCuaHang[0].DiaChi.Trim();
            txtSDT.Text = lstCuaHang[0].SoDienThoai.Trim();
            txtMatKhauWifi.Text = lstCuaHang[0].Passwifi.Trim();
        }

        private void TrangThaiControl(bool isClickedBtnChinhSua)
        {
            foreach(Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox)
                    ctr.Enabled = isClickedBtnChinhSua;
                if (ctr is Button)
                    if (ctr.Name != "btnChinhSua")
                        ctr.Enabled = isClickedBtnChinhSua;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            TrangThaiControl(true);
        }

        string strError = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuHopLe())
            {
                clsCuaHang_DTO CH = new clsCuaHang_DTO();
                CH.TenCuaHang = txtTenCuaHang.Text;
                CH.DiaChi = txtDiaChi.Text;
                CH.SoDienThoai = txtSDT.Text;
                CH.GiayPhepKinhDoanh = txtGPKD.Text;
                CH.Passwifi = txtMatKhauWifi.Text;
                CH.MaCuaHang = lstCuaHang[0].MaCuaHang;
                if (BUS.CuaHang_BUS.UpdateCuaHang(CH))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    TrangThaiControl(false);
                }
            }
            else MessageBox.Show(strError);
            strError = "";
                
        }

        private bool KiemTraDuLieuHopLe()
        {
            bool flag = true;
            if (!KiemTraTenCuaHang(3, 13))
            {
                strError += " *Tên cửa hàng không hợp lệ\n";
                flag = false;
            }
            if (!KiemTraSoDienThoai(9, 13))
            {
                strError += " *Số điện thoại không hợp lệ\n";
                flag = false;
            }
            if (!KiemTraDiaChi(15, 250))
            {
                strError += " *Địa chỉ không hợp lệ\n";
                flag = false;
            }
            if (!KiemTraGPKDHoacWifi(7, 20, txtGPKD))
            {
                strError += " *GPKD không hợp lệ\n";
                flag = false;
            }
            if (!KiemTraGPKDHoacWifi(8, 20, txtMatKhauWifi))
            {
                strError += " *Mật khẩu wifi không hợp lệ\n";
                flag = false;
            }
            return flag;
        }

        private bool KiemTraTenCuaHang(int min, int max)
        {
            return utl.KiemTraBieuThucChinhQuy(utl.BTCQDiaChi(min, max), txtTenCuaHang);
        }

        private bool KiemTraSoDienThoai(int min, int max)
        {
            return utl.KiemTraBieuThucChinhQuy(utl.BTCQSoDienThoai(min, max), txtSDT);
        }

        private bool KiemTraDiaChi(int min, int max)
        {
            return utl.KiemTraBieuThucChinhQuy(utl.BTCQDiaChi(min, max), txtDiaChi);
        }

        private bool KiemTraGPKDHoacWifi(int min, int max, Control ctr)
        {
            return utl.KiemTraBieuThucChinhQuy(@"^(([0-9A-Z]){"+min+","+max+"})$", ctr);
        }


        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            TrangThaiControl(false);
        }
    }
}
