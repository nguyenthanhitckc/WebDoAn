using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsCTHoaDonDAO
    {
        public static bool ThemCTHoaDon(clsCTHoaDonDTO ctHoaDonDTO)
        {
            string query = "INSERT INTO tblCTHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@MaHD", ctHoaDonDTO.MaHD);
            parameter[1] = new SqlParameter("@MaSP", ctHoaDonDTO.MaSP);
            parameter[2] = new SqlParameter("@SoLuong", ctHoaDonDTO.SoLuong);
            parameter[3] = new SqlParameter("@DonGia", ctHoaDonDTO.DonGia);
            return DataProvider.ExecuteInsertQuery(query, parameter) == 1;
        }
    }
}
