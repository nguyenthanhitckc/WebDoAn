using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class clsSanPhamBUS
    {
        public static DataTable LayDSSanPham()
        {
            return clsSanPhamDAO.LayDSSanPham();
        }

        public static DataTable LayDSSanPham(string maLoaiSP)
        {
            return clsSanPhamDAO.LayDSSanPham(maLoaiSP);
        }

        public static clsSanPhamDTO LayThongTinSP(string maSP)
        {
            if (clsSanPhamDAO.KiemTraSPTonTai(maSP))
            {
                DataRow dr = clsSanPhamDAO.LayThongTinSP(maSP);
                clsSanPhamDTO sanPhamDTO = new clsSanPhamDTO();

                sanPhamDTO.MaSP = dr["MaSP"].ToString();
                sanPhamDTO.TenSP = dr["TenSP"].ToString();
                sanPhamDTO.ThongTin = dr["ThongTin"].ToString();
                sanPhamDTO.GiaTien = Convert.ToInt32(dr["GiaTien"]);
                sanPhamDTO.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
                sanPhamDTO.AnhMinhHoa = dr["AnhMinhHoa"].ToString();
                sanPhamDTO.MaLoaiSP = dr["MaLoaiSP"].ToString();
                sanPhamDTO.TrangThai = Convert.ToBoolean(dr["TrangThai"]);

                return sanPhamDTO;
            }
            else
            {
                return null;
            }
        }
    }
}
