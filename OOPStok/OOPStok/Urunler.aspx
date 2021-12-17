<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="OOPStok.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Urun ID </th>
            <th>Urun Ad </th>
            <th>Urun Fiyat </th>
            <th>Urun Adet </th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("URUNID")%></td>
                        <td><%#Eval("URUNAD")%></td>
                        <td><%#Eval("URUNFIYAT")%></td>
                        <td><%#Eval("URUNADET")%></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <div>
        <a href="Urunekle.aspx" class="btn btn-info">Yeni Ürün Ekle</a>
    </div>
</asp:Content>
