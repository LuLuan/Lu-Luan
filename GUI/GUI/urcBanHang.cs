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
    public partial class urcBanHang : UserControl
    {
        public urcBanHang()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void urcBanHang_Load(object sender, EventArgs e)
        {
            List<clsMonAn_DTO> lstMonAn = BUS.MonAn_BUS.DSMonAn("");
            DuaDuLieuLenListView(lstMonAn);
        }

        private void DuaDuLieuLenListView(List<clsMonAn_DTO> lstMonAn)
        {
            lswThucUong.Items.Clear();
            foreach (clsMonAn_DTO tr in lstMonAn)
            {
                ThemListViewItem(tr);
            }
            lswThucUong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lvwTruyen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }
        private void ThemListViewItem(clsMonAn_DTO MonAn)
        {
            // tạo ListViewItem 
            ListViewItem lvi = new ListViewItem(MonAn.TenMonAn);
            lvi.SubItems.Add(MonAn.MaMonAn.ToString());
            lvi.SubItems.Add(MonAn.MaLoaiMon);
            lvi.SubItems.Add(MonAn.MaDonViTinh);
            
            //lvi.SubItems.Add(string.Format("{0:#,###}", tr.GiaNhap));
            //lvi.SubItems.Add(string.Format("{0:#,###}", tr.GiaBan));
            //lvi.SubItems.Add(tr.TheLoai);
            //lvi.SubItems.Add(tr.KieuTruyen);
            //lvi.SubItems.Add(tr.MaNXB);
            // xử lý HinhAnh
            if (MonAn.AnhMonAn != null)
            {
                string url = MonAn.AnhMonAn;
                if (url != "")
                {
                    Bitmap bm = new Bitmap(url);
                    ilsLon.Images.Add(url, bm); // set key là url
                    ilsNho.Images.Add(url, bm);
                    lvi.ImageKey = url;
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
            lswThucUong.Items.Add(lvi);
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

    }
}
