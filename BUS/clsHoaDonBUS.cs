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
    public class clsHoaDonBUS
    {
        public static bool ThemHD(clsHoaDonDTO hoaDonDTO)
        {
            // Lấy giỏ hàng
            DataTable dtbGioHang = clsGioHangDAO.LayGioHang(hoaDonDTO.TenTaiKhoan);

            hoaDonDTO.MaHD = (clsHoaDonDAO.LayMaHDLonNhat() + 1).ToString();

            // Nếu tất cả sản phẩm trong giỏ hàng đều đủ số lượng để mua
            if (clsGioHangBUS.KiemTraSoLuongSPTrongGH(hoaDonDTO.TenTaiKhoan))
            {
                // Thêm hóa đơn
                if (!clsHoaDonDAO.ThemHD(hoaDonDTO))
                {
                    return false;
                }

                // Thêm sản phẩm vào CTHD
                foreach (DataRow dr in dtbGioHang.Rows)
                {
                    clsSanPhamDTO sanPhamDTO = clsSanPhamBUS.LayThongTinSP(dr["MaSP"].ToString());

                    clsCTHoaDonDTO ctHoaDonDTO = new clsCTHoaDonDTO();
                    ctHoaDonDTO.MaHD = hoaDonDTO.MaHD;
                    ctHoaDonDTO.MaSP = dr["MaSP"].ToString();
                    ctHoaDonDTO.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                    ctHoaDonDTO.DonGia = sanPhamDTO.GiaTien;

                    clsCTHoaDonDAO.ThemCTHoaDon(ctHoaDonDTO);
                    
                    // Cập nhật số lượng tồn kho
                    sanPhamDTO.SoLuongTonKho -= ctHoaDonDTO.SoLuong;
                    clsSanPhamDAO.SuaSP(sanPhamDTO);
                }
                clsGioHangDAO.XoaGioHang(hoaDonDTO.TenTaiKhoan);

                return true;
            }
            // Ngược lại => Báo lỗi
            else
            {
                return false;
            }
        }
    }
}
