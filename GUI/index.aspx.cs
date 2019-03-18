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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["MaLoaiSP"] == null)
                {
                    dtlDSSanPham.DataSource = clsSanPhamBUS.LayDSSanPham();
                    dtlDSSanPham.DataBind();
                }
                else
                {
                    string maLoaiSP = Request.QueryString["MaLoaiSP"];
                    dtlDSSanPham.DataSource = clsSanPhamBUS.LayDSSanPham(maLoaiSP);
                    dtlDSSanPham.DataBind();
                }
            }
        }

        protected void dtlDSSanPham_ItemCommand(object source, DataListCommandEventArgs e)
        {
            // Xử lí nút Thêm vào giỏ hàng
            if (e.CommandName == "ThemGH")
            {
                // Người dùng đã đăng nhập => Thêm SP vào GH
                if (Request.Cookies["TaiKhoan"] != null)
                {
                    clsGioHangDTO gioHangDTO = new clsGioHangDTO();
                    gioHangDTO.TenTaiKhoan = Request.Cookies["TaiKhoan"]["TenTaiKhoan"];
                    gioHangDTO.MaSP = e.CommandArgument.ToString();
                    gioHangDTO.SoLuong = 1;

                    // Thêm SP vào GH thành công
                    if (clsGioHangBUS.ThemSPVaoGH(gioHangDTO))
                    {

                    }
                    // Ngược lại => Thông báo lỗi
                    else
                    {
                        Response.Write("<script>alert('Thêm sản phẩm vào giỏ hàng thất bại');</script>");
                    }
                }
                // Ngược lại => Thông báo lỗi: Yêu cầu đăng nhập
                else
                {
                    Response.Write("<script>alert('Vui lòng đăng nhập để mua hàng');</script>");
                }
            }
        }
    }
}