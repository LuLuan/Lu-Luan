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
using System.IO;
using System.Text.RegularExpressions;

namespace GUI
{
  public partial class urcThemNhanVien : UserControl
  {
    public urcThemNhanVien()
    {
      InitializeComponent();
    }
    public delegate void LoadLaiDanhSachNhanVien(bool isLoad);
    public LoadLaiDanhSachNhanVien LoadLaiDSNhanVienDele;
    //ThaoTacChung thaoTac = new ThaoTacChung(); // Để táu sử dụng hàm nếu cần thiết DRY (Don't Repeat Yourself)
    Utilities utl = new Utilities(); // Class chứa các hàm để tái sử dụng giữa các UserControl
    private void urcThemNhanVien_Load(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      HienThiDSChucVu();
      HienThiDSQuyenDangNhap();
      TuPhatSinhMaNhanVien();

    }

    #region Hiển thị dữ liệu có sẵn

    private void TuPhatSinhMaNhanVien()
    {
      NhanVien_BUS bus = new NhanVien_BUS();
      txtMaNhanVien.Text = bus.LayMaNhanVien();
    }

    private void HienThiDSChucVu()
    {
      ChucVu_BUS bus = new ChucVu_BUS();
      List<clsChucVu_DTO> lstChucVu = bus.LayDanhSachChucVu();
      clsChucVu_DTO dtoChucVu = new clsChucVu_DTO();
      dtoChucVu.TenChucVu = "Chức vụ";
      dtoChucVu.MaChucVu = "";

      lstChucVu.Insert(0, dtoChucVu);

      cboChucVu.DisplayMember = "TenChucVu";
      cboChucVu.ValueMember = "MaChucVu";

      cboChucVu.DataSource = lstChucVu;
    }

    private void HienThiDSQuyenDangNhap()
    {
      QuyenDangNhap_BUS bus = new QuyenDangNhap_BUS();
      List<clsQuyenDangNhap_DTO> lstQDN = bus.LayQuyenDangNhapTheoMaQDN("");

      clsQuyenDangNhap_DTO dtoQDN = new clsQuyenDangNhap_DTO();
      dtoQDN.TenQuyenDangNhap = "Quyền đăng nhập";
      dtoQDN.MaQuyenDangNhap = "";

      cboQuyenDangNhap.DisplayMember = "TenQuyenDangNhap";
      cboQuyenDangNhap.ValueMember = "MaQuyenDangNhap";

      lstQDN.Insert(0, dtoQDN);

      cboQuyenDangNhap.DataSource = lstQDN;
    }

    #endregion



    #region DI CHUYỂN USERCONTROL urcThemNhanVien
    private Point ViTriMouseDown;

