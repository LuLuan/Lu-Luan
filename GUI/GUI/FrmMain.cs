using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DTO;
using BUS;
namespace GUI
{
    public partial class FrmMain : Form
    {

       //Các con số 970, 650,... là độ rộng của panelMain truyền vào các hàm để xử lý việc chia layout
        public FrmMain()
        {
            InitializeComponent();
        }
        //Biến toàn cục
        private static List<clsNhanVien_DTO> clsNhanVien = new List<clsNhanVien_DTO>();
        private static  List<clsChucNang_DTO> clsChucNang = new List<clsChucNang_DTO>();



        #region Region này là đoạn về các hiệu ứng, menu động của form
        //Layout //
        //Tắt 3 panel con trong panel main
        public void TatVienButton(Button btnClickToLogin)
        {
            btnClickToLogin.TabStop = false;
            btnClickToLogin.FlatStyle = FlatStyle.Flat;
            btnClickToLogin.FlatAppearance.BorderSize = 0;
        }
        public void TatTatCaTrenPnlMain()
        {
            
            pnlChuaMenuDong.Visible = false;
            pnlMiniMenu.Visible = false;
            pnlThongTinTop.Visible = false;
            //Chuyển mini menu về dạng thu nhỏ
           
        }
        //Mở 1 trong 3 panel trong panel main (truyền tham số 1 panel menu động, 2 mini menu, 3 thông tin nhân viên)
        public void TatTatCaTrenPnlMain(int a)
        {
            
            pnlChuaMenuDong.Visible = false;
            pnlMiniMenu.Visible = false;
            pnlThongTinTop.Visible = false;
            if (a==1)       
                pnlChuaMenuDong.Visible = true;
            if (a==2)
            {
                pnlMiniMenu.Visible = true;
                //Chuyển mini menu về dạng thu nhỏ
                pnlMiniMenu.Size = new Size(40, 650);
                picHome.Size = new Size(40, 40);
                picHome.Dock = DockStyle.None;
                pnlMiniMenu.Dock = DockStyle.Left;
            }
            if (a == 3)           
                pnlThongTinTop.Visible = true;           
        }
        //Mở 3 panel con trong panel main
        public void MoTatCaTrenPnlMain()
        {
            pnlChuaMenuDong.Visible = true;
            pnlMiniMenu.Visible = true;
            pnlThongTinTop.Visible = true;
            pnlMiniMenu.Size = new Size(74, 74);
            pnlChuaMenuDong.Size = new Size(968, 493);
            pnlChuaMenuDong.Location = new Point(1, 76);
            picHome.Dock = DockStyle.Fill;
            pnlMiniMenu.Dock = DockStyle.None;
        }
        // Để cho panel main nó trượt qua trái
        public static void TruotTrai(Panel pnl, int with)
        {
            if (pnl.Width<with)
            {
                while( pnl.Width< with-1)
                {
                    pnl.Size = new Size(pnl.Width +10, pnl.Height);
                    //Thread.Sleep(1);
                }
            }
        }
        
        // Để cho panel main nó trượt qua phải
        public static void TruotPhai(Panel pnl, int with)
        {
            if (pnl.Width > with)
            {
                while (pnl.Width > with+1)
                {
                    pnl.Size = new Size(pnl.Width - 10, pnl.Height);
                   // Thread.Sleep(1);
                }
            }
        }
     
        Button CreateBTN(string Name,string Text,int ToaDoX, int ToaDoY, int SoLuongNutBtn, int btnDai,int btnRong,string Image)//Hàm trả về button cho menu động, các tham số truyền vào
        {
            Button btn = new Button();
            btn.Text = Text;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Name = Name;
            btn.Size = new Size(btnDai, btnRong);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Image = new Bitmap(Image);
            btn.Font = new Font("Serif", 16);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleRight;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.ForeColor = Color.Black;
            btn.BackColor = Color.White;
            btn.Location = new Point(ToaDoX, ToaDoY);
            return btn;
            //     
        }
       
