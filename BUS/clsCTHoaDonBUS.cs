using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsCTHoaDonBUS
    {
        public static bool ThemCTHoaDon(clsCTHoaDonDTO ctHoaDonDTO)
        {
            return clsCTHoaDonDAO.ThemCTHoaDon(ctHoaDonDTO);
        }
    }
}
