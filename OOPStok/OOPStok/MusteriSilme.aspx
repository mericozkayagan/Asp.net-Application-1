<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriSilme.aspx.cs" Inherits="OOPStok.MusteriSilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
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
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Müşteri ID:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Müşteri adı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Müşteri Soyadı:" Font-Bold="true"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox><br />
        </div>
        
        <br />
        <div>
            <asp:Button ID="btnguncelle" runat="server" Text="Musteriyi Guncelle" CssClass="btn btn-primary" OnClick="Button1_Click1" />
            <asp:Button ID="btnsil" runat="server" Text="Musteriyi Sil" CssClass="btn btn-primary" OnClick="btnsil_Click" />
            <asp:Button ID="btnaktiflestir" runat="server" Text="Musteriyi Aktiflestir" CssClass="btn btn-primary" OnClick="Button3_Click1"/>
            
        </div>
        
    </form>
</asp:Content>
