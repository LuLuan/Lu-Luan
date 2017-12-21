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
using System.IO;
using System.Threading;

namespace GUI
{
  public partial class urcDanhSachNguyenLieu : UserControl
  {
      public static DataTable dt = new DataTable();
      float fTongtien = 0;
      bool flag = true;
      bool chinhsua = false;
      bool nhaphang = false;
      bool themmoi = false;
    public urcDanhSachNguyenLieu()
    {
      InitializeComponent();
    }
       void TaoDataTable()
        {
            DataColumn dc = new DataColumn("colMaNguyenLieuNhap", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colTenNguyenLieuNhap", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colTongSoLuongNhap", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colDonViTinhNhap", typeof(String));
            dt.Columns.Add(dc);
            dc = new DataColumn("colDonGiaNhap", typeof(String));
            dt.Columns.Add(dc);
            dc = new DataColumn("colMaNhaCungCapNhap", typeof(String));
            dt.Columns.Add(dc);
        }
    DataGridViewRow dvrSelected;
    private string MaMonAnDuocChon = "";
    private string ChuoiTimKiem = "";
    private string AnhNguyenLieu = "";
    List<clsNguyenLieu_DTO> lstNguyenLieu;
    List<clsDonViTinh_DTO> lstDonViTinh = BUS.DonViTinh_BUS.DSDonViTinh();
    List<clsLoaiNguyenLieu_DTO> lstLoaiNguyenLieu = BUS.LoaiNguyenLieu_BUS.DSLoaiNguyenLieu("");

    public void UpdatenewLstNL()
    {
      lstNguyenLieu = BUS.NguyenLieu_BUS.DSNguyenLieu(ChuoiTimKiem);
    }

    private void urcDanhSachNguyenLieu_Load(object sender, EventArgs e)
    {
        if (flag)
        {
            TaoDataTable();
            flag = false;
        }
        dgvGioHangNhap.AutoGenerateColumns = false;
        dgvDSNguyenLieu.AutoGenerateColumns = false;
      LoadCbbTrangThai();
      LoadTatCaCBB();
      UpdatenewLstNL();
      dgvDSNguyenLieu.DataSource = lstNguyenLieu;
    }
    private void LoadCbbTrangThai()
    {
      //cbbTrangThai.Items.Add("Đã hết");
      //cbbTrangThai.Items.Add("Đang còn");
      //cbbTrangThai.SelectedIndex = -1;
    }

    private void dgvDSNguyenLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (dgvDSNguyenLieu.Columns[e.ColumnIndex].Name == "colAnhNguyenLieu")
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
    private string TaoRaMaNguyenLieuMoi(int iSoLuongMa)
    {
      string MaNL = "";
      iSoLuongMa += 1;

      int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
      if (DoDaiSoThuTu <= 10)
        MaNL = "NL000" + iSoLuongMa.ToString();
      else if (DoDaiSoThuTu <= 100)
        MaNL = "NL00" + iSoLuongMa.ToString();
      else if (DoDaiSoThuTu <= 1000)
        MaNL = "NL0" + iSoLuongMa.ToString();
      else if (DoDaiSoThuTu < 10000)
        MaNL = "NL" + iSoLuongMa.ToString();
      else if (DoDaiSoThuTu >= 9999)
        MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

      return MaNL;
    }


    public void LoadTatCaCBB()// load tất cả combobox
    {

      /// Load cbb Đơn vị tính
      cbbDVTinhNL.DataSource = BUS.DonViTinh_BUS.DSDonViTinh();
      cbbDVTinhNL.DisplayMember = "TenDonViTinh";
      cbbDVTinhNL.ValueMember = "MaDonViTinh";
      cbbDVTinhNL.SelectedValue = "";
      /// Load cbb Kích thước món ăn
      cbbLoaiNL.DataSource = BUS.LoaiNguyenLieu_BUS.DSLoaiNguyenLieu("");
      cbbLoaiNL.DisplayMember = "TenLoaiNguyenLieu";
      cbbLoaiNL.ValueMember = "MaLoaiNguyenLieu";
      cbbLoaiNL.SelectedValue = "";
      /// Load cbb Loại món ăn
      cbbNCC.DataSource = BUS.NhaCungCap_BUS.DSNhaCungCap("");
      cbbNCC.DisplayMember = "TenNhaCungCap";
      cbbNCC.ValueMember = "MaNhaCungCap";
      cbbNCC.SelectedIndex = 0;
    }

    public void isEnableControls(bool isEnable)
    {
      //txtDonGiaNL.Enabled = isEnable;
      txtSoLuongNL.Enabled = isEnable;
      txtTenNL.Enabled = isEnable;
      cbbDVTinhNL.Enabled = isEnable;
      cbbLoaiNL.Enabled = isEnable;
     // cbbTrangThai.Enabled = isEnable;



    }

    private void btnChinhSuaNL_Click(object sender, EventArgs e)
    {
        chinhsua = true;
      btnHuyBoChinhSua.Visible = true;
      btnNhapNL.Enabled = false;
      btnThemMoiNL.Enabled = false;
      btnLuu.Enabled = true;
      btnAnhNguyenLieu.Enabled = true;
      dgvDSNguyenLieu.Enabled = false;
      //
      txtTenNL.Enabled = true;
      txtSoLuongNL.Enabled = true;
      //txtDonGiaNL.Enabled = true;
      cbbDVTinhNL.Enabled = true;
      cbbLoaiNL.Enabled = true;
    }



      private void XuLyKhiNhanNhapHang(bool isClick)
    {
        if (isClick)
        {
            grbThongTinSP.Size = new Size(898, 285);
            dgvGioHangNhap.Visible = isClick;
            lbNCC.Visible = isClick;
            cbbNCC.Visible = isClick;
            picAddNhaCungCap.Visible = isClick;
            grbDSNL.Location = new Point(22,312);
            grbDSNL.Size = new Size(898, 200);
            dgvDSNguyenLieu.Size = new Size(886, 175);
            lblGia.Visible = isClick;
            txtGia.Visible = isClick;
            txtThemNhap.Visible = isClick;
        }
          else
            {
                grbThongTinSP.Size = new Size(898, 220);
                dgvGioHangNhap.Visible = isClick;
                lbNCC.Visible = isClick;
                cbbNCC.Visible = isClick;
                picAddNhaCungCap.Visible = isClick;
                grbDSNL.Location = new Point(22, 250);
                grbDSNL.Size = new Size(898, 250);
                dgvDSNguyenLieu.Size = new Size(886, 225);
                lblGia.Visible = isClick;
                txtGia.Visible = isClick;
                txtThemNhap.Visible = isClick;
            
            }
        
    }
    private void btnNhapNL_Click(object sender, EventArgs e)
    {
        nhaphang = true;
      btnHuyBoNhapHang.Visible = true;
      btnChinhSuaNL.Enabled = false;
      btnThemMoiNL.Enabled = false;
      btnLuu.Enabled = true;
      txtSoLuongNL.Enabled = true;
      txtSoLuongNL.Text = "";
     // dgvDSNguyenLieu.Enabled = false;
      XuLyKhiNhanNhapHang(true);
    }

    private void btnThemMoiNL_Click(object sender, EventArgs e)
    {
        themmoi = true;
      AnhNguyenLieu = "";
      btnHuyBoThemMoi.Visible = true;
      btnChinhSuaNL.Enabled = false;
      btnNhapNL.Enabled = false;
      btnLuu.Enabled = true;
      btnAnhNguyenLieu.Enabled = true;
      Utilities.ResetAllControls(grbThongTinSP);
      isEnableControls(true);
      dgvDSNguyenLieu.Enabled = false;
      txtSoLuongNL.Enabled = false;
      picAnhNguyenLieu.Image = null;
    }



    private void btnHuyBoThemMoi_Click(object sender, EventArgs e)
    {
        themmoi = false;
      btnHuyBoThemMoi.Visible = false;
      btnChinhSuaNL.Enabled = true;
      btnNhapNL.Enabled = true;
      btnLuu.Enabled = false;
      isEnableControls(false);
      Utilities.ResetAllControls(grbThongTinSP);
      dgvDSNguyenLieu_SelectionChanged(sender, e);
      dgvDSNguyenLieu.Enabled = true;
    }

    private void btnHuyBoNhapHang_Click(object sender, EventArgs e)
    {
        nhaphang = false;
      txtSoLuongNL.Enabled = false;
      btnHuyBoNhapHang.Visible = false;
      btnChinhSuaNL.Enabled = true;
      btnThemMoiNL.Enabled = true;
      btnLuu.Enabled = false;
      isEnableControls(false);
      dgvDSNguyenLieu_SelectionChanged(sender, e);
      dgvDSNguyenLieu.Enabled = true;
      XuLyKhiNhanNhapHang(false);
      HuyBoGioHangTinhToan();
    }
    private void HuyBoGioHangTinhToan()
    {
        while (dgvGioHangNhap.Rows.Count>0)
        {
            foreach (DataGridViewRow row in dgvGioHangNhap.Rows)
            {
                try
                {
                    dgvGioHangNhap.Rows.Remove(row);
                }
                catch (Exception) { }
            }
        }
        
        fTongtien = 0;
    }

    private void btnHuyBoChinhSua_Click(object sender, EventArgs e)
    {
        chinhsua = false;
      btnHuyBoChinhSua.Visible = false;
      btnNhapNL.Enabled = true;
      btnThemMoiNL.Enabled = true;
      btnLuu.Enabled = false;
      isEnableControls(false);
      Utilities.ResetAllControls(grbThongTinSP);
      dgvDSNguyenLieu_SelectionChanged(sender, e);
      dgvDSNguyenLieu.Enabled = true;
    }

    private void btnAnhNguyenLieu_Click(object sender, EventArgs e)
    {
      OpenFileDialog fd = new OpenFileDialog();
      fd.Title = "Chọn ảnh đại diện nhân viên";
      fd.Filter = "Image Only (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
      if (fd.ShowDialog() == DialogResult.OK)
      {

        if (fd.CheckFileExists)
        {
          //  MessageBox.Show(DateTime.Now.ToString("yyyyMMddHHmmss")); // định dạng năm tháng ngày giờ phút giây
          picAnhNguyenLieu.Image = Image.FromFile(fd.FileName);
          picAnhNguyenLieu.SizeMode = PictureBoxSizeMode.Zoom;
          //   MessageBox.Show(Path.GetFileName(fd.FileName));
          //   File.Copy()
          File.Copy(fd.FileName, @"HinhAnh\AnhNguyenLieu\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName));
          AnhNguyenLieu = @"HinhAnh\AnhNguyenLieu\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName);
        }
      }
    }
    public void _reloadAllCbb(bool isreload)
    {
      LoadTatCaCBB();
    }
    private void picAddDonViTinh_Click(object sender, EventArgs e)
    {
      urcDanhSachDonViTinh urcDanhSachDonViTinh = new urcDanhSachDonViTinh();
      urcDanhSachDonViTinh._LoadDSDonVi = new urcDanhSachDonViTinh.LoadDSDonVi(_reloadAllCbb);

      if (!this.Controls.ContainsKey("urcDanhSachDonViTinh"))
      {
        this.Controls.Add(urcDanhSachDonViTinh);
        urcDanhSachDonViTinh.BackColor = Color.White;
        urcDanhSachDonViTinh.Top = 0;
        urcDanhSachDonViTinh.Left = 0;
      }
      urcDanhSachDonViTinh.BringToFront();
    }

    private void picAddLoaiNguyenLieu_Click(object sender, EventArgs e)
    {


      urcDanhSachLoaiNguyenLieu urcLoaiNguyenLieu = new urcDanhSachLoaiNguyenLieu();
      urcLoaiNguyenLieu._ReloadDSNguyenLieu = new urcDanhSachLoaiNguyenLieu.ReLoadDSNguyenLieu(_reloadAllCbb);
      if (!this.Controls.ContainsKey("urcLoaiNguyenLieu"))
      {
        this.Controls.Add(urcLoaiNguyenLieu);
        urcLoaiNguyenLieu.BackColor = Color.White;
        urcLoaiNguyenLieu.Top = 0;
        urcLoaiNguyenLieu.Left = 0;
      }
      urcLoaiNguyenLieu.BringToFront();
    }
    private string TaoRaMaMoi(int iSoLuongMa)
    {
        string MaNL = "";
        iSoLuongMa += 1;

        // int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
        if (iSoLuongMa < 10)
            MaNL = "HDN000000" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 100)
            MaNL = "HDN00000" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 1000)
            MaNL = "HDN0000" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 10000)
            MaNL = "HDN000" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 100000)
            MaNL = "HDN00" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 1000000)
            MaNL = "HDN0" + iSoLuongMa.ToString();
        else if (iSoLuongMa < 10000000)
            MaNL = "HDN" + iSoLuongMa.ToString();
        else if (iSoLuongMa >= 9999999)
            MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

        return MaNL;
    }
    private void btnLuu_Click(object sender, EventArgs e)
    {
      clsNguyenLieu_DTO NguyenLieu = new clsNguyenLieu_DTO();
      NguyenLieu.MaNguyenLieu = TaoRaMaNguyenLieuMoi(lstNguyenLieu.Count);
      NguyenLieu.AnhNguyenLieu = AnhNguyenLieu;
      #region kiểm tra dữ liệu
      if (txtTenNL.Text == "")
      {
        MessageBox.Show("Thiếu dữ liệu tên "); return;
      }
      NguyenLieu.TenNguyenLieu = txtTenNL.Text;
      if (cbbDVTinhNL.SelectedValue == null)
      {
        MessageBox.Show("Thiếu dữ liệu đơn vị tính"); return;
      }
      NguyenLieu.DonViTinh = cbbDVTinhNL.SelectedValue.ToString();
      if (cbbLoaiNL.SelectedValue == null)
      {
        MessageBox.Show("Thiếu dữ liệu loại nguyên liệu"); return;
      }

      #endregion kiểm tra dữ liệu
      NguyenLieu.MaLoaiNguyenLieu = cbbLoaiNL.SelectedValue.ToString().Trim();
      NguyenLieu.TongSoLuong = 0;
      NguyenLieu.TrangThai = true; // tạm thời để là true chưa sửa 
      if (themmoi)// Đang thêm mới
      {
          #region thêm mới nguyên liệu
          if (BUS.NguyenLieu_BUS.InsertNguyenLieu(NguyenLieu))
        {
          MessageBox.Show("Đã thêm thành công nguyên liệu");
          urcDanhSachNguyenLieu_Load(sender, e);
          btnHuyBoThemMoi_Click(sender, e);
          Utilities.ResetAllControls(grbThongTinSP);
          dgvDSNguyenLieu.Enabled = true;
          return;
        }
        else
        {
            MessageBox.Show("Thêm thất bại vui lòng thử lại"); return;
        }
          #endregion thêm mới nguyên liệu
      }
      if (txtSoLuongNL.Text == "")
      {
        MessageBox.Show("Thiếu dữ liệu số lượng "); return;
      }
      NguyenLieu.TongSoLuong = float.Parse(txtSoLuongNL.Text);
      if (nhaphang)//Đang nhập hàng thêm vào
      {
          if (dt.Rows.Count > 0)
          {
              for (int i = 0; i < dt.Rows.Count; i++)
              {
                  for (int j = 0; j < dgvDSNguyenLieu.Rows.Count; j++)
                  {
                      if (dt.Rows[i][0].ToString() == dgvDSNguyenLieu.Rows[j].Cells[0].Value.ToString())
                      {
                          int soluongsp = int.Parse(dgvDSNguyenLieu.Rows[j].Cells[3].Value.ToString()) + int.Parse(dt.Rows[i][2].ToString());
                          MessageBox.Show(dt.Rows[i][0].ToString());
                          clsNguyenLieu_DTO _NguyenLieuUP = new clsNguyenLieu_DTO();
                          _NguyenLieuUP = TaoRaMotDoiTuongNguyenLieu(soluongsp,dgvDSNguyenLieu,j);
                          BUS.NguyenLieu_BUS.UpdateNguyenLieu(_NguyenLieuUP);
                          urcDanhSachNguyenLieu_Load(sender, e);
                          dgvDSNguyenLieu_SelectionChanged(sender, e);
                          // đối tượng hóa đơn nhập để add vào hóa đơn nhập
                      }
                     
                  }
              }
             //  tao hoa don nhap
              clsHoaDonNhap_DTO hdn = new clsHoaDonNhap_DTO();
              hdn.MaHoaDon = TaoRaMaMoi(BUS.HoaDonNhap_BUS.SoLuongHoaDonNhap());
              hdn.MaNhanVien = urcDangNhap.strMaNhanVien;
              hdn.NgayTaoHoaDon = DateTime.Now;
              hdn.TongTien = fTongtien;
              hdn.TrangThai = true;
              MessageBox.Show(hdn.TongTien.ToString() + "-" + hdn.NgayTaoHoaDon.ToString() + "-" + hdn.MaNhanVien.ToString() + "-" + hdn.MaHoaDon.ToString()+"-"+hdn.TrangThai.ToString());
              BUS.HoaDonNhap_BUS.AddHoaDonNhap(hdn);
                // xuất hóa đơn
              frmHoaDonNhap frmhdh = new frmHoaDonNhap();
              frmhdh.Show();
              Thread.Sleep(900);
              btnHuyBoNhapHang_Click(sender, e);
          }
          else
          { 
              MessageBox.Show("Trong danh sách chưa có nguyên liệu nào"); return;
          }
      }
      if (chinhsua)//Đang chỉnh sửa thông tin nguyên liệu
      {
          #region chỉnh sửa nguyên liệu
          DataGridViewRow r = dgvDSNguyenLieu.SelectedRows[0];

        clsNguyenLieu_DTO nguyenLieu = new clsNguyenLieu_DTO();
        nguyenLieu.MaNguyenLieu = r.Cells[0].Value.ToString();
        nguyenLieu.AnhNguyenLieu = AnhNguyenLieu;
        nguyenLieu.TenNguyenLieu = txtTenNL.Text;
        nguyenLieu.TongSoLuong = float.Parse(txtSoLuongNL.Text);
        nguyenLieu.DonViTinh = cbbDVTinhNL.SelectedValue.ToString();
       // nguyenLieu.DonGia = float.Parse(txtDonGiaNL.Text);
        nguyenLieu.MaLoaiNguyenLieu = cbbLoaiNL.SelectedValue.ToString();
        nguyenLieu.TrangThai = true;

        if(BUS.NguyenLieu_BUS.UpdateNguyenLieu(nguyenLieu))
        {
          MessageBox.Show("Cập nhật thành công");
          urcDanhSachNguyenLieu_Load(sender, e);
          btnHuyBoChinhSua_Click(sender, e);
          dgvDSNguyenLieu.Enabled = true;

        }
          #endregion chỉnh sửa nguyên liệu
      }
    }
      private clsNguyenLieu_DTO TaoRaMotDoiTuongNguyenLieu(int soluongsp, DataGridView dgv, int chisodong)
    {
        //soluongsp += int.Parse(txtSoLuongNL.Text);
        clsNguyenLieu_DTO _NguyenLieuUP = new clsNguyenLieu_DTO();
        _NguyenLieuUP.MaNguyenLieu = dgv.Rows[chisodong].Cells["colMaNguyenLieu"].Value.ToString();
        _NguyenLieuUP.AnhNguyenLieu = dgv.Rows[chisodong].Cells["colAnhNguyenLieu"].Value.ToString();
        _NguyenLieuUP.TenNguyenLieu = dgv.Rows[chisodong].Cells["colTenNguyenLieu"].Value.ToString();
        _NguyenLieuUP.TongSoLuong = soluongsp;
        _NguyenLieuUP.DonViTinh = dgv.Rows[chisodong].Cells["colDonViTinh"].Value.ToString();
        _NguyenLieuUP.MaLoaiNguyenLieu = dgv.Rows[chisodong].Cells["colLoaiNguyenLieu"].Value.ToString();
        _NguyenLieuUP.TrangThai = true;
        return _NguyenLieuUP;
    }

    private void dgvDSNguyenLieu_SelectionChanged(object sender, EventArgs e)
    {


      try
      {

        if (dgvDSNguyenLieu.Rows.Count > 0)
        {
          dvrSelected = dgvDSNguyenLieu.SelectedRows[0];

          txtTenNL.Text = dvrSelected.Cells["colTenNguyenLieu"].Value.ToString();
          if (!nhaphang)
          {
              txtSoLuongNL.Text = dvrSelected.Cells["colTongSoLuongCon"].Value.ToString();
          }
        
          //txtDonGiaNL.Text = dvrSelected.Cells["colDonGia"].Value.ToString();
          cbbDVTinhNL.SelectedValue = dvrSelected.Cells["colDonViTinh"].Value.ToString();

          cbbLoaiNL.SelectedValue = dvrSelected.Cells["colLoaiNguyenLieu"].Value.ToString();
          //cbbTrangThai.SelectedValue = dvrSelected.Cells["colTrangThai"].Value.ToString();
          // 

          MaMonAnDuocChon = dvrSelected.Cells["colMaNguyenLieu"].Value.ToString();
          // MessageBox.Show("Tới đây chưa");
          picAnhNguyenLieu.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
          //DataGridViewRow 

          //colAnhMonAn

          if (dvrSelected.Cells["colAnhNguyenLieu"].Value != null)
          {
            picAnhNguyenLieu.Image = Image.FromFile(dvrSelected.Cells["colAnhNguyenLieu"].Value.ToString());
            AnhNguyenLieu = dvrSelected.Cells["colAnhNguyenLieu"].Value.ToString();
          }
          else
          {
            picAnhNguyenLieu.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
             AnhNguyenLieu =@"HinhAnh\AnhMonAn\no_picture.gif";
          }

        }
        else
          //    picAnhDaiDien.Image = null;
          picAnhNguyenLieu.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");

      }
      catch (Exception)
      {
        picAnhNguyenLieu.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
      }



    }

    private void picAddNhaCungCap_Click(object sender, EventArgs e)
    {
      urcNhaCungCap urcNhaCungCap = new urcNhaCungCap();
      if (!this.Controls.ContainsKey("urcNhaCungCap"))
      {
        this.Controls.Add(urcNhaCungCap);
        urcNhaCungCap.BackColor = Color.White;
        urcNhaCungCap.Top = 0;
        urcNhaCungCap.Left = 0;
      }
      urcNhaCungCap.BringToFront();
    }

    private void cbbNCC_SelectionChangeCommitted(object sender, EventArgs e)
    {
      string query = string.Format("Select * from NhaCungCap where ten_nha_cung_cap like N'%{0}%'", cbbNCC.Text);
      cbbNCC.DataSource = BUS.NhaCungCap_BUS.DSNhaCungCap(query);
    }

    private void cbbNCC_TextChanged(object sender, EventArgs e)
    {
      string query = string.Format("Select * from NhaCungCap where ten_nha_cung_cap like N'%{0}%'", cbbNCC.Text);
      cbbNCC.DataSource = BUS.NhaCungCap_BUS.DSNhaCungCap(query);
    }

    private void picExit_Click(object sender, EventArgs e)
    {
      this.Parent.Controls.Remove(this);
    }

    private void grbThongTinSP_Enter(object sender, EventArgs e)
    {

    }

    private void txtThemNhap_Click(object sender, EventArgs e)
    {
        if (txtSoLuongNL.Text=="" || txtGia.Text =="")
        {
            return;
        }

        bool bflag = true;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i][0]==dvrSelected.Cells["colMaNguyenLieu"].Value.ToString())
            {
                bflag = false;
                dt.Rows[i][2] = int.Parse(dt.Rows[i][2].ToString()) + int.Parse(txtSoLuongNL.Text);
                fTongtien += float.Parse(txtSoLuongNL.Text) * float.Parse(dt.Rows[i][4].ToString());
            }
        }

        if (bflag)
        {
            DataRow dr = dt.NewRow();
            dr[0] = dvrSelected.Cells["colMaNguyenLieu"].Value.ToString();
            dr[1] = dvrSelected.Cells["colTenNguyenLieu"].Value.ToString();
            dr[2] = txtSoLuongNL.Text;
            dr[3] = dvrSelected.Cells["colDonViTinh"].Value.ToString();
            dr[4] = txtGia.Text;
            // dr[5] = cbbNCC.SelectedValue.ToString();
            dt.Rows.Add(dr);
            dgvGioHangNhap.DataSource = dt;
            fTongtien += (float.Parse(dr[2].ToString()) * float.Parse(dr[4].ToString()));
        }
        MessageBox.Show(fTongtien.ToString());
    }


  }
}
