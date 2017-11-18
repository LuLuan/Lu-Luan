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

namespace GUI
{
  public partial class urcDanhSachNhanVien : UserControl
  {
    public urcDanhSachNhanVien()
    {
      InitializeComponent();
    }

    urcThemNhanVien tnv = new urcThemNhanVien();
    void LoadLaiMain(bool isLoad)
    {
      if (isLoad)
      {
        HienThiDSNhanVien();
      }

    }

    Utilities utl = new Utilities(); // Gọi lại  những hàm dùng chung trong Class Utilities

    public void urcDanhSachNhanVien_Load(object sender, EventArgs e)
    {
      HienThiDSNhanVien();
      HienThiDSChucVu(cboChucVu);
      HienThiDSChucVu(cboChucVu_TK);
      ThemGioiTinhVaoComboboxGioiTinh_TK();
      HienThiDSTrangThai(cboTrangThai);
      HienThiDSTrangThai(cboTrangThai_TK);
      //delegate
      tnv.LoadLaiDSNhanVienDele = new urcThemNhanVien.LoadLaiDanhSachNhanVien(LoadLaiMain);

      //MessageBox.Show(dtpNgayThoiViec.Value.ToShortDateString());
    }


    #region Hiển thị dữ liệu: Danh sách nhân viên - dgvNhanVien, Danh sách chức vụ - cboChucVu,...
    public void HienThiDSNhanVien()
    {
      NhanVien_BUS bus = new NhanVien_BUS();
      List<clsNhanVien_DTO> lstNhanVien = BUS.NhanVien_BUS.LayNhanVienTheoMa("");
      dgvDSNV.AutoGenerateColumns = false;
      dgvDSNV.DataSource = lstNhanVien;
    }

    private void HienThiDSChucVu(ComboBox cbo)
    {
      ChucVu_BUS bus = new ChucVu_BUS();
      List<clsChucVu_DTO> lstChucVu = bus.LayDanhSachChucVu();
      clsChucVu_DTO dtoChucVu = new clsChucVu_DTO();
      if (cbo.Name == cboChucVu_TK.Name)
      {
        dtoChucVu.TenChucVu = "- -Tất cả- -";
        dtoChucVu.MaChucVu = "";
        lstChucVu.Insert(0, dtoChucVu);
      }

      cbo.DataSource = lstChucVu;
      cbo.DisplayMember = "TenChucVu";
      cbo.ValueMember = "MaChucVu";
      cbo.SelectedIndex = 0;
    }

    private void HienThiDSTrangThai(ComboBox cbo)
    {
      TrangThaiNV_BUS bus = new TrangThaiNV_BUS();
      List<clsTrangThaiNV_DTO> lstTrangThaiNV = bus.LayDanhSachTrangThaiNhanVien();
      clsTrangThaiNV_DTO dtoTrangThaiNV = new clsTrangThaiNV_DTO();
      if (cbo.Name == cboTrangThai_TK.Name)
      {
        dtoTrangThaiNV.TenTrangThaiNV = "- -Tất cả- -";
        dtoTrangThaiNV.MaTrangThaiNV = 0;
        lstTrangThaiNV.Insert(0, dtoTrangThaiNV);
      }


      cbo.DataSource = lstTrangThaiNV;
      cbo.DisplayMember = "TenTrangThaiNV";
      cbo.ValueMember = "MaTrangThaiNV";

      //cbo.DataSource = null;
      //cbo.Items.RemoveAt(cbo.Items.Count);
      //cbo.DataSource = lstTrangThaiNV;
      //MessageBox.Show(cbo.Items.Count.ToString());

      //cbo.SelectedIndex = 0;
    }


    private void ThemGioiTinhVaoComboboxGioiTinh_TK()
    {

      cboGioiTinh_TK.Items.Add("- -Tất cả- -");
      cboGioiTinh_TK.Items.Add("Nam");
      cboGioiTinh_TK.Items.Add("Nữ");
      cboGioiTinh_TK.SelectedIndex = 0;
    }

