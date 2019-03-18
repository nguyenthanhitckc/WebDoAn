using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsLoaiSPDAO
    {
        public static DataTable LayDSLoaiSanPham()
        {
            string query = "SELECT * FROM tblLoaiSanPham";
            SqlParameter[] parameter = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }

        public static DataRow LayLoaiSP(string maLoaiSP)
        {
            string query = "SELECT * FROM tblLoaiSanPham WHERE MaLoaiSP=@MaLoaiSP";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return DataProvider.ExecuteSelectQuery(query, parameter).Rows[0];
        }

        public static bool XoaLoaiSanPham(string maLoaiSP)
        {
            string query = "UPDATE tblLoaiSanPham SET TrangThai=0 WHERE MaLoaiSP=@MaLoaiSP";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }
    }
}
