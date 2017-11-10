using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TheKhachHang_BUS
    {
        public List<clsTheKhachHang> LayDanhSachTheKH()
        {
            TheKhachHang_DAO dao = new TheKhachHang_DAO();
            return dao.LayDanhSachTheKH();
        }
    }
}
