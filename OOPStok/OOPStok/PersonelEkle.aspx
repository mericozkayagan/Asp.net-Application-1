<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPStok.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Personel Adı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel adını giriniz..."></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Personel soyadı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel soyadını giriniz..."></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Personel Maaşı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel maaşı giriniz..."></asp:TextBox><br />
        </div>
        <div>            
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Personeli kaydet" CssClass="btn btn-primary" />
        </div>
        
    </form>
</asp:Content>
