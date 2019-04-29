<%@ Page Title="" Language="C#" MasterPageFile="~/MaestroMovilidad.Master" AutoEventWireup="true" CodeBehind="RegistrarPromociones.aspx.cs" Inherits="WebMoviSchool.RegistrarPromociones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td><h3 class="align-center">Registro Promociónes</h3></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    <asp:TextBox ID="txtPromocio" runat="server" CssClass="auto-style3" Height="31px" Width="744px"></asp:TextBox>
                    <asp:Button ID="btnRegistro" runat="server" OnClick="btnRegistro_Click" Text="Guardar Promoción" />
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblPromociones" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
