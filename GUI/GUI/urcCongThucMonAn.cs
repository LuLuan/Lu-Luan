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
  public partial class urcCongThucMonAn : UserControl
  {
    public urcCongThucMonAn()
    {
      InitializeComponent();
    }

   // DataGridViewRow dtvr;
    private string ChuoiTimKiemNL = "";
    private string MaDuocChon = urcDanhSachSanPham.MaMonAnDuocChon.ToString();
    private List<clsMonAn_DTO> lstMonAnTP = urcDanhSachSanPham.lstMonAn;
    //  private List<clsThanhPhanMonAn_DTO> lstMonAnTP;
    // private List<clsThanhPhanMonAn_DTO> lstThanhPhanTP = urcDanhSachSanPham.lstThanhPhanMonAn;
    private List<clsThanhPhanMonAn_DTO> lstThanhPhanTP;
    private DataGridViewRow drv = urcDanhSachSanPham.dvrSelected;
    private List<clsNguyenLieu_DTO> lstTongNguyenLieu;
    private void picExit_Click(object sender, EventArgs e)
    {
      this.Parent.Controls.Remove(this);
    }
    private void urcCongThucMonAn_Load(object sender, EventArgs e)
    {
        dgvThanhPhanCT.AutoGenerateColumns = false;
        dgvDSTongSoNL.AutoGenerateColumns = false;
      lstThanhPhanTP = BUS.ThanhPhanMonAn_BUS.LayCacThanhPhanCuaMon(MaDuocChon);
      LoadDgvThanhPhan();
      //dgv tất cả nguyên liệu
      lstTongNguyenLieu = BUS.NguyenLieu_BUS.DSNguyenLieu(ChuoiTimKiemNL);
      
      dgvDSTongSoNL.DataSource = lstTongNguyenLieu;
    }
    public void LoadDgvThanhPhan()
    {
      try
      {


        //  
        //  lstMonAnTP = BUS.ThanhPhanMonAn_BUS.LayCacThanhPhanCuaMon(MaDuocChon);
        dgvThanhPhanCT.DataSource = lstThanhPhanTP;
        if (drv.Cells["colAnhMonAn"].Value != null)
        {
          try
          {
            picAnhMonAnTP.Image = Image.FromFile(drv.Cells["colAnhMonAn"].Value.ToString().Trim());
          }
          catch (Exception)
          {
            picAnhMonAnTP.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
          }

        }
        else picAnhMonAnTP.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
        txtTenMonAnTP.Text = drv.Cells["colTenMonAn"].Value.ToString();
        txtMaMonAnTP.Text = drv.Cells["colMaMonAn"].Value.ToString();
        txtTongSoNLTP.Text = lstMonAnTP.Count.ToString();
      }
      catch (Exception)
      {

      }

    }
    public void btnThemNguyenLieu_Click(object sender, EventArgs e)
    {

      //if (txtSoLuongNLNL.Text.ToString() == "")
      //{
      //    MessageBox.Show("Vui lòng nhập vào số lượng của nguyên liệu này dành cho món bên");
      //    return;
      //}

      foreach (clsThanhPhanMonAn_DTO item in lstThanhPhanTP)
      {
        if (item.MaNguyenLieu == txtMaNLNL.Text)
        {
          MessageBox.Show("Đã có thành phần này, vui lòng chỉnh sửa ở bảng cạnh bên");
          return;
        }
      }



      clsThanhPhanMonAn_DTO itemThanhPhanUp = new clsThanhPhanMonAn_DTO();
      itemThanhPhanUp.MaMonAn = txtMaMonAnTP.Text;
      itemThanhPhanUp.MaNguyenLieu = txtMaNLNL.Text; // dtvr.Cells["colMaNguyenLieu"].Value.ToString();
      itemThanhPhanUp.DonVi = txtDonViNLNL.Text;  //dtvr.Cells["colDonVi"].Value.ToString();
      itemThanhPhanUp.SoLuong = 1;




      if (BUS.ThanhPhanMonAn_BUS.InsertThanhPhanMonAn(itemThanhPhanUp))
      {
        btnThemNguyenLieu.Enabled = false;
        urcCongThucMonAn_Load(sender, e);
        //  LoadDgvThanhPhan();
      }
      btnThemNguyenLieu.Enabled = true;
    }

    //private void dgvThanhPhanCT_SelectionChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (dgvThanhPhanCT.Rows.Count > 0)
    //        {
    //            dtvr = dgvThanhPhanCT.SelectedRows[0];
    //            txtTenNLTP.Text = dtvr.Cells["colMaNL"].Value.ToString();
    //            txtSoLuongTP.Text = dtvr.Cells["colSoLuong"].Value.ToString();
    //            txtDonVi.Text = dtvr.Cells["colDonVi"].Value.ToString();
    //        }
    //    }
    //    catch (Exception)
    //    {
    //    }
    //}
    private void btnChinhSua_Click(object sender, EventArgs e)
    {
      //lbGiaTriSoLuongBanDau.Text = txtSoLuongTP.Text;
      //btnLuuChinhSuaSanPham.Enabled = true;
      //btnTroVeBanDau.Enabled = true;
      //btnChinhSua.Enabled = false;
      //txtSoLuongTP.Enabled = true;

    }
    private void btnLuuChinhSuaSanPham_Click(object sender, EventArgs e)
    {
      //btnLuuChinhSuaSanPham.Enabled = false;
      //btnTroVeBanDau.Enabled = false;
      //btnChinhSua.Enabled = true;
      //txtSoLuongTP.Enabled = false;
    }
    private void btnTroVeBanDau_Click(object sender, EventArgs e)
    {
      //txtSoLuongTP.Text = lbGiaTriSoLuongBanDau.Text;
    }
    private void dgvDSTongSoNL_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {

      if (dgvDSTongSoNL.Columns[e.ColumnIndex].Name == "colAnhNguyenLieu")
      {
        try
        {
          if (e.Value != null)
          {
            e.Value = new Bitmap(e.Value.ToString());
          }
          else e.Value = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
        }
        catch (Exception)
        {
          e.Value = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
        }
      }



    }
    private void dgvDSTongSoNL_SelectionChanged(object sender, EventArgs e)
    {
      btnThemNguyenLieu.Enabled = true;
      try
      {
        if (dgvDSTongSoNL.Rows.Count > 0)
        {
          DataGridViewRow dvrSelected = dgvDSTongSoNL.SelectedRows[0];

          if (dvrSelected.Cells["colAnhNguyenLieu"].Value.ToString() != "")
          {
            picAnhNLNL.Image = Image.FromFile(dvrSelected.Cells["colAnhNguyenLieu"].Value.ToString().Trim());
          }
          else
          {
            picAnhNLNL.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
          }


          txtMaNLNL.Text = dvrSelected.Cells["colMaNguyenLieu"].Value.ToString();
          txtTenNLNL.Text = dvrSelected.Cells["colTenNguyenLieu"].Value.ToString();
          //      txtSoLuongNLNL.Text = dvrSelected.Cells["colSoLuongNguyenLieu"].Value.ToString();
          txtDonViNLNL.Text = dvrSelected.Cells["colDonViTinhNguyenLieu"].Value.ToString();

          //   lbTimNL.Text = dvrSelected.Cells["colMaNguyenLieu"].Value.ToString(); 
        }

      }
      catch (Exception)
      {


      }

    }

    
    //private void dgvThanhPhanMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    //{
    //  
    //}

    List<clsNguyenLieu_DTO> lstNguyenLieu = BUS.NguyenLieu_BUS.DSNguyenLieu("");
    private void dgvThanhPhanCT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvThanhPhanCT.Columns[e.ColumnIndex].Name == "colMaNL")
      {
        clsNguyenLieu_DTO dtoNguyenLieu = lstNguyenLieu.First(u => u.MaNguyenLieu == e.Value.ToString());
        e.Value = dtoNguyenLieu.TenNguyenLieu;
      }
    }

    private void dgvThanhPhanCT_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void dgvThanhPhanCT_KeyUp(object sender, KeyEventArgs e)
    {
        if (dgvThanhPhanCT.Rows.Count > 0)
        {
            DataGridViewRow row = dgvThanhPhanCT.SelectedRows[0];
            if (e.KeyCode == Keys.Delete)
            {
                MessageBox.Show("!");
            }
        }
    }


  }
}
