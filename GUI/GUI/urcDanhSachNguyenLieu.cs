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

namespace GUI
{
    public partial class urcDanhSachNguyenLieu : UserControl
    {
        public urcDanhSachNguyenLieu()
        {
            InitializeComponent();
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
            cbbDVTinhNL.DataSource = lstDonViTinh;
            cbbDVTinhNL.DisplayMember = "TenDonViTinh";
            cbbDVTinhNL.ValueMember = "MaDonViTinh";
            cbbDVTinhNL.SelectedValue = "";
            /// Load cbb Kích thước món ăn
            cbbLoaiNL.DataSource = lstLoaiNguyenLieu;
            cbbLoaiNL.DisplayMember = "TenLoaiNguyenLieu";
            cbbLoaiNL.ValueMember = "MaLoaiNguyenLieu";
            cbbLoaiNL.SelectedValue = "";
            /// Load cbb Loại món ăn
            cbbNCC.DataSource = BUS.NhaCungCap_BUS.DSNhaCungCap("");
            cbbNCC.DisplayMember = "TenNhaCungCap";
            cbbNCC.ValueMember = "MaNhaCungCap";
        }

        public void isEnableControls(bool isEnable)
        {
            txtDonGiaNL.Enabled = isEnable;
            txtSoLuongNL.Enabled = isEnable;
            txtTenNL.Enabled = isEnable;
            cbbDVTinhNL.Enabled = isEnable;
            cbbLoaiNL.Enabled = isEnable;
            cbbTrangThai.Enabled = isEnable;



        }

        private void btnChinhSuaNL_Click(object sender, EventArgs e)
        {
            btnHuyBoChinhSua.Visible = true;
            btnNhapNL.Enabled = false;
            btnThemMoiNL.Enabled = false;
            btnLuu.Enabled = true;
            btnAnhNguyenLieu.Enabled = true;
            dgvDSNguyenLieu.Enabled = false;
        }

        private void btnNhapNL_Click(object sender, EventArgs e)
        {
            btnHuyBoNhapHang.Visible = true;
            btnChinhSuaNL.Enabled = false;
            btnThemMoiNL.Enabled = false;
            btnLuu.Enabled = true;
            lbNCC.Visible = true;
            cbbNCC.Visible = true;
            picAddNhaCungCap.Visible = true;
            txtSoLuongNL.Enabled = true;
            txtSoLuongNL.Text = "";
            dgvDSNguyenLieu.Enabled = false;
        }

        private void btnThemMoiNL_Click(object sender, EventArgs e)
        {
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
          
            txtSoLuongNL.Enabled = false;
            btnHuyBoNhapHang.Visible = false;
            btnChinhSuaNL.Enabled = true;
            btnThemMoiNL.Enabled = true;
            btnLuu.Enabled = false;
            lbNCC.Visible = false;
            cbbNCC.Visible = false;
            picAddNhaCungCap.Visible = false;
            isEnableControls(false);
            dgvDSNguyenLieu_SelectionChanged(sender, e);
            dgvDSNguyenLieu.Enabled = true;
        }

