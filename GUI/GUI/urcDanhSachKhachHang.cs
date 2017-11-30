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
  public partial class urcDanhSachKhachHang : UserControl
  {
    public urcDanhSachKhachHang()
    {
      InitializeComponent();
    }

    Utilities utl = new Utilities();
    public void urcDanhSachKhachHang_Load(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      HienThiDSKhachHang();
    }


    private void HienThiDSKhachHang()
    {
      KhachHang_BUS bus = new KhachHang_BUS();
      List<clsKhachHang_DTO> lstKH = bus.LayDanhSachKhachHang("", -1);
      dgvDSKH.AutoGenerateColumns = false;
      dgvDSKH.DataSource = lstKH;
    }



    #region CÁC NÚT CHỨC NĂNG (Cập nhật, Hủy thao tác)

    private bool KiemTraKhachHangDaCoThe(string maKH)
    {
      TheKhachHang_BUS bus = new TheKhachHang_BUS();
      return bus.KiemTraKhachHangDaCoThe(maKH);
    }




    private clsTheKhachHang TaoDoiTuongTheKhachHang()
    {
      string maThe = TuPhatSinhMaTheKhachHang();
      string maKH = txtMaKH.Text;
      string maLoaiThe = "1234567890";
      DateTime ngayDK = DateTime.Now;
      bool trangThai = true;

      return utl.TaoDoiThuongTheKhachHang(maThe, maKH, maLoaiThe, ngayDK, trangThai);
    }

    private string TuPhatSinhMaTheKhachHang()
    {
      TheKhachHang_BUS bus = new TheKhachHang_BUS();
      return bus.LayMaTheKhachHang();
    }




    private string strError = "";
    private string strWarning = "";

    private void btnCapNhat_Click(object sender, EventArgs e)
    {
      if (KiemTraDuLieuHopLe())
      {
        string strThongBao = "Cập nhật khách hàng  " + txtHoTen.Text;
        MessageBoxIcon MBIcon = MessageBoxIcon.Question;
        MessageBoxButtons MBButton = MessageBoxButtons.OK;

        if(strWarning != "")
        {
          strThongBao = strWarning + "\n Vẫn muốn tiếp tục?";
          MBIcon = MessageBoxIcon.Warning;
          MBButton = MessageBoxButtons.YesNo;
        }

        if (DialogResult.Yes == MessageBox.Show(strThongBao, "Cập nhật", MBButton, MBIcon))
        {

          KhachHang_BUS bus = new KhachHang_BUS();
          clsKhachHang_DTO KH = TaoDoiTuongKhachHang();
          if(bus.ThaoTacVoiKhachHang(KH, "Update"))
          {
            MessageBox.Show("Cập nhật thành công");
            TrangThaiBanDau();
            HienThiDSKhachHang();
          }

        }
        
      }
      else MessageBox.Show(strError, "Dữ liệu không chính xác", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
      strWarning = "";
      strError = "";

    }

    
    private void btnHuyThaoTac_Click(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      
      LamMoiDanhSach();
    }

    #endregion

    private clsKhachHang_DTO TaoDoiTuongKhachHang()
    {
      string maKH = txtMaKH.Text;
      string tenKH = txtHoTen.Text;
      bool gioiTinh = (rdbNam.Checked ? true : false);
      DateTime ngaySinh = dtpNgaySinh.Value;
      string SDT = txtSoDienThoai.Text;
      string diaChi = txtDiaChi.Text;
      bool trangThai = true;

      return utl.TaoDoiTuongKhachHang(maKH, tenKH, gioiTinh, ngaySinh, SDT, diaChi, trangThai);
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
        else strWarning += " *Khách hàng chưa có số điện thoại\n";
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

      if (!KiemTraNgaySinh())
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

    private bool KiemTraNgaySinh()
    {
      return (utl.KiemTraDateTimePicker(dtpNgaySinh) && utl.KiemTraTuoi(15, dtpNgaySinh));
    }



    #region CÁC SỰ KIỆN DATAGRIDVIEW


    private void dgvDSKH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      TrangThaiBanDau();
    }


    private void dgvDSKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSKH.Columns[e.ColumnIndex].Name.ToString() == "colGioiTinh")
      {
        if (Convert.ToBoolean(e.Value) == true)
          e.Value = "Nam";
        else e.Value = "Nữ";
      }

      if (dgvDSKH.Columns[e.ColumnIndex].Name.ToString() == "colTrangThai")
      {
        if (Convert.ToBoolean(e.Value) == true)
          e.Value = "Có sẵn";
        else e.Value = "Đã xóa";
      }

      if (dgvDSKH.Columns[e.ColumnIndex].Name.ToString() == "colNgaySinh")
      {
        e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
      }

      foreach (DataGridViewRow r in dgvDSKH.Rows)
      {
        if (!Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()))
          r.DefaultCellStyle.ForeColor = Color.Gray;
        else r.DefaultCellStyle.ForeColor = Color.Black;

      }
    }
    
    private void dgvDSKH_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        if (DialogResult.Yes == MessageBox.Show("Xóa khách hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        {
          TheKhachHang_BUS busTheKH = new TheKhachHang_BUS();
          KhachHang_BUS busKH = new KhachHang_BUS();
          if (busKH.Xoa(txtMaKH.Text) && busTheKH.Xoa(txtMaKH.Text))
          {
            //MessageBox.Show("Đã xóa khách hàng");
            TrangThaiBanDau();
            HienThiDSKhachHang();
          }
        }
        else MessageBox.Show("Hủy thao tác");
      }
    }

    #endregion CÁC SỰ KIỆN DATAGRIDVIEW


    private void LayNgayTrongDataGridViewLenDateTimePicker(DateTimePicker dtp, DateTime dt)
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


    private void LamMoiDanhSach()
    {
      HienThiDSKhachHang();
      foreach (Control ctr in grbDSKhachHang.Controls)
      {
        if (ctr is TextBox)
        {
          TextBox TextBox = (TextBox)ctr;
          TextBox.Text = "";
        }

        if (ctr is RadioButton)
        {
          RadioButton RadioButton = (RadioButton)ctr;
          RadioButton.Checked = false;
        }
      }
    }


    private void TrangThaiBanDau()
    {

      btnCapNhat.Enabled = false;
      rdbTrangThaiCoSan.Checked = false;
      rdbTrangThaiCoSan.Enabled = false;
      foreach (Control ctr in grbTTKhachHang.Controls)
      {
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

      foreach (Control ctr in grbDSKhachHang.Controls)
      {
        if (ctr is DataGridView)
        {
          DataGridView dgv = (DataGridView)ctr;
          dgv.ClearSelection();
        }
      }
    }


    private void TrangThaiKhiChonMotKhachHang()
    {
      rdbTrangThaiCoSan.Enabled = true;
      btnCapNhat.Enabled = true;
      foreach (Control ctr in grbTTKhachHang.Controls)
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
        if (ctr is DateTimePicker)
        {
          DateTimePicker DateTimePicker = (DateTimePicker)ctr;
          DateTimePicker.Enabled = true;
        }
      }
    }

    #region Chuyển đổi Format của DataTimePicker thành Short khi click chọn ngày nào đó
    private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
    {
      dtpNgaySinh.Format = DateTimePickerFormat.Short;
    }
    #endregion

    #region Tìm kiếm
    private void TimKiem()
    {
      string hoTen = txtHoTen_TK.Text;
      int trangThai = -1;
      if (rdbTrangThaiCoSan_TK.Checked)
        trangThai = 1;
      else if (rdbTrangThaiDaXoa_TK.Checked)
        trangThai = 0;
      KhachHang_BUS bus = new KhachHang_BUS();
      List<clsKhachHang_DTO> lstKH = bus.LayDanhSachKhachHang(hoTen, trangThai);
      dgvDSKH.AutoGenerateColumns = false;
      dgvDSKH.DataSource = lstKH;

    }

    private void txtHoTen_TK_TextChanged(object sender, EventArgs e)
    {
      TimKiem();
    }

    private void rdbTrangThaiCoSan_TK_CheckedChanged(object sender, EventArgs e)
    {
      TimKiem();
    }

    private void rdbTrangThaiDaXoa_TK_CheckedChanged(object sender, EventArgs e)
    {
      TimKiem();
    }

    #endregion

    private void dgvDSKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      //var grid = sender as DataGridView;
      //var rowIdx = (e.RowIndex + 1).ToString();

      //var centerFormat = new StringFormat()
      //{
      //  Alignment = StringAlignment.Center,
      //  LineAlignment = StringAlignment.Center
      //};

      //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
      //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
    }


    private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      //if (dgvDSKH.SelectedRows.Count > 0)
      //{
      //  DataGridViewRow r = dgvDSKH.SelectedRows[0];

      //  txtMaKH.Text = r.Cells["colMaKH"].Value.ToString();
      //  txtHoTen.Text = r.Cells["colTenKH"].Value.ToString();
      //  txtDiaChi.Text = r.Cells["colDiaChi"].Value.ToString();
      //  txtSoDienThoai.Text = r.Cells["colSDT"].Value.ToString();
      //  if (r.Cells["colEmail"].Value != null)
      //    txtEmail.Text = r.Cells["colEmail"].Value.ToString();

      //  if (Convert.ToBoolean(r.Cells["colGioiTinh"].Value.ToString()) == true)
      //    rdbGioiTinhNam.Checked = true;
      //  else rdbGioiTinhNu.Checked = true;

      //  if (Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()) == true)
      //    rdbTrangThaiCoSan.Checked = true;
      //  else rdbTrangThaiDaXoa.Checked = true;

      //  DateTime dtNgaySinh = DateTime.Parse(r.Cells["colNgaySinh"].Value.ToString());
      //  LayNgayTrongDataGridViewLenDateTimePicker(dtpNgaySinh, dtNgaySinh);

      //  TrangThaiKhiChonMotKhachHang();
      //}
    }


    private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
    {
      if (!dgvDSKH.Focused)
        return;

      if (dgvDSKH.SelectedRows.Count > 0)
      {
        DataGridViewRow r = dgvDSKH.SelectedRows[0];

        txtMaKH.Text = r.Cells["colMaKH"].Value.ToString();
        txtHoTen.Text = r.Cells["colTenKH"].Value.ToString();
        txtDiaChi.Text = r.Cells["colDiaChi"].Value.ToString();
        txtSoDienThoai.Text = r.Cells["colSDT"].Value.ToString().Trim();
        if (r.Cells["colEmail"].Value != null)
          //txtEmail.Text = r.Cells["colEmail"].Value.ToString();

        if (Convert.ToBoolean(r.Cells["colGioiTinh"].Value.ToString()) == true)
          rdbNam.Checked = true;
        else rdbNu.Checked = true;

        if (Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()) == true)
          rdbTrangThaiCoSan.Checked = true;
        else rdbTrangThaiCoSan.Checked = false;

        DateTime dtNgaySinh = DateTime.Parse(r.Cells["colNgaySinh"].Value.ToString());
        LayNgayTrongDataGridViewLenDateTimePicker(dtpNgaySinh, dtNgaySinh);

        TrangThaiKhiChonMotKhachHang();
      }
    }

    private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
    }





    private void txtHoTen_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraHoTen())
        txtHoTen.ForeColor = Color.Black;
      else txtHoTen.ForeColor = Color.Red;
    }

    private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraSDT(10, 13))
        txtSoDienThoai.ForeColor = Color.Black;
      else txtSoDienThoai.ForeColor = Color.Red;
    }

    private void txtDiaChi_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraDiaChi(15, 250))
        txtDiaChi.ForeColor = Color.Black;
      else txtDiaChi.ForeColor = Color.Red;
    }









  }
}
