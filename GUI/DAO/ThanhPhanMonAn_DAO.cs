using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ThanhPhanMonAn_DAO
    {
        public static List<clsThanhPhanMonAn_DTO> LayThanhPhanMonAn(string MaMonAn)
        {
            List<clsThanhPhanMonAn_DTO> CacThanhPhanMonAn = new List<clsThanhPhanMonAn_DTO>();
            //
            string query = "";
            if (MaMonAn != "")
            {
                query = string.Format("select * from ThanhPhan where ma_mon_an = '{0}'", MaMonAn);
            }
            else return CacThanhPhanMonAn = null;


            query = string.Format("select * from ThanhPhan where ma_mon_an = '{0}'", MaMonAn);

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsThanhPhanMonAn_DTO itemThanhPhan = new clsThanhPhanMonAn_DTO();
                if (!rddtMA.IsDBNull(0))
                itemThanhPhan.MaMonAn = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                itemThanhPhan.MaNguyenLieu = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                itemThanhPhan.SoLuong = (float)(double)rddtMA[2];
                if (!rddtMA.IsDBNull(3))
                itemThanhPhan.DonVi = (string)rddtMA[3];
                CacThanhPhanMonAn.Add(itemThanhPhan);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return CacThanhPhanMonAn;

        }


        public static bool InsertThanhPhanMonAn(clsThanhPhanMonAn_DTO InsertTPMon)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO ThanhPhan (ma_mon_an, ma_nguyen_lieu, so_luong, don_vi) VALUES ('{0}','{1}','{2}','{3}')", InsertTPMon.MaMonAn, InsertTPMon.MaNguyenLieu, InsertTPMon.SoLuong, InsertTPMon.DonVi);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }





    }
}
