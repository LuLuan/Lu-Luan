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

    public delegate void NhanPhimHome(bool bolPhimHome);
    public NhanPhimHome bolNhanPhimHome;

    private void btnHome_Click(object sender, EventArgs e)
    {
      if (bolNhanPhimHome != null)
      {
        bolNhanPhimHome(true);
      }
    }


  }
}
