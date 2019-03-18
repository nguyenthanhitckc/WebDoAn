using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsGioHangDTO
    {
        private string tenTaiKhoan;
        private string maSP;
        private int soLuong;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }        

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }        

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
