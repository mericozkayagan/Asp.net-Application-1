<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satisekle.aspx.cs" Inherits="OOPStok.Satisekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün seçiniz:" Font-Bold="true"></asp:Label>
            <br />
            <div>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Personel seçiniz:" Font-Bold="true"></asp:Label>
            <br />
            <div>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Müşteri Seçiniz:" Font-Bold="true"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Tutar giriniz:" Font-Bold="true"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Tutar..."></asp:TextBox>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Personeli kaydet" CssClass="btn btn-primary" />
            </div>
        </div>
    </form>
</asp:Content>
