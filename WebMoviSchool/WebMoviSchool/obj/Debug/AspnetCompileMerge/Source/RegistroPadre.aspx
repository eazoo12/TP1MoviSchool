﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="RegistroPadreaspx.aspx.cs" Inherits="WebMoviSchool.RegistroPadreaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 325px;
        }
        .auto-style4 {
            width: 100%;
            height: 299px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div _designerregion="0">
        <table style="width:100%;">
            <tr>
                
                <td >
                    <div class="align-center">
                        <strong>Registro de Padre de Familia</strong></div>
                    <table class="auto-style4">
                    <tr>
                        <td class="col-6 col-12-small">Nombre :<asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="256px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Apellidos :<asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td>Nro. Celular :<asp:TextBox ID="TextBox8" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Tipo Documento :<asp:DropDownList ID="DropDownList2" runat="server" Width="202px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style3">Nro :<asp:TextBox ID="TextBox3" runat="server" Height="31px" Width="230px"></asp:TextBox>
                        </td>
                        <td>Direccion :<asp:TextBox ID="TextBox4" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Correo Electronico :<asp:TextBox ID="TextBox5" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Fecha de Nacimiento :</td>
                        <td>:<asp:TextBox ID="TextBox7" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Usuario :<asp:TextBox ID="TextBox9" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td class="auto-style3">Password :<asp:TextBox ID="TextBox10" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                        <td>Repite Password :<asp:TextBox ID="TextBox11" runat="server" Height="31px" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button1" runat="server" Text="Guardar" Height="44px" Width="151px" />
                        </td>
                        
                        
                    </tr>
                    </table>
                </td>
                
            </tr>
            
        </table>
    </div>
</asp:Content>