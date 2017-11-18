using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public  class DonViTinh_DAO
    {

        public static List<clsDonViTinh_DTO> LaydsDonVi()
        {
            List<clsDonViTinh_DTO> dsDonVi = new List<clsDonViTinh_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("select * from DonViTinh");
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsDonViTinh_DTO itemDonViTinh = new clsDonViTinh_DTO();
                if (!rddtMA.IsDBNull(0))
                itemDonViTinh.MaDonViTinh = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                itemDonViTinh.TenDonViTinh = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                itemDonViTinh.TrangThai = (bool)rddtMA[2];

                //
                dsDonVi.Add(itemDonViTinh);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsDonVi;
        }

         public static bool InsertDonViTinh(clsDonViTinh_DTO DonViTinh)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO DonViTinh  VALUES ('{0}',N'{1}',N'{2}')", DonViTinh.MaDonViTinh, DonViTinh.TenDonViTinh, DonViTinh.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }

    }
}
