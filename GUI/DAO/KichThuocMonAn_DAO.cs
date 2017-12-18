using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
  public class KichThuocMonAn_DAO
  {
    public static List<clsKichThuocMonAn_DTO> LaydsKichThuoc()
    {
      List<clsKichThuocMonAn_DTO> dsKichThuoc = new List<clsKichThuocMonAn_DTO>();

      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("select * from KichThuocMonAn");
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader rddtMA = cmd.ExecuteReader();
      while (rddtMA.Read())
      {
        clsKichThuocMonAn_DTO itemKichThuoc = new clsKichThuocMonAn_DTO();
        if (!rddtMA.IsDBNull(0))
          itemKichThuoc.MaKichThuoc = (string)rddtMA[0];
        if (!rddtMA.IsDBNull(1))
          itemKichThuoc.TenKichThuoc = (string)rddtMA[1];
        if (!rddtMA.IsDBNull(2))
          itemKichThuoc.TrangThai = (bool)rddtMA[2];

        //
        dsKichThuoc.Add(itemKichThuoc);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return dsKichThuoc;
    }

    //////////////////////////////////

    public static List<clsKichThuocMonAn_DTO> LaydsKichThuocTheoMaSanPham(string a, bool b)
    {
      List<clsKichThuocMonAn_DTO> dsKichThuoc = new List<clsKichThuocMonAn_DTO>();
      
      SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
      string query = string.Format("select ChiTietMonAn.ma_kich_thuoc, KichThuocMonAn.ten_kich_thuoc,ChiTietMonAn.trang_thai  from ChiTietMonAn, KichThuocMonAn where ChiTietMonAn.ma_kich_thuoc = KichThuocMonAn.ma_kich_thuoc AND ma_mon_an = '{0}' AND ChiTietMonAn.trang_thai = N'{1}' ",a, b);
      SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
      SqlDataReader rddtMA = cmd.ExecuteReader();
      while (rddtMA.Read())
      {
        clsKichThuocMonAn_DTO itemKichThuoc = new clsKichThuocMonAn_DTO();
        if (!rddtMA.IsDBNull(0))
          itemKichThuoc.MaKichThuoc = (string)rddtMA[0];
        if (!rddtMA.IsDBNull(1))
          itemKichThuoc.TenKichThuoc = (string)rddtMA[1];
        if (!rddtMA.IsDBNull(2))
          itemKichThuoc.TrangThai = (bool)rddtMA[2];

        //
        dsKichThuoc.Add(itemKichThuoc);
      }
      ThaoTacDuLieu_DAO.DongKetNoi(con);
      return dsKichThuoc;
    }




  }
}
