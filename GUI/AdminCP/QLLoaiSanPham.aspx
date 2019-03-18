<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCP/AdminCP.Master" AutoEventWireup="true" CodeBehind="QLLoaiSanPham.aspx.cs" Inherits="GUI.AdminCP.QLLoaiSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <h3>Quản lí loại sản phẩm</h3>
    <div class="form-group">
        <label for="txtMaLoaiSP">Mã loại sản phẩm:</label>
        <asp:TextBox ID="txtMaLoaiSP" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtTenLoaiSP">Tên loại sản phẩm:</label>
        <asp:TextBox ID="txtTenLoaiSP" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Còn hiệu lực:</label>
        <asp:CheckBox ID="chkTrangThai" runat="server" Checked="true" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="btn btn-primary" />
        <asp:Button ID="btnSua" runat="server" Text="Sửa" CssClass="btn btn-primary" />
        <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" CssClass="btn btn-danger" OnClick="btnHuy_Click" />
        <asp:Label ID="lblThongBaoThanhCong" runat="server" CssClass="font-weight-bold text-primary" Visible="false"></asp:Label>
        <asp:Label ID="lblThongBaoThatBai" runat="server" CssClass="font-weight-bold text-danger" Visible="false"></asp:Label>
    </div>
    <div class="form-group">
        <asp:GridView ID="grvDSLoaiSanPham" runat="server" CssClass="table table-bordered table-hover thead-light" AutoGenerateColumns="False" OnRowCommand="grvDSLoaiSanPham_RowCommand">
            <Columns>
                <asp:BoundField DataField="MaLoaiSP" HeaderText="Mã loại SP" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                <asp:BoundField DataField="TenLoaiSP" HeaderText="Tên loại SP" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                <asp:CheckBoxField DataField="TrangThai" HeaderText="Còn hiệu lực" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                <asp:TemplateField ShowHeader="False" HeaderText="Chức năng" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                    <ItemTemplate>
                        <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonLoaiSP" CommandArgument='<%# Eval("MaLoaiSP") %>' Text="Chọn" />
                        <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaLoaiSP" CommandArgument='<%# Eval("MaLoaiSP") %>' Text="Xóa" OnClientClick="return confirm('Bạn có chắc chắn xóa loại sản phẩm này không?');" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
