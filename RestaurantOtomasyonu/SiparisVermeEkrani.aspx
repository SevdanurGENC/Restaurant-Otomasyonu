<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="SiparisVermeEkrani.aspx.cs" Inherits="SiparisVermeEkrani" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            color: #7E1818;
            font-weight: bold;
        }
        .style4
        {
            color: #893639;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label1" runat="server" Text="Menuler" CssClass="style3"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDLAnaMenu" runat="server" Height="30px" Width="450px" 
                                AutoPostBack="True" onselectedindexchanged="DDLAnaMenu_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label2" runat="server" Text="Menu Icerigi" CssClass="style3"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDLAltMenu" runat="server" Height="29px" Width="277px" 
                                AutoPostBack="True" 
                                onselectedindexchanged="DDLAltMenu_SelectedIndexChanged">
                            </asp:DropDownList>
                        &nbsp;
                            <asp:Label ID="Label7" runat="server" Text="Fiyat" CssClass="style3"></asp:Label>
                        &nbsp;&nbsp;
                            <asp:TextBox ID="txtFiyat" runat="server" Width="88px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label3" runat="server" Text="Adet" CssClass="style3"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAdet" runat="server" AutoPostBack="True" 
                             ontextchanged="txtAdet_TextChanged"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Text="Toplam Tutar" CssClass="style3"></asp:Label>
                        &nbsp;&nbsp;
                            <asp:TextBox ID="txtToplamTutar" runat="server" Width="110px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Listeye Ekle" Width="450px" 
                                onclick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Sepete Ekle / Sepetten Cikart" 
                                CssClass="style3"></asp:Label>
                        </td>
                        <td>
                            <asp:ListBox ID="ListBox1" runat="server" Height="213px" Width="450px">
                            </asp:ListBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:Label ID="Label5" runat="server" CssClass="style3" Text="Aciklama"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAciklama" runat="server" Height="88px" TextMode="MultiLine" 
                                Width="450px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:Label ID="Label6" runat="server" CssClass="style3" Text="Ek Istekler"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtEkIstekler" runat="server" Height="88px" TextMode="MultiLine" 
                                Width="450px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:Label ID="Label4" runat="server" Text="Toplam Tutar" CssClass="style4"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtGenelToplam" runat="server" AutoPostBack="True">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Siparis Ver" Width="450px" 
                                onclick="Button2_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
            </td>
        </tr>
    </table>
</asp:Content>

