using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class MonAn_DAO
    {
        public static List<clsMonAn_DTO> LayDSMonAn(string ChuoiTimKiem)
        {
            string query = string.Format("select * from MonAn where trang_thai='TRUE' ");
            if (ChuoiTimKiem != "")
            {
                query = ChuoiTimKiem;
            }
            List<clsMonAn_DTO> dsMonAn = new List<clsMonAn_DTO>();
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsMonAn_DTO itemMonAn = new clsMonAn_DTO();
                if (!rddtMA.IsDBNull(0))
                    itemMonAn.MaMonAn = (string)rddtMA[0];
                if (!rddtMA.IsDBNull(1))
                    itemMonAn.TenMonAn = (string)rddtMA[1];
                if (!rddtMA.IsDBNull(2))
                    itemMonAn.AnhMonAn = (string)rddtMA[2];
                // if (!rddtMA.IsDBNull(3))
                //      itemMonAn.GhiChu = (string)rddtMA[3];
                if (!rddtMA.IsDBNull(4))
                    itemMonAn.MaLoaiMon = (string)rddtMA[4];
                if (!rddtMA.IsDBNull(5))
                    itemMonAn.MaDonViTinh = (string)rddtMA[5];
                if (!rddtMA.IsDBNull(6))
                    itemMonAn.TrangThai = (bool)rddtMA[6];
                dsMonAn.Add(itemMonAn);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsMonAn;
        }
        //Đếm số lượng món ăn
        public static int SoLuongMonAn()
        {
            string query = string.Format("select count(*) from MonAn ");
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int TongSP =int.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return TongSP;
        }
        //Đếm số lượng món ăn ở chi tiết sản phẩm
        public static int SoLuongMonAnChiTietMonAn(string MaMonAn)
        {
            string query = string.Format("select count(*) from ChiTietMonAn where ma_mon_an = N'{0}' AND trang_thai =N'True' ",MaMonAn);
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int TongSP = int.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return TongSP;
        }
        public static List<clsChiTietMonAn_DTO> LayDSChiTietMonAn()
        {
            List<clsChiTietMonAn_DTO> dsChiTietMonAn = new List<clsChiTietMonAn_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("select * from ChiTietMonAn where trang_thai='TRUE'");
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtMA = cmd.ExecuteReader();
            while (rddtMA.Read())
            {
                clsChiTietMonAn_DTO itemMonAn = new clsChiTietMonAn_DTO();
                itemMonAn.MaMonAn = (string)rddtMA[0];
                itemMonAn.MaKichThuoc = (string)rddtMA[1];
                itemMonAn.GiaBan = (float)(double)rddtMA[2];
                itemMonAn.TrangThai = (bool)rddtMA[3];

                dsChiTietMonAn.Add(itemMonAn);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsChiTietMonAn;
        }
        //Thêm sản phẩm
        public static bool AddMonAn(clsMonAn_DTO MonAn)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO MonAn (ma_mon_an, ten_mon_an, anh_mon_an, ghi_chu, ma_loai_mon_an, ma_don_vi_tinh, trang_thai) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", MonAn.MaMonAn, MonAn.TenMonAn, MonAn.AnhMonAn, MonAn.GhiChu, MonAn.MaLoaiMon, MonAn.MaDonViTinh, MonAn.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;

        }
        public static bool AddChiTietMonAn(clsChiTietMonAn_DTO ChiTietMonAn)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("INSERT INTO ChiTietMonAn(ma_mon_an, ma_kich_thuoc, gia_ban, trang_thai) VALUES (N'{0}',N'{1}','{2}',N'{3}')", ChiTietMonAn.MaMonAn, ChiTietMonAn.MaKichThuoc, ChiTietMonAn.GiaBan,ChiTietMonAn.TrangThai);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }
        //





        public static bool UpDeleteMonAn(string MaMonAn, bool isDelete) //xóa món ăn
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE MonAn Set trang_thai = N'{0}'  where ma_mon_an = N'{1}' ", isDelete, MaMonAn);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }
        public static bool UpDeleteChiTietMonAn(string MaMonAn, string MaKichThuoc, bool isDelete) // xóa chi tiết món ăn
        {
            int ketqua = 0;
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE ChiTietMonAn Set trang_thai = N'{0}' where ma_mon_an = N'{1}' and ma_kich_thuoc = N'{2}'", isDelete, MaMonAn, MaKichThuoc);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }



        public static bool UpMonAn(clsMonAn_DTO UpMon)
        {
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE MonAn Set ten_mon_an = N'{0}', anh_mon_an =N'{1}',ghi_chu =N'{2}',ma_loai_mon_an = N'{3}',ma_don_vi_tinh=N'{4}'  where ma_mon_an = N'{5}' ", UpMon.TenMonAn, UpMon.AnhMonAn, UpMon.GhiChu, UpMon.MaLoaiMon, UpMon.MaDonViTinh, UpMon.MaMonAn);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            int ketqua = cmd.ExecuteNonQuery();
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return (ketqua == 1) ? true : false;
        }
        public static bool UpChiTietMonAn(clsChiTietMonAn_DTO UpCTMon, string MaKichThuocCu)
        {
            int ketqua = 0;
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("UPDATE ChiTietMonAn Set ma_kich_thuoc = N'{0}', gia_ban = {1} ,trang_thai ='{2}' where ma_mon_an = N'{3}' and ma_kich_thuoc = N'{4}'  ", UpCTMon.MaKichThuoc, UpCTMon.GiaBan, UpCTMon.TrangThai, UpCTMon.MaMonAn, MaKichThuocCu);
            try
            {
                SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
                ketqua = cmd.ExecuteNonQuery();
                ThaoTacDuLieu_DAO.DongKetNoi(con);
            }
            catch (Exception)
            {
                return false;
            }

            return (ketqua == 1) ? true : false;
        }
        //Lấy giá tiền của chi tiết món ăn
        public static float GiaMonAnChiTiet(string MaMonAn,string KichThuocMonAn)
        {
            string query = string.Format("select gia_ban from ChiTietMonAn where ma_mon_an = N'{0}' and ma_kich_thuoc= N'{1}' AND trang_thai = N'True' ", MaMonAn, KichThuocMonAn);
            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            float TongSP = float.Parse(cmd.ExecuteScalar().ToString());
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return TongSP;
        }



    }
}
