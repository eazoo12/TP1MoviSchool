<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Logueo.aspx.cs" Inherits="WebMoviSchool.Logueo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 97%;
        }
        .auto-style2 {
            width: 246px;
        }
        .auto-style4 {
            width: 234px;
        }
        .auto-style5 {
            width: 1147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <div class="align-center">
                 <p>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="auto-style3"></asp:Label>
                 </div>
            </td>
            <td>
                <div class="align-center">
                 <p>
                     <asp:TextBox ID="txtUsuario" runat="server" Height="28px" Width="371px" CssClass="auto-style3"></asp:TextBox>
                </p>
                </div>
            </td>
         </tr>
        
        <tr>
            <td>
                <div class="align-center">
                     <p>
                    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" CssClass="auto-style3"></asp:Label>
                    </p>
                </div>
             </td>
            <td>
                <div class="align-center">
                    <p>
                    <asp:TextBox ID="txtContraseña" runat="server" Height="28px" Width="383px" TextMode="Password" CssClass="auto-style3"></asp:TextBox>
                        </p>
                </div>
            </td>
        </tr>
        </table> 

      
   
    <p>
        <table class="auto-style1" >
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
         
                <asp:Button ID="btnIngresar" runat="server" Height="43px" Text="Ingresar" Width="234px" OnClick="btnIngresar_Click" />
         
                </td>
                <td class="auto-style5">
         
        <asp:Button ID="btnOlvido" runat="server" Text="Olvidé mi contraseña" Width="248px" OnClick="btnOlvido_Click" />
         
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
           
        </table>
    </p>
    
    
    <p>
        &nbsp;</p>
    </asp:Content>
