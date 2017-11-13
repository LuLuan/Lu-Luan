using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiNguyenLieu_DAO
    {
        public static List<clsLoaiNguyenLieu_DTO> LayDSLoaiNguyenLieu(string ChuoiTimKiem)
        {
            string query = string.Format("select * from LoaiNguyenLieu");
            if (ChuoiTimKiem != "")
            {
                query += ChuoiTimKiem;
            }
            List<clsLoaiNguyenLieu_DTO> dsMonAn = new List<clsLoaiNguyenLieu_DTO>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsLoaiNguyenLieu_DTO itemLoaiNguyenLieu = new clsLoaiNguyenLieu_DTO();
                if (!rddtMA.IsDBNull(0))
                itemLoaiNguyenLieu.MaLoaiNguyenLieu = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                itemLoaiNguyenLieu.TenLoaiNguyenLieu = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                itemLoaiNguyenLieu.TrangThai = (bool)rddtMA[2];
                dsMonAn.Add(itemLoaiNguyenLieu);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsMonAn;
        }

        public static bool InsertLoaiNguyenLieu(clsLoaiNguyenLieu_DTO LoaiNguyenLieu)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO LoaiNguyenLieu (ma_loai_nguyen_lieu, ten_loai_nguyen_lieu, trang_thai) VALUES ('{0}',N'{1}',N'{2}')", LoaiNguyenLieu.MaLoaiNguyenLieu, LoaiNguyenLieu.TenLoaiNguyenLieu, LoaiNguyenLieu.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }

        public static bool UpLoaiNguyenLieu(clsLoaiNguyenLieu_DTO LoaiNguyenLieu)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE MonAn Set ten_loai_nguyen_lieu =N'{0}',trang_thai =N'{1}' where ma_loai_nguyen_lieu = N'{2}' ", LoaiNguyenLieu.MaLoaiNguyenLieu, LoaiNguyenLieu.TenLoaiNguyenLieu, LoaiNguyenLieu.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }




    }
}
