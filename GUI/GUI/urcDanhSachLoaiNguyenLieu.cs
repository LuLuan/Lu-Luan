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
    public partial class urcDanhSachLoaiNguyenLieu : UserControl
    {
        public urcDanhSachLoaiNguyenLieu()
        {
            InitializeComponent();
        }
        private string ChuoiTimKiem = "";
        List<clsLoaiNguyenLieu_DTO> lstLoaiNguyenLieu;
        private void urcDanhSachLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
           lstLoaiNguyenLieu = BUS.LoaiNguyenLieu_BUS.DSLoaiNguyenLieu(ChuoiTimKiem);
            dgvDSLoaiNguyenLieu.DataSource = lstLoaiNguyenLieu;
            
        }

        private string TaoRaMa(int iSoLuongMa)
        {
            string Ma = "";
            iSoLuongMa += 1;

            int DoDaiSoThuTu = iSoLuongMa.ToString().Length;
            if (DoDaiSoThuTu < 10)
                Ma = "LNL00" + iSoLuongMa.ToString();
            else if (DoDaiSoThuTu < 100)
                Ma = "LNL0" + iSoLuongMa.ToString();
            else if (DoDaiSoThuTu < 1000)
                Ma = "LNL" + iSoLuongMa.ToString();
            else if (DoDaiSoThuTu >= 999)
                MessageBox.Show("Tràn mã nguyên liệu, xin liên hệ hãy liên hệ adm Lu : 01634699175");

            return Ma;
        }



        private void btnThemLoaiNL_Click_1(object sender, EventArgs e)
        {
            txtTenLoaiNL.Enabled = true;
            btnHuyBoThemMoi.Enabled = true;
            btnHuyBoThemMoi.Visible = true;
            btnChinhSuaLoaiNL.Enabled = false;
            btnThemLoaiNL.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnChinhSuaLoaiNL_Click_1(object sender, EventArgs e)
        {
            txtTenLoaiNL.Enabled = true;
            btnHuyBoChinhSua.Enabled = true;
            btnHuyBoChinhSua.Visible = true;
            btnThemLoaiNL.Enabled = false;
            btnChinhSuaLoaiNL.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnHuyBoThemMoi_Click_1(object sender, EventArgs e)
        {
            txtTenLoaiNL.Enabled = false;
            btnHuyBoThemMoi.Enabled = false;
            btnHuyBoThemMoi.Visible = false;
            btnChinhSuaLoaiNL.Enabled = true;
            btnThemLoaiNL.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnHuyBoChinhSua_Click_1(object sender, EventArgs e)
        {
            txtTenLoaiNL.Enabled = false;
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
                clsLoaiNguyenLieu_DTO LoaiNguyenLieu = new clsLoaiNguyenLieu_DTO();

                LoaiNguyenLieu.MaLoaiNguyenLieu = TaoRaMa(lstLoaiNguyenLieu.Count);
                if (txtTenLoaiNL.Text =="")
                {
                    MessageBox.Show("Chưa nhập tên nguyên liệu ");
                    return;         
                }
                
                LoaiNguyenLieu.TenLoaiNguyenLieu = txtTenLoaiNL.Text;
                LoaiNguyenLieu.TrangThai = true;//tạm thời là true sửa trong thời gian update tới !

                if (BUS.LoaiNguyenLieu_BUS.InsertLoaiNguyenLieu(LoaiNguyenLieu))
                {
                    txtTenLoaiNL.Enabled = false;
                    btnHuyBoThemMoi.Enabled = false;
                    btnHuyBoThemMoi.Visible = false;
                    btnChinhSuaLoaiNL.Enabled = true;
                    btnThemLoaiNL.Enabled = true;
                    btnLuu.Enabled = false;


                    MessageBox.Show("Đã thêm loại nguyên liệu thành công ");
                    urcDanhSachLoaiNguyenLieu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm loại nguyên liệu thất bại ");
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

    }
}
