<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QuenMatKhau.aspx.cs" Inherits="GUI.QuenMatKhau" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <h2>Quên mật khẩu</h2>
    <p>Đặt lại mật khẩu bằng cách sử dụng Email và SĐT lúc đăng kí</p>
    <asp:Panel ID="panQuenMatKhau" runat="server" DefaultButton="btnTiepTuc">
        <p>Nhập tên tài khoản, địa chỉ Email và SĐT và nhấn nút Tiếp tục</p>
        <div class="form-group">
            <label for="txtTenTaiKhoan">Tên tài khoản:</label>
            <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtSDT">SĐT:</label>
            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnTiepTuc" runat="server" CssClass="btn btn-primary" Text="Tiếp tục" OnClick="btnTiepTuc_Click" /><br />
        <asp:Label ID="lblThongTinSai" runat="server" Text="Email hoặc SĐT không đúng" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panDoiMatKhau" runat="server" DefaultButton="btnDoiMatKhau" Visible="false">
        <p>Nhập mật khẩu mới 2 lần và nhấn nút Tiếp tục</p>
        <div class="form-group">
            <label for="txtMatKhauMoi">Mật khẩu mới:</label>
            <asp:TextBox ID="txtMatKhauMoi" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtNhapLaiMatKhauMoi">Nhập lại mật khẩu mới:</label>
            <asp:TextBox ID="txtNhapLaiMatKhauMoi" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnDoiMatKhau" runat="server" CssClass="btn btn-primary" Text="Cập nhật" OnClick="btnDoiMatKhau_Click" />
        <asp:Button ID="btnHuy" runat="server" CssClass="btn btn-danger" Text="Hủy bỏ" OnClick="btnHuy_Click" /><br />
        <asp:Label ID="lblDoiMKThanhCong" runat="server" Text="Đổi mật khẩu thành công" CssClass="font-weight-bold text-primary" Visible="false"></asp:Label>
        <asp:Label ID="lblDoiMKThatBai" runat="server" Text="Đổi mật khẩu thất bại" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
    </asp:Panel>
</asp:Content>
