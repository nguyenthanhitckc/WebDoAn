using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsHoaDonDAO
    {
        public static int LayMaHDLonNhat()
        {
            try
            {
                string query = "SELECT MAX(MaHD) FROM tblHoaDon";
                SqlParameter[] parameter = new SqlParameter[0];
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameter).Rows[0][0]);
            }
            catch (InvalidCastException e)
            {
                return 0;
            }
        }

        public static bool ThemHD(clsHoaDonDTO hoaDonDTO)
        {
            string query = "INSERT INTO tblHoaDon (MaHD, TenTaiKhoan, NgayMua, DiaChiGiaoHang, SDTGiaoHang, TongTien, TrangThai) VALUES (@MaHD, @TenTaiKhoan, @NgayMua, @DiaChiGiaoHang, @SDTGiaoHang, @TongTien, @TrangThai)";
            SqlParameter[] parameter = new SqlParameter[7];
            parameter[0] = new SqlParameter("@MaHD", hoaDonDTO.MaHD);
            parameter[1] = new SqlParameter("@TenTaiKhoan", hoaDonDTO.TenTaiKhoan);
            parameter[2] = new SqlParameter("@NgayMua", hoaDonDTO.NgayMua);
            parameter[3] = new SqlParameter("@DiaChiGiaoHang", hoaDonDTO.DiaChiGiaoHang);
            parameter[4] = new SqlParameter("@SDTGiaoHang", hoaDonDTO.SDTGiaoHang);
            parameter[5] = new SqlParameter("@TongTien", hoaDonDTO.TongTien);
            parameter[6] = new SqlParameter("@TrangThai", hoaDonDTO.TrangThai);
            return DataProvider.ExecuteInsertQuery(query, parameter) == 1;
        }
    }
}