        private void btnHuyBoChinhSua_Click(object sender, EventArgs e)
        {
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

        private void picAddDonViTinh_Click(object sender, EventArgs e)
        {
            urcDanhSachDonViTinh urcDanhSachDonViTinh = new urcDanhSachDonViTinh();
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
            if (!this.Controls.ContainsKey("urcLoaiNguyenLieu"))
            {
                this.Controls.Add(urcLoaiNguyenLieu);
                urcLoaiNguyenLieu.BackColor = Color.White;
                urcLoaiNguyenLieu.Top = 0;
                urcLoaiNguyenLieu.Left = 0;
            }
            urcLoaiNguyenLieu.BringToFront();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            clsNguyenLieu_DTO NguyenLieu = new clsNguyenLieu_DTO();
            NguyenLieu.MaNguyenLieu = TaoRaMaNguyenLieuMoi(lstNguyenLieu.Count);
            NguyenLieu.AnhNguyenLieu = AnhNguyenLieu;


            if (txtTenNL.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu tên "); return;
            }
            NguyenLieu.TenNguyenLieu = txtTenNL.Text;
          
            if (txtDonGiaNL.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu đơn giá "); return;
            }
            NguyenLieu.DonGia = float.Parse(txtDonGiaNL.Text);
            if (cbbDVTinhNL.SelectedValue == null)
            {
                MessageBox.Show("Thiếu dữ liệu đơn vị tính"); return;
            }
            NguyenLieu.DonViTinh = cbbDVTinhNL.SelectedValue.ToString();
            if (cbbLoaiNL.SelectedValue == null)
            {
                MessageBox.Show("Thiếu dữ liệu loại nguyên liệu"); return;
            }
            NguyenLieu.MaLoaiNguyenLieu = cbbLoaiNL.SelectedValue.ToString().Trim();
            NguyenLieu.TongSoLuong = 0;
            //  NguyenLieu.TrangThai = (bool)cbbTrangThai.SelectedValue;
            NguyenLieu.TrangThai = true; // tạm thời để là true chưa sửa 
            if (btnHuyBoThemMoi.Visible == true)// Đang thêm mới
            {

                if (BUS.NguyenLieu_BUS.InsertNguyenLieu(NguyenLieu))
                {
                    MessageBox.Show("Đã thêm thành công nguyên liệu");
                    urcDanhSachNguyenLieu_Load(sender, e);
                    btnHuyBoThemMoi_Click(sender, e);
                    Utilities.ResetAllControls(grbThongTinSP);
                    dgvDSNguyenLieu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại vui lòng thử lại");
                }

            }
            if (txtSoLuongNL.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu số lượng "); return;
            }
            NguyenLieu.TongSoLuong = float.Parse(txtSoLuongNL.Text);
            if (btnHuyBoNhapHang.Visible == true)//Đang nhập hàng thêm vào
            {

          

                //if (cbbNCC.SelectedText == "")
                //{
                //    MessageBox.Show("Thiếu tên nhà cung cấp bồ ơi"); return;
                //}
               
                lbNCC.Visible = false;
                cbbNCC.Visible = false;
                picAddNhaCungCap.Visible = false;
                dgvDSNguyenLieu.Enabled = true;
                int soluongsp = int.Parse( dvrSelected.Cells["colTongSoLuongCon"].Value.ToString());
                if (txtSoLuongNL.Text=="")
                {
                    return;
                }
                soluongsp += int.Parse(txtSoLuongNL.Text);
                clsNguyenLieu_DTO _NguyenLieuUP = new clsNguyenLieu_DTO();
                _NguyenLieuUP.MaNguyenLieu = dvrSelected.Cells["colMaNguyenLieu"].Value.ToString();
                _NguyenLieuUP.AnhNguyenLieu = dvrSelected.Cells["colAnhNguyenLieu"].Value.ToString();
                _NguyenLieuUP.TenNguyenLieu = dvrSelected.Cells["colTenNguyenLieu"].Value.ToString();
                _NguyenLieuUP.TongSoLuong = soluongsp;
                _NguyenLieuUP.DonViTinh = dvrSelected.Cells["colDonViTinh"].Value.ToString();
                _NguyenLieuUP.DonGia = float.Parse(dvrSelected.Cells["colDonGia"].Value.ToString());
                _NguyenLieuUP.MaLoaiNguyenLieu = dvrSelected.Cells["colLoaiNguyenLieu"].Value.ToString();
                _NguyenLieuUP.TrangThai = true; // bool.Parse(dvrSelected.Cells["colTrangThai"].Value.ToString());



                if (BUS.NguyenLieu_BUS.UpdateNguyenLieu(_NguyenLieuUP))
                {
                    MessageBox.Show("Nhập hàng thành công");
                    urcDanhSachNguyenLieu_Load(sender, e);
                    btnHuyBoNhapHang_Click(sender, e);
                    dgvDSNguyenLieu.Enabled = true;
                    dgvDSNguyenLieu_SelectionChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Không nhập được hàng");
                }
                


            }
            if (btnChinhSuaNL.Visible == true)//Đang chỉnh sửa thông tin nguyên liệu
            {
                dgvDSNguyenLieu.Enabled = true;
            }
        }

        private void dgvDSNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            

            try
            {

                if (dgvDSNguyenLieu.Rows.Count > 0)
                {
                    dvrSelected = dgvDSNguyenLieu.SelectedRows[0];

                    txtTenNL.Text = dvrSelected.Cells["colTenNguyenLieu"].Value.ToString();
                    txtSoLuongNL.Text = dvrSelected.Cells["colTongSoLuongCon"].Value.ToString();
                    txtDonGiaNL.Text = dvrSelected.Cells["colDonGia"].Value.ToString();
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


    }
}
