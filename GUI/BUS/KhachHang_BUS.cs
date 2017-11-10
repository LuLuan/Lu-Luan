using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHang_BUS
    {
        public List<clsKhachHang_DTO> LayDanhSachKhachHang(string hoTen, int trangThai)
        {
            KhachHang_DAO dao = new KhachHang_DAO();
            return dao.LayDanhSachKhachHang(hoTen, trangThai);
        }
    }
}