    #endregion Kết thúc Hiển thị dữ liệu: Danh sách nhân viên - dgvNhanVien, Danh sách chức vụ - cboChucVu,...




    OpenFileDialog fd = new OpenFileDialog(); // Biến toàn cục, để khi click vào nút Thêm mới đưa ảnh vào thư mục
    private void btnThemAnh_Click(object sender, EventArgs e)
    {
      fd.Title = "Chọn ảnh đại diện nhân viên";
      fd.Filter = "Image Only (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
      if (fd.ShowDialog() == DialogResult.OK)
      {
        if (fd.CheckFileExists)
        {
          picAnhDaiDien.Image = Image.FromFile(fd.FileName);

          //picAnhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
          //MessageBox.Show(Path.GetFileName(fd.FileName));

          //File.Copy(Path.GetFileName(fd.FileName), "HinhAnh/AnhDaiDien/" + Path.GetFileName(fd.FileName)); //Lưu ảnh lại folder
        }
      }
    }


    private void btnHuyThaoTac_Click(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      LamMoiDanhSach();
      //cboChucVu.SelectedIndex = 0;
      //cboTrangThai.SelectedIndex = 0;
    }





    private void btnInThe_Click(object sender, EventArgs e)
    {
      MessageBox.Show("In");
    }

    private void btnInDSNV_Click(object sender, EventArgs e)
    {
      MessageBox.Show("In danh sách nhân viên");
    }

    #region Cập nhật nhân viên


