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
using System.Globalization;
namespace GUI
{
    public partial class urcBanHang : UserControl
    {
        public urcBanHang()
        {
            InitializeComponent();
        }
        public static float tongtien = 0;
        public static DataTable dt = new DataTable();
        List<clsKichThuocMonAn_DTO> lstKichThuocMonAn = BUS.KichThuocMonAn_BUS.DSKichThuoc();
        List<clsMonAn_DTO> lstMonAn = BUS.MonAn_BUS.DSMonAn("");
        ListView.SelectedListViewItemCollection ItemDuocChon;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void urcBanHang_Load(object sender, EventArgs e)
        {
            
          //  LoadDulieuLenListView();
            LoadDulieuLenListView(lswThucUong);
            dgvGioHang.Columns["colGia"].DefaultCellStyle.Format = "#,### đ";

            TaoDataTable();


        }
        private void LoadDulieuLenListView(ListView lstView)
        {
            DuaDuLieuLenListView(lstMonAn, lstView);
        }

        private void DuaDuLieuLenListView(List<clsMonAn_DTO> lstMonAn,ListView lstView)
        {
            lswThucUong.Items.Clear();
            foreach (clsMonAn_DTO tr in lstMonAn)
            {
                ThemListViewItem(tr, lstView);
            }
            lswThucUong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lvwTruyen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }
        private void ThemListViewItem(clsMonAn_DTO MonAn, ListView lstView)
        {
            // tạo ListViewItem 
            ListViewItem lvi = new ListViewItem(MonAn.TenMonAn);
            lvi.SubItems.Add(MonAn.MaMonAn.ToString());
            lvi.SubItems.Add(MonAn.MaDonViTinh);
            if (MonAn.AnhMonAn != null)
            {
                string url = MonAn.AnhMonAn;
                if (url != "")
                {
                    try
                    {
                        Bitmap bm = new Bitmap(url);
                        ilsLon.Images.Add(url, bm); // set key là url
                        ilsNho.Images.Add(url, bm);
                        lvi.ImageKey = url;
                    }
                    catch (Exception)
                    {

                        Bitmap bm = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
                        ilsLon.Images.Add(url, bm); // set key là url
                        ilsNho.Images.Add(url, bm);

                        lvi.ImageKey = url;
                    }
                   
                }
                else
                    if (url == "")
                    {
                        //@"HinhAnh\AnhMonAn\no_picture.gif"; h×nh defaul

                        Bitmap bm = new Bitmap(@"HinhAnh\AnhMonAn\no_picture.gif");
                        ilsLon.Images.Add(url, bm); // set key là url
                        ilsNho.Images.Add(url, bm);
                        
                        lvi.ImageKey = url;
                    }

            }


            // add lvi vào listview
            lstView.Items.Add(lvi);
        }

        private void rdbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            lswThucUong.View = View.LargeIcon;
        }

        private void rdbDetails_CheckedChanged(object sender, EventArgs e)
        {
            lswThucUong.View = View.Details;
        }

