<%@ Page Title="" Language="C#" MasterPageFile="~/MaestroMovilidad.Master" AutoEventWireup="true" CodeBehind="RegistroMovilidad.aspx.cs" Inherits="WebMoviSchool.RegistroMovilidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 921px;
        }
        .auto-style3 {
            width: 768px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table style="width:100%;">
            <tr>
                <td class="align-center">Registro de Movilidad<br />
                    <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">Nombre y Apellido :
                            <asp:Label ID="lblNombreApe" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="align-left">&nbsp;Celular :
                            <asp:Label ID="Celular" runat="server" Text="Label"></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="auto-style3">Corre Electronico:
                            <asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label>
                        </td>
                        
                    </tr>
                  
                    </table>
        
                    <tr> 
                        <td class="auto-style2">Cantidad Conductores :&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="65px">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>

                   
                </td>
                
            </tr>

            <tr>
                dddd
            </tr>
            
        </table>
    </p>
</asp:Content>
