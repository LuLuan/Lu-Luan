using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NguyenLieu_DAO
    {
        public static List<clsNguyenLieu_DTO> LaydsNguyenLieu(string ChuoiTimKiem)
        {
            string query = string.Format("select * from NguyenLieu");
            if (ChuoiTimKiem != "")
            {
                query += ChuoiTimKiem;
            }


            List<clsNguyenLieu_DTO> dsNguyenLieu = new List<clsNguyenLieu_DTO>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsNguyenLieu_DTO itemThuocTinhNguyenLieu = new clsNguyenLieu_DTO();
                if (!rddtMA.IsDBNull(0))
                itemThuocTinhNguyenLieu.MaNguyenLieu = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                itemThuocTinhNguyenLieu.AnhNguyenLieu = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                itemThuocTinhNguyenLieu.TenNguyenLieu = (string)rddtMA[2];
                if (!rddtMA.IsDBNull(3))
                itemThuocTinhNguyenLieu.TongSoLuong = (float)(double)rddtMA[3];
                if (!rddtMA.IsDBNull(4))
                itemThuocTinhNguyenLieu.DonViTinh = (string)rddtMA[4]; // mã
                if (!rddtMA.IsDBNull(5))
                    itemThuocTinhNguyenLieu.DonGia = (float)(double)rddtMA[5];

                if (!rddtMA.IsDBNull(6))
                itemThuocTinhNguyenLieu.MaLoaiNguyenLieu = (string)rddtMA[6];
                if (!rddtMA.IsDBNull(7))
                itemThuocTinhNguyenLieu.TrangThai = (bool)rddtMA[7];

                //
                dsNguyenLieu.Add(itemThuocTinhNguyenLieu);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsNguyenLieu;
        }
        public static bool InsertNguyenLieu(clsNguyenLieu_DTO NguyenLieu)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO NguyenLieu (ma_nguyen_lieu, anh_nguyen_lieu, ten_nguyen_lieu, tong_so_luong,don_vi_tinh,don_gia,ma_loai_nguyen_lieu,trang_thai ) VALUES ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}',N'{7}')", NguyenLieu.MaNguyenLieu, NguyenLieu.AnhNguyenLieu, NguyenLieu.TenNguyenLieu, NguyenLieu.TongSoLuong, NguyenLieu.DonViTinh, NguyenLieu.DonGia, NguyenLieu.MaLoaiNguyenLieu, NguyenLieu.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }


    }
}
