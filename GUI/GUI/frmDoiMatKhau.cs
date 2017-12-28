using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public partial class frmDoiMatKhau : Form
  {

 
    public frmDoiMatKhau()
    {
      InitializeComponent();
    }

    Utilities utl = new Utilities(); // Class chứa các hàm để tái sử dụng giữa các UserControl
    

    private void frmDoiMatKhau_Load(object sender, EventArgs e)
    {
    }




    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;

    private void frmDoiMatKhau_MouseDown(object sender, MouseEventArgs e)
    {
      dragging = true;
      dragCursorPoint = Cursor.Position;
      dragFormPoint = this.Location;
    }

    private void frmDoiMatKhau_MouseMove(object sender, MouseEventArgs e)
    {
      if (dragging)
      {
        Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
        this.Location = Point.Add(dragFormPoint, new Size(dif));
      }
    }

    private void frmDoiMatKhau_MouseUp(object sender, MouseEventArgs e)
    {
      dragging = false;
    }

    private void btnDongCuaSo_Click(object sender, EventArgs e)
    {
      if(DialogResult.Yes == MessageBox.Show("Công việc hiện tại sẽ bị hủy. Vẫn muốn tiếp tục?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        this.Close();
    }



    #region ĐỔI MẬT KHẨU

    string strError = "";
    private void btnDongY_Click(object sender, EventArgs e)
    {
      if(KiemTraDuLieuHopLe())
        if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Xác nhận đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) )
        {
          if (BUS.TaiKhoan_BUS.KiemTraDangNhap_BUS(txtMaDangNhap.Text.Trim(), txtMatKhauHienTai.Text.Trim()))
            if (BUS.TaiKhoan_BUS.DoiMatKhau(txtMaDangNhap.Text, txtMatKhauMoi.Text))
            {
              MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txtMatKhauHienTai.Text = txtMatKhauMoi.Text = txtMatKhauMoi2.Text = txtMaDangNhap.Text = "";
            }
            else
            {
              MessageBox.Show("Đã xảy ra lỗi hệ thống trong quá trình thực thực hiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
              txtMatKhauHienTai.Text = txtMatKhauMoi.Text = txtMatKhauMoi2.Text = txtMaDangNhap.Text = "";
            }
          else MessageBox.Show("Sai mã đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }
        else
        {
          MessageBox.Show("Hủy thao tác");
          txtMatKhauHienTai.Text = txtMatKhauMoi.Text = txtMatKhauMoi2.Text = txtMaDangNhap.Text = "";
        }
      else
      {
        MessageBox.Show(strError, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        strError = "";
      }
    }
    

    #region Kiểm tra dữ liệu hợp lệ
    private bool KiemTraDuLieuHopLe()
    {
      bool flag = true;
      if (!KiemTraMaDangNhap(6,6))
      {
        flag = false;
        strError += " *Mã đăng nhập phải dài 6 kí tự, và có dạng Nxxxxx trong đó 'x' là các chữ số\n";
      }
      if (!KiemTraMatKhauHienTai(5,20))
      {
        flag = false;
        strError += " *Mật khẩu hiện tại phải dài từ 5 tới 20 kí tự, có ít nhất 1 chữ cái thường, 1 chữ cái in hoa, 1 chữ số và 1 kí tự đặc biệt (\" * \"  hoặc \" @ \" hoặc \" _ \")\n";
      }
      if (!KiemTraMatKhauMoi(5,20))
      {
        flag = false;
        strError += " *Mật khẩu mới dài từ 5 tới 20 kí tự, có ít nhất 1 chữ cái thường, 1 chữ cái in hoa, 1 chữ số và 1 kí tự đặc biệt (\" * \"  hoặc \" @ \" hoặc \" _ \")\n";
      }
      if (!KiemTraMatKhauMoi2())
      {
        flag = false;
        strError += " *Mật khẩu nhập lại không khớp\n";
      }
        

      return flag;
    }
    #endregion


    #endregion


    

    private void txtMaDangNhap_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMaDangNhap(6,6))
        txtMaDangNhap.ForeColor = Color.Black;
      else txtMaDangNhap.ForeColor = Color.Red;
    }

    private void txtMatKhauHienTai_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMatKhauHienTai(5, 20))
        txtMatKhauHienTai.ForeColor = Color.Black;
      else txtMatKhauHienTai.ForeColor = Color.Red;
    }

    private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMatKhauMoi(5,20))
        txtMatKhauMoi.ForeColor = Color.Black;
      else txtMatKhauMoi.ForeColor = Color.Red;
      if (KiemTraMatKhauMoi2())
        txtMatKhauMoi2.ForeColor = Color.Black;
      else txtMatKhauMoi2.ForeColor = Color.Red;
    }

    private void txtMatKhauMoi2_TextChanged(object sender, EventArgs e)
    {
      if (KiemTraMatKhauMoi2())
        txtMatKhauMoi2.ForeColor = Color.Black;
      else txtMatKhauMoi2.ForeColor = Color.Red;
    }


    private bool KiemTraMaDangNhap(int min, int max)
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQMaDangNhap(min, max), txtMaDangNhap);
    }

    private bool KiemTraMatKhauHienTai(int min, int max)
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQMatKhau(min, max), txtMatKhauHienTai);
    }

    private bool KiemTraMatKhauMoi(int min, int max)
    {
      return utl.KiemTraBieuThucChinhQuy(utl.BTCQMatKhau(min, max), txtMatKhauMoi);
    }

    private bool KiemTraMatKhauMoi2()
    {
      return (txtMatKhauMoi.Text.Trim() == txtMatKhauMoi2.Text.Trim());
    }
    



  }
}