        public void KhiLoadPanelMain(List<clsChucNang_DTO> ChucNang) // Hàm tạo ra các button chức năng nằm trong panelChuaMenuDong
        {
            int ToaDoX = 75;
            int ToaDoY = 70;
            int SoPhanTuBangChucNang = ChucNang.Count();
                string LinkAnh ="";
          // nút thì dài 190 rộng 100
               int BtnDai = 190;
               int BtnRong = 100;
            for (int i = 0; i < SoPhanTuBangChucNang; i++) // for này để tạo ra 1 nùi button ở panel menu động
            {
                LinkAnh ="HinhAnh/AnhChucNangMenu/"+ChucNang[i].MaChucNang+".png";
                Button btn = new Button();
                btn = CreateBTN(ChucNang[i].MaChucNang, ChucNang[i].TenChucNang, ToaDoX, ToaDoY, SoPhanTuBangChucNang, BtnDai, BtnRong, LinkAnh);
                btn.Click += new System.EventHandler(this.ChuyenForm);// add sự kiện
                pnlChuaMenuDong.Controls.Add(btn);
                    ToaDoX += 210; 
                if ((i + 1) % 4 == 0 ) // nếu tới button thứ 4 thì xuống hàng nên tọa độ Y cũng được tăng và X quay lại từ đầu
                {
                    ToaDoY += 120;
                    ToaDoX = 75;
                }                
            }
        }

        #endregion



        private void btnClickToLogin_Click(object sender, EventArgs e)
        {
            btnThoatUngDung.Visible = true;// hiện cái nút X ở màn hình đăng nhập
            btnThoatUngDung.Location = new Point(610, 0); // cho nút xuất hiện ở màn hình đăng nhập xuất hiện đúng tọa độ
            btnClickToLogin.Visible = false;
            TruotPhai(pnlMenu, 650); 
            urcDangNhap urcDN = new urcDangNhap();
            urcDN.LayKetQuaDangNhap = new urcDangNhap.GetKetQuaDangNhap(NhanKetQuaDangNhap);
            urcDN.LayThongTinNV = new urcDangNhap.GetThongTinNV(XuLyThongTinNV);
            urcDN.LayQuyenDangNhap = new urcDangNhap.GetQuyenDangNhap(LayQuyenDangNhap);
            this.Controls.Add(urcDN);    
        }
        public void XuLyThongTinNV(List<clsNhanVien_DTO> lstNV)
        {
            //clsNhanVien = lstNV;
            clsChucNang = BUS.ChucNang_BUS.LayChucNangTheoMaNhanVien(lstNV[0].MaNhanVien.ToString());
            KhiLoadPanelMain(clsChucNang);//load menu của panel main
            lbTenNhanVien.Text = lstNV[0].HoTen.ToString();
            try
            {
                btnThoatUngDung.Visible = false; // ẩn cái nút x ở ngoài màn hình đăng nhập
                picAnhNhanVien.BackgroundImage = new Bitmap(lstNV[0].AnhNhanVien.ToString());
            }
            catch (Exception)
            {
                //MessageBox.Show("NV này chưa có ảnh đại diện ạ");
            }
     
        }
        public void LayQuyenDangNhap(List<clsQuyenDangNhap_DTO> lstQDN)//Hàm này test thử lấy được quyền đăng nhập chưa
        {
            //MessageBox.Show("Mã đăng nhập của tài khoản này là: " + lstQDN.Count().ToString());
            
        }
        public void NhanKetQuaDangNhap(bool boolXuLyDangNhap)
        {
            if (boolXuLyDangNhap==true)
            {
                TruotTrai(pnlMenu, 970);
                MoTatCaTrenPnlMain();
            } 
        }

