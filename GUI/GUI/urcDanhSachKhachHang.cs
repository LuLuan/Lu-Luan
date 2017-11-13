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

    public void urcDanhSachKhachHang_Load(object sender, EventArgs e)
    {
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

    private void btnThemTheKH_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Thêm thẻ cho khách hàng " + txtHoTen.Text);

    }

    private void btnCapNhat_Click(object sender, EventArgs e)
    {

    }

    private void btnHuyThaoTac_Click(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      LamMoiDanhSach();
    }

    #endregion



    #region CÁC SỰ KIỆN DATAGRIDVIEW


    private void dgvDSKH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      //TrangThaiBanDau();
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
    }

    private void dgvDSKH_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        DataGridViewRow row = dgvDSKH.SelectedRows[0];
        MessageBox.Show("Bạn muốn xóa khách hàng " + row.Cells["colMaKH"].Value.ToString() + "\nCó mã " + row.Cells["colHoTen"].Value.ToString());
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

      btnCapNhat.Enabled = btnThemTheKH.Enabled = false;
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
      btnCapNhat.Enabled = btnThemTheKH.Enabled = true;
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

    private void dgvDSKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      var grid = sender as DataGridView;
      var rowIdx = (e.RowIndex + 1).ToString();

      var centerFormat = new StringFormat()
      {
        // right alignment might actually make more sense for numbers
        Alignment = StringAlignment.Center,
        LineAlignment = StringAlignment.Center
      };

      var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
      e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
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

    private void rdbGioiTinhNam_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
    {
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
          rdbGioiTinhNam.Checked = true;
        else rdbGioiTinhNu.Checked = true;

        if (Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()) == true)
          rdbTrangThaiCoSan.Checked = true;
        else rdbTrangThaiDaXoa.Checked = true;

        DateTime dtNgaySinh = DateTime.Parse(r.Cells["colNgaySinh"].Value.ToString());
        LayNgayTrongDataGridViewLenDateTimePicker(dtpNgaySinh, dtNgaySinh);

        TrangThaiKhiChonMotKhachHang();
      }
    }

    private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
    }









  }
}
