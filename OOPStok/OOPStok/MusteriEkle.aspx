<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="OOPStok.MusteriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Müşterinin adı:" Font-Bold="true" Font-Italic="true"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Müşterinin soyadı: " Font-Bold="true" Font-Italic="true"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Müşteriyi kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
