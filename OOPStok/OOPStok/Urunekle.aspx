<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunekle.aspx.cs" Inherits="OOPStok.Urunekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Adı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Departman adını giriniz..."></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Ürünün fiyatı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Departman adını giriniz..."></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Ürünün Adedi:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Departman adını giriniz..."></asp:TextBox><br />
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürünü kaydet" CssClass="btn btn-primary" />
        </div>
    </form>
</asp:Content>
