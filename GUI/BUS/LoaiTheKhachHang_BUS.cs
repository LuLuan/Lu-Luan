using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiTheKhachHang_BUS
    {
        public List<clsLoaiTheKhachHang> LayLoaiTheKhachHang()
        {
            LoaiTheKhachHang_DAO dao = new LoaiTheKhachHang_DAO();
            return dao.LayLoaiTheKhachHang();
        }



    }
}
