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
  public partial class urcChiTietBanPhanCong : UserControl
  {
    public urcChiTietBanPhanCong()
    {
      InitializeComponent();
    }

    public void urcChiTietBanPhanCong_Load(object sender, EventArgs e)
    {
      TrangThaiBanDau();
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang, "Ca001");
      //HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang1, "Ca001");
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaChieu, "Ca002");
    }

    private void dtpNgayLam_ValueChanged(object sender, EventArgs e)
    {
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang, "Ca001");
      //HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang1, "Ca001");
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaChieu, "Ca002");
    }

    private void HienThiDSPhanCongLlenDataGridView(DataGridView dgv, string ca)
    {
      ChiTietBanPhanCong_BUS busCaSang = new ChiTietBanPhanCong_BUS();
      List<clsChiTietBanPhanCong_DTO> lstCTBPC = busCaSang.LayDSPCTheoNgayVaCa(dtpNgayLam.Value, ca, "ngayLam");
      dgv.AutoGenerateColumns = false;
      dgv.DataSource = lstCTBPC;
    }


    #region DataGridView Danh Sách Nhân Viên Ca Sáng
    private void dgvDSNVCaSang_SelectionChanged(object sender, EventArgs e)
    {
      if (!dgvDSNVCaSang.Focused)
        return;

      dgvDSNVCaChieu.Enabled = false;
      if (dgvDSNVCaSang.Rows.Count > 0)
      {
        if (dgvDSNVCaSang.SelectedRows.Count > 0)
        {

          TrangThaiKhiChonMotDong();


          DataGridViewRow row = dgvDSNVCaSang.SelectedRows[0];
          if (row.Cells["colTrangThaiSang"].Value.ToString() == "1")
            rdbDiLam.Checked = true;
          else if (row.Cells["colTrangThaiSang"].Value.ToString() == "2")
            rdbDiTre.Checked = true;
          else if (row.Cells["colTrangThaiSang"].Value.ToString() == "3")
            rdbNghiCoPhep.Checked = true;
          else if (row.Cells["colTrangThaiSang"].Value.ToString() == "4")
            rdbNghiKhongPhep.Checked = true;
          else rdbChuaChapCong.Checked = true;

        }

      }
    }

    //List<clsTrangThaiBanPhanCong_DTO> lstTTBanPhanCong = BUS.TrangThaiBanPhanCong_BUS.LayDSTrangThaiBPC();
    //clsTrangThaiBanPhanCong_DTO dtoTTBanPhanCong;

    private void dgvDSNVCaSang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSNVCaSang.Rows.Count > 0)
      {
        if (dgvDSNVCaChieu.Columns[e.ColumnIndex].Name == "colHoTenChieu")
        {
          NhanVien_BUS busNV = new NhanVien_BUS();
          List<clsNhanVien_DTO> lstNV = busNV.LayNhanVienTheoTenHoacMaa("", "");
          clsNhanVien_DTO dtoNV = lstNV.Find(u => u.MaNhanVien == e.Value.ToString());
          e.Value = dtoNV.HoTen;
        }

        if (dgvDSNVCaSang.Columns[e.ColumnIndex].Name == "colTrangThaiSang")
        {

          dtoTTBPC = listTTBPC.Find(u => u.MaTrangThaiBanPhanCong == (int)e.Value);
          e.Value = dtoTTBPC.TenTrangThaiBanPhanCong;
        }

        foreach (DataGridViewRow row in dgvDSNVCaSang.Rows)
        {
          if (row.Cells["colTrangThaiSang"].Value.ToString() == "5")
            row.DefaultCellStyle.ForeColor = Color.Blue;
          else
            row.DefaultCellStyle.ForeColor = Color.Black;
        }
      }
    }


    private void dgvDSNVCaSang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

    private void dgvDSNVCaSang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      TrangThaiBanDau();
    }


    #endregion DataGridView Danh Sách Nhân Viên Ca Sáng




    #region DataGridView Danh Sách Nhân Viên Ca Chiều
    private void dgvDSNVCaChieu_SelectionChanged(object sender, EventArgs e)
    {
      if (!dgvDSNVCaChieu.Focused)
        return;

      dgvDSNVCaSang.Enabled = false;
      if (dgvDSNVCaChieu.Rows.Count > 0)
      {
        if (dgvDSNVCaChieu.SelectedRows.Count > 0)
        {
          TrangThaiKhiChonMotDong();

          DataGridViewRow row = dgvDSNVCaChieu.SelectedRows[0];
          if (row.Cells["colTrangThaiChieu"].Value.ToString() == "1")
            rdbDiLam.Checked = true;
          else if (row.Cells["colTrangThaiChieu"].Value.ToString() == "2")
            rdbDiTre.Checked = true;
          else if (row.Cells["colTrangThaiChieu"].Value.ToString() == "3")
            rdbNghiCoPhep.Checked = true;
          else if (row.Cells["colTrangThaiChieu"].Value.ToString() == "4")
            rdbNghiKhongPhep.Checked = true;
          else rdbChuaChapCong.Checked = true;

        }
      }
    }

    List<clsTrangThaiBanPhanCong_DTO> listTTBPC = BUS.TrangThaiBanPhanCong_BUS.LayDSTrangThaiBPC();
    clsTrangThaiBanPhanCong_DTO dtoTTBPC;
    private void dgvDSNVCaChieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSNVCaChieu.Rows.Count > 0)
      {
        if (dgvDSNVCaChieu.Columns[e.ColumnIndex].Name == "colHoTenChieu")
        {
          NhanVien_BUS busNV = new NhanVien_BUS();
          List<clsNhanVien_DTO> lstNV = busNV.LayNhanVienTheoTenHoacMaa("", "");
          clsNhanVien_DTO dtoNV = lstNV.Find(u => u.MaNhanVien == e.Value.ToString());
          e.Value = dtoNV.HoTen;
        }

        if (dgvDSNVCaChieu.Columns[e.ColumnIndex].Name == "colTrangThaiChieu")
        {

          dtoTTBPC = listTTBPC.Find(u => u.MaTrangThaiBanPhanCong == (int)e.Value);
          e.Value = dtoTTBPC.TenTrangThaiBanPhanCong;
        }

        foreach (DataGridViewRow row in dgvDSNVCaChieu.Rows)
        {
          if (row.Cells["colTrangThaiChieu"].Value.ToString() == "5")
            row.DefaultCellStyle.ForeColor = Color.Blue;
          else row.DefaultCellStyle.ForeColor = Color.Black;
        }
      }
    }

    private void dgvDSNVCaChieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

    private void dgvDSNVCaChieu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      TrangThaiBanDau();
    }

    #endregion DataGridView Danh Sách Nhân Viên Ca Chiều



    private void TrangThaiBanDau()
    {
      foreach (Control ctr in grbChamCong.Controls)
      {
        if (ctr is RadioButton)
        {
          RadioButton RadioButton = (RadioButton)ctr;
          RadioButton.Checked = false;
          RadioButton.Enabled = false;
        }

        if (ctr is Button)
        {
          Button Button = (Button)ctr;
          Button.Enabled = false;
        }

        if (ctr is DataGridView)
        {
          DataGridView dgv = (DataGridView)ctr;
          dgv.ClearSelection();
          dgv.Enabled = true;
        }
      }
    }

    private void TrangThaiKhiChonMotDong()
    {
      foreach (Control ctr in grbChamCong.Controls)
      {
        if (ctr is RadioButton)
        {
          RadioButton RadioButton = (RadioButton)ctr;
          RadioButton.Checked = false;
          RadioButton.Enabled = true;
        }

        if (ctr is Button)
        {
          Button Button = (Button)ctr;
            Button.Enabled = true;
        }
      }
    }


    private bool CheckIfOneRadioButtonIsChecked()
    {
      if (rdbDiLam.Checked || rdbDiTre.Checked || rdbNghiCoPhep.Checked || rdbNghiKhongPhep.Checked)
        return true;
      else return false;
    }


    private void btnHuyThaoTac_Click(object sender, EventArgs e)
    {
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang, "Ca001");
      HienThiDSPhanCongLlenDataGridView(dgvDSNVCaChieu, "Ca002");
      TrangThaiBanDau();
    }

    private void rdbDiLam_CheckedChanged(object sender, EventArgs e)
    {
      btnLuuThayDoi.Enabled = true;
    }

    private void rdbDiTre_CheckedChanged(object sender, EventArgs e)
    {
      btnLuuThayDoi.Enabled = true;
    }

    private void rdbNghiCoPhep_CheckedChanged(object sender, EventArgs e)
    {
      btnLuuThayDoi.Enabled = true;
    }

    private void rdbNghiKhongPhep_CheckedChanged(object sender, EventArgs e)
    {
      btnLuuThayDoi.Enabled = true;
    }

    private void btnLuuThayDoi_Click(object sender, EventArgs e)
    {
      if(DialogResult.Yes == MessageBox.Show("Lưu thay đổi", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      { 
        string Id = "";
        DataGridViewRow row;
        if (dgvDSNVCaSang.Enabled == true)
        { 
          row = dgvDSNVCaSang.SelectedRows[0];
          Id = row.Cells["colMaBanGhiSang"].Value.ToString();
        }
        else
        {
          row = dgvDSNVCaChieu.SelectedRows[0];
          Id = row.Cells["colMaBanGhiChieu"].Value.ToString();
        }

        int trangThai = XetTrangThai();


        ChiTietBanPhanCong_BUS bus = new ChiTietBanPhanCong_BUS();
        if (bus.Update(Id, trangThai))
          MessageBox.Show("Đã chấm công");
        if (dgvDSNVCaSang.Enabled == true)
          HienThiDSPhanCongLlenDataGridView(dgvDSNVCaSang, "Ca001");
        else HienThiDSPhanCongLlenDataGridView(dgvDSNVCaChieu, "Ca002");

        TrangThaiBanDau();
      }

    }

    private int XetTrangThai()
    {
      int trangThai = 5;
      if (rdbDiLam.Checked)
        trangThai = 1;
      else if (rdbDiTre.Checked)
        trangThai = 2;
      else if (rdbNghiCoPhep.Checked)
        trangThai = 3;
      else if (rdbNghiKhongPhep.Checked)
        trangThai = 4;

      return trangThai;
    }



    private void rdbDiLam_EnabledChanged(object sender, EventArgs e)
    {
      rdbDiLam.ForeColor = Color.Black;
    }

    private void rdbDiTre_EnabledChanged(object sender, EventArgs e)
    {
      rdbDiTre.ForeColor = Color.Black;
    }

    private void rdbNghiCoPhep_EnabledChanged(object sender, EventArgs e)
    {
      rdbNghiCoPhep.ForeColor = Color.Black;
    }

    private void rdbNghiKhongPhep_EnabledChanged(object sender, EventArgs e)
    {
      rdbNghiKhongPhep.ForeColor = Color.Black;
    }

    private void btnHuyThaoTac_EnabledChanged(object sender, EventArgs e)
    {
      btnHuyThaoTac.ForeColor = Color.Black;
    }

    








  }
}
