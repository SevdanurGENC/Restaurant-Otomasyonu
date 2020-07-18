<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="YeniUyeKayit.aspx.cs" Inherits="YeniUyeKayit2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style3
        {
            width: 70px;
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
                        Text="Yeni Uye Kayit Ekranina Hosgeldiniz..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" CssClass="style2" Text="Isim : "></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox1" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" CssClass="style2" Text="Soyisim : "></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox2" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" CssClass="style2" Text="Adres : "></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox3" runat="server" Height="76px" TextMode="MultiLine" 
                        Width="192px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" CssClass="style2" Text="Kullanici Adi : "></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox4" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" CssClass="style2" Text="Sifre : "></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBox5" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="Button1" runat="server" Text="Bilgileri Kaydet" Width="193px" />
                </td>
            </tr>
        </table>
    
        </td>
    </tr>
</table>
</asp:Content>