        private void rdbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            lswThucUong.View = View.SmallIcon;
        }

        private void rdbList_CheckedChanged(object sender, EventArgs e)
        {
            lswThucUong.View = View.List;
        }

        private void rdbTile_CheckedChanged(object sender, EventArgs e)
        {
            lswThucUong.View = View.Tile;
        }

        private void lswThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lswThucUong.SelectedItems.Count > 0) // Xử lý khi có item được chọn
            {
                txtSoLuong.Enabled = true;

               ItemDuocChon = lswThucUong.SelectedItems;
                picAnhMonAn.ImageLocation = ItemDuocChon[0].ImageKey;
                txtTenMon.Text = ItemDuocChon[0].Text;
                txtSoLuong.Text = "1";

                cbbKichThuocMonAn.DataSource = lstKichThuocMonAn;
                cbbKichThuocMonAn.DisplayMember = "TenKichThuoc";
                cbbKichThuocMonAn.ValueMember = "MaKichThuoc";
                cbbKichThuocMonAn.SelectedIndex = 0;

                txtGia.Text = (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text))).ToString(); // String.Format("{0:C0}", (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text))));  //
            }
            else
            {
                picAnhMonAn.ImageLocation = "";
                txtTenMon.Clear();
                txtSoLuong.Clear();
                txtGia.Clear();
                txtSoLuong.Enabled = false;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSoLuong.Text!="")
            {
                txtGia.Text = (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text))).ToString(); //String.Format("{0:C0}", (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text)))); 
            } 
        }

        private void cbbKichThuocMonAn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtTenMon.Text=="")return;
            
            txtGia.Text = (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text))).ToString(); String.Format("{0:C0}", (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString()) * (float.Parse(txtSoLuong.Text)))); // 
            
        }
        void TaoDataTable()
        {
            DataColumn dc = new DataColumn("colTenMon", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colDonGia", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colSL", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("colGia", typeof(String));
            dt.Columns.Add(dc);
            dc = new DataColumn("colMaMon", typeof(String));
            dt.Columns.Add(dc);
        }
        private void txtThemSanPham_Click(object sender, EventArgs e)
        {
            int iTongtien = 0;
            bool flag = true;
            DataRow dr = dt.NewRow();
            //ItemDuocChon[0].SubItems[1].Text;
            dr[0] =  txtTenMon.Text + "(" + cbbKichThuocMonAn.Text + ")";
            dr[1] = (BUS.MonAn_BUS.GiaMonAnChiTiet(ItemDuocChon[0].SubItems[1].Text, cbbKichThuocMonAn.SelectedValue.ToString())).ToString();
            dr[2] = txtSoLuong.Text ;
            dr[3] = txtGia.Text ;
            dr[4] = ItemDuocChon[0].SubItems[1].Text;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
              //  MessageBox.Show(dgvGioHang.Rows[i].Cells[1].Value.ToString());
                if (dgvGioHang.Rows[i].Cells[0].Value.ToString() == dr[0].ToString())
                {
                    flag = false;
                    float newTien = (float.Parse(dgvGioHang.Rows[i].Cells[3].Value.ToString())) + float.Parse(dr[3].ToString());
                    dgvGioHang.Rows[i].Cells[3].Value =  newTien.ToString();
                    float newSL = (float.Parse(dgvGioHang.Rows[i].Cells[2].Value.ToString()))+ float.Parse(dr[2].ToString());
                    dgvGioHang.Rows[i].Cells[2].Value = newSL.ToString();
                }
                
            }
            if (flag)
            {
                dt.Rows.Add(dr);
                flag = true;
            }
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.DataSource = dt;



            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                iTongtien += int.Parse(String.Format("{0:0}",dgvGioHang.Rows[i].Cells[3].Value.ToString()));
            }
            tongtien = float.Parse(iTongtien.ToString());
            txtTongTien.Text = String.Format("{0:C0}", iTongtien);
         //   MessageBox.Show();

           // Utilities.ResetAllControls(grbThongTinThemMonAnVaoHoaDon);


        }


        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count<=0) return;
            urcThanhToan urcThanhToan = new urcThanhToan();
            urcThanhToan.xulyui = new GUI.urcThanhToan.XuLyUI(XuLiTruotleftPanel);
            urcThanhToan.xulytaothanhconghoadon = new GUI.urcThanhToan.XuLyTaoThanhCongHoaDon(XuLyTaoThanhCongHoaDon);
            pnlright.Controls.Add(urcThanhToan);
            urcThanhToan.BringToFront();
            XuLiTruotleftPanel(true);
            //this.Visible = true;

        }
        void XuLyTaoThanhCongHoaDon(bool isAddOk)
        {
            if (isAddOk)
            {
                ResetHoaDon();
            }
        }
        void XuLiTruotleftPanel(bool isAppear)
        {

            
            if (isAppear)
            {
                grbChuNangThanhToan.Visible = false;
                lblTongTien.Location = new Point(lblTongTien.Location.X, 498); 
                txtTongTien.Location = new Point(txtTongTien.Location.X, 493);
                dgvGioHang.Size = new Size(dgvGioHang.Size.Width, 485);
            }
            else
            {
                grbChuNangThanhToan.Visible = true;
                lblTongTien.Location = new Point(3, 366);
                txtTongTien.Location = new Point(117, 361);
                dgvGioHang.Size = new Size(dgvGioHang.Size.Width, 355);
            }
           
        }
        private void btnTraSP_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvGioHang.SelectedRows)
            {
                dgvGioHang.Rows.RemoveAt(item.Index);
            }
            int iTongtien = 0;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                iTongtien += int.Parse(String.Format("{0:0}", dgvGioHang.Rows[i].Cells[3].Value.ToString()));
            }
            tongtien = float.Parse(iTongtien.ToString());
            txtTongTien.Text = String.Format("{0:C0}", iTongtien); 
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            ResetHoaDon();
        }
        void ResetHoaDon()
        {
            do
            {
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    try
                    {
                        dgvGioHang.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvGioHang.Rows.Count > 0);

            int iTongtien = 0;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                iTongtien += int.Parse(String.Format("{0:0}", dgvGioHang.Rows[i].Cells[3].Value.ToString()));
            }
            tongtien = float.Parse(iTongtien.ToString());
            txtTongTien.Text = String.Format("{0:C0}", iTongtien); 
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {
            if (txtTenMon.Text=="")
              txtThemSanPham.Enabled = false;else txtThemSanPham.Enabled = true;
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
         

        }
        string[] timkiem = { "", "", "" };
        int vitritabcu = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //luu lai tu tim kiem
            //chuyen noi dung
            //MessageBox.Show(tabControl1.TabPages.IndexOf(tabControl1.SelectedTab).ToString());
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab)==0)
            {
                timkiem[vitritabcu] = txtTimKiem.Text;
                vitritabcu = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                txtTimKiem.Text = timkiem[vitritabcu].ToString();
            }
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 1)
            {
                timkiem[vitritabcu] = txtTimKiem.Text ;
                vitritabcu = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                txtTimKiem.Text = timkiem[vitritabcu].ToString();
              
            }
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 2)
            {
                timkiem[vitritabcu] = txtTimKiem.Text;
                vitritabcu = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                txtTimKiem.Text = timkiem[vitritabcu].ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string ChuoiTimKiem = timkiem[vitritabcu].ToString();
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 0)
            {
                lswThucUong.Items.Clear();
                LoadDulieuLenListView(lswThucUong);
            }
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 1)
            {
                lswTopping.Items.Clear();
                LoadDulieuLenListView(lswTopping);

            }
            if (tabControl1.TabPages.IndexOf(tabControl1.SelectedTab) == 2)
            {
                lswMonAn.Items.Clear();
                LoadDulieuLenListView(lswMonAn);
            }
        }

    }
}