    string destFileName = ""; // Đường dân + Thời gian (năm-tháng-ngày-giờ-phút-giây) + Tên ảnh
    string strError = ""; // Thông bó lỗi nếu sai Biểu thức chính quy
    private void btnCapNhat_Click(object sender, EventArgs e)
    {
      if (KiemTraDuLieuHopLe())
      {
        if (DialogResult.Yes == MessageBox.Show("Bạn muốn cập nhật nhân viên " + txtHoTen.Text, "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        {
          NhanVien_BUS busNhanVien = new NhanVien_BUS();
          destFileName = TaoDuongDanAnh(); // Lưu đường dẫn ảnh trước khi TaoNhanVien
          clsNhanVien_DTO NV = TaoDoiTuongNhanVien();

          //try
          {
            if (busNhanVien.ThaoTacVoiDoiTuongNhanVien(NV, "Update"))
            {
              if (utl.KiemTraFileDialog(fd))
                //File Dialog = fd
                //destFileName = @"HinhAnh\AnhDaiDien\" + imageName;
                File.Copy(fd.FileName, destFileName);
              MessageBox.Show("Đã cập nhật nhân viên " + NV.HoTen);
              TrangThaiBanDau();
              HienThiDSNhanVien();
            }
          }
          //catch (Exception)
          //{
          //  throw;
          //}

        }
        else MessageBox.Show("Hủy thao tác");
      }
      else MessageBox.Show(strError, "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

      strError = "";
      destFileName = "";


      //if (fd.FileName == "")
      //{
      //  MessageBox.Show("Chưa có chọn ảnh mới");
      //}
      //else MessageBox.Show("Ảnh mới là" + fd.FileName);
    }

    private bool KiemTraDuLieuHopLe()
    {
      bool flag = true;


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
      //if (!KiemTraHinhAnh())
      //{
      //  flag = false;
      //  strError += " *Không được để trống hình ảnh\n";
      //}
      //if (!KiemTraChucVu())
      //{
      //  flag = false;
      //  strError += " *Không được để trống chức vụ\n";
      //}
      //if (!KiemTraTrangThai())
      //{
      //  flag = false;
      //  strError += " *Không được để trống trạng thái\n";
      //}

      if (!KiemTraNgaySinh())
      {
        flag = false;
        strError += " *Nhân viên phải đủ từ 15 tuổi trờ lên\n";
      }


      return flag;
    }

    private string TaoDuongDanAnh()
    {
      if (utl.KiemTraFileDialog(fd))
        destFileName = utl.TaoDuongDanAnh(fd);
      else
      {
        DataGridViewRow r = dgvDSNV.SelectedRows[0];
        string imageUrl = r.Cells["colAnhNhanVien"].Value.ToString();
        string imageName = imageUrl.Substring(imageUrl.LastIndexOf(@"\") + 1);

        destFileName = @"HinhAnh\AnhDaiDien\" + imageName;
      }
      return destFileName;
    }


    private clsNhanVien_DTO TaoDoiTuongNhanVien()
    {
      string ma = lblMaNV.Text;
      string hoTen = txtHoTen.Text;

      string anh = destFileName;

      DateTime ngaySinh = dtpNgaySinh.Value;
      bool gioiTinh = utl.KiemTraRadioButton(rdbNam);
      string diaChi = txtDiaChi.Text;
      string sdt = txtSoDienThoai.Text;

      DateTime ngayBatDauLam = dtpNgayVaoLam.Value;

      DateTime? ngayThoiViec;
      DateTime? nullDateTime = null;
      ngayThoiViec = (dtpNgayThoiViec.Format == DateTimePickerFormat.Custom ? nullDateTime : dtpNgayThoiViec.Value);

      string maChucVu = cboChucVu.SelectedValue.ToString().Trim();
      int trangThai = (int)cboTrangThai.SelectedValue;

      return utl.TaoDoiTuongNhanVien(ma, hoTen, anh, ngaySinh, gioiTinh, diaChi, sdt, ngayBatDauLam, ngayThoiViec, maChucVu, trangThai);
    }

    private bool KiemTraNhanVienDaVaoLam()
    {
      return (ngayVaoLamTrongDGV <= DateTime.Now ?  true : false);
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






    //private bool KiemTraHinhAnh()
    //{
    //  return (utl.KiemTraFileDialog(fd) && utl.KiemTraPictuerBox(picAnhDaiDien));
    //}
    //private bool KiemTraChucVu()
    //{
    //  return (cboChucVu.SelectedIndex > -1);
    //}

    //private bool KiemTraTrangThai()
    //{
    //  return (cboTrangThai.SelectedIndex > -1);
    //}

    private bool KiemTraNgaySinh()
    {
      return (utl.KiemTraDateTimePicker(dtpNgaySinh) && utl.KiemTraTuoi(15, dtpNgaySinh));
    }

    private bool KiemTraNgayVaoLam()
    {
      return (utl.KiemTraDateTimePicker(dtpNgayVaoLam) && utl.KiemTraNgayVaoLam(7, dtpNgaySinh));
    }


    private bool KiemTraHoTen()
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQHoTen(), txtHoTen);
    }

    private bool KiemTraSDT()
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQSoDienThoai(), txtSoDienThoai);
    }
    private bool KiemTraDiaChi()
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQDiaChi(), txtDiaChi);
    }






    #endregion


    #region Xóa nhân viên (cập nhật lại trạng thái)
    private void dgvDSNV_KeyUp(object sender, KeyEventArgs e)
    {
      if (dgvDSNV.Rows.Count > 0 && dgvDSNV.SelectedRows.Count > 0)
      {
        DataGridViewRow row = dgvDSNV.SelectedRows[0];
        int rowIndex = row.Index;

        if (e.KeyCode == Keys.Delete)
        {
          if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên " + txtHoTen.Text + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
          {
            clsNhanVien_DTO NV = new clsNhanVien_DTO();
            clsTaiKhoan_DTO TK = new clsTaiKhoan_DTO();
            TK.MaDangNhap = lblMaNV.Text;
            TK.TrangThai = false;
            NV.MaNhanVien = lblMaNV.Text;
            NV.TrangThai = 4;
            NhanVien_BUS busNV = new NhanVien_BUS();
            try
            {
              if (busNV.ThaoTacVoiDoiTuongNhanVien(NV, "Delete"))
              {
                MessageBox.Show("Đã xóa nhân viên " + txtHoTen.Text);
                HienThiDSNhanVien();
                TrangThaiBanDau();
              }
            }
            catch (Exception)
            {
              throw;
            }

            dgvDSNV.FirstDisplayedScrollingRowIndex = rowIndex;
          }

        }
      }
    }

