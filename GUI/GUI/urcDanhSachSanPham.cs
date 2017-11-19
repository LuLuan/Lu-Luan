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
    public partial class urcDanhSachSanPham : UserControl
    {
        public urcDanhSachSanPham()
        {
            InitializeComponent();
        }

        private string strTimKiemMonAn = "";
        private string DuongDanAnhMonAn = "";
        public static string MaMonAnDuocChon = "";
        public static DataGridViewRow dvrSelected = new DataGridViewRow();
        //  public List<clsMonAn_DTO> lstMonAn = BUS.MonAn_BUS.DSMonAn();
        // public List<clsLoaiMonAn_DTO> lstLoaiMonAn = BUS.LoaiMonAn_BUS.DSLoaiMonAn();
        // public List<clsDonViTinh_DTO> lstDonViTinh = BUS.DonViTinh_BUS.DSDonViTinh();

        //public  List<clsChiTietMonAn_DTO> lstCTMonAn = BUS.ChiTietMonAn_BUS.DSChiTietMonAn();
        //public  List<clsKichThuocMonAn_DTO> lstKichThuocMonAn = BUS.KichThuocMonAn_BUS.DSKichThuoc();

        public static List<clsMonAn_DTO> lstMonAn;
        public List<clsLoaiMonAn_DTO> lstLoaiMonAn;
        public List<clsDonViTinh_DTO> lstDonViTinh;
        public List<clsChiTietMonAn_DTO> lstCTMonAn;
        public List<clsKichThuocMonAn_DTO> lstKichThuocMonAn;
        public static List<clsThanhPhanMonAn_DTO> lstThanhPhanMonAn;
        public void LamMoiDanhSach(string strTimKiemMonAn)
        {
            lstMonAn = BUS.MonAn_BUS.DSMonAn(strTimKiemMonAn);
            lstLoaiMonAn = BUS.LoaiMonAn_BUS.DSLoaiMonAn();
            lstDonViTinh = BUS.DonViTinh_BUS.DSDonViTinh();
            lstCTMonAn = BUS.ChiTietMonAn_BUS.DSChiTietMonAn();
            lstKichThuocMonAn = BUS.KichThuocMonAn_BUS.DSKichThuoc();
            //  lstThanhPhanMonAn = BUS.ThanhPhanMonAn_BUS.LayCacThanhPhanCuaMon(MaMonAnDuocChon);
        }
        public void LoadTatCaCBB()// load tất cả combobox
        {

            /// Load cbb Đơn vị tính
            cbbDonViTinh.DataSource = lstDonViTinh;
            cbbDonViTinh.DisplayMember = "TenDonViTinh";
            cbbDonViTinh.ValueMember = "MaDonViTinh";
            cbbDonViTinh.SelectedValue = "";
            /// Load cbb Kích thước món ăn
            cbbKichThuoc.DataSource = lstKichThuocMonAn;
            cbbKichThuoc.DisplayMember = "TenKichThuoc";
            cbbKichThuoc.ValueMember = "MaKichThuoc";
            cbbKichThuoc.SelectedValue = "";
            /// Load cbb Loại món ăn
            cbbLoaiMonAn.DataSource = lstLoaiMonAn;
            cbbLoaiMonAn.DisplayMember = "TenLoaiMonAn";
            cbbLoaiMonAn.ValueMember = "MaLoaiMonAn";
            cbbLoaiMonAn.SelectedValue = "";
        }

        private void urcDanhSachSanPham_Load(object sender, EventArgs e)
        {
            LamMoiDanhSach(strTimKiemMonAn);
            LoadTatCaCBB();
            LoadDuLieuLendgvMonAn();
            LoadDuLieuLendgvThanhPhan();

        }
        private void LoadDuLieuLendgvThanhPhan()
        {
            //   BUS.ThanhPhanMonAn_BUS BusTPMonAn = new ThanhPhanMonAn_BUS();
            if (MaMonAnDuocChon != null)
            {



                lstThanhPhanMonAn = BUS.ThanhPhanMonAn_BUS.LayCacThanhPhanCuaMon(MaMonAnDuocChon);
                dgvThanhPhanMonAn.AutoGenerateColumns = false;
                dgvThanhPhanMonAn.DataSource = lstThanhPhanMonAn;
            }




        }
        public void LoadDuLieuLendgvMonAn()
        {
            dgvDSSP.AutoGenerateColumns = false; //không tự sinh cột

            var q = (from MonAn in lstMonAn
                     join ChiTietMonAn in lstCTMonAn
                     on MonAn.MaMonAn equals ChiTietMonAn.MaMonAn
                     //join LoaiMonAn in lstLoaiMonAn  on MonAn.MaLoaiMon equals LoaiMonAn.MaLoaiMonAn
                     //join DonViTinh in lstDonViTinh on MonAn.MaDonViTinh equals DonViTinh.MaDonViTinh
                     //join KichThuocMonAn in lstKichThuocMonAn on ChiTietMonAn.MaKichThuoc equals KichThuocMonAn.MaKichThuoc
                     select new
                     {
                         MonAn.MaMonAn,
                         MonAn.TenMonAn,
                         MonAn.AnhMonAn,
                         MonAn.GhiChu,
                         MonAn.MaLoaiMon,
                         //LoaiMonAn.TenLoaiMonAn,
                         MonAn.MaDonViTinh,
                         //DonViTinh.TenDonViTinh,
                         ChiTietMonAn.MaKichThuoc,
                         //KichThuocMonAn.TenKichThuoc,
                         ChiTietMonAn.GiaBan,
                         ChiTietMonAn.TrangThai
                     }).ToList();
            dgvDSSP.DataSource = q;



        }


        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Chọn ảnh đại diện nhân viên";
            fd.Filter = "Image Only (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {

                if (fd.CheckFileExists)
                {
                    //  MessageBox.Show(DateTime.Now.ToString("yyyyMMddHHmmss")); // định dạng năm tháng ngày giờ phút giây
                    picAnhDaiDien.Image = Image.FromFile(fd.FileName);
                    picAnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
                    //   MessageBox.Show(Path.GetFileName(fd.FileName));
                    //   File.Copy()
                    File.Copy(fd.FileName, @"HinhAnh\AnhMonAn\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName));
                    DuongDanAnhMonAn = @"HinhAnh\AnhMonAn\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(fd.FileName);
                }
            }
        }
        public void isEnabledControls(bool isenable)// đóng hết các b
        {
            txtGia.Enabled = isenable;
            // txtMaMonAn.Enabled = isenable;
            txtTenMonAn.Enabled = isenable;
            cbbDonViTinh.Enabled = isenable;
            cbbKichThuoc.Enabled = isenable;
            cbbLoaiMonAn.Enabled = isenable;
            btnChinhSuaAnh.Enabled = isenable;
            picAnhDaiDien.Enabled = isenable;
            btnLuuChinhSuaSanPham.Enabled = isenable;
            if (!isenable)
            {
                btnAddSP.Visible = true;
                btnChinhSua.Visible = true;
            }



        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            isEnabledControls(true);
            btnChinhSua.Visible = false;
            btnLuuChinhSuaSanPham.Enabled = true;

        }

        private void btnLuuChinhSuaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvDSSP.Rows.Count > 0)
            {
              //  DuongDanAnhMonAn = picAnhDaiDien.ImageLocation.ToString();
              
                string MaKichThuocCu = "";
                DataGridViewRow dtvr = dgvDSSP.SelectedRows[0];
                MaKichThuocCu = dtvr.Cells[4].Value.ToString();
               
                //
                if (DuongDanAnhMonAn == "" || txtMaMonAn.Text == "" || txtGia.Text == "" || cbbKichThuoc.SelectedValue.ToString() == "" || txtTenMonAn.Text == "" || cbbDonViTinh.SelectedValue.ToString() == "" || cbbLoaiMonAn.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Thao tác sai. Vui lòng thao tác lại");
                    isEnabledControls(true);
                    return;
                }
                string MaMon = txtMaMonAn.Text;
                string Gia = txtGia.Text;
                string MaKichThuoc = cbbKichThuoc.SelectedValue.ToString();
                string TenMon = txtTenMonAn.Text;
                string MaDonViTinh = cbbDonViTinh.SelectedValue.ToString();
                string MaLoaiMonAn = cbbLoaiMonAn.SelectedValue.ToString();
                //
                //  MessageBox.Show(DuongDanAnhMonAn);

               

                clsMonAn_DTO itemUpMonAn = new clsMonAn_DTO();
                itemUpMonAn.MaMonAn = MaMon;
                itemUpMonAn.TenMonAn = TenMon;
                itemUpMonAn.AnhMonAn = DuongDanAnhMonAn;
                itemUpMonAn.GhiChu = "Đang cập nhật";
                itemUpMonAn.MaLoaiMon = MaLoaiMonAn;
                itemUpMonAn.MaDonViTinh = MaDonViTinh;
                itemUpMonAn.TrangThai = true;

                clsChiTietMonAn_DTO itemUpChiTietMonAn = new clsChiTietMonAn_DTO();
                itemUpChiTietMonAn.MaMonAn = MaMon + " ";
                itemUpChiTietMonAn.GiaBan = float.Parse(Gia);
                itemUpChiTietMonAn.MaKichThuoc = MaKichThuoc;
                itemUpChiTietMonAn.TrangThai = true;
                //
             //   MessageBox.Show("``" + DuongDanAnhMonAn + "`" + txtMaMonAn.Text + "`" + txtGia.Text + "`" + cbbKichThuoc.SelectedValue.ToString() + "`" + txtTenMonAn.Text + "`" + cbbDonViTinh.SelectedValue.ToString() + "`" + cbbLoaiMonAn.SelectedValue.ToString()); return;
                //Lấy mã kích thước món ăn khi chưa sửa 
                //
                if (BUS.MonAn_BUS.UpMonAn(itemUpMonAn) && BUS.MonAn_BUS.UpCTMonAn(itemUpChiTietMonAn, MaKichThuocCu))
                {
                    MessageBox.Show("Bạn đã cập nhật thành công");
                    isEnabledControls(false);
                    LamMoiDanhSach(strTimKiemMonAn);
                    LoadDuLieuLendgvMonAn();
                    btnChinhSua.Visible = true;
                }
                else
                {
                    MessageBox.Show("Dữ liệu trùng hoặc sai. Vui lòng thao tác lại");
                    isEnabledControls(true);
                }

            }
        }

       
        private void dgvDSSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvDSSP.Columns[e.ColumnIndex].Name == "colAnhMonAn")
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


           
            try
            {
                if (dgvDSSP.Columns[e.ColumnIndex].Name == "colDonViTinh")
                {
                    clsDonViTinh_DTO  dtoDonViTinh = lstDonViTinh.First(i => i.MaDonViTinh == e.Value.ToString());
                    e.Value = dtoDonViTinh.TenDonViTinh;
                }
            }
            catch (Exception)
            {


            }
            if (dgvDSSP.Columns[e.ColumnIndex].Name == "colTenLoaiMonAn")
            {
                clsLoaiMonAn_DTO dtoTenLoaiMonAn = lstLoaiMonAn.First(u => u.MaLoaiMonAn == e.Value.ToString());
                e.Value = dtoTenLoaiMonAn.TenLoaiMonAn;
            }
   

            //colTenKichThuoc
            if (dgvDSSP.Columns[e.ColumnIndex].Name == "colTenKichThuoc")
            {
                clsKichThuocMonAn_DTO dtoKichThuocMonAn = lstKichThuocMonAn.First(u => u.MaKichThuoc == e.Value.ToString());
                e.Value = dtoKichThuocMonAn.TenKichThuoc;
            }


        }

        private string TaoRaMaMoi(int iSoLuongMa)
        {
            string MaNL = "";
            iSoLuongMa += 1;

            // int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
            if (iSoLuongMa < 10)
                MaNL = "M000" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 100)
                MaNL = "M00" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 1000)
                MaNL = "M0" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 10000)
                MaNL = "M" + iSoLuongMa.ToString();
            else if (iSoLuongMa >= 9999)
                MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

            return MaNL;
        }

        private void btnAddSP_Click_1(object sender, EventArgs e)
        {
            btnAddSP.Visible = false;
            isEnabledControls(true);
            picAnhDaiDien.Image = null;
            Utilities.ResetAllControls(grbThongTinSP);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

           
            //  if (txtMaMonAn.Text == "") return;
            if (txtGia.Text == "") return;
            if (cbbKichThuoc.SelectedValue == null) return;
            if (txtTenMonAn.Text == "") return;
            if (cbbDonViTinh.SelectedValue == null) return;
            if (cbbLoaiMonAn.SelectedValue == null) return;

            isEnabledControls(true);
            btnAddSP.Visible = false;
            btnChinhSua.Enabled = false;
            btnLuuChinhSuaSanPham.Enabled = false;
            //Thông tin sản phẩm
            string MaMon = txtMaMonAn.Text;
            string Gia = txtGia.Text;
            string MaKichThuoc = cbbKichThuoc.SelectedValue.ToString();
            string TenMon = txtTenMonAn.Text;
            string MaDonViTinh = cbbDonViTinh.SelectedValue.ToString();
            string MaLoaiMonAn = cbbLoaiMonAn.SelectedValue.ToString();

            clsMonAn_DTO itemMonAn = new clsMonAn_DTO();
            itemMonAn.MaMonAn = TaoRaMaMoi(BUS.MonAn_BUS.SoLuongMonAn());
            itemMonAn.TenMonAn = TenMon;
            itemMonAn.AnhMonAn = DuongDanAnhMonAn;
            itemMonAn.GhiChu = "Đang cập nhật";
            itemMonAn.MaLoaiMon = MaLoaiMonAn;
            itemMonAn.MaDonViTinh = MaDonViTinh;
            itemMonAn.TrangThai = true;
            //   MessageBox.Show(itemMonAn.MaMonAn.ToString() + itemMonAn.TenMonAn.ToString() + itemMonAn.AnhMonAn.ToString() + itemMonAn.GhiChu +"-"+ itemMonAn.MaLoaiMon+"-" + itemMonAn.MaDonViTinh + itemMonAn.TrangThai.ToString()); return;
            clsChiTietMonAn_DTO itemChiTietMonAn = new clsChiTietMonAn_DTO();
            itemChiTietMonAn.MaMonAn = itemMonAn.MaMonAn;
            itemChiTietMonAn.GiaBan = float.Parse(Gia);
            itemChiTietMonAn.MaKichThuoc = MaKichThuoc;
            itemChiTietMonAn.TrangThai = true;
            //   MessageBox.Show(itemChiTietMonAn.MaMonAn + "+" + itemChiTietMonAn.MaKichThuoc + "+" + itemChiTietMonAn.GiaBan.ToString() + "+" + itemChiTietMonAn.TrangThai.ToString()); return;
            //

            //&& BUS.MonAn_BUS.AddChiTietMonAn(itemChiTietMonAn)
            string[] strMA = { "KTAN ", "KTUL ", "KTUM ", "KTUS " };
                if (BUS.MonAn_BUS.AddMonAn(itemMonAn))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        itemChiTietMonAn.MaKichThuoc = strMA[i];
                        BUS.MonAn_BUS.AddChiTietMonAn(itemChiTietMonAn);
                        itemChiTietMonAn.GiaBan = (itemChiTietMonAn.GiaBan +3000);
                    }
                    MessageBox.Show("Đã thêm thành công nguyên liệu");
                    urcDanhSachSanPham_Load(sender, e);
                    isEnabledControls(false);

                }
                else
                {
                    MessageBox.Show("Thêm thất bại vui lòng thử lại");
                }
            





        }

        private void btnDelSP_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(grbThongTinSP);
            isEnabledControls(false);
            btnChinhSua.Enabled = false;
            btnLuuChinhSuaSanPham.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (ckbTen.Checked)
            {
                strTimKiemMonAn = "select * from MonAn  WHERE ten_mon_an LIKE N'%" + txtTimKiem.Text + "%'" + " AND trang_thai='TRUE'";
            }
            else if (ckbMaMonAn.Checked)
            {
                strTimKiemMonAn = "select * from MonAn  WHERE ma_mon_an LIKE N'%" + txtTimKiem.Text + "%'" + " AND trang_thai='TRUE'";
            }
            else if (!ckbMaMonAn.Checked && !ckbTen.Checked)
            {
                strTimKiemMonAn = "select * from MonAn  WHERE ma_mon_an LIKE N'%" + txtTimKiem.Text + "%'" + " or ten_mon_an LIKE N'%" + txtTimKiem.Text + "%'" + " AND trang_thai='TRUE'";
            }

            isEnabledControls(false);
            LamMoiDanhSach(strTimKiemMonAn);
            LoadDuLieuLendgvMonAn();
            btnChinhSua.Visible = true;
        }

        private void dgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvDSSP.SelectedRows.ToString());
            btnLuuChinhSuaSanPham.Enabled = false;
            btnChinhSua.Enabled = true;

            try
            {

                if (dgvDSSP.Rows.Count > 0)
                {

                    dvrSelected = dgvDSSP.SelectedRows[0];

                    txtTenMonAn.Text = dvrSelected.Cells["colTenMonAn"].Value.ToString();
                    txtMaMonAn.Text = dvrSelected.Cells["colMaMonAn"].Value.ToString();
                    txtGia.Text = dvrSelected.Cells["colGiaBan"].Value.ToString();
                    cbbKichThuoc.SelectedValue = dvrSelected.Cells["colTenKichThuoc"].Value.ToString();
                    cbbLoaiMonAn.SelectedValue = dvrSelected.Cells["colTenLoaiMonAn"].Value.ToString();
                    cbbDonViTinh.SelectedValue = dvrSelected.Cells["colDonViTinh"].Value.ToString();
                    //
                    MaMonAnDuocChon = dvrSelected.Cells["colMaMonAn"].Value.ToString();
                    LoadDuLieuLendgvThanhPhan();
                    picAnhDaiDien.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
                    //DataGridViewRow 

                    //colAnhMonAn

                    if (dvrSelected.Cells["colAnhMonAn"].Value != null)
                    {
                        picAnhDaiDien.Image = Image.FromFile(dvrSelected.Cells["colAnhMonAn"].Value.ToString());
                        DuongDanAnhMonAn = dvrSelected.Cells["colAnhMonAn"].Value.ToString();
                    }
                    else
                    {
                        picAnhDaiDien.Image = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
                    }
                }
                else
                    picAnhDaiDien.Image = null;

            }
            catch (Exception)
            {
            }


        }
        public void RemoveControl(bool remove)
        {

        }
        private void btnEditCongThuc_Click(object sender, EventArgs e)
        {
            //  CaiDatPanelMenu(btnThemNhanVien);
            urcCongThucMonAn urcCongThucMonAn = new urcCongThucMonAn();
            if (!this.Controls.ContainsKey("urcThemNhanVien"))
            {
                this.Controls.Add(urcCongThucMonAn);
                urcCongThucMonAn.BackColor = Color.White;
                urcCongThucMonAn.Top = 0;
                urcCongThucMonAn.Left = 0;
            }
            urcCongThucMonAn.BringToFront();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void dgvDSSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvDSSP.Rows.Count > 0)
            {
                DataGridViewRow row = dgvDSSP.SelectedRows[0];
                int rowIndex = row.Index;

                if (e.KeyCode == Keys.Delete)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa sp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        //&& BUS.MonAn_BUS.UpDeleteMonAn(MaMonAnDuocChon, false)
                        if (BUS.MonAn_BUS.UpDeleteCTMonAn(MaMonAnDuocChon, row.Cells["colTenKichThuoc"].Value.ToString(), false))
                        {
                            if (BUS.MonAn_BUS.SoLuongMonAnChiTietMonAn(MaMonAnDuocChon) <= 0)// đếm xem còn ở chi tiết không mới xóa ở sp
                            {
                                BUS.MonAn_BUS.UpDeleteMonAn(MaMonAnDuocChon, false);
                            }
                            LamMoiDanhSach(strTimKiemMonAn);
                            LoadDuLieuLendgvMonAn();
                            MessageBox.Show("Đã xóa món ăn ");
                            Utilities.ResetAllControls(grbThongTinSP);
                            picAnhDaiDien.Image = null;
                        }
                        else
                            MessageBox.Show("Không thể xóa");


                        //    dgvDSSP.FirstDisplayedScrollingRowIndex = rowIndex;
                    }

                }
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvDSSP.Rows.Count > 0)
            {
                DataGridViewRow row = dgvDSSP.SelectedRows[0];
                int rowIndex = row.Index;

                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa sp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    //&& BUS.MonAn_BUS.UpDeleteMonAn(MaMonAnDuocChon, false)
                    if (BUS.MonAn_BUS.UpDeleteCTMonAn(MaMonAnDuocChon, row.Cells["colTenKichThuoc"].Value.ToString(), false))
                    {
                        if (BUS.MonAn_BUS.SoLuongMonAnChiTietMonAn(MaMonAnDuocChon) <= 0)// đếm xem còn ở chi tiết không mới xóa ở sp
                        {
                            BUS.MonAn_BUS.UpDeleteMonAn(MaMonAnDuocChon, false); 
                        }
                         
                        LamMoiDanhSach(strTimKiemMonAn);
                        LoadDuLieuLendgvMonAn();
                        MessageBox.Show("Đã xóa món ăn ");
                        Utilities.ResetAllControls(grbThongTinSP);
                        picAnhDaiDien.Image = null;
                    }
                    else
                        MessageBox.Show("Không thể xóa");


                    // dgvDSSP.FirstDisplayedScrollingRowIndex = rowIndex;
                }


            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
