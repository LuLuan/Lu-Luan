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
    public partial class urcDanhSachTaiKhoan : UserControl
    {
        public urcDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        
       
        private void urcDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiDSTaiKhoan();
            HienThiDSQuyenDangNhapComboBox();
            HienThiDSTrangThaiTaiKhoan();
            
        }

        #region Hiển thị dữ liệu lên DataGridView, ComboBox, ....

        private void HienThiDSTaiKhoan()
        {
            TaiKhoan_BUS bus = new TaiKhoan_BUS();
            List<clsTaiKhoan_DTO> lstTaiKhoan = bus.LayDanhSachTaiKhoan("");
            dgvDSTK.AutoGenerateColumns = false;
            dgvDSTK.DataSource = lstTaiKhoan;
        }

        private void HienThiDSQuyenDangNhapComboBox()
        {
            QuyenDangNhap_BUS bus = new QuyenDangNhap_BUS();
            List<clsQuyenDangNhap_DTO> lstQuyenDangNhap = bus.LayQuyenDangNhapTheoMaQDN("");
            clsQuyenDangNhap_DTO dtoQuyenDangNhap = new clsQuyenDangNhap_DTO();
            dtoQuyenDangNhap.MaQuyenDangNhap = "";
            dtoQuyenDangNhap.TenQuyenDangNhap = "Quyền đăng nhập";
            lstQuyenDangNhap.Insert(0, dtoQuyenDangNhap);
            cboQuyenDangNhap.DataSource = lstQuyenDangNhap;
            cboQuyenDangNhap.DisplayMember = "TenQuyenDangNhap";
            cboQuyenDangNhap.ValueMember = "MaQuyenDangNhap";
            cboQuyenDangNhap.SelectedIndex = 0;
        }

        private void HienThiDSTrangThaiTaiKhoan()
        {
            cboTrangThai.DisplayMember = "tenTrangThai";
            cboTrangThai.ValueMember = "giaTri";

            var trangThai = new[]
            { 
                new { tenTrangThai = "Tất cả", giaTri = "-1" }, 
                new { tenTrangThai = "Kích hoạt", giaTri = "True" }, // Kích hoạt
                new { tenTrangThai = "Vô hiệu hóa", giaTri = "False" } //Vô hiệu
            };

            cboTrangThai.DataSource = trangThai;
        }



        #endregion



        private void dgvDSTK_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TrangThaiBanDau();
        }
        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDSTK.Rows.Count > 0)
            {
                DataGridViewRow row = dgvDSTK.SelectedRows[0];

                cboQuyenDangNhap.SelectedValue = row.Cells["colQuyenDangNhap"].Value.ToString();
                cboTrangThai.SelectedValue = row.Cells["colTrangThai"].Value.ToString();
                txtMaDangNhap.Text = row.Cells["colMaDangNhap"].Value.ToString().Trim();
                txtMatKhau.Text = row.Cells["colMatKhau"].Value.ToString().Trim();
                txtMaKhanCap.Text = row.Cells["colMaKhanCap"].Value.ToString().Trim();

                DateTime dtNgayDangKy = DateTime.Parse(row.Cells["colNgayTao"].Value.ToString());
                LayNgayTrongDataGridViewLenDateTimePicker(dtpNgayDangKy, dtNgayDangKy);

                TrangThaiKhiChonMotNhanVien();

            }
        }

        private void dgvDSTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvDSTK.Columns[e.ColumnIndex].Name == "colHoTen")
            {
                List<clsNhanVien_DTO> lstNhanVien = BUS.NhanVien_BUS.LayNhanVienTheoMa("");
                clsNhanVien_DTO dtoNhanVien = lstNhanVien.First(u => u.MaNhanVien == e.Value.ToString());
                e.Value = dtoNhanVien.HoTen;
            }

            if (dgvDSTK.Columns[e.ColumnIndex].Name == "colQuyenDangNhap")
            {
                QuyenDangNhap_BUS bus = new QuyenDangNhap_BUS();
                List<clsQuyenDangNhap_DTO> lstQDN = bus.LayQuyenDangNhapTheoMaQDN("");
                clsQuyenDangNhap_DTO dtoQDN = lstQDN.First(u => u.MaQuyenDangNhap == e.Value.ToString());
                e.Value = dtoQDN.TenQuyenDangNhap;
            }

            if (dgvDSTK.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if (Convert.ToBoolean(e.Value.ToString()) == false)
                    e.Value = "Đã vô hiệu";
                else e.Value = "Đã kích hoạt";
            }


            foreach(DataGridViewRow r in dgvDSTK.Rows)
            {
                if (Convert.ToBoolean(r.Cells["colTrangThai"].Value) == false)
                    r.DefaultCellStyle.ForeColor = Color.Gray;
                else r.DefaultCellStyle.ForeColor = Color.Black;
            }
        }


        #region Nút Cập nhật, Hủy thao tác
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật");
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            HienThiDSTaiKhoan();
            TrangThaiBanDau();
            cboQuyenDangNhap.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
        }
        #endregion


        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
        }

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



        private void TrangThaiBanDau()
        {
            btnCapNhat.Enabled = false;
            foreach (Control ctr in grbTTTaiKhoan.Controls)
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

            foreach (Control ctr in grbDSTaiKhoan.Controls)
            {
                if (ctr is DataGridView)
                {
                    DataGridView dgv = (DataGridView)ctr;
                    dgv.ClearSelection();
                }
            }
        }

        private void TrangThaiKhiChonMotNhanVien()
        {
            btnCapNhat.Enabled = true;
            foreach (Control ctr in grbTTTaiKhoan.Controls)
            {

                if (ctr is TextBox)
                {
                    TextBox TextBox = (TextBox)ctr;
                    TextBox.Enabled = true;
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






        //Tìm kiếm
        private void txtHoTen_TK_TextChanged(object sender, EventArgs e)
        {
            TaiKhoan_BUS bus = new TaiKhoan_BUS();
            List<clsTaiKhoan_DTO> lstTaiKhoan = bus.LayDanhSachTaiKhoan(txtHoTen_TK.Text);
            dgvDSTK.AutoGenerateColumns = false;
            dgvDSTK.DataSource = lstTaiKhoan;
        }

        private void dgvDSTK_SelectionChanged(object sender, EventArgs e)
        {

        }

        


        

        

    }
}