    #endregion




    private void LamMoiDanhSach()
    {
      HienThiDSNhanVien();
      foreach (Control ctr in grbDSNhanVien.Controls)
      {
        if (ctr is TextBox)
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Text = "";
        }

        if (ctr is ComboBox)
        {
          ComboBox ComboBox = (ComboBox)ctr;
          ComboBox.SelectedIndex = 0;
        }
      }
    }


    private void TrangThaiBanDau()
    {

      btnThemAnh.Enabled = btnCapNhat.Enabled = btnInThe.Enabled = false;
      lblMaNV.Text = "";
      foreach (Control ctr in grbTTNhanVien.Controls)
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
          ComboBox.SelectedIndex = -1;
        }
        if (ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;

          DateTimePicker.CustomFormat = " ";
          DateTimePicker.Format = DateTimePickerFormat.Custom;
          DateTimePicker.Enabled = false;
        }
      }

      foreach (Control ctr in grbDSNhanVien.Controls)
      {
        if (ctr is DataGridView)
        {
          DataGridView dgv = (DataGridView)ctr;
          dgv.ClearSelection();
        }
      }

    }









    #region Các sự kiện của DataGridView dgvDSNV




    private void dgvDSNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      TrangThaiBanDau();
    }


    private void dgvDSNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colAnhNhanVien")
      {
        e.Value = new Bitmap(e.Value.ToString());
      }


      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colNgayVaoLam")
      {
        if (DateTime.Parse(e.Value.ToString()).ToShortDateString() != "01/01/0001")
          e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
      }

      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colNgayThoiViec")
      {
        if (e.Value != null)
          e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
      }


      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colGioiTinh")
      {
        if (Convert.ToBoolean(e.Value) == true)
          e.Value = "Nam";
        else e.Value = "Nữ";
      }

      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colChucVu")
      {
        ChucVu_BUS bus = new ChucVu_BUS();
        List<clsChucVu_DTO> lstChucVu = bus.LayDanhSachChucVu();
        clsChucVu_DTO dtoChucVu = lstChucVu.First(u => u.MaChucVu == e.Value.ToString());
        e.Value = dtoChucVu.TenChucVu;
      }

      if (dgvDSNV.Columns[e.ColumnIndex].Name == "colTrangThai")
      {

        TrangThaiNV_BUS bus = new TrangThaiNV_BUS();
        List<clsTrangThaiNV_DTO> lstTrangThaiNV = bus.LayDanhSachTrangThaiNhanVien();
        clsTrangThaiNV_DTO dtoTrangThaiNV = lstTrangThaiNV.First(u => u.MaTrangThaiNV == Convert.ToInt32(e.Value.ToString()));
        e.Value = dtoTrangThaiNV.TenTrangThaiNV;
      }

      foreach (DataGridViewRow r in dgvDSNV.Rows)
      {
        if (Convert.ToInt32(r.Cells["colTrangThai"].Value) == 2) // Đã nghỉ việc
        {
          r.DefaultCellStyle.ForeColor = Color.Gray;
        }
        else if (Convert.ToInt32(r.Cells["colTrangThai"].Value) == 3) // Đang chờ vào làm
          r.DefaultCellStyle.ForeColor = Color.Blue;
        else r.DefaultCellStyle.ForeColor = Color.Black;
      }

    }


    // Biến toàn cục, để khi click chọn 1 row trong DataGridView lưu lại mã nhân viên => Cập nhật nhân viên
    private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
    {

      //if (dgvDSNV.SelectedRows.Count > 0)
      //{
      //  DataGridViewRow r = dgvDSNV.SelectedRows[0];

      //  picAnhDaiDien.Image = Image.FromFile(r.Cells["colAnhNhanVien"].Value.ToString());
      //  //picAnhDaiDien.Image.name
      //  lblMaNV.Text = r.Cells["colMaNV"].Value.ToString();

      //  txtHoTen.Text = r.Cells["colHoTen"].Value.ToString();
      //  txtSoDienThoai.Text = r.Cells["colSDT"].Value.ToString().Trim();
      //  txtDiaChi.Text = r.Cells["colDiaChi"].Value.ToString();

      //  if (Convert.ToBoolean(r.Cells["colGioiTinh"].Value.ToString()))
      //    rdbNam.Checked = true;
      //  else rdbNu.Checked = true;

      //  cboChucVu.SelectedValue = r.Cells["colChucVu"].Value.ToString();
      //  cboTrangThai.SelectedValue = r.Cells["colTrangThai"].Value.ToString();
      //  cboTrangThai.SelectedValue = Convert.ToInt32(r.Cells["colTrangThai"].Value.ToString());

      //  DateTime ngaySinh = DateTime.Parse(r.Cells["colNgaySinh"].Value.ToString());
      //  LayNgayTrongDataGridViewLenDateTimePicker(dtpNgaySinh, ngaySinh);
      //  DateTime ngayVaoLam = DateTime.Parse(r.Cells["colNgayVaoLam"].Value.ToString());
      //  LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayVaoLam, ngayVaoLam);
      //  DateTime ngayThoiViec = DateTime.Parse(r.Cells["colNgayThoiViec"].Value.ToString());
      //  LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayThoiViec, ngayThoiViec);

      //  TrangThaiKhiChonMotNhanVien();
      //}


    }







    #endregion Kết thúc các sự kiện của DataGridView dgvDSNV





    private void TrangThaiKhiChonMotNhanVien()
    {
      btnThemAnh.Enabled = btnCapNhat.Enabled = btnInThe.Enabled = true;
      foreach (Control ctr in grbTTNhanVien.Controls)
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
          if (ComboBox.Name != cboTrangThai.Name)
            ComboBox.Enabled = true;
          else
          {
            if ((int)cboTrangThai.SelectedValue == 2)
              ComboBox.Enabled = true;
            else ComboBox.Enabled = false;
          }

        }
        if (ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;

          //if(DateTimePicker.Name == dtpNgayThoiViec.Name)
          //{
          //  if (cboTrangThai.SelectedIndex == 1)
          //    DateTimePicker.Enabled = true;
          //  else DateTimePicker.Enabled = false;
          //}
          //else
          DateTimePicker.Enabled = true;

        }
      }
    }


    private void LayNgayTrongDataGridViewLenDateTimePicker(DateTimePicker dtp, DateTime? dt)
    {
      if (dt <= DateTime.MinValue || dt >= DateTime.MaxValue || dt == null)
      {
        XoaThoiGianTrenDateTimePicker(dtp);
      }
      else
      {
        dtp.Format = DateTimePickerFormat.Short;
        dtp.Value = new DateTime(dt.Value.Year, dt.Value.Month, dt.Value.Day);
      }
    }



    private void XoaThoiGianTrenDateTimePicker(DateTimePicker dtp)
    {
      dtp.CustomFormat = " ";
      dtp.Format = DateTimePickerFormat.Custom;
    }


    private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }


    #region Chuyển định dạng Ngày Tháng Năm DateTimePicker về Short khi chọn một ngày nào đó
    private void dtpNgaySinh_ValueChanged_1(object sender, EventArgs e)
    {
      //dtpNgaySinh.Format = DateTimePickerFormat.Short;
    }



    private void dtpNgayVaoLam_ValueChanged_1(object sender, EventArgs e)
    {

      if(!dtpNgayVaoLam.Focused)
      {
        return;
      }

      dtpNgayVaoLam.Format = DateTimePickerFormat.Short;

      if(KiemTraNhanVienDaVaoLam()) // DateTime < = DateTime.Now
      {
        if (dtpNgayVaoLam.Value > DateTime.Now && (ngayThoiViecTrongDGV == null || (ngayThoiViecTrongDGV != null && dtpNgayVaoLam.Value < ngayThoiViecTrongDGV)))
          cboTrangThai.SelectedValue = 3;
        else if (ngayThoiViecTrongDGV != null && dtpNgayVaoLam.Value >= ngayThoiViecTrongDGV)
        {
          MessageBox.Show("Không thể chọn thời gian này vì nhân viên đã nghỉ việc");
          dtpNgayVaoLam.Value = ngayVaoLamTrongDGV;

          if(ngayThoiViecTrongDGV <= DateTime.Now)
            cboTrangThai.SelectedValue = 2;
          else cboTrangThai.SelectedValue = 1;
        }
        else if(dtpNgayVaoLam.Value <= DateTime.Now)
          cboTrangThai.SelectedValue = 1;

      }

      else // Nhân viên chưa vào làm
      {
        if (dtpNgayVaoLam.Value <= DateTime.Now && (ngayThoiViecTrongDGV == null || (ngayThoiViecTrongDGV != null && dtpNgayVaoLam.Value < ngayThoiViecTrongDGV)))
          cboTrangThai.SelectedValue = 1;
        else if ((ngayThoiViecTrongDGV != null && dtpNgayVaoLam.Value >= ngayThoiViecTrongDGV))
        {
          MessageBox.Show("Không thể chọn thời gian này vì nhân viên đã nghỉ việc từ " + ngayThoiViecTrongDGV.ToString());
          dtpNgayVaoLam.Value = ngayVaoLamTrongDGV;
          cboTrangThai.SelectedValue = 3;
        }
        else if (dtpNgayVaoLam.Value > DateTime.Now && (ngayThoiViecTrongDGV == null || (ngayThoiViecTrongDGV != null && dtpNgayVaoLam.Value < ngayThoiViecTrongDGV)))
          cboTrangThai.SelectedValue = 3;
      }




    }

    private void dtpNgayThoiViec_ValueChanged(object sender, EventArgs e)
    {

      // -- Giải thích: Khi chưa Focus vào dtpNgayThoiViec -> Chưa làm gì cả
      // -- Khi focus (Chọn ngày tháng năm):
      //----- Trong trường hợp Nhân viên đã vào làm (dtpNgayVaoLam.Value >= DateTime.Now):
      //------- Nếu chọn ngày tháng năm nghỉ việc < = Ngày vào làm -> Sai
      //-------- Nếu chưa nghỉ việc (Chưa có ngày thôi việc) -> Xóa ngày tháng trên dtpNgayThoiViec && gán dtpNgayThoiViec.Value = DateTime.Now cho dễ quản lý (Vì DateTimePicker Bắt buộc phải có giá trị)
      //-------- Nếu đã có ngày thôi việc từ trước -> gán lại ngày thôi việc đó cho dtpNgayThoiViec

      if (!dtpNgayThoiViec.Focused)
        return;

      dtpNgayThoiViec.Format = DateTimePickerFormat.Short;
      if(KiemTraNhanVienDaVaoLam()) // Nếu nhân viên đã vào làm (Ngày tháng năm trên DateTimePicker NgayVaoLam <= DateTime.Now)
      {
        
        if (dtpNgayThoiViec.Value <= dtpNgayVaoLam.Value && dtpNgayThoiViec.Format != DateTimePickerFormat.Custom)
        {
          MessageBox.Show("Nhân viên ĐÃ vào làm từ " + dtpNgayVaoLam.Value.ToShortDateString());
          if (ngayThoiViecTrongDGV == null)
          {
            dtpNgayThoiViec.Value = DateTime.Now;
            dtpNgayThoiViec.CustomFormat = " ";
            dtpNgayThoiViec.Format = DateTimePickerFormat.Custom;
          }
          else
          {
            dtpNgayThoiViec.Format = DateTimePickerFormat.Short;
            LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayThoiViec, ngayThoiViecTrongDGV);
          }
        }
        if (dtpNgayThoiViec.Value > ngayVaoLamTrongDGV && dtpNgayThoiViec.Value <= DateTime.Now)
        {
          cboTrangThai.SelectedValue = 2;
        }
        else if (dtpNgayThoiViec.Value > ngayVaoLamTrongDGV && dtpNgayThoiViec.Value > DateTime.Now)
          cboTrangThai.SelectedValue = 1;
        
      }

      // ---- Nếu nhân viên chưa vào làm (dtpNgayVaoLam.value > DateTime.Now)
      else // Chưa vào làm
      {
        //dtpNgayThoiViec.Format = DateTimePickerFormat.Short;
        if (dtpNgayThoiViec.Value <= dtpNgayVaoLam.Value && dtpNgayThoiViec.Format != DateTimePickerFormat.Custom)
        {
          MessageBox.Show("Nhân viên SẼ vào làm từ " + dtpNgayVaoLam.Value.ToShortDateString());
          if (ngayThoiViecTrongDGV == null)
          {

            //dtpNgayThoiViec.Value = DateTime.Now;
            MessageBox.Show(dtpNgayThoiViec.Value.ToShortDateString());
            dtpNgayThoiViec.CustomFormat = " ";
            dtpNgayThoiViec.Format = DateTimePickerFormat.Custom;
          }
          else
          {
            dtpNgayThoiViec.Format = DateTimePickerFormat.Short;
            LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayThoiViec, ngayThoiViecTrongDGV);
          }
        }
        if (dtpNgayThoiViec.Value > ngayVaoLamTrongDGV && dtpNgayThoiViec.Value <= DateTime.Now)
        {
          cboTrangThai.SelectedValue = 2;
        }
        else if (dtpNgayThoiViec.Value > ngayVaoLamTrongDGV && dtpNgayThoiViec.Value > DateTime.Now)
          cboTrangThai.SelectedValue = 3;

      }

    }





    #endregion



    #region TÌM KIẾM

    private void txtHoTen_TK_TextChanged(object sender, EventArgs e)
    {
      //if (string.IsNullOrWhiteSpace(txtHoTen_TK.Text))
      //  txtHoTen_TK.Text = "Tìm kiếm theo tên";

      TimKiemNhanVien();

    }

    private void cboTrangThai_TK_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cbo = (ComboBox)sender;
      if (!cbo.Focused)
        return;

      TimKiemNhanVien();
    }


    private void cboChucVu_TK_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cbo = (ComboBox)sender;
      if (!cbo.Focused)
        return;
      TimKiemNhanVien();
    }

    private void cboGioiTinh_TK_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cbo = (ComboBox)sender;
      if (!cbo.Focused)
        return;
      TimKiemNhanVien();
    }

    private void TimKiemNhanVien()
    {
      string hoTen = txtHoTen_TK.Text;
      string maChucVu = cboChucVu_TK.SelectedValue.ToString();
      int gioiTinh = -1;
      if (cboGioiTinh_TK.SelectedIndex == 1)
        gioiTinh = 1;
      else if (cboGioiTinh_TK.SelectedIndex == 2)
        gioiTinh = 0;
      int trangThai = cboTrangThai_TK.SelectedIndex;
      int trangThai2 = -1; // Cái này dùng cho Phân Công - Tái sử dụng hàm :))
      NhanVien_BUS bus = new NhanVien_BUS();

      List<clsNhanVien_DTO> lstNhanVien = bus.LayDanhSachNhanVienCoChonLoc(hoTen, maChucVu, gioiTinh, trangThai, trangThai2);
      dgvDSNV.AutoGenerateColumns = false;
      dgvDSNV.DataSource = lstNhanVien;
    }


    #endregion KẾT THÚC TÌM KIẾM

    private void dgvDSNV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      //var grid = sender as DataGridView;
      //var rowIdx = (e.RowIndex + 1).ToString();

      //var centerFormat = new StringFormat()
      //{
      //  // right alignment might actually make more sense for numbers
      //  Alignment = StringAlignment.Center,
      //  LineAlignment = StringAlignment.Center
      //};

      //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
      //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
    }

    DateTime? ngayThoiViecTrongDGV = null; // lưu lại ngày thôi việc trong DataGridView nếu có
    int trangThaiNVTrongDGV;
    DateTime ngayVaoLamTrongDGV;
    private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
    {
      try
      {
        if (!dgvDSNV.Focused)
          return;
        if (dgvDSNV.SelectedRows.Count > 0)
        {
          DataGridViewRow r = dgvDSNV.SelectedRows[0];

          picAnhDaiDien.Image = Image.FromFile(r.Cells["colAnhNhanVien"].Value.ToString());
          //picAnhDaiDien.Image.name
          lblMaNV.Text = r.Cells["colMaNV"].Value.ToString();

          txtHoTen.Text = r.Cells["colHoTen"].Value.ToString();
          txtSoDienThoai.Text = r.Cells["colSDT"].Value.ToString().Trim();
          txtDiaChi.Text = r.Cells["colDiaChi"].Value.ToString();

          if (Convert.ToBoolean(r.Cells["colGioiTinh"].Value.ToString()))
            rdbNam.Checked = true;
          else rdbNu.Checked = true;

          cboChucVu.SelectedValue = r.Cells["colChucVu"].Value.ToString();

          trangThaiNVTrongDGV = Convert.ToInt32(r.Cells["colTrangThai"].Value.ToString());
          //cboTrangThai.SelectedValue = r.Cells["colTrangThai"].Value.ToString();
          cboTrangThai.SelectedValue = Convert.ToInt32(r.Cells["colTrangThai"].Value.ToString());

          DateTime ngaySinh = DateTime.Parse(r.Cells["colNgaySinh"].Value.ToString());
          LayNgayTrongDataGridViewLenDateTimePicker(dtpNgaySinh, ngaySinh);

          ngayVaoLamTrongDGV = DateTime.Parse(r.Cells["colNgayVaoLam"].Value.ToString());
          DateTime ngayVaoLam = DateTime.Parse(r.Cells["colNgayVaoLam"].Value.ToString());
          LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayVaoLam, ngayVaoLam);



          if (r.Cells["colNgayThoiViec"].Value == null)
          {
            dtpNgayThoiViec.Value = DateTime.Now;
            dtpNgayThoiViec.CustomFormat = " ";
            dtpNgayThoiViec.Format = DateTimePickerFormat.Custom;
            //MessageBox.Show(dtpNgayThoiViec.Value.ToShortDateString());
          }
          else
          {
            ngayThoiViecTrongDGV = DateTime.Parse(r.Cells["colNgayThoiViec"].Value.ToString());
            //dtpNgayThoiViec.Format = DateTimePickerFormat.Short;
            DateTime? ngayThoiViec2 = null;
            ngayThoiViec2 = DateTime.Parse(r.Cells["colNgayThoiViec"].Value.ToString());
            LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayThoiViec, ngayThoiViec2);
          }
          //if (dtpNgayThoiViec.Format == DateTimePickerFormat.Custom)
          //  MessageBox.Show("custom");
          //else MessageBox.Show("Short");



          TrangThaiKhiChonMotNhanVien();
        }
      }
      catch (Exception)
      {

      }
    }

    private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!cboTrangThai.Focused)
        return;

      if ((int)cboTrangThai.SelectedValue == 1)
      {
        if (ngayThoiViecTrongDGV <= DateTime.Now)
        {
          dtpNgayThoiViec.CustomFormat = " ";
          dtpNgayThoiViec.Format = DateTimePickerFormat.Custom;
        }
      }
      else if((int)cboTrangThai.SelectedValue == 2)
      {
        LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayThoiViec, ngayThoiViecTrongDGV);
        dtpNgayVaoLam.Value = ngayVaoLamTrongDGV;
      }
      else
      {
        dtpNgayVaoLam.CustomFormat = " ";
        dtpNgayVaoLam.Format = DateTimePickerFormat.Custom;
      }
        
    }








  }
}
