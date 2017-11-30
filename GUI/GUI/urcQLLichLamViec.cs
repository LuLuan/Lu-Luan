using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public partial class urcQLLichLamViec : UserControl
  {
    public urcQLLichLamViec()
    {
      InitializeComponent();
    }

    urcXemLichLamViec urcXemLichLamViec = new urcXemLichLamViec();

    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;

    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }

    private void pnlContainer_Paint(object sender, PaintEventArgs e)
    {

    }

    private void urcQLLichLamViec_Load(object sender, EventArgs e)
    {
      this.pnlContainer.Controls.Add(urcXemLichLamViec);
    }


  }
}
  