<%@ Page Title="" Language="C#" MasterPageFile="~/MaestroMovilidad.Master" AutoEventWireup="true" CodeBehind="RegistroMovilidad.aspx.cs" Inherits="WebMoviSchool.RegistroMovilidad" %>
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
        
                                      
                </td>
                
            </tr>

            
            
                  
                        <td class="auto-style2">
                            <table class="auto-style4">
                                <tr>
                        <td class="col-6 col-12-small">Soat (*):<asp:TextBox ID="txtNombre" runat="server" Height="31px" Width="256px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Placa :<asp:TextBox ID="txtApellido" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td class="auto-style5">Rev. Tecnica :<asp:TextBox ID="txtNrocelular" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Marca (*):<asp:TextBox ID="txtNombre0" runat="server" Height="31px" Width="256px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Modelo (*):<asp:TextBox ID="txtNro" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td class="auto-style5">Color :<asp:TextBox ID="txtDireccion" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Capacidad (*) :<asp:TextBox ID="txtCorreoElec" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td>Nombre chofer :<asp:TextBox ID="txtCorreoElec0" runat="server" Height="31px" Width="315px"></asp:TextBox>
                            
                        </td>

                        <td class="auto-style5">Telefono :<asp:TextBox ID="txtCorreoElec1" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            
                            Pais (*):
                                    <asp:DropDownList ID="cboPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboPais_SelectedIndexChanged" Width="202px">
                                    </asp:DropDownList>
                                    
                        </td>
                        <td class="auto-style3">Departamento (*) :
                            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                                <ContentTemplate>
                                    <asp:DropDownList ID="cboDepartamento" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" Width="202px">
                                    </asp:DropDownList>
                                </ContentTemplate>

                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="cboDepartamento" EventName="SelectedIndexChanged"/>
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                        <td class="auto-style5">Distrito (*):<asp:DropDownList ID="cboDistrito" runat="server" Width="202px" AutoPostBack="True" OnSelectedIndexChanged="cboDistrito_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Colegio (*):<asp:DropDownList ID="cboColegio" runat="server" Width="202px" AutoPostBack="false">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Tipo Documento (*) :<asp:DropDownList ID="cboTipDocumento" runat="server" Width="202px" >
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style5">Nro Documento (*):<asp:TextBox ID="txtRepass" runat="server" Height="31px" Width="315px" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button1" runat="server" Text="Agregar" Height="44px" Width="151px"/>
                        </td>
                        
                        
                    </tr>
                            </table>
                        </td>
             

                   
                            
        </table>
    </p>
</asp:Content>
