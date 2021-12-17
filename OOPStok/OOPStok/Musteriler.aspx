<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="OOPStok.Musteriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Musteri id </th>
            <th>Musteri ad </th>
            <th>Musteri Soyad </th>
            <th>Musteri Durum </th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("MUSTERIID")%></td>
                        <td><%#Eval("MUSTERIAD")%></td>
                        <td><%#Eval("MUSTERISOYAD")%></td>
                        <td><%#Eval("MUSTERIDURUM")%></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <div>
        <a href="MusteriEkle.aspx" class="btn btn-info">Yeni Müşteri Ekle</a>
        <a href="MusteriSilme.aspx" class="btn btn-info">Müşterileri Düzenle</a>
    </div>
</asp:Content>
