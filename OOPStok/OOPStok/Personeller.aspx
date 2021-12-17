<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="OOPStok.Personeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Personel id </th>
            <th>Personel ad </th>
            <th>Personel Soyad </th>
            <th>Personel Foto </th>
            <th>Personel Departman </th>
            <th>Personel Maas </th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("PERID")%></td>
                        <td><%#Eval("PERAD")%></td>
                        <td><%#Eval("PERSOYAD")%></td>
                        <td><%#Eval("PERFOTO")%></td>
                        <td><%#Eval("DEPARTMANAD")%></td>
                        <td><%#Eval("PERMAAS")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="PersonelEkle.aspx" class="btn btn-primary">Personel Ekle</a>
</asp:Content>
