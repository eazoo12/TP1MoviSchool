<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Rank10.aspx.cs" Inherits="WebMoviSchool.Rank10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<td class="align-center"><h3 class="align-center">10 Primeras Movilidades</h3><br />
    
        <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <div class="auto-style3">
                 
                 <table class="auto-style3">
                     

                     <tr class="auto-style3">
                         
                         <td class="auto-style3">
                             <h3>Puntaje</h3>
                             <%# DataBinder.Eval(Container.DataItem,"promedio") %>
                             
                             
                         </td>
                         <td class="auto-style3">
                             <h3>Nombre Apellido</h3>
                             <%# DataBinder.Eval(Container.DataItem,"nom_ape") %>

                         </td>
                         <td>
                             <h3>Celular</h3>
                             <%# DataBinder.Eval(Container.DataItem,"celular") %>

                         </td>
                         
                     </tr>
                    
                     
                 </table>

             </div>


         </ItemTemplate>

    </asp:Repeater>
    
</td>


</asp:Content>
