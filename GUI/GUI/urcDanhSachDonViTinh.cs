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
    public partial class urcDanhSachDonViTinh : UserControl
    {
        public urcDanhSachDonViTinh()
        {
            InitializeComponent();
        }
        private string ChuoiTimKiem = "";
        List<clsDonViTinh_DTO> lstDonViTinh;
        private void urcDanhSachLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvDSDonViTinh.AutoGenerateColumns = false;
            lstDonViTinh = BUS.DonViTinh_BUS.DSDonViTinh();
            dgvDSDonViTinh.DataSource = lstDonViTinh; 
        }

        private string TaoRaMa(int iSoLuongMa)
        {
            string Ma = "";
            iSoLuongMa += 1;

            int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
            if (DoDaiSoThuTu <= 10)
                Ma = "DVT0" + iSoLuongMa.ToString();
            else if (DoDaiSoThuTu < 100)
                Ma = "DVT" + iSoLuongMa.ToString();
            else if (DoDaiSoThuTu >= 99)
                MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

            return Ma;
        }



        private void btnThemLoaiNL_Click_1(object sender, EventArgs e)
        {
            txtTenDonViTinh.Enabled = true;
            btnHuyBoThemMoi.Enabled = true;
            btnHuyBoThemMoi.Visible = true;
            btnChinhSuaLoaiNL.Enabled = false;
            btnThemLoaiNL.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnChinhSuaLoaiNL_Click_1(object sender, EventArgs e)
        {
            txtTenDonViTinh.Enabled = true;
            btnHuyBoChinhSua.Enabled = true;
            btnHuyBoChinhSua.Visible = true;
            btnThemLoaiNL.Enabled = false;
            btnChinhSuaLoaiNL.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnHuyBoThemMoi_Click_1(object sender, EventArgs e)
        {
            txtTenDonViTinh.Enabled = false;
            btnHuyBoThemMoi.Enabled = false;
            btnHuyBoThemMoi.Visible = false;
            btnChinhSuaLoaiNL.Enabled = true;
            btnThemLoaiNL.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnHuyBoChinhSua_Click_1(object sender, EventArgs e)
        {
            txtTenDonViTinh.Enabled = false;
            btnHuyBoChinhSua.Enabled = false;
            btnHuyBoChinhSua.Visible = false;
            btnThemLoaiNL.Enabled = true;
            btnChinhSuaLoaiNL.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (btnHuyBoThemMoi.Visible == true)
            {   //Giao diện
                
                //
                clsDonViTinh_DTO DonViTinh = new clsDonViTinh_DTO();

                DonViTinh.MaDonViTinh= TaoRaMa(lstDonViTinh.Count);
                if (txtTenDonViTinh.Text=="")
                {
                    MessageBox.Show("Chưa nhập tên đơn vị mới ");
                    return;         
                }

                DonViTinh.TenDonViTinh = txtTenDonViTinh.Text;
                DonViTinh.TrangThai = true;//tạm thời là true sửa trong thời gian update tới !
                MessageBox.Show(DonViTinh.MaDonViTinh.ToString() + "-" + DonViTinh.TenDonViTinh + "-" + DonViTinh.TrangThai.ToString()); return;
                if (BUS.DonViTinh_BUS.InsertDonViTinh(DonViTinh))
                {
                    txtTenDonViTinh.Enabled = false;
                    btnHuyBoThemMoi.Enabled = false;
                    btnHuyBoThemMoi.Visible = false;
                    btnChinhSuaLoaiNL.Enabled = true;
                    btnThemLoaiNL.Enabled = true;
                    btnLuu.Enabled = false;


                    MessageBox.Show("Đã thêm đơn vị tính thành công ");
                    urcDanhSachLoaiNguyenLieu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm đơn vị tính thất bại ");
                }


            }
            if (btnHuyBoChinhSua.Visible == true)
            {  //Giao diện
                btnHuyBoChinhSua.Enabled = false;
                btnHuyBoChinhSua.Visible = false;
                btnThemLoaiNL.Enabled = true;
                btnChinhSuaLoaiNL.Enabled = true;
                btnLuu.Enabled = false;
                //
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

    }
}
