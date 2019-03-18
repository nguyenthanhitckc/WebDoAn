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
    public class clsLoaiSPBUS
    {
        public static DataTable LayDSLoaiSanPham()
        {
            return clsLoaiSPDAO.LayDSLoaiSanPham();
        }

        public static clsLoaiSPDTO LayLoaiSP(string maLoaiSP)
        {
            DataRow dr = clsLoaiSPDAO.LayLoaiSP(maLoaiSP);
            clsLoaiSPDTO loaiSPDTO = new clsLoaiSPDTO();
            loaiSPDTO.MaLoaiSP = dr["MaLoaiSP"].ToString();
            loaiSPDTO.TenLoaiSP = dr["TenLoaiSP"].ToString();
            loaiSPDTO.TrangThai = Convert.ToBoolean(dr["TrangThai"]);

            return loaiSPDTO;
        }

        public static bool XoaLoaiSanPham(string maLoaiSP)
        {
            return clsLoaiSPDAO.XoaLoaiSanPham(maLoaiSP);
        }
    }
}