        public void ChuyenForm(object sender, EventArgs e)// Code tại đây ! đây là hàm chuyển form khi click button
        {
            #region TÊN CÁC CHƯC NĂNG VÀ MÃ CHỨC NĂNG

            /*
             * CN0001 = Chấm công.
             * CN0002 = Quản lý lỗi nhân viên
             * CN0003 = Phân công
             * CN0004 = Quản lý nhân viên
             * CN0005 = Chưa có
             * CN0006 = Quản lý nguyên liệu
             * CN0007 = Quản lý doanh thu
             * CN0008 = Quản lý khách hàng
             * CN0009 = Bán hàng
             * CN0010 = Quản lý lịch làm việc
             * CN0011 = Quản lý lịch sử bán
             * CN0012 = Quản lý lương
             * CN0013 = Quản lý sản phẩm
             * CN0014 = Quản lý cửa hàng
             
             */

            #endregion

            Button btnMenu = (Button)sender;// lấy name của btn được gọi sự kiện
            foreach (Control item in this.Controls)// ẩn hết các urc khác click vào 1 button không liên quan tới urc đó  
            {
                if (item.Name != "urcDangNhap" && item.Name != "pnlMenu")
                    item.Visible = false;
            }
          
            if (btnMenu.Name == "CN0001")  
            {
                TruotPhai(pnlMenu, 40);
                TatTatCaTrenPnlMain(2);
                
            }
            //// chức năng 0004 quản lý nhân viên
            if (btnMenu.Name == "CN0004")
            {
                TruotPhai(pnlMenu, 0);
                TatTatCaTrenPnlMain(); //Chuyển về dạng miniMenu nhỏ
                urcQLNhanVien urcQLNhanVien = new urcQLNhanVien();
                urcQLNhanVien.bolNhanPhimHome = new urcQLNhanVien.NhanPhimHome(isClickedHome);
                if (KiemTraTonTaiCuaUrc(urcQLNhanVien, this) == true)
                {
                    urcQLNhanVien.BringToFront();
                    this.Controls.Add(urcQLNhanVien);
                }
            }
            //// chức năng 08

            if (btnMenu.Name == "CN0008")
            {
                TruotPhai(pnlMenu, 0);
                TatTatCaTrenPnlMain(2); //Chuyển về dạng miniMenu nhỏ
                urcQLKhachHang urcQLKhachHang = new urcQLKhachHang();
                urcQLKhachHang.bolNhanPhimHome = new urcQLKhachHang.NhanPhimHome(isClickedHome);
                if (KiemTraTonTaiCuaUrc(urcQLKhachHang, this) == true)
                {
                    urcQLKhachHang.BringToFront();
                    this.Controls.Add(urcQLKhachHang);
                }
            }
            //// chức năng 06 quản lý nguyên liệu (kho nguyên liệu)
            if (btnMenu.Name == "CN0006")
            {
                TruotPhai(pnlMenu, 0);
                TatTatCaTrenPnlMain(); //Chuyển về dạng miniMenu nhỏ
                urcQLKhoNguyenLieu urcQLKhoNguyenLieu = new urcQLKhoNguyenLieu();
                urcQLKhoNguyenLieu.bolNhanPhimHome = new urcQLKhoNguyenLieu.NhanPhimHome(isClickedHome);
                if (KiemTraTonTaiCuaUrc(urcQLKhoNguyenLieu, this) == true)
                {
                    urcQLKhoNguyenLieu.BringToFront();
                    this.Controls.Add(urcQLKhoNguyenLieu);
                }
            }
            //// chức năng 09 bán sản phẩm
            if (btnMenu.Name == "CN0009")
            {
                TruotPhai(pnlMenu, 0);
                TatTatCaTrenPnlMain(); //Chuyển về dạng miniMenu nhỏ
                urcQLBanHang urcQLBanHang = new urcQLBanHang();
                urcQLBanHang.bolNhanPhimHome = new urcQLBanHang.NhanPhimHome(isClickedHome);
                if (KiemTraTonTaiCuaUrc(urcQLBanHang, this) == true)
                {
                    urcQLBanHang.BringToFront();
                    this.Controls.Add(urcQLBanHang);
                }
            }
            //// chức năng 13 quản lý sản phẩm ( thức ăn)
            if (btnMenu.Name == "CN0013")
            {
                TruotPhai(pnlMenu, 0);
                TatTatCaTrenPnlMain(); //Chuyển về dạng miniMenu nhỏ
                urcQLSanPham urcQLSanPham = new urcQLSanPham();
                urcQLSanPham.bolNhanPhimHome = new urcQLSanPham.NhanPhimHome(isClickedHome);
                if (KiemTraTonTaiCuaUrc(urcQLSanPham, this) == true)
                {
                    urcQLSanPham.BringToFront();
                    this.Controls.Add(urcQLSanPham);
                }
            }


        }

        private void isClickedHome(bool isclickedHome)// hàm này tạm tạo lại chút test
        {
            if (isclickedHome)
            {
                TruotTrai(pnlMenu, 970);
                MoTatCaTrenPnlMain();
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            TatTatCaTrenPnlMain();// tắt hết mở panel số 2 (miniMenu)
            TruotPhai(pnlMenu, 0);
        }

        public bool KiemTraTonTaiCuaUrc(UserControl urc, FrmMain frm) // kiểm tra urc đó đã tồn tại chưa để show lên hoặc tạo mới
        {
            foreach (Control item in frm.Controls)
            {
                if (urc.Name == item.Name)
                {
                    item.Visible = true;
                    return false;
                }
            }
            return true;
        }





        private void FrmMain_Load(object sender, EventArgs e)
        {
            TatTatCaTrenPnlMain();//tắt tất cả các thứ nằm trên panel main
            TatVienButton(btnClickToLogin); //tắt viền của button
            
///
           
        }
        #region
        //Đoạn này nói về các nút tắt form, đăng xuất, ẩn;
        private void itemMnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void itemMnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void itemMnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }         
        }

        private void btnThoatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoatUngDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnClickToLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }




    }
}
