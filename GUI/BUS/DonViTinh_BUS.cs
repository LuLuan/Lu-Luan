using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class DonViTinh_BUS
    {
       public static List<clsDonViTinh_DTO> DSDonViTinh()
       {
           return DAO.DonViTinh_DAO.LaydsDonVi();
       }
        public static bool InsertDonViTinh(clsDonViTinh_DTO DonViTinh)
       {
           return DAO.DonViTinh_DAO.InsertDonViTinh(DonViTinh);
       }
    }
}
