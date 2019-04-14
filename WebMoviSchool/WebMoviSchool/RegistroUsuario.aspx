<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="WebMoviSchool.RegistroUsuario" %>
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
                        <td class="auto-style3">Tipo Documento (*):<asp:DropDownList ID="cboTipDoc" runat="server" Width="202px" AutoPostBack="True" OnSelectedIndexChanged="cboTipDoc_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Nro (*):<asp:TextBox ID="txtNro" runat="server" Height="31px" Width="230px" AutoPostBack="True" OnTextChanged="txtNro_TextChanged"></asp:TextBox>
                            <asp:Label ID="lblNroVa" runat="server" Text="0"></asp:Label>
                        </td>
                        <td>Direccion :<asp:TextBox ID="txtDireccion" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Correo Electronico(*) :<asp:TextBox ID="txtCorreoElec" runat="server" Height="31px" Width="315px" AutoPostBack="True" OnTextChanged="txtCorreoElec_TextChanged"></asp:TextBox>
                            <asp:Label ID="lblCorreo" runat="server" Text="0"></asp:Label>
                        </td>
                        <td>Fecha Nacimiento :<div><asp:Calendar ID="datepicker" runat="server" Visible="False" OnSelectionChanged="datepicker_SelectionChanged" BackColor="White" BorderColor="Black" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" BorderStyle="Solid" CellSpacing="1">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCCCCC" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" Font-Bold="True" Font-Size="12pt" ForeColor="White" BorderStyle="Solid" Height="12pt" />
                            <TodayDayStyle BackColor="#999999" ForeColor="White" />
                            </asp:Calendar></div>
                            <asp:TextBox ID="txtdtp" runat="server"></asp:TextBox><asp:LinkButton ID="lnkpickdate" runat="server" OnClick="lnkpickdate_Click">Fecha Nacimiento</asp:LinkButton>
                            
                        </td>

                        <td>Sexo :<asp:DropDownList ID="cboGenero" runat="server" Width="202px">
                            <asp:ListItem>Selecciona Genero</asp:ListItem>
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                            <asp:ListItem>Otro</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Pais (*):<asp:DropDownList ID="cboPais" runat="server" Width="202px" AutoPostBack="True" OnSelectedIndexChanged="cboPais_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Departamento (*):<asp:DropDownList ID="cboDepartamento" runat="server" Width="202px" AutoPostBack="True" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>Distrito (*):<asp:DropDownList ID="cboDistrito" runat="server" Width="202px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Usuario (*):<asp:TextBox ID="txtUsuario" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Password(*) :<asp:TextBox ID="txtPass"  runat="server" Height="31px" Width="315px" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>Repite Password (*):<asp:TextBox ID="txtRepass" runat="server" Height="31px" Width="315px" TextMode="Password"></asp:TextBox>
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
                            <asp:Button ID="Button1" runat="server" Text="Guardar" Height="44px" Width="151px" OnClick="Button1_Click" />
                        </td>
                        
                        
                    </tr>
                    </table>


    </table>
</asp:Content>
