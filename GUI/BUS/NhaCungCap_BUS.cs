using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhaCungCap_BUS
    {
        public static List<clsNhaCungCap_DTO> DSNhaCungCap(string ChuoiTimKiem)
        {
            return DAO.NhaCungCap_DAO.LayDSNhaCungCap(ChuoiTimKiem);
        }
        public static bool InsertNhaCungCap(clsNhaCungCap_DTO NhaCungCap)
        {
            return DAO.NhaCungCap_DAO.InsertNhaCungCap(NhaCungCap);
        }
        public static bool UpdateNhaCungCap(clsNhaCungCap_DTO NhaCungCap)
        {
            return DAO.NhaCungCap_DAO.UpNhaCungCap(NhaCungCap);
        }
    }
}
