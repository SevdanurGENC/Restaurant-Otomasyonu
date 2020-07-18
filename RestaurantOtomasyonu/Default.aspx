<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<script runat="server">
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style3
        {
            width: 120px;
            height: 30px;
        }
        .style4
        {
            height: 30px;
        }
    .style5
    {
        height: 28px;
        text-align: left;
    }
    .style8
    {
            text-align: left;
        }
    .style9
    {
        height: 99px;
    }
    .style11
    {
        height: 14px;
    }
    .style12
    {
        height: 14px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
    <tr>
        <td class="style9">
    
        <table>
            <tr>
                <td colspan="2" style="font-weight: 700; color: #CC0000">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" colspan="2">
                    <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #CC0000" 
                        Text="Restaurant Otomasyonu Web Siparis Modulune Hosgeldiniz... "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label2" runat="server" CssClass="style1" Text="Kullanici Adi : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKulAdi" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label3" runat="server" CssClass="style1" Text="Sifre : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSifre" runat="server" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style4">
                    <asp:Button ID="Button1" runat="server" Text="Giris Yap" Font-Bold="True" 
                        onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="style12" colspan="2">
                    <asp:Label ID="Label4" runat="server" style="font-weight: 700; color: #3333FF" 
                        Text="Uye Degilseniz Uye Kaydi Icin Tiklayiniz..."></asp:Label>
                </td>
            </tr>
        </table>
    
        </td>
    </tr>
</table>
</asp:Content>

