using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Đã đăng nhập => Chuyển về trang chủ
            if (Request.Cookies["TaiKhoan"] != null)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnDangKi_Click(object sender, EventArgs e)
        {
            clsTaiKhoanDTO taiKhoanDTO = new clsTaiKhoanDTO();
            taiKhoanDTO.TenTaiKhoan = txtTenTaiKhoan.Text;
            taiKhoanDTO.MatKhau = txtMatKhau.Text;
            taiKhoanDTO.Email = txtEmail.Text;
            taiKhoanDTO.SDT = txtSDT.Text;
            taiKhoanDTO.DiaChi = txtDiaChi.Text;
            taiKhoanDTO.HoTen = txtHoTen.Text;

            if (clsTaiKhoanBUS.ThemTK(taiKhoanDTO))
            {
                HttpCookie cookie = new HttpCookie("TaiKhoan");
                cookie["TenTaiKhoan"] = taiKhoanDTO.TenTaiKhoan;
                cookie["HoTen"] = Server.UrlEncode(taiKhoanDTO.HoTen);
                cookie.Expires = DateTime.Now.AddDays(14);
                Response.Cookies.Add(cookie);
                Response.Redirect("index.aspx");
            }
            else
            {
                lblDangKiThatBai.Visible = true;
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = txtMatKhau.Text = txtNhapLaiMatKhau.Text = txtEmail.Text = txtSDT.Text = txtDiaChi.Text = txtHoTen.Text = string.Empty;
        }
    }
}