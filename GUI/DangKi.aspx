<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="GUI.DangKi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <h2>Đăng kí tài khoản</h2>
    <p>Nếu đã có tài khoản, vui lòng chọn mục Đăng nhập ở menu phía trên cùng.</p>
    <asp:Panel ID="panDangKi" runat="server" DefaultButton="btnDangKi">
        <fieldset>
            <legend>Thông tin tài khoản</legend>
            <div class="form-group">
                <label for="txtTenTaiKhoan">Tên tài khoản:</label>
                <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control" placeholder="6-20 kí tự"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTenTaiKhoan" runat="server" ControlToValidate="txtTenTaiKhoan" ErrorMessage="Chưa nhập tên tài khoản" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revTenTaiKhoan" runat="server" ControlToValidate="txtTenTaiKhoan" ErrorMessage="Tên tài khoản phải từ 6-20 kí tự, bao gồm chữ cái, chữ số, dấu gạch dưới" ValidationExpression="\w{6,20}" Display="None"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label for="txtMatKhau">Mật khẩu:</label>
                <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" TextMode="Password" placeholder="6-20 kí tự"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvMatKhau" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Chưa nhập mật khẩu" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revMatKhau" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Mật khẩu phải từ 6-20 kí tự, bao gồm chữ cái, chữ số, dấu gạch dưới" ValidationExpression="\w{6,20}" Display="None"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label for="txtNhapLaiMatKhau">Nhập lại mật khẩu:</label>
                <asp:TextBox ID="txtNhapLaiMatKhau" runat="server" CssClass="form-control" TextMode="Password" placeholder="6-20 kí tự"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNhapLaiMatKhau" runat="server" ControlToValidate="txtNhapLaiMatKhau" ErrorMessage="Chưa nhập lại mật khẩu" Display="None"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cpvNhapLaiMatKhau" runat="server" ControlToValidate="txtNhapLaiMatKhau" ControlToCompare="txtMatKhau" ErrorMessage="Mật khẩu không khớp" Display="None"></asp:CompareValidator>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Chưa nhập email" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ" ValidationExpression="\w+@[A-Za-z0-9_\.]+" Display="None"></asp:RegularExpressionValidator>
            </div>
        </fieldset>
        <fieldset>
            <legend>Thông tin liên hệ (Không bắt buộc)</legend>
            <div class="form-group">
                <label for="txtSDT">SĐT:</label>
                <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revSDT" runat="server" ControlToValidate="txtSDT" ErrorMessage="SĐT không hợp lệ" ValidationExpression="0\d{9,10}" Display="None"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label for="txtDiaChi">Địa chỉ:</label>
                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtHoTen">Họ tên:</label>
                <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </fieldset>
        <asp:Button ID="btnDangKi" runat="server" CssClass="btn btn-primary" Text="Đăng kí" OnClick="btnDangKi_Click" />
        <asp:Button ID="btnHuy" runat="server" CssClass="btn btn-danger" Text="Hủy bỏ" OnClick="btnHuy_Click" /><br />
        <asp:Label ID="lblDangKiThatBai" runat="server" Text="Đăng kí thất bại" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
        <asp:ValidationSummary ID="vsmDSLoi" runat="server" />
    </asp:Panel>
</asp:Content>
