<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="KisiselBilgilerim.aspx.cs" Inherits="KisiselBilgilerim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style3
        {
            width: 70px;
        }
    .style4
    {
        width: 71px;
    }
    .style5
    {
        width: 280px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
    <tr>
        <td>
    
        <table>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label6" runat="server" style="font-weight: 700; color: #CC0000" 
                        
                        Text="Kisisel Bilgilerinizi Asagidaki Alanlari Guncelleyerek Yapabilirsiniz..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label1" runat="server" CssClass="style2" Text="Isim : " 
                        Font-Bold="True"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtIsim" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label2" runat="server" CssClass="style2" Text="Soyisim : " 
                        Font-Bold="True"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtSoyisim" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label3" runat="server" CssClass="style2" Text="Adres : " 
                        Font-Bold="True"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtAdres" runat="server" Height="76px" TextMode="MultiLine" 
                        Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label4" runat="server" CssClass="style2" Text="Kullanici Adi : " 
                        Font-Bold="True"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtKulAdi" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label5" runat="server" CssClass="style2" Text="Sifre : " 
                        Font-Bold="True"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtSifre" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="Button1" runat="server" Text="Bilgileri Guncelle" 
                        Width="195px" onclick="Button1_Click" />
                </td>
            </tr>
        </table>
    
        </td>
    </tr>
</table>
</asp:Content>

