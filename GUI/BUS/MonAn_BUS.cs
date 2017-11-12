using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class MonAn_BUS
    {
        public static List<clsMonAn_DTO> DSMonAn(string ChuoiTimKiem)
        {
            return DAO.MonAn_DAO.LayDSMonAn(ChuoiTimKiem);
        }
        //Đếm số sản phẩm
        public static int SoLuongMonAn()
        {
           return DAO.MonAn_DAO.SoLuongMonAn();
        }
        //Đế số lượng chi tiết sp theo mã sp
        public static int SoLuongMonAnChiTietMonAn(string MaMonAn)
        {
            return DAO.MonAn_DAO.SoLuongMonAnChiTietMonAn(MaMonAn);
        }
        // Thêm
        public static bool AddMonAn(clsMonAn_DTO MonAn)
        {
            return DAO.MonAn_DAO.AddMonAn(MonAn);
        }
        public static bool AddChiTietMonAn(clsChiTietMonAn_DTO CTMonAn)
        {
            return DAO.MonAn_DAO.AddChiTietMonAn(CTMonAn);
        }
        // Xóa
        public static bool UpDeleteMonAn(string MaMonAn, bool isDelete)
        {
            return DAO.MonAn_DAO.UpDeleteMonAn(MaMonAn, isDelete);
        }
        public static bool UpDeleteCTMonAn(string MaMonAn, string MaKichThuoc, bool isDelete)
        {
            return DAO.MonAn_DAO.UpDeleteChiTietMonAn(MaMonAn, MaKichThuoc, isDelete);
        }
        // Sửa
        public static bool UpMonAn(clsMonAn_DTO MonAn)
        {
            return DAO.MonAn_DAO.UpMonAn(MonAn);
        }
        public static bool UpCTMonAn(clsChiTietMonAn_DTO CTMonAn, string MaKichThuocCu)
        {
            return DAO.MonAn_DAO.UpChiTietMonAn(CTMonAn, MaKichThuocCu);
        }
        // Lấy giá tiền của 1 món ăn chi tiết
        public static float GiaMonAnChiTiet(string MaMonAn, string KichThuocMonAn)
        {
            return DAO.MonAn_DAO.GiaMonAnChiTiet(MaMonAn, KichThuocMonAn);
        }
        


    }
}
