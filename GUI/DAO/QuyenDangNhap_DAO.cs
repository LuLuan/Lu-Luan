using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class QuyenDangNhap_DAO
    {
        public static List<clsQuyenDangNhap_DTO> LayQuyenDangNhapTheoMaNV(string maNhanVien)
        {
            List<clsQuyenDangNhap_DTO> dsQuyenDangNhap = new List<clsQuyenDangNhap_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("select QuyenDangNhap.ma_quyen_dang_nhap, QuyenDangNhap.ten_quyen_dang_nhap, QuyenDangNhap.trang_thai from QuyenDangNhap,TaiKhoan where TaiKhoan.ma_quyen_dang_nhap = QuyenDangNhap.ma_quyen_dang_nhap AND  ma_dang_nhap ='{0}'", maNhanVien);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader rddtSV = cmd.ExecuteReader();
            while (rddtSV.Read())
            {
                clsQuyenDangNhap_DTO quyenDN = new clsQuyenDangNhap_DTO();
                quyenDN.MaQuyenDangNhap = (string)rddtSV[0];
                quyenDN.TenQuyenDangNhap = rddtSV[1].ToString();
                quyenDN.TrangThai = (bool)rddtSV[2];
                dsQuyenDangNhap.Add(quyenDN);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsQuyenDangNhap;
        }

        public List<clsQuyenDangNhap_DTO> LayQuyenDangNhapTheoMaQDN(string maQDN)
        {
            List<clsQuyenDangNhap_DTO> dsQuyenDangNhap = new List<clsQuyenDangNhap_DTO>();

            SqlConnection con = ThaoTacDuLieu_DAO.TaoKetNoi();
            string query = string.Format("SELECT * FROM QuyenDangNhap WHERE ma_quyen_dang_nhap LIKE '%{0}%'", maQDN);
            SqlCommand cmd = ThaoTacDuLieu_DAO.TruyVan(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clsQuyenDangNhap_DTO quyenDN = new clsQuyenDangNhap_DTO();
                if (!reader.IsDBNull(0))
                    quyenDN.MaQuyenDangNhap = (string)reader[0];
                if (!reader.IsDBNull(1))
                    quyenDN.TenQuyenDangNhap = reader[1].ToString();
                if (!reader.IsDBNull(2)) 
                    quyenDN.TrangThai = (bool)reader[2];

                dsQuyenDangNhap.Add(quyenDN);
            }
            ThaoTacDuLieu_DAO.DongKetNoi(con);
            return dsQuyenDangNhap;
        }
    }
}
