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
  public partial class urcDanhSachPhanCong : UserControl
  {
    public urcDanhSachPhanCong()
    {
      InitializeComponent();
    }

    Utilities utl = new Utilities();

    private void urcDanhSachPhanCong_Load(object sender, EventArgs e)
    {
      HienThiListViewNhanVien();
      cboKhungNhin.SelectedIndex = 0;
      ToggleTextBoxPlaceHolder(txtTimKiem);
      AutoGenerateLabel();
      AutoGenerateCheckBox();


      //BanPhanCong_BUS busBPC = new BanPhanCong_BUS();
      //string ma = busBPC.LayMaTuDong();

      //ChiTietBanPhanCong_BUS busCTBPC = new ChiTietBanPhanCong_BUS();
      //string maCTBPC = busCTBPC.LayMaTuDong();

      //MessageBox.Show("Mã bản phân công là: "+ma + "\n" + " Mã chi tiết bản phân công là " + maCTBPC);

    }


    private void HienThiListViewNhanVien()
    {
      listviewNhanVien.Items.Clear();
      NhanVien_BUS bus = new NhanVien_BUS();
      List<clsNhanVien_DTO> listNhanVien = bus.LayDanhSachNhanVienCoChonLoc("", "", -1, 1, 3);

      foreach (clsNhanVien_DTO nhanVien in listNhanVien)
        ThemNhanVienVaoListViewNhanVien(nhanVien);
    }


    private void ThemNhanVienVaoListViewNhanVien(clsNhanVien_DTO NV)
    {
      ListViewItem lvItem = new ListViewItem(NV.HoTen + " - " + NV.MaNhanVien);
      lvItem.SubItems.Add(NV.MaNhanVien);
      string gioiTinh = "";
      if (NV.GioiTinh.ToString() == "True")
        gioiTinh = "Nam";
      else gioiTinh = "Nữ";
      lvItem.SubItems.Add(gioiTinh);
      lvItem.SubItems.Add(NV.SoDienThoai);
      string trangThai = "";
      if (NV.TrangThai == 1)
        trangThai = "Đang làm việc";
      else trangThai = "Chưa vào làm";
      lvItem.SubItems.Add(trangThai);

      string imageURL = NV.AnhNhanVien;
      Bitmap bm = new Bitmap(imageURL);
      largeImageList.Images.Add(imageURL, bm);
      smallImageList.Images.Add(imageURL, bm);
      lvItem.ImageKey = imageURL;

      listviewNhanVien.Items.Add(lvItem);
    }

    private void cboKhungNhin_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboKhungNhin.SelectedItem.ToString() == "Large Icon")
        listviewNhanVien.View = View.LargeIcon;
      if (cboKhungNhin.SelectedItem.ToString() == "Detail")
        listviewNhanVien.View = View.Details;
      if (cboKhungNhin.SelectedItem.ToString() == "Tile")
        listviewNhanVien.View = View.Tile;
    }



    #region TextBox PlaceHolder
    private void ToggleTextBoxPlaceHolder(TextBox TextBox)
    {
      TextBox.GotFocus += new EventHandler(this.GotOrLostFocusTextBox);
      TextBox.LostFocus += new EventHandler(this.GotOrLostFocusTextBox);
    }
    private void GotOrLostFocusTextBox(Object sender, EventArgs e)
    {
      TextBox TextBox = (TextBox)sender;
      if (TextBox.Focused)
      {
        TextBox.Text = "";
        TextBox.ForeColor = Color.Black;
      }

      if (!TextBox.Focused)
      {
        TextBox.Text = "Nhập mã hoặc tên nhân viên để tìm kiếm";
        TextBox.ForeColor = Color.Gray;
      }
    }
    #endregion


    #region Tìm kiếm
    private void txtTimKiem_TextChanged(object sender, EventArgs e)
    {
      if (!txtTimKiem.Focused)
        return;
      //LayNhanVienTheoTenHoacMa
      listviewNhanVien.Items.Clear();
      NhanVien_BUS bus = new NhanVien_BUS();

      List<clsNhanVien_DTO> listNhanVien = bus.LayNhanVienTheoTenHoacMaa(txtTimKiem.Text, txtTimKiem.Text);

      foreach (clsNhanVien_DTO nhanVien in listNhanVien)
        ThemNhanVienVaoListViewNhanVien(nhanVien);

    }
    #endregion

    private void listviewNhanVien_DoubleClick(object sender, EventArgs e)
    {
      foreach (ListViewItem item in listviewNhanVien.SelectedItems)
      {
        if (listviewNhanVien.SelectedItems[0].ForeColor != Color.Red)
        {
          listviewDanhSachChon.Items.Add((ListViewItem)item.Clone());
          listviewNhanVien.SelectedItems[0].ForeColor = Color.Red;
        }

      }
    }

    private void listviewDanhSachChon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      ListViewItem item = listviewDanhSachChon.SelectedItems[0];
      ListViewItem lsNV = listviewNhanVien.FindItemWithText(item.Text);
      lsNV.ForeColor = Color.Black;

      listviewDanhSachChon.Items.Remove(item);
    }


    public void AutoGenerateLabel()
    {
      int x = 90;
      int y = 201;
      int soLuongCanPhatSinh = 7; // 7 ngày 1 tuần
      string ten = "ngayThu";
      int sizeX = 52;
      int sizeY = 17;

      for (int i = 0; i < soLuongCanPhatSinh; i++)
      {
        DateTime ngayBatDau = dtpNgayBatDau.Value;
        Label lbl = CreateLabel(ten + (i + 1).ToString(), ngayBatDau.AddDays(i).ToString("dd/MM"), x, y, sizeX, sizeY);

        this.grbDanhSachNVDuocChon.Controls.Add(lbl);
        x += 65;
      }
    }

    Label CreateLabel(string ten, string text, int x, int y, int sizeX, int sizeY)
    {
      Label lbl = new Label();
      lbl.Name = ten;
      lbl.Text = text;
      lbl.Location = new Point(x, y);
      lbl.Font = new Font("Serif", 10, System.Drawing.FontStyle.Bold);
      lbl.ForeColor = Color.Black;
      lbl.BackColor = Color.White;
      lbl.Size = new Size(sizeX, sizeY);
      return lbl;
    }

    public void AutoGenerateCheckBox()
    {
      int x = 104;
      int y = 230;
      int soLuongCanPhatSinh = 14; // 7 ngày 1 tuần
      string ten = "chbsang";
      int sizeX = 15;
      int sizeY = 15;
      int temp = 0;
      for (int i = 0; i < soLuongCanPhatSinh; i++)
      {

        CheckBox chb = CreateCheckbox(ten + dtpNgayBatDau.Value.AddDays(temp).ToString("ddMMyyyy"), x, y, sizeX, sizeY);
        this.grbDanhSachNVDuocChon.Controls.Add(chb);

        x += 65;
        temp++;

        if ((i + 1) % 7 == 0 && i % 14 != 0)
        {
          ten = "chbchieu";
          x = 104;
          y += 45;
          temp = 0;
        }
      }


    }

    //private void UncheckAutomaticallyCheckBox()
    //{
    //  foreach (Control ctr in grbDanhSachNVDuocChon.Controls)
    //  {
    //    if (ctr is CheckBox)
    //    {
    //      CheckBox chb = (CheckBox)ctr;
    //      chb.Checked = false;
    //    }
    //  }
    //}

    CheckBox CreateCheckbox(string ten, int x, int y, int sizeX, int sizeY)
    {
      CheckBox chb = new CheckBox();
      chb.Name = ten;
      chb.Location = new Point(x, y);
      chb.Font = new Font("Serif", 9, System.Drawing.FontStyle.Bold);
      chb.Size = new Size(sizeX, sizeY);
      return chb;
    }

    private void dtpNgayBatDauLamTheoPhanCong_ValueChanged(object sender, EventArgs e)
    {
      DeleteCheckBoxes(grbDanhSachNVDuocChon);
      GenerateDateAutomatically();
      //AutoGenerateLabel();
      AutoGenerateCheckBox();
    }

    private void DeleteCheckBoxes(GroupBox grb)
    {

      for (int i = grb.Controls.Count - 1; i > 0; i--)
      {
        if (grb.Controls[i] is CheckBox)
          grb.Controls.Remove(grb.Controls[i]);
      }
    }

    private void GenerateDateAutomatically()
    {
      foreach (Control ctr in grbDanhSachNVDuocChon.Controls)
      {
        if (ctr is Label)
        {
          Label lbl = (Label)ctr;

          for (int i = 0; i < 7; i++)
          {
            if (lbl.Name == "ngayThu" + (i + 1).ToString())
              lbl.Text = dtpNgayBatDau.Value.AddDays(i).ToString("dd/MM");
          }

        }
      }
    }


    private void button3_Click(object sender, EventArgs e)
    {

      
      // Nếu có nhân viên được chọn
      if (listviewDanhSachChon.Items.Count > 0)
      {

        if (DialogResult.Yes == MessageBox.Show("Thêm bản phân công mới" + dtpNgayBatDau.Value.ToString(), "Thêm", MessageBoxButtons.YesNo))
        {
          ChiTietBanPhanCong_BUS busChiTietBPC = new ChiTietBanPhanCong_BUS();

          //if (busBPC.TaoBanPhanCong(banPhanCong))
          //{
          //  MessageBox.Show("ThemThanhCong");
          //}

          ////Duyệt qua từng nhân viên đã chọn
          foreach (ListViewItem lvItem in listviewDanhSachChon.Items)
          {

            ////Duyệt Control trong Groupbox, lấy ra các control là CheckBox
            foreach (Control ctr in grbDanhSachNVDuocChon.Controls)
            {



              if (ctr is CheckBox)
              {
                CheckBox chb = (CheckBox)ctr;
                string checkBoxName = "chbsang";
                int temp = 0;
                for (int i = 0; i < 14; i++)
                {
                  DateTime ngayBatDau = dtpNgayBatDau.Value;

                  if (chb.Name == checkBoxName + ngayBatDau.AddDays(temp).ToString("ddMMyyyy") && chb.Checked)
                  {
                    
                    string maNV = lvItem.Text;
                    string ngayLam = chb.Name.Substring(chb.Name.Length - 8);

                    //DateTime ngayLamViec = DateTime.Parse(ngayLam.Substring(0, 2) + "/" + ngayLam.Substring(2, 2) + "/" + ngayLam.Substring(4));
                    //MessageBox.Show(ngayLamViec.ToString());



                    //MessageBox.Show(lvItem.Text.Substring(lvItem.Text.LastIndexOf("-") + 1).Trim() + " Làm vào " + chb.Name );

                    //Tao doi tuong phan cong
                    //clsChiTietBanPhanCong_DTO chiTietBPC = TaoDoiBanChiTietPhanCong(chb.Name);
                    //if(busChiTietBPC.ThemChiTietPhanCong(chiTietBPC))
                    //{
                    //  MessageBox.Show("hihi");
                    //}

                  }
                  temp++;
                  if ((i + 1) % 7 == 0)
                  {
                    checkBoxName = "chbchieu";
                    temp = 0;
                  }
                }

              } /*End if*/


            } /*End Foreach*/

          } /// Foreach duyệt qua từng nhân viên

        } //End messsagebox.show
      } /*End if*/
      
    } /*Kết thúc hàm*/



    //private clsChiTietBanPhanCong_DTO TaoDoiBanChiTietPhanCong(string checkboxName, string maNV)
    //{

    //  //clsChiTietBanPhanCong_DTO CTBPC = new clsChiTietBanPhanCong_DTO();

    //  //CTBPC.MaBanGhi = "00002";
    //  //CTBPC.MaNhanVien = "N00004";
    //  //CTBPC.MaCaLamViec = "Ca001";
    //  //CTBPC.NgayLamViec = DateTime.Parse(ngay.Substring(0,2)+"/"+ngay.Substring(2,2)+"/"+ngay.Substring(4));
    //  //CTBPC.CoMat = true;
    //  //return CTBPC;


    //  ChiTietBanPhanCong_BUS busCTBPC = new ChiTietBanPhanCong_BUS();

    //  string ma = busCTBPC.LayMaTuDong();
    //  string maNhanVien = maNV.Substring(maNV.LastIndexOf("-") + 1).Trim();
    //  string maCa = "Ca001";
    //  if (checkboxName.Contains("sang"))
    //    maCa = "Ca002";
    //  string strNgayLamCheckBox = checkboxName.Substring(checkboxName.Length - 8);
    //  DateTime ngayLamViec = DateTime.Parse(strNgayLamCheckBox.Substring(0, 2) + "/" + strNgayLamCheckBox.Substring(2, 2) + "/" + strNgayLamCheckBox.Substring(4));

    //  string maNVTao = urcDangNhap.maNhanVien;






    //}




  }
}
