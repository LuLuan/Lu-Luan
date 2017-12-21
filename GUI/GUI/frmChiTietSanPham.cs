using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmChiTietSanPham : Form
    {
        private string maspp;

        public frmChiTietSanPham()
        {
            InitializeComponent();
        }

        public frmChiTietSanPham(string maspp)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.maspp = maspp;
        }
       
        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
          dgvThanhPhanMonAn.AutoGenerateColumns = false;
          List<clsMonAn_DTO> MonAn = BUS.MonAn_BUS.LayMotMonAn(maspp);
          List<clsThanhPhanMonAn_DTO> lstThanhPhan = BUS.ThanhPhanMonAn_BUS.LayCacThanhPhanCuaMon(maspp);
          dgvThanhPhanMonAn.DataSource = lstThanhPhan;
          txtMaMonAn.Text = maspp;  //sida  bữa m ;kêu lỗi gì đó thì phải :)):))
          txtTenMonAn.Text = MonAn[0].TenMonAn.ToString();
          picAnhMonAn.Image = Image.FromFile(MonAn[0].AnhMonAn.ToString()); 
        }
        List<clsNguyenLieu_DTO> lstNguyenLieu = BUS.NguyenLieu_BUS.DSNguyenLieu("");

        private void dgvThanhPhanMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvThanhPhanMonAn.Columns[e.ColumnIndex].Name == "colTenNguyenLieu")
            {
                clsNguyenLieu_DTO dtoNguyenLieu = lstNguyenLieu.First(u => u.MaNguyenLieu == e.Value.ToString());
                e.Value = dtoNguyenLieu.TenNguyenLieu;
            }
        }
    }
}
