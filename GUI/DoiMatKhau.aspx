<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="GUI.DoiMatKhau" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <h2>Đổi mật khẩu</h2>
    <p>Nhập mật khẩu hiện tại, sau đó nhập mật khẩu mới 2 lần và nhấn nút Đổi mật khẩu</p>
    <asp:Panel ID="panDoiMatKhau" runat="server" DefaultButton="btnDoiMatKhau">
        <div class="form-group">
            <label for="txtMatKhauCu">Mật khẩu cũ:</label>
            <asp:TextBox ID="txtMatKhauCu" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtMatKhauMoi">Mật khẩu mới:</label>
            <asp:TextBox ID="txtMatKhauMoi" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtNhapLaiMatKhauMoi">Nhập lại mật khẩu mới:</label>
            <asp:TextBox ID="txtNhapLaiMatKhauMoi" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnDoiMatKhau" runat="server" CssClass="btn btn-primary" Text="Đổi mật khẩu" OnClick="btnDoiMatKhau_Click" />
        <asp:Button ID="btnHuy" runat="server" CssClass="btn btn-danger" Text="Hủy bỏ" OnClick="btnHuy_Click" /><br />
        <asp:Label ID="lblDoiMKThanhCong" runat="server" Text="Đổi mật khẩu thành công" CssClass="font-weight-bold text-primary" Visible="false"></asp:Label>
        <asp:Label ID="lblDoiMKThatBai" runat="server" Text="Đổi mật khẩu thất bại" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
        <asp:Label ID="lblMKCuSai" runat="server" Text="Mật khẩu cũ không đúng" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
    </asp:Panel>
</asp:Content>
