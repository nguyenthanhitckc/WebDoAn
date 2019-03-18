using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI.AdminCP
{
    public partial class QLLoaiSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDSLoaiSP();
            }
        }

        protected void grvDSLoaiSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonLoaiSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();

                clsLoaiSPDTO loaiSPDTO = clsLoaiSPBUS.LayLoaiSP(maLoaiSP);
                txtMaLoaiSP.Text = loaiSPDTO.MaLoaiSP;
                txtTenLoaiSP.Text = loaiSPDTO.TenLoaiSP;
                chkTrangThai.Checked = loaiSPDTO.TrangThai;
            }

            if (e.CommandName == "XoaLoaiSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();

                if (clsLoaiSPBUS.XoaLoaiSanPham(maLoaiSP))
                {
                    lblThongBaoThanhCong.Text = "Xóa thành công";
                    lblThongBaoThanhCong.Visible = true;
                    lblThongBaoThatBai.Visible = false;

                    LoadDSLoaiSP();
                }
                else
                {
                    lblThongBaoThatBai.Text = "Xóa thất bại";
                    lblThongBaoThatBai.Visible = true;
                    lblThongBaoThanhCong.Visible = false;
                }
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaLoaiSP.Text = txtTenLoaiSP.Text = string.Empty;
        }

        private void LoadDSLoaiSP()
        {
            grvDSLoaiSanPham.DataSource = clsLoaiSPBUS.LayDSLoaiSanPham();
            grvDSLoaiSanPham.DataBind();
        }
    }
}