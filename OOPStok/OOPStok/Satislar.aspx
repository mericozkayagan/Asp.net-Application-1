<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="OOPStok.Satislar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Satıs ID </th>
            <th>Urun Ad </th>
            <th>Personel</th>
            <th>Musteri</th>
            <th>Tutar</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("SATISID")%></td>
                        <td><%#Eval("URUNAD")%></td>
                        <td><%#Eval("PERSONELAD")%></td>
                        <td><%#Eval("MUSTERIAD")%></td>
                        <td><%#Eval("TUTAR")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="Satisekle.aspx">Yeni Satış Ekle</a>
</asp:Content>
