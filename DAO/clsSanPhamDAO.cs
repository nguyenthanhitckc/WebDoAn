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
    public class clsSanPhamDAO
    {
        public static DataTable LayDSSanPham()
        {
            string query = "SELECT TOP 30 * FROM tblSanPham";
            SqlParameter[] parameter = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }

        public static DataTable LayDSSanPham(string maLoaiSP)
        {
            string query = "SELECT * FROM tblSanPham WHERE MaLoaiSP=@MaLoaiSP";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }

        public static DataRow LayThongTinSP(string maSP)
        {
            string query = "SELECT * FROM tblSanPham WHERE MaSP=@MaSP";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaSP", maSP);
            return DataProvider.ExecuteSelectQuery(query, parameter).Rows[0];
        }

        public static bool SuaSP(clsSanPhamDTO sanPhamDTO)
        {
            string query = "UPDATE tblSanPham SET TenSP=@TenSP, ThongTin=@ThongTin, GiaTien=@GiaTien, SoLuongTonKho=@SoLuongTonKho, MaLoaiSP=@MaLoaiSP, AnhMinhHoa=@AnhMinhHoa, TrangThai=@TrangThai WHERE MaSP=@MaSP";
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MaSP", sanPhamDTO.MaSP);
            parameter[1] = new SqlParameter("@TenSP", sanPhamDTO.TenSP);
            parameter[2] = new SqlParameter("@ThongTin", sanPhamDTO.ThongTin);
            parameter[3] = new SqlParameter("@GiaTien", sanPhamDTO.GiaTien);
            parameter[4] = new SqlParameter("@SoLuongTonKho", sanPhamDTO.SoLuongTonKho);
            parameter[5] = new SqlParameter("@MaLoaiSP", sanPhamDTO.MaLoaiSP);
            parameter[6] = new SqlParameter("@AnhMinhHoa", sanPhamDTO.AnhMinhHoa);
            parameter[7] = new SqlParameter("@TrangThai", sanPhamDTO.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }

        public static bool KiemTraSPTonTai(string maSP)
        {
            string query = "SELECT COUNT(*) FROM tblSanPham WHERE MaSP=@MaSP";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaSP", maSP);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameter).Rows[0][0]) == 1;
        }
    }
}
