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
    public partial class urcNhaCungCap : UserControl
    {
        public urcNhaCungCap()
        {
            InitializeComponent();
        }
        private List<clsNhaCungCap_DTO> lstNhaCungCap;
        private void btnThemMoiNCC_Click(object sender, EventArgs e)
        {

            txtSoDienThoaiNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;

            btnThemMoiNCC.Enabled = false;
            btnHuyBoThemMoi.Visible = true;
            btnLuu.Enabled = true;
            btnChinhSuaNCC.Enabled = false;
            Utilities.ResetAllControls(grbThongTinNCC);
            dgvDSNhaCungCap.Enabled = false;
        }

        private void btnChinhSuaNCC_Click(object sender, EventArgs e)
        {
            txtSoDienThoaiNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;


            btnThemMoiNCC.Enabled = false;
            btnChinhSuaNCC.Enabled = false;
            btnHuyBoChinhSua.Visible = true;
            btnLuu.Enabled = true;
            dgvDSNhaCungCap.Enabled = false;
        }

        private void btnHuyBoThemMoi_Click(object sender, EventArgs e)
        {
            txtSoDienThoaiNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChiNCC.Enabled = false;


            btnChinhSuaNCC.Enabled = true;
            btnThemMoiNCC.Enabled = true;
            btnHuyBoThemMoi.Visible = false;
            btnLuu.Enabled = false;
            dgvDSNhaCungCap.Enabled = true;
        }

        private void btnHuyBoChinhSua_Click(object sender, EventArgs e)
        {
            txtSoDienThoaiNCC.Enabled = false ;
            txtTenNCC.Enabled = false;
            txtDiaChiNCC.Enabled = false;

            btnThemMoiNCC.Enabled = true;
            btnChinhSuaNCC.Enabled = true;
            btnHuyBoChinhSua.Visible = false;
            btnLuu.Enabled = false;
            dgvDSNhaCungCap.Enabled = true;
        }

        private string TaoRaMa(int iSoLuongMa)
        {
            string Ma = "";
            iSoLuongMa += 1;

            if (iSoLuongMa < 10)
                Ma = "NCC00" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 100)
                Ma = "NCC0" + iSoLuongMa.ToString();
            else if (iSoLuongMa < 1000)
                Ma = "NCC" + iSoLuongMa.ToString();
            else if (iSoLuongMa >= 999)
                MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

            return Ma;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text=="")
            {
                MessageBox.Show("Chưa nhập tên"); return;
            }
            if (txtDiaChiNCC.Text=="")
            {
                MessageBox.Show("Chưa nhập địa chỉ"); return;
            }
            if (txtSoDienThoaiNCC.Text=="")
            {
                MessageBox.Show("Chưa nhập số điện thoại"); return;
            }



            if (btnHuyBoThemMoi.Visible)
            {
                clsNhaCungCap_DTO NhaCungCap = new clsNhaCungCap_DTO();
                NhaCungCap.MaNhaCungCap = TaoRaMa(dgvDSNhaCungCap.Rows.Count);
                NhaCungCap.TenNhaCungCap = txtTenNCC.Text;
                NhaCungCap.DiaChi = txtDiaChiNCC.Text;
                NhaCungCap.SoDienThoai = txtSoDienThoaiNCC.Text;
                NhaCungCap.TrangThai = true;

              //  MessageBox.Show(NhaCungCap.MaNhaCungCap + NhaCungCap.TenNhaCungCap + NhaCungCap.DiaChi + NhaCungCap.SoDienThoai + NhaCungCap.TrangThai);
                if (BUS.NhaCungCap_BUS.InsertNhaCungCap(NhaCungCap))
                {
                    btnHuyBoThemMoi_Click(sender, e);
                    MessageBox.Show("Đã lưu thêm mới");
                    Utilities.ResetAllControls(grbThongTinNCC);
                    urcNhaCungCap_Load(sender, e);
                }
              
            }
            if (btnHuyBoChinhSua.Visible)
            {
                btnHuyBoChinhSua_Click(sender, e);
                MessageBox.Show("Đã chỉnh sửa thành công");
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void urcNhaCungCap_Load(object sender, EventArgs e)
        {
            lstNhaCungCap = BUS.NhaCungCap_BUS.DSNhaCungCap("");
            dgvDSNhaCungCap.AutoGenerateColumns = false;
            MessageBox.Show(lstNhaCungCap.Count.ToString());
            dgvDSNhaCungCap.DataSource = lstNhaCungCap;
        }
    }
}
