using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHoaDonDTO
    {
        private string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private DateTime ngayMua;

        public DateTime NgayMua
        {
            get { return ngayMua; }
            set { ngayMua = value; }
        }
        private string diaChiGiaoHang;

        public string DiaChiGiaoHang
        {
            get { return diaChiGiaoHang; }
            set { diaChiGiaoHang = value; }
        }
        private string sDTGiaoHang;

        public string SDTGiaoHang
        {
            get { return sDTGiaoHang; }
            set { sDTGiaoHang = value; }
        }
        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public clsHoaDonDTO()
        {
            TrangThai = true;
        }
    }
}
