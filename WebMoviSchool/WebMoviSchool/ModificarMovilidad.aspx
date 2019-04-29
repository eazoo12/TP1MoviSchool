<%@ Page Title="" Language="C#" MasterPageFile="~/MaestroMovilidad.Master" AutoEventWireup="true" CodeBehind="ModificarMovilidad.aspx.cs" Inherits="WebMoviSchool.ModificarMovilidad1" %>
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

    <table style="width=100%;">
        <tr>
            <td class="align-center">
                <strong>Modificación de Datos de Movilidad</strong>
                <table style="width=100%;">
                    <tr>
                        <td class="auto-style3">Nombre y Apellido:
                            <asp:Label ID="lblNombre" runat="server" Text="label"></asp:Label>
                        </td>
                        <td class="align-left">Celular:
                            <asp:Label ID="Celular" runat="server" Text="label"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style3">Correo Electrónico: 
                            <asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>

                </table>
            </td>
        </tr>


        <td class="auto-style2">
            <table class="auto-style4">
                <tr>

                </tr>
                <tr>
                    <td class="auto-style3">Marca: <asp:TextBox ID="txtMarca" runat="server" Height="31px" Width="25px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">Modelo:<asp:TextBox ID="txtModelo" runat="server" Height="31px" Width="219px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">Color:<asp:TextBox ID="txtColor" runat="server" Height="31px" Width="315px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="44px" Width="151px" />
                    </td>
                </tr>
            </table>
        </td>

    </table>

</asp:Content>
