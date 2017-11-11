using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;
using System.Text.RegularExpressions;
namespace GUI
{
    public class Utilities
    {
public void TrangThaiBanDau(GroupBox grbThongTin, GroupBox grbDanhSach)
    {
      foreach (Control ctr in grbThongTin.Controls)
      {
        if (ctr is PictureBox)
        {
          PictureBox PictureBox = (PictureBox)ctr;
          PictureBox.Image = null;
        }
        if (ctr is TextBox)
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Text = null;
          TextBox.Enabled = false;
        }
        if (ctr is RadioButton)
        {
          RadioButton RadioButton = (RadioButton)ctr;
          RadioButton.Checked = false;
          RadioButton.Enabled = false;
        }
        if (ctr is ComboBox)
        {
          ComboBox ComboBox = (ComboBox)ctr;
          ComboBox.Enabled = false;
        }
        if (ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;
          DateTimePicker.CustomFormat = " ";
          DateTimePicker.Format = DateTimePickerFormat.Custom;
          DateTimePicker.Enabled = false;
        }
      }

      foreach (Control ctr in grbDanhSach.Controls)
      {
        if (ctr is DataGridView)
        {
          DataGridView dgv = (DataGridView)ctr;
          dgv.ClearSelection();
        }
      }
    }





    public void TrangThaiKhiChonMotDongTrongDataGridView(GroupBox grbThongTin)
    {
      foreach (Control ctr in grbThongTin.Controls)
      {
        if (ctr is TextBox)
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Enabled = true;
        }
        if (ctr is RadioButton)
        {
          RadioButton RadioButton = (RadioButton)ctr;
          RadioButton.Enabled = true;
        }
        if (ctr is ComboBox)
        {
          ComboBox ComboBox = (ComboBox)ctr;
          ComboBox.Enabled = true;
        }
        if (ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;
          DateTimePicker.Enabled = true;
        }
      }
    }



    public void LayNgayTrongDataGridViewLenDateTimePicker(DateTimePicker dtp, DateTime dt)
    {
      if (dt <= DateTime.MinValue || dt >= DateTime.MaxValue)
      {
        dtp.CustomFormat = " ";
        dtp.Format = DateTimePickerFormat.Custom;
      }
      else
      {
        dtp.Format = DateTimePickerFormat.Short;
        dtp.Value = new DateTime(dt.Year, dt.Month, dt.Day);
      }
    }


    #region UserControl Thêm nhân viên


    public string TaoDuongDanAnh(FileDialog fd)
    {
      return @"HinhAnh\AnhDaiDien\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName);
    }

    public clsNhanVien_DTO TaoDoiTuongNhanVien(string ma, string hoTen, string anh, DateTime ngaySinh, bool gioiTinh, string diaChi, string sdt, DateTime ngayVaoLam, DateTime? ngayThoiViec, string chucVu, int trangThai)
    {
      clsNhanVien_DTO nhanVien = new clsNhanVien_DTO();

      nhanVien.MaNhanVien = ma;
      nhanVien.HoTen = hoTen;
      nhanVien.AnhNhanVien = anh;
      nhanVien.NgaySinh = ngaySinh;
      nhanVien.GioiTinh = gioiTinh;
      nhanVien.DiaChi = diaChi;
      nhanVien.SoDienThoai = sdt;
      nhanVien.NgayBatDauLam = ngayVaoLam;
      nhanVien.NgayThoiViec = ngayThoiViec;
      nhanVien.MaChucVu = chucVu;
      nhanVien.TrangThai = trangThai;

      return nhanVien;
    }

    public clsTaiKhoan_DTO TaoDoiTuongTaiKhoanNhanVien(string maDN, string matKhau, DateTime ngayTao, string maQuyenDangNhap, string maKhanCap, bool trangThai)
    {
      clsTaiKhoan_DTO taiKhoan = new clsTaiKhoan_DTO();

      taiKhoan.MaDangNhap = maDN;
      taiKhoan.MatKhau = matKhau;
      taiKhoan.NgayTao = ngayTao;
      taiKhoan.MaQuyenDangNhap = maQuyenDangNhap;
      taiKhoan.MaKhanCap = maKhanCap;
      taiKhoan.TrangThai = trangThai;

      return taiKhoan;
    }

    public bool KiemTraFileDialog(FileDialog fd)
    {
      return (fd.FileName != "" ? true : false);
    }
    public bool KiemTraPictuerBox(PictureBox pic)
    {
      if (pic.Image != null)
        return true;
      else return false;
      // Nếu có hình ảnh ở trong thì return true  
    }

    public bool KiemTraDateTimePicker(DateTimePicker dtp)
    {
      return (dtp.Format != DateTimePickerFormat.Custom);
      // Nếu chưa chọn ngày tháng năm, Format là custom = " ";
      // Khi chọn một ngày nào đó, Format của DateTimePicker chuyển thành Short (ngày/tháng/năm)
    }

    public bool KiemTraNgaySinh(int tuoiLamViec, DateTimePicker dtp)
    {
      return (dtp.Value < DateTime.Now.AddYears(-tuoiLamViec));
    }

    public bool KiemTraNgayVaoLam(int soNgay, DateTimePicker dtp)
    {
      return (DateTime.Now <= dtp.Value && dtp.Value <= DateTime.Now.AddDays(soNgay));
    }

    public bool KiemTraComboBox(ComboBox cbo)
    {
      return (cbo.SelectedIndex > 0);
    }

    public bool KiemTraRadioButton(RadioButton rdb)
    {
      return (rdb.Checked ? true : false);
    }


    
    public string BTCQMatKhau()
    {
      return @"^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[_|*|@])([a-zA-Z0-9*_@]){5,20})$";
    }

    public string BTCQMaKhanCap()
    {
      return @"^(([0-9]){6,6})$";
    }

    public string BTCQHoTen()
    {
      return @"^((?!.*[\`|\~|\!|\@|\#|\$|\%|\^|\&|\*|\(|\)|\+|\=|\[|\{|\]|\}|\||\\|\'|\<|\,|\.|\>|\?|\/|\""|\;|\:])(?!.*[\d]).{5,50})$";
    }

    public string BTCQSoDienThoai()
    {
      return @"^(([0-9]){10,13})$";
    }
    public string BTCQDiaChi()
    {
      return @"^((?!.*[\`|\~|\!|\@|\#|\$|\%|\^|\&|\*|\+|\=|\[|\{|\]|\}|\||\\|\'|\<|\>|\?|\""|\;|\:]).{15,250})$";
    }



    public bool KiemTraBieuThucChinhQuy(string bieuThuc, Control ctr)
    {
      bool flag = true;
      Regex regex = new Regex(bieuThuc);
      if (ctr is TextBox)
      {
        TextBox txt = (TextBox)ctr;
        if (!regex.IsMatch(txt.Text))
        {
          flag = false;
        }
        else
        {
          flag = true;
        }
      }
      return flag;
    }


    #endregion








        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }      
    }
}
