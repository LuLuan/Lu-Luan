using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
   public  class NhaCungCap_DAO
    {
        public static List<clsNhaCungCap_DTO> LayDSNhaCungCap(string ChuoiTimKiem)
        {
            string query = string.Format("select * from NhaCungCap");
            if (ChuoiTimKiem != "")
            {
                query = ChuoiTimKiem;
            }
            List<clsNhaCungCap_DTO> dsNhaCungCap = new List<clsNhaCungCap_DTO>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsNhaCungCap_DTO itemNhaCungCap = new clsNhaCungCap_DTO();
                if (!rddtMA.IsDBNull(0))
                    itemNhaCungCap.MaNhaCungCap = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                    itemNhaCungCap.TenNhaCungCap = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                    itemNhaCungCap.DiaChi = (string)rddtMA[2];
                if (!rddtMA.IsDBNull(3))
                    itemNhaCungCap.SoDienThoai = (string)rddtMA[3];
                if (!rddtMA.IsDBNull(4))
                    itemNhaCungCap.TrangThai = (bool)(rddtMA[4]);
                dsNhaCungCap.Add(itemNhaCungCap);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsNhaCungCap;
        }

        public static bool InsertNhaCungCap(clsNhaCungCap_DTO NhaCungCap)
        {
            /*
         * ma_nha_cung_cap -char(6)
         * ten_nha_cung_cap -nvarchar(30)
         * dia_chi -nvarchar(30)
         * so_dien_thoai -varchar(15)
         * trang_thai -bit
         */
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO NhaCungCap (ma_nha_cung_cap, ten_nha_cung_cap, dia_chi,so_dien_thoai,trang_thai) VALUES ('{0}',N'{1}',N'{2}',N'{3}','{4}')", NhaCungCap.MaNhaCungCap, NhaCungCap.TenNhaCungCap,NhaCungCap.DiaChi,NhaCungCap.SoDienThoai, NhaCungCap.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }

        public static bool UpNhaCungCap(clsNhaCungCap_DTO NhaCungCap)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE NhaCungCap Set ten_nha_cung_cap =N'{0}',dia_chi =N'{1}',so_dien_thoai=N'{2}',trang_thai=N'{3}' where ma_nha_cung_cap = N'{4}' ", NhaCungCap.TenNhaCungCap, NhaCungCap.DiaChi, NhaCungCap.SoDienThoai, NhaCungCap.TrangThai, NhaCungCap.MaNhaCungCap);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }

    }
}
