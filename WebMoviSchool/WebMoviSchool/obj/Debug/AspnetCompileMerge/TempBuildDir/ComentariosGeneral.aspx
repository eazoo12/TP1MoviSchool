<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ComentariosGeneral.aspx.cs" Inherits="WebMoviSchool.ComentariosGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <td class="align-center"><h3 class="align-center">Datos Movilidad</h3><br />
          <table style="width:100%;">
                    <tr>
                        <td class="align-center">Nombre y Apellido :
                            <asp:Label ID="lblNombreApe" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="align-left">&nbsp;Celular :
                            <asp:Label ID="Celular" runat="server" Text="Label"></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="align-center">Corre Electronico:
                            <asp:Label ID="lblCorreo" runat="server" Text="Label"></asp:Label>
                        </td>
                                                
                    </tr>
                        
                  
            </table>
        </td>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <table style="width: 100%;" class="auto-style3">
            <tr>
                <td><h3 class="auto-style1">Ingrese Comentario</h3></td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="col-6 col-12-small">Comentario (*):<asp:TextBox ID="txtComentario" runat="server" Height="94px" Width="677px" TextMode="MultiLine" Wrap="False"></asp:TextBox>
                        </td>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" Height="44px" OnClick="Button1_Click" Text="Agregar" Width="151px" />
                </td>
                <td>&nbsp;</td>
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
