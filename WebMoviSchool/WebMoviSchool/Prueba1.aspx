<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Prueba1.aspx.cs" Inherits="WebMoviSchool.Prueba1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table style="width:100%;">
            <tr>
                
                <td >
                    <div class="align-center">
                        <strong>Registro de Usuario</strong></div>
                
                    <table class="auto-style4">
                    <tr>
                        <td class="col-6 col-12-small">Nombre (*):<asp:TextBox ID="txtNombre" runat="server" Height="31px" Width="256px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Apellidos :<asp:TextBox ID="txtApellido" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td>Nro. Celular :<asp:TextBox ID="txtNrocelular" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Tipo Documento (*):<asp:DropDownList ID="cboTipDoc" runat="server" Width="202px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Nro (*):<asp:TextBox ID="txtNro" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td>Direccion :<asp:TextBox ID="txtDireccion" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Correo Electronico(*) :<asp:TextBox ID="txtCorreoElec" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td>Fecha Nacimiento :</td>

                        <td>Sexo :<asp:DropDownList ID="cboGenero" runat="server" Width="202px">
                            <asp:ListItem>Selecciona Genero</asp:ListItem>
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                            <asp:ListItem>Otro</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Pais (*):<asp:DropDownList ID="cboPais" runat="server" Width="202px" AutoPostBack="True" >
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Departamento (*):<asp:DropDownList ID="cboDepartamento" runat="server" Width="202px" AutoPostBack="True" >
                            </asp:DropDownList>
                        </td>
                        <td>Distrito (*):<asp:DropDownList ID="cboDistrito" runat="server" Width="202px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Usuario (*):<asp:TextBox ID="txtUsuario" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Password(*) :<asp:TextBox ID="txtPass" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td>Repite Password (*):<asp:TextBox ID="txtRepass" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                           
                            Tipo Usuario (*):<asp:DropDownList ID="cboTipoUsuario" runat="server" Width="202px">
                            </asp:DropDownList>
                           
                        </td>
                        
                        
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button1" runat="server" Text="Guardar" Height="44px" Width="151px"  />
                        </td>
                        
                        
                    </tr>
                    </table>


    </table>

</asp:Content>
