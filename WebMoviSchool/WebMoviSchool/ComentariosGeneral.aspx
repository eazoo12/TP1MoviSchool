<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ComentariosGeneral.aspx.cs" Inherits="WebMoviSchool.ComentariosGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
        .auto-style2 {
            width: 99%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <td class="align-center"><h3 class="align-center">Datos Movilidad</h3><br />
          <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">Nombre y Apellido :
                            <asp:Label ID="lblNombreApe" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style3">&nbsp;Celular :
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
    <asp:Panel ID="Panel1" runat="server" Visible="False" class="auto-style3" Width="1054px">
        <table class="auto-style2" >
            <tr>
                <td class="auto-style3"><h3 class="auto-style1">Ingrese Comentario</h3></td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td  class="auto-style3">Comentario (*):<asp:TextBox ID="txtComentario" runat="server" Height="94px" Width="677px" TextMode="MultiLine" Wrap="False"></asp:TextBox>
                        </td>
                
                
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" Height="44px" OnClick="Button1_Click" Text="Agregar" Width="151px" />
                </td>
            </tr>
        </table>


    </asp:Panel>


    <h3>COMENTARIOS</h3>
    <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <div class="auto-style3">

                 <table style="width: 100%;">
                     <tr>
                         
                         <td>
                             <h5><%# DataBinder.Eval(Container.DataItem,"idComentario") %>
                             <%# DataBinder.Eval(Container.DataItem,"NombrePadre") %></h5> 
                             
                         </td>
                         <td></td>
                         <td>&nbsp;</td>
                     </tr>
                     <tr>
                         <td><%# DataBinder.Eval(Container.DataItem,"desComentario") %></td>
                         <%--<td>&nbsp;</td>
                         <td>&nbsp;</td>--%>
                     </tr>
                     
                 </table>

             </div>


         </ItemTemplate>

    </asp:Repeater>

</asp:Content>