    private void urcThemNhanVien_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        this.Left = e.X + this.Left - ViTriMouseDown.X;
        this.Top = e.Y + this.Top - ViTriMouseDown.Y;
      }
    }

    private void urcThemNhanVien_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        ViTriMouseDown = e.Location;
      }
    }




    private void btnDongCuaSo_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes == MessageBox.Show("Dữ liệu sẽ bị mất. Bạn có chắc muốn đóng?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        //urcDanhSachNhanVien urcDSNV = new urcDanhSachNhanVien();
        //urcDanhSachTaiKhoan urcDSTK = new urcDanhSachTaiKhoan();

        //if (this.Parent.Controls.ContainsKey("urcDanhSachNhanVien"))
        //{
        //  urcDSNV.urcDanhSachNhanVien_Load(sender, e);
        //}
        //if (this.Parent.Controls.ContainsKey("urcDanhSachTaiKhoan"))
        //{
        //  urcDSTK.urcDanhSachTaiKhoan_Load(sender, e);
        //}
        TrangThaiBanDau();
        this.Parent.Controls.Remove(this);
      }

    }

    #endregion



    private void btnDongCuaSo_MouseEnter(object sender, EventArgs e)
    {
      btnDongCuaSo.FlatAppearance.BorderSize = 0;
      btnDongCuaSo.FlatAppearance.BorderColor = Color.FromArgb(39, 176, 96);
    }



    #region Chọn ảnh

    OpenFileDialog fd = new OpenFileDialog();
    private void btnThemAnh_Click(object sender, EventArgs e)
    {
      fd.Title = "Chọn ảnh đại diện nhân viên";
      fd.Filter = "Image Only (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
      if (fd.ShowDialog() == DialogResult.OK)
      {
        if (fd.CheckFileExists)
        {
          picAnhDaiDien.Image = Image.FromFile(fd.FileName);
          //picAnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
          //File.Copy(fd.FileName, @"HinhAnh\AnhDaiDien\" + Path.GetFileName(fd.FileName)); //Lưu ảnh lại folder
        }
        else
          MessageBox.Show("Đã xảy ra lỗi không xác định");
      }
    }

    #endregion

    private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        e.Handled = true;
    }

    private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
    {
      dtpNgaySinh.Format = DateTimePickerFormat.Short;
    }

    private void dtpNgayVaoLam_ValueChanged(object sender, EventArgs e)
    {
      dtpNgayVaoLam.Format = DateTimePickerFormat.Short;
    }

    private void TrangThaiBanDau()
    {
      dtpNgaySinh.CustomFormat = " ";
      dtpNgaySinh.Format = DateTimePickerFormat.Custom;
      picAnhDaiDien.Image = null;
      foreach (Control ctr in this.Controls)
      {
        if (ctr is TextBox && ctr.Name != "txtMaNhanVien")
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Text = "";
        }
        if (ctr is ComboBox)
        {
          ComboBox ComboBox = (ComboBox)ctr;
          //ComboBox.SelectedIndex = -1;
        }
        if (ctr is CheckBox)
        {
          CheckBox CheckBox = (CheckBox)ctr;
          CheckBox.Checked = true;
        }
      }
    }




    #region THÊM NHÂN VIÊN

    string destFileName = ""; // Đường dân + Thời gian (năm-tháng-ngày-giờ-phút-giây) + Tên ảnh
    string strError = ""; // Thông bó lỗi nếu sai Biểu thức chính quy
    //string strWarning = ""; // Cảnh báo trường dữ liệu nhập có thể sai. Nhưng vẫn thêm được vào cơ sở dữ liệu.
    private void btnDongY_Click(object sender, EventArgs e)
    {
      if (KiemTraDuLieuHopLe())
      {
        if (DialogResult.Yes == MessageBox.Show("Bạn muốn thêm mới nhân viên " + txtHoTen.Text, "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        {
          NhanVien_BUS busNhanVien = new NhanVien_BUS();
          TaiKhoan_BUS busTaiKhoan = new TaiKhoan_BUS();

          destFileName = TaoDuongDanAnh(); // Lưu đường dẫn ảnh trước khi TaoNhanVien

          clsNhanVien_DTO NV = TaoDoiTuongNhanVien();
          clsTaiKhoan_DTO TK = TaoDoiTuongTaiKhoanNhanVien();

          try
          {
            if (busNhanVien.ThaoTacVoiDoiTuongNhanVien(NV, "Add") && busTaiKhoan.ThaoTacVoiTaiKhoan(TK, "Add"))
            {
              File.Copy(fd.FileName, destFileName);
              MessageBox.Show("Đã thên nhân viên mới");
              TrangThaiBanDau();

            }
            else MessageBox.Show("Thêm thất bại");
          }
          catch (Exception)
          {
          }
          TrangThaiBanDau();
        }
        else
        {
          MessageBox.Show("Hủy thao tác");
        }
      }
      else
      {
        MessageBox.Show(strError, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      strError = "";
      destFileName = "";
    }

    public string TaoDuongDanAnh()
    {
      return utl.TaoDuongDanAnh(fd);
    }

    private clsNhanVien_DTO TaoDoiTuongNhanVien()
    {
      string ma = txtMaNhanVien.Text;
      string hoTen = txtHoTen.Text;
      string anh = destFileName;
      DateTime ngaySinh = dtpNgaySinh.Value;
      bool gioiTinh = utl.KiemTraRadioButton(rdbNam);
      string diaChi = txtDiaChi.Text;
      string sdt = txtSoDienThoai.Text;
      DateTime ngayBatDauLam = dtpNgayVaoLam.Value;
      string maChucVu = cboChucVu.SelectedValue.ToString().Trim();
      int trangThai = (dtpNgayVaoLam.Value <= DateTime.Now ? 1 : 3);
      DateTime? ngayThoiViec = null;
      return utl.TaoDoiTuongNhanVien(ma, hoTen, anh, ngaySinh, gioiTinh, diaChi, sdt, ngayBatDauLam, ngayThoiViec, maChucVu, trangThai);
    }

    private clsTaiKhoan_DTO TaoDoiTuongTaiKhoanNhanVien()
    {
      string maDN = txtMaNhanVien.Text;
      string matKhau = txtMatKhau.Text.Trim();
      DateTime ngayTao = DateTime.Now;
      string maQuyenDangNhap = cboQuyenDangNhap.SelectedValue.ToString().Trim();
      string maKhanCap = txtMaKhanCap.Text;
      bool trangThai = (chbKichHoatTK.Checked ? true : false);

      return utl.TaoDoiTuongTaiKhoanNhanVien(maDN, matKhau, ngayTao, maQuyenDangNhap, maKhanCap, trangThai);
    }


    private bool KiemTraDuLieuHopLe()
    {
      bool flag = true;
      if (!KiemTraMatKhau())
      {
        flag = false;
        strError += " *Mật khẩu phải dài từ 5 tới 20 kí tự, có ít nhất 1 chữ cái thường, 1 chữ cái in hoa, 1 chữ số và 1 kí tự đặc biệt (\" * \"  hoặc \" @ \" hoặc \" _ \")\n";
      }

      if (!KiemTraMaKhanCap())
      {
        flag = false;
        strError += " *Mã khẩn cấp phải đủ 6 kí tự là những chữ số (từ 0 tới 9)\n";
      }
      if (!KiemTraHoTen())
      {
        flag = false;
        strError += " *Họ tên phải dài từ 5 tới 50 kí tự, không bao gồm chữ số và kí tự đặc biệt\n";
      }
      if (!KiemTraSDT())
      {
        flag = false;
        strError += " *Số điện thoại phải dài từ 10 tới 13 kí tự là những chữ số\n";
      }
      if (!KiemTraDiaChi())
      {
        flag = false;
        strError += " *Địa chỉ phải dài từ 15 tới 250 kí tự, chỉ được phép sử dụng chữ cái, chữ số và các kí tự dặc biệt (\" , . / ( ) \")\n";
      }
      if (!KiemTraHinhAnh())
      {
        flag = false;
        strError += " *Không được để trống hình ảnh\n";
      }
      if (!KiemTraComboBoxChucVu())
      {
        flag = false;
        strError += " *Không được để trống chức vụ\n";
      }
      if (!KiemTraComboBoxQuyenDangNhap())
      {
        flag = false;
        strError += " *Không được để trống quyền đăng nhập\n";
      }

      if (!KiemTraNgaySinh())
      {
        flag = false;
        strError += " *Nhân viên phải đủ từ 15 tuổi trở lên\n";
      }

      if (!KiemTraNgayVaoLam())
      {
        flag = false;
        strError += " *Ngày vào làm phải lớn hơn hoặc bằng hôm nay\n";
      }

      return flag;
    }


    private void txtMatKhau_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMatKhau())
        txtMatKhau.ForeColor = Color.Black;
      else txtMatKhau.ForeColor = Color.Red;
    }

    private void txtMaKhanCap_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMaKhanCap())
        txtMaKhanCap.ForeColor = Color.Black;
      else txtMaKhanCap.ForeColor = Color.Red;
    }
    private void txtHoTen_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraHoTen())
        txtHoTen.ForeColor = Color.Black;
      else txtHoTen.ForeColor = Color.Red;
    }

    private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraSDT())
        txtSoDienThoai.ForeColor = Color.Black;
      else txtSoDienThoai.ForeColor = Color.Red;
    }

    private void txtDiaChi_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraDiaChi())
        txtDiaChi.ForeColor = Color.Black;
      else txtDiaChi.ForeColor = Color.Red;
    }



    private bool KiemTraHinhAnh()
    {
      return (utl.KiemTraFileDialog(fd) && utl.KiemTraPictuerBox(picAnhDaiDien));
    }
    private bool KiemTraComboBoxQuyenDangNhap()
    {
      return utl.KiemTraComboBox(cboQuyenDangNhap);
    }

    private bool KiemTraComboBoxChucVu()
    {
      return utl.KiemTraComboBox(cboChucVu);
    }

    private bool KiemTraNgaySinh()
    {
      return (utl.KiemTraDateTimePicker(dtpNgaySinh) && utl.KiemTraNgaySinh(15, dtpNgaySinh));
    }

    private bool KiemTraNgayVaoLam()
    {
      return (utl.KiemTraDateTimePicker(dtpNgayVaoLam) && utl.KiemTraNgayVaoLam(7, dtpNgayVaoLam));
    }

    private bool KiemTraMatKhau()
    {
      //string str = @"^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[_|*|@])([a-zA-Z0-9*_@]){5,20})$";

      return utl.KiemTraBieuThucChinhQuy(utl.BTCQMatKhau(), txtMatKhau);
    }

    private bool KiemTraMaKhanCap()
    {
      //string str = @"^(([0-9]){6,6})$";
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQMaKhanCap(), txtMaKhanCap);
    }

    private bool KiemTraHoTen()
    {
      //string str = @"^((?!.*[\`|\~|\!|\@|\#|\$|\%|\^|\&|\*|\(|\)|\+|\=|\[|\{|\]|\}|\||\\|\'|\<|\,|\.|\>|\?|\/|\""|\;|\:])(?!.*[\d]).{5,50})$";
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQHoTen(), txtHoTen);
    }

    private bool KiemTraSDT()
    {
      //string str = @"^(([0-9]){10,13})$";
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQSoDienThoai(), txtSoDienThoai);
    }
    private bool KiemTraDiaChi()
    {
      //string str = @"^((?!.*[\`|\~|\!|\@|\#|\$|\%|\^|\&|\*|\+|\=|\[|\{|\]|\}|\||\\|\'|\<|\>|\?|\""|\;|\:]).{15,250})$";
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQDiaChi(), txtDiaChi);
    }



    //private bool KiemTraBieuThucChinhQuy(string bieuThuc, Control ctr)
    //{
    //  bool flag = true;
    //  Regex regex = new Regex(bieuThuc);
    //  if (ctr is TextBox)
    //  {
    //    TextBox txt = (TextBox)ctr;
    //    if (!regex.IsMatch(txt.Text))
    //    {
    //      flag = false;
    //    }
    //    else
    //    {
    //      flag = true;
    //    }
    //  }
    //  return flag;
    //}

    #endregion














  }
}
