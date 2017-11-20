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
    public static string MaHD;
    string MaNhanVien = urcDangNhap.strMaNhanVien;
    public delegate void XuLyUI(bool isApear);
    public delegate void XuLyTaoThanhCongHoaDon(bool isAddOK);
    public XuLyUI xulyui;
    public XuLyTaoThanhCongHoaDon xulytaothanhconghoadon;
    private float tongtien = urcBanHang.tongtien;

    public static string tienmat;
    public static string tientralai;
    public static string VAT;
    private void btnHuyBoThanhToan_Click(object sender, EventArgs e)
    {
      this.Parent.Controls.Remove(this);
      if (xulyui != null)
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

    private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
    {
      //
      if (txtTienKhachDua.Text == "" || txtTienKhachDua.Text == "000") return;
      //
      tienmat = txtTienKhachDua.Text;
      tientralai = txtTienTraLai.Text;
      
      
      urcDangNhap urcDN = new urcDangNhap();
      clsHoaDonBan HoaDon = new clsHoaDonBan();
      HoaDon.MaHoaDon = TaoRaMaMoi(BUS.HoaDonBan_BUS.SoLuongHoaDonBan());
      HoaDon.MaNhanVien = MaNhanVien;
      HoaDon.NgayLapHoaDon = DateTime.Now;
      HoaDon.TongTien = tongtien;
      HoaDon.TienDua = float.Parse(txtTienKhachDua.Text);
      HoaDon.TienThoi = float.Parse(txtTienTraLai.Text);

      HoaDon.VAT = HoaDon.TongTien/10;
      //
      VAT = HoaDon.VAT.ToString();
      MaHD = HoaDon.MaHoaDon.ToString();

      if (ckbGiaoHang.Checked)
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



        if (ckbXuatHoaDon.Checked)
        {
          /////
          frmPhieuHoaDon frm = new frmPhieuHoaDon();
          frm.Show();
          frm.tathoadon = new frmPhieuHoaDon.TatHoaDon(KetThucGiaoDich);
        }
        else
        {
          KetThucGiaoDich(true);
        }
      }
    }

    void KetThucGiaoDich(bool isEnd)
    {
      if (isEnd)
      {
        MessageBox.Show("Tạo thành công Hóa đơn");
        this.Parent.Controls.Remove(this);
        if (xulyui != null)
          xulyui(false);
        if (xulytaothanhconghoadon != null)
          xulytaothanhconghoadon(true);
      }
    }

    private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
    {

      if (txtTienKhachDua.Text != "")
      {
        float tienkhachdua = float.Parse(txtTienKhachDua.Text);
        txtTienTraLai.Text = (tienkhachdua - tongtien).ToString();
      }
      else
      {
        txtTienTraLai.Text = "";
      }

    }

    private void ckbKhachHangVangLai_CheckedChanged(object sender, EventArgs e)
    {
      if (ckbKhachHangVangLai.Checked)
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
      ///
      this.ActiveControl = txtTienKhachDua;
      txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length - 3; // add some logic if length is 0
      txtTienKhachDua.SelectionLength = 0;
    }


    private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
    }

    private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
