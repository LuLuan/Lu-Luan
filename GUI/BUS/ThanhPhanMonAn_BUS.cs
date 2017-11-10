using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ThanhPhanMonAn_BUS
    {
        public static  List<clsThanhPhanMonAn_DTO> LayCacThanhPhanCuaMon(string MaMonAn)
        {
           // DAO.ThanhPhanMonAn_DAO dao = new ThanhPhanMonAn_DAO();
            return DAO.ThanhPhanMonAn_DAO.LayThanhPhanMonAn(MaMonAn);
        }
        public static bool InsertThanhPhanMonAn(clsThanhPhanMonAn_DTO clsTpMon)
        {
            return DAO.ThanhPhanMonAn_DAO.InsertThanhPhanMonAn(clsTpMon);
        }


    }
}
