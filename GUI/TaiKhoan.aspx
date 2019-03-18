<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TaiKhoan.aspx.cs" Inherits="GUI.TaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <h2>Thông tin tài khoản</h2>
    <p>Nếu muốn sửa đổi thông tin tài khoản, nhập thông tin mới và nhấn nút Cập nhật</p>
    <p>Để thay đổi mật khẩu, vui lòng sử dụng trang <a href="DoiMatKhau.aspx">Đổi mật khẩu</a></p>
    <asp:Panel ID="panThongTinTaiKhoan" runat="server" DefaultButton="btnCapNhat">
        <div class="form-group">
            <label for="txtTenTaiKhoan">Tên tài khoản:</label>
            <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtSDT">SĐT:</label>
            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDiaChi">Địa chỉ:</label>
            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtHoTen">Họ tên:</label>
            <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtHoTen">Ảnh đại diện:</label><br />
            <asp:FileUpload ID="filAnhDaiDien" runat="server" /><br />
            <asp:Image ID="imgAnhDaiDien" runat="server" Width="300px" />
        </div>
        <asp:Button ID="btnCapNhat" runat="server" CssClass="btn btn-primary" Text="Cập nhật" OnClick="btnCapNhat_Click" />
        <asp:Button ID="btnHuy" runat="server" CssClass="btn btn-danger" Text="Hủy bỏ" OnClick="btnHuy_Click" /><br />
        <asp:Label ID="lblCapNhatThanhCong" runat="server" Text="Cập nhật thông tin thành công" CssClass="font-weight-bold text-primary" Visible="false"></asp:Label>
        <asp:Label ID="lblCapNhatThatBai" runat="server" Text="Cập nhật thông tin thất bại" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
        <asp:Label ID="lblLoiUploadAnh" runat="server" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
    </asp:Panel>
</asp:Content>
