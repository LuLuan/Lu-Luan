using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace BUS
{
    public class ChiTietHoaDonBan_BUS
    {
        public static bool AddChiTietHoaDonBan(clsChiTietHoaDonBan_DTO ChiTietHoaDonBan)
        {
            return DAO.ChiTietHoaDonBan_DAO.AddChiTietHoaDonBan(ChiTietHoaDonBan);
        }
        public static DataTable SelectChiTietHoaDonBan()
        {
            return DAO.ChiTietHoaDonBan_DAO.SelectChiTietHoaDonBan();
        }
    }
}
