using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
  public partial class urcThemKhachHang : UserControl
  {
    public urcThemKhachHang()
    {
      InitializeComponent();
    }

    Utilities utl = new Utilities();

    private void urcThemKhachHang_Load(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      TuPhatSinhMaKhachHang();
    }

    private void TuPhatSinhMaKhachHang()
    {
      KhachHang_BUS bus = new KhachHang_BUS();
      txtMaKhachHang.Text = bus.LayMaKhachHang();
    }
    private string TuPhatSinhMaTheKhachHang()
    {
      TheKhachHang_BUS bus = new TheKhachHang_BUS();
      return bus.LayMaTheKhachHang();
    }



    private void TrangThaiBanDau()
    {
      foreach (Control ctr in this.Controls)
      {
        if (ctr is TextBox && ctr.Name != txtMaKhachHang.Name)
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Text = "";
        }
        //if (ctr is ComboBox)
        //{
        //  ComboBox ComboBox = (ComboBox)ctr;
        //}
        if (ctr is CheckBox)
        {
          CheckBox CheckBox = (CheckBox)ctr;
          CheckBox.Checked = true;
        }
        if(ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;
          DateTimePicker.CustomFormat = " ";
          DateTimePicker.Format = DateTimePickerFormat.Custom;
        }
      }
    }


    #region THÊM KHÁCH HÀNG

    private string strError = "";
    private string strWarning = "";

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (KiemTraDuLieuHopLe())
      {
        string strThongBao = "Thêm khách hàng " + txtHoTen.Text;
        MessageBoxButtons MBButton = MessageBoxButtons.OK;
        MessageBoxIcon MBIcon = MessageBoxIcon.Question;
        
        if(strWarning != "")
        {
          strThongBao = strWarning += "\n Vẫn muốn tiếp tục";
          MBButton = MessageBoxButtons.YesNo;
          MBIcon = MessageBoxIcon.Warning;
        }

        if (DialogResult.Yes == MessageBox.Show(strThongBao, "Xác nhận thêm", MBButton, MBIcon))
        {
          TheKhachHang_BUS theKH_bus = new TheKhachHang_BUS();
          clsTheKhachHang theKH = TaoDoiTuongTheKhachHang();

          KhachHang_BUS KH_bus = new KhachHang_BUS();
          clsKhachHang_DTO KH = TaoDoiTuongKhachHang();

          try
          {
            if (KH_bus.ThaoTacVoiKhachHang(KH, "Add") && theKH_bus.ThaoTacVoiDoiTuongTheKhachHang(theKH, "Add"))
            {
              //MessageBox.Show("Đã thêm khách hàng " + KH.TenKhachHang);
              TrangThaiBanDau();
              TuPhatSinhMaKhachHang();
            }
          }
          catch (Exception){}

        }
        else
        {
          MessageBox.Show("Hủy thao tác");
        }

      }
      else MessageBox.Show(strError, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error );

      strError = "";
      strWarning = "";

    }


    private clsKhachHang_DTO TaoDoiTuongKhachHang()
    {
      string maKH = txtMaKhachHang.Text;
      string tenKH = txtHoTen.Text;
      bool gioiTinh = (rdbNam.Checked ? true : false);
      DateTime ngaySinh = dtpNgaySinh.Value;
      string SDT = txtSoDienThoai.Text;
      string diaChi = txtDiaChi.Text;
      bool trangThai = true;

      clsKhachHang_DTO kh = new clsKhachHang_DTO();
      return utl.TaoDoiTuongKhachHang(maKH, tenKH, gioiTinh, ngaySinh, SDT, diaChi, trangThai);
    }

    private clsTheKhachHang TaoDoiTuongTheKhachHang()
    {
      string maThe = TuPhatSinhMaTheKhachHang();
      string maKH = txtMaKhachHang.Text;
      string maLoaiThe = "1234567890";
      DateTime ngayDK = DateTime.Now;

      bool trangThai = true;

      return utl.TaoDoiThuongTheKhachHang(maThe, maKH, maLoaiThe, ngayDK, trangThai);
    }
    

    private bool KiemTraDuLieuHopLe()
    {
      bool flag = true;

      if (!KiemTraHoTen())
      {
        flag = false;
        strError += " *Họ tên phải dài từ 5 tới 50 kí tự, không bao gồm chữ số và kí tự đặc biệt\n";
      }

      if (!KiemTraSDT(10, 13))
      {
        if (!KiemTraSDT(0, 0))
        {
          flag = false;
          strError += " *Số điện thoại phải dài từ 10 tới 13 kí tự là những chữ số\n";
        }
        else strWarning += " *Chưa có số điện thoại khách hàng\n";
      }

      if (!KiemTraDiaChi(15, 250))
      {
        if (!KiemTraDiaChi(0, 0))
        {
          flag = false;
          strError += " *Địa chỉ phải dài từ 15 tới 250 kí tự, chỉ được phép sử dụng chữ cái, chữ số và các kí tự dặc biệt (\" , . / ( ) \")\n";
        }
        else strWarning += " *Chưa có địa chỉ khách hàng\n";
      }

      if (!KiemTraNgaySinh(15))
      {
        flag = false;
        strError += " *Khách hàng chưa đủ 15 tuổi trở lên\n";
      }
      

      return flag;
    }



    private bool KiemTraHoTen()
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQHoTen(), txtHoTen);
    }

    private bool KiemTraSDT(int min, int max)
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQSoDienThoai(min, max), txtSoDienThoai);
    }

    private bool KiemTraDiaChi(int min, int max)
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQDiaChi(min, max), txtDiaChi);
    }

    private bool KiemTraNgaySinh(int min)
    {
      return (utl.KiemTraDateTimePicker(dtpNgaySinh) && utl.KiemTraTuoi(min, dtpNgaySinh));
    }



    #endregion


    #region Đổi màu chữ khi nhập sai dữ liệu
    private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraSDT(10, 13))
        txtSoDienThoai.ForeColor = Color.Black;
      else txtSoDienThoai.ForeColor = Color.Red;
    }

    private void txtHoTen_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraHoTen())
        txtHoTen.ForeColor = Color.Black;
      else txtHoTen.ForeColor = Color.Red;
    }

    private void txtDiaChi_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraDiaChi(15, 250))
        txtDiaChi.ForeColor = Color.Black;
      else txtDiaChi.ForeColor = Color.Red;
    }
    #endregion

    #region Di chuyển UserControl

    private Point ViTriMouseDown;
    private void urcThemKhachHang_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        this.Left = e.X + this.Left - ViTriMouseDown.X;
        this.Top = e.Y + this.Top - ViTriMouseDown.Y;
      }
    }

    private void urcThemKhachHang_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        ViTriMouseDown = e.Location;
      }
    }

    #endregion

    

    private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
    {
      dtpNgaySinh.Format = DateTimePickerFormat.Short;
    }

    private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
    }

    private void btnDongCuaSo_Click(object sender, EventArgs e)
    {
      if(DialogResult.Yes == MessageBox.Show("Dữ liệu chưa lưu sẽ bị mất. Bạn có chắc muốn đóng?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        TrangThaiBanDau();
        this.Parent.Controls.Remove(this);
      }
    }

    private void btnDongCuaSo_MouseEnter(object sender, EventArgs e)
    {
      btnDongCuaSo.FlatAppearance.BorderSize = 0;
      btnDongCuaSo.FlatAppearance.BorderColor = Color.FromArgb(39, 176, 96);
    }

    

    

  }
}
