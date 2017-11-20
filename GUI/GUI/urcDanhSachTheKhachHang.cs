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
  public partial class urcDanhSachTheKhachHang : UserControl
  {
    public urcDanhSachTheKhachHang()
    {
      InitializeComponent();
    }

    ThaoTacChung ttc = new ThaoTacChung();


    public void urcDanhSachTheKhachHang_Load(object sender, EventArgs e)
    {
      HienThiDSTheKhachHang();
      TrangThaiBanDau();
    }

    private void HienThiDSTheKhachHang()
    {
      TheKhachHang_BUS theKH_BUS = new TheKhachHang_BUS();
      List<clsTheKhachHang> lstTheKH = theKH_BUS.LayDanhSachTheKH("", "");
      //LoaiTheKhachHang_BUS loaiTheKH_BUS = new LoaiTheKhachHang_BUS();
      //List<clsLoaiTheKhachHang> lstLoaiTheKH = loaiTheKH_BUS.LayLoaiTheKhachHang();

      //var query = from theKH in lstTheKH
      //            join loaiTheKH in lstLoaiTheKH
      //            on theKH.MaLoaiThe equals loaiTheKH.MaLoaiThe
      //            select new
      //            {
      //              theKH.MaThe,
      //              theKH.MaKhachHang,
      //              theKH.MaLoaiThe,
      //              theKH.NgayDangKy,
      //              theKH.TrangThai,
      //              loaiTheKH.TenLoaiTheKH,
      //              loaiTheKH.DonViGiamGia,
      //              loaiTheKH.GiamGia
      //            };
      dgvDSTheKH.AutoGenerateColumns = false;
      dgvDSTheKH.DataSource = lstTheKH;
      //dgvDSTheKH.DataSource = query.ToList();


    }

    #region Các sự kiện của Datagridview



    private void dgvDSTheKH_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
        MessageBox.Show("Xóa thẻ ?");
    }

    private void dgvDSTheKH_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      //if(dgvDSTheKH.SelectedRows.Count > 0)
      //{

      //    DataGridViewRow r = dgvDSTheKH.SelectedRows[0];
      //    txtMaTheKH.Text = r.Cells["colMaThe"].Value.ToString();
      //    txtTenKH.Text = r.Cells["colTenKH"].Value.ToString();
      //    txtLoaiThe.Text = r.Cells["colLoaiThe"].Value.ToString();

      //    if (Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()))
      //        rdbTrangThaiMo.Checked = true;
      //    else rdbTrangThaiDong.Checked = true;

      //    DateTime dtNgayDangKy = DateTime.Parse(r.Cells["colNgayDangKy"].Value.ToString());
      //    DateTime dtNgayHetHan = dtNgayDangKy.AddDays(365);
      //    ttc.LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayHetHanTheKH, dtNgayHetHan);



      //    TrangThaiKhiChonMotTheKH();
      //}
    }

    private void dgvDSTheKH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      TrangThaiBanDau();
    }

    private void dgvDSTheKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colTrangThai")
        if (Convert.ToBoolean(e.Value) == true)
          e.Value = "Mở";
        else e.Value = "Khóa";

      if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colTenKH")
      {
        KhachHang_BUS bus = new KhachHang_BUS();
        List<clsKhachHang_DTO> lstKH = bus.LayDanhSachKhachHang("", -1);
        clsKhachHang_DTO KH = lstKH.First(u => u.MaKhachHang == e.Value.ToString());
        e.Value = KH.TenKhachHang;
      }


      LoaiTheKhachHang_BUS LoaiTheKH_bus = new LoaiTheKhachHang_BUS();
      List<clsLoaiTheKhachHang> lstLoaiTheKH = LoaiTheKH_bus.LayLoaiTheKhachHang();

      if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colLoaiThe")
      {
        
        clsLoaiTheKhachHang LoaiTheKH = lstLoaiTheKH.First(u => u.MaLoaiThe == e.Value.ToString());
        e.Value = LoaiTheKH.TenLoaiTheKH;
      }

      //if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colGiamGia")
      //{
      //  e.Value = lstLoaiTheKH[0].GiamGia;
      //}

      //if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colDonViGiamGia")
      //{
      //  e.Value = lstLoaiTheKH[0].DonViGiamGia;
      //}





      if (dgvDSTheKH.Columns[e.ColumnIndex].Name.ToString() == "colNgayDangKy")
      {
        e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
      }


      foreach (DataGridViewRow r in dgvDSTheKH.Rows)
      {
        if (!Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()))
          r.DefaultCellStyle.ForeColor = Color.Gray;
        else r.DefaultCellStyle.ForeColor = Color.Black;

      }
    }
    #endregion

    #region Các nút chức năng (Cập nhật, Hủy thao tác)

    private void btnHuyThaoTac_Click(object sender, EventArgs e)
    {

    }
    private void btnCapNhat_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Cập nhật");
    }

    #endregion


    private void TrangThaiBanDau()
    {
      btnCapNhat.Enabled = false;
      ttc.TrangThaiBanDau(grbTTTheKH, grbDSTheKH);
    }

    private void TrangThaiKhiChonMotTheKH()
    {
      btnCapNhat.Enabled = true;
      ttc.TrangThaiKhiChonMotDongTrongDataGridView(grbTTTheKH);
      txtLoaiThe.Enabled = false;
    }

    private void dgvDSTheKH_SelectionChanged(object sender, EventArgs e)
    {
      if (dgvDSTheKH.SelectedRows.Count > 0)
      {
        DataGridViewRow r = dgvDSTheKH.SelectedRows[0];
        txtMaTheKH.Text = r.Cells["colMaThe"].Value.ToString();
        txtTenKH.Text = r.Cells["colTenKH"].Value.ToString();
        txtLoaiThe.Text = r.Cells["colLoaiThe"].Value.ToString();

        if (Convert.ToBoolean(r.Cells["colTrangThai"].Value.ToString()))
          rdbTrangThaiMo.Checked = true;
        else rdbTrangThaiDong.Checked = true;


        TrangThaiKhiChonMotTheKH();
      }
    }





  }
}
