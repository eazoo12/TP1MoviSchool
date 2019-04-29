<%@ Page Title="" Language="C#" MasterPageFile="~/MaestroPadre.Master" AutoEventWireup="true" CodeBehind="ModificarPadre.aspx.cs" Inherits="WebMoviSchool.ModificarPadre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 921px;
        }
        .auto-style3 {
            width: 768px;
        }
        .auto-style4 {
            width: 101%;
        }
        .auto-style5 {
            width: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="align-center">
                <strong>Modificación de Datos del Padre</strong><br />
                <table style="width:100%";>
            <tr>
                <td class="auto-style3">Nombre y Apellido:
                    <asp:Label ID="lblNombreApe" runat="server" Text="Label"></asp:Label>
                </td>
            </tr> 
                </table>
            </td>

        </tr>


    </table>

    <td class="auto-style2">
        <table class="auto-style4">
            <tr>
                <td class="auto-style3">Celular:
                    <asp:TextBox ID="txtCelular" runat="server" Height="31px" Width="256px" placeholder="Ingrese celular"></asp:TextBox>           
                </td>
                <td class="auto-style3">Correo Electrónico:
                    <asp:TextBox ID="txtCorreo" runat="server" Height="31px" Width="256px" placeholder="Ingrese correo"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Dirección:
                     <asp:TextBox ID="txtDireccion" runat="server" Height="31px" Width="256px" placeholder="Ingrese dirección" ></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="44px" Width="151px" OnClick="btnGuardar_Click"/>
                </td>
                <td class="auto-style3">
                        <asp:Button ID="btnCancelar" runat="server" Text="Regresar" Height="44px" Width="151px" OnClick="btnCancelar_Click"/>
                    </td>    

            </tr>
        </table>

    </td>
</asp:Content>
