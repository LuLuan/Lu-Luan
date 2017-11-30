using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ChucNang_DAO
    {
        public static List<clsChucNang_DTO> LayChucNangTheoMaNhanVien(string maNhanVien)
        {
            List<clsChucNang_DTO> dsChucNang = new List<clsChucNang_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string Query = string.Format("SELECT ChucNang.ma_chuc_nang, ten_chuc_nang, ghi_chu, ChucNang.trang_thai FROM NhanVien, ChucNang, ChucVu, ChiTietChucNang WHERE NhanVien.ma_nhan_vien='{0}' AND NhanVien.ma_chuc_vu = ChucVu.ma_chuc_vu AND ChiTietChucNang.ma_chuc_vu = ChucVu.ma_chuc_vu AND ChiTietChucNang.ma_chuc_nang = ChucNang.ma_chuc_nang AND ChiTietChucNang.trang_thai = {1} AND ChucNang.trang_thai = {1}", maNhanVien, 1);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(Query, con);
            SqlDataReader rddtSV = cmd.ExecuteReader();
            while (rddtSV.Read())
            {
                clsChucNang_DTO chucNang = new clsChucNang_DTO();
                if (!rddtSV.IsDBNull(0))
                chucNang.MaChucNang = (string)rddtSV[0];
                if (!rddtSV.IsDBNull(1))
                chucNang.TenChucNang = rddtSV[1].ToString();
                if (!rddtSV.IsDBNull(2))
                chucNang.GhiChu = rddtSV[2].ToString();
                if (!rddtSV.IsDBNull(3))
                chucNang.TrangThai = (bool)rddtSV[3];
                dsChucNang.Add(chucNang);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsChucNang;
        }
    }
}
