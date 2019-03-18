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
    public partial class TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Đã đăng nhập => Load thông tin tài khoản. Ẩn tất cả Label thông báo, tùy trường hợp sẽ hiện thông báo tương ứng
            if (Request.Cookies["TaiKhoan"] != null)
            {
                if (!Page.IsPostBack)
                {
                    LoadThongTinTaiKhoan();
                }
                lblCapNhatThanhCong.Visible = lblCapNhatThatBai.Visible = false;
            }
            // Chưa đăng nhập => Chuyển về trang chủ
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Tạo 1 đối tượng clsTaiKhoanDTO chứa thông tin hiện tại của tài khoản
            string tenTK = Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString();
            clsTaiKhoanDTO taiKhoanDTO = clsTaiKhoanBUS.LayTK(tenTK);

            // Upload ảnh
            if (filAnhDaiDien.HasFile)
            {
                // Kiểm tra định dạng file: JPEG
                if (filAnhDaiDien.PostedFile.ContentType == "image/jpeg")
                {
                    // Kiểm tra dung lượng file: tối đa 5 MB
                    if (filAnhDaiDien.PostedFile.ContentLength <= 5 * 1024 * 1024)
                    {
                        filAnhDaiDien.SaveAs(Server.MapPath("~/img/AnhDaiDien/" + tenTK + ".jpg"));
                        taiKhoanDTO.AnhDaiDien = "img/AnhDaiDien/" + tenTK + ".jpg";
                        lblLoiUploadAnh.Visible = false;
                    }
                    else
                    {
                        lblLoiUploadAnh.Text = "Dung lượng file vượt quá 5 MB";
                        lblLoiUploadAnh.Visible = true;
                        return;
                    }
                }
                else
                {
                    lblLoiUploadAnh.Text = "Định dạng file phải là JPG/JPEG";
                    lblLoiUploadAnh.Visible = true;
                    return;
                }
            }

            // Cập nhật thông tin của đối tượng clsTaiKhoanDTO theo dữ liệu người dùng nhập
            taiKhoanDTO.Email = txtEmail.Text;
            taiKhoanDTO.SDT = txtSDT.Text;
            taiKhoanDTO.DiaChi = txtDiaChi.Text;
            taiKhoanDTO.HoTen = txtHoTen.Text;

            // Cập nhật thành công
            if (clsTaiKhoanBUS.SuaTK(taiKhoanDTO))
            {
                lblCapNhatThanhCong.Visible = true;
            }
        }

        // Nhấn nút Hủy => Load lại thông tin của tài khoản
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            LoadThongTinTaiKhoan();
        }

        private void LoadThongTinTaiKhoan()
        {
            string tenTK = Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString();
            clsTaiKhoanDTO taiKhoanDTO = clsTaiKhoanBUS.LayTK(tenTK);

            txtTenTaiKhoan.Text = taiKhoanDTO.TenTaiKhoan;
            txtEmail.Text = taiKhoanDTO.Email;
            txtSDT.Text = taiKhoanDTO.SDT;
            txtDiaChi.Text = taiKhoanDTO.DiaChi;
            txtHoTen.Text = taiKhoanDTO.HoTen;
            imgAnhDaiDien.ImageUrl = taiKhoanDTO.AnhDaiDien;
        }
    }
}