<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Logueo.aspx.cs" Inherits="WebMoviSchool.Logueo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <div class="align-center">
                 <p>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                 </div>
            </td>
            <td>
                <div class="align-center">
                 <p>
                     <asp:TextBox ID="txtUsuario" runat="server" Height="28px" Width="205px"></asp:TextBox>
                </p>
                </div>
            </td>
         </tr>
        
        <tr>
            <td>
                <div class="align-center">
                     <p>
                    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
                    </p>
                </div>
             </td>
            <td>
                <div class="align-center">
                    <p>
                    <asp:TextBox ID="txtContraseña" runat="server" Height="28px" Width="132px"></asp:TextBox>
                        </p>
                </div>
            </td>
        </tr>
        </table> 
        <p>
         
                <asp:Button ID="btnIngresar" runat="server" Height="43px" Text="Ingresar" Width="142px" OnClick="btnIngresar_Click" />
         
        </p>

      
   
    <p>
        <asp:Button ID="btnOlvido" runat="server" Text="Olvidé mi contraseña" Width="248px" OnClick="btnOlvido_Click" />
    </p>
    
    
    <p>
        &nbsp;</p>
    </asp:Content>
