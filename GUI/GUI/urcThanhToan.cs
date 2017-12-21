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
    float TienTraLai = 0;
    // float TienKhachDua = 0;
    public static string MaHD;
    string MaNhanVien = urcDangNhap.strMaNhanVien;
    public delegate void XuLyUI(bool isApear);
    public delegate void XuLyTaoThanhCongHoaDon(bool isAddOK);
    public XuLyUI xulyui;
    public XuLyTaoThanhCongHoaDon xulytaothanhconghoadon;


    private float tongtien = urcBanHang.tongtien;

    bool flagisKhach = true;

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
      //if (float.Parse(String.Format("{0:0}",TienTraLai) < 0) return;
      if (TienTraLai < 0) return;
      if (txtTienKhachDua.Text == "" || txtTienKhachDua.Text == "000") return;
      //
      tienmat = txtTienKhachDua.Text;
      tientralai = TienTraLai.ToString();


      urcDangNhap urcDN = new urcDangNhap();
      clsHoaDonBan HoaDon = new clsHoaDonBan();
      HoaDon.MaHoaDon = TaoRaMaMoi(BUS.HoaDonBan_BUS.SoLuongHoaDonBan());
      HoaDon.MaNhanVien = MaNhanVien;
      HoaDon.NgayLapHoaDon = DateTime.Now;
      HoaDon.TongTien = tongtien;

      HoaDon.TienDua = float.Parse(txtTienKhachDua.Text);
      //HoaDon.TienThoi = float.Parse(txtTienTraLai.Text);
      HoaDon.TienThoi = TienTraLai;

      HoaDon.VAT = HoaDon.TongTien / 10;
      //
      VAT = HoaDon.VAT.ToString();
      MaHD = HoaDon.MaHoaDon.ToString();

      if (ckbGiaoHang.Checked)
        HoaDon.GiaoHang = true;
      else
        HoaDon.GiaoHang = false;

      if (!ckbKhachHangVangLai.Checked && txtMaTheKhachHang.Text != "")
        //HoaDon.MaKhachHang = "!!!!!";
        MessageBox.Show(txtMaTheKhachHang.Text.Trim());

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
        //  float tienkhachdua = TienKhachDua;
        //  txtTienKhachDua.Text = String.Format("{0:C0}", tienkhachdua);
        //  txtTienKhachDua.TextChanged -= txtTienKhachDua_TextChanged;
        TienTraLai = (float.Parse(String.Format("{0,0}", tienkhachdua)) - tongtien);
        txtTienTraLai.Text = String.Format("{0:C0}", (float.Parse(String.Format("{0,0}", tienkhachdua)) - tongtien));
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
        txtMaTheKhachHang.Enabled = false;
        txtMaTheKhachHang.Text = "";
      }
      else
      {
        txtMaTheKhachHang.Enabled = true;
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

      // TienKhachDua =  float.Parse(String.Format("{0:0}", txtTienKhachDua.Text));
      // txtTienKhachDua.Text = String.Format("{0,C0}", TienKhachDua);

    }

    private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtMaTheKhachHang_TextChanged(object sender, EventArgs e)
    {
      TheKhachHang_BUS busTheKH = new TheKhachHang_BUS();
      
      if(busTheKH.LayTenKhacHangQuaMaThe(txtMaTheKhachHang.Text.Trim())  != null)
      {
       
        if (flagisKhach)
        {
         
          tongtien = tongtien - (tongtien / 20);
            flagisKhach = false;
        }
       
        picTick.Visible = lblTenKhachHang.Visible = true;
        lblTenKhachHang.Text = busTheKH.LayTenKhacHangQuaMaThe(txtMaTheKhachHang.Text.Trim());

        
      }
      else
      {
        
        lblTenKhachHang.Visible = picTick.Visible = false;
        lblTenKhachHang.Text = "";
      }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
