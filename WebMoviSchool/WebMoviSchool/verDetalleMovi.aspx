<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="verDetalleMovi.aspx.cs" Inherits="WebMoviSchool.verDetalleMovi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        

    <p>
        <table style="width:100%;">
            <tr>
                <td class="align-center"><h3>Registro de Movilidad</h3><br />
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
                        <td  class="auto-style3">

                            

                            <asp:Label ID="Label1" runat="server" Text="Para comentar Ingresa o Registrate al Sistema"></asp:Label>
                            <asp:Button ID="btnVeComentario" runat="server" Text="Ver Comentario" OnClick="btnVeComentario_Click" />

                            

                            <asp:Button ID="btnComentar" runat="server" Text="Comentar" Visible="False" OnClick="btnComentar_Click" />

                            

                        </td>
                        
                    </tr>
                    <tr>
                        <td> 
                            <asp:Panel ID="panelPun" runat="server" Visible="False">
                                 <p class="clasificacion" typeof="radio">
                                    <asp:RadioButtonList ID="rdbComentario" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="5" Selected="True">5 ★</asp:ListItem>
                                        <asp:ListItem Value="4">4 ★</asp:ListItem>
                                        <asp:ListItem Value="3">3 ★</asp:ListItem>
                                        <asp:ListItem Value="2">2 ★</asp:ListItem>
                                        <asp:ListItem Value="1">1 ★</asp:ListItem>
                                    </asp:RadioButtonList>

                                  
                                     <asp:Button ID="btnVotar" runat="server" Text="Votación" OnClick="btnVotar_Click" Width="172px" />

                                  
                                    </p>

                            </asp:Panel>
                               

                                
                                    
                                <%--<input id="radio1" type="radio" name="estrellas" value="5" ><!--
                                --><label for="radio1">★</label><!--
                                --><input id="radio2" type="radio" name="estrellas" value="4"><!--
                                --><label for="radio2">★</label><!--
                                --><input id="radio3" type="radio" name="estrellas" value="3"><!--
                                --><label for="radio3">★</label><!--
                                --><input id="radio4" type="radio" name="estrellas" value="2"><!--
                                --><label for="radio4">★</label><!--
                                --><input id="radio5" type="radio" name="estrellas" value="1"><!--
                                --><label for="radio5">★</label>--%>
                              

                        </td>
                        <td><h3> <asp:Label ID="lblVolorasCom" runat="server" Text="0">Si Desea Votar Inicie Sesión</asp:Label>  </h3>
                            <h3>Valoracion de la Movilidad <asp:Label ID="lblPuntos" runat="server" Text="0"></asp:Label>

                             </h3></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Promociones : "></asp:Label>
                            <asp:Label ID="lblPromociones" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>

                                      
                    </table>
        
                                      
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style3">
                                <h3>Registro de Choferes</h3>
                                <asp:GridView ID="dgvDeRegistroChofe" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="dgvDeRegistroChofe_RowCommand">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="IdMovilidad" HeaderText="Cod. Movilida">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="NombreChofer" HeaderText="Nombre Chofer">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="NroDocumento" HeaderText="Nro. Documento">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Placa" HeaderText="Placa">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Capacidad" HeaderText="Capacidad">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="DesColegio" HeaderText="Colegio">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="DesDistrito" HeaderText="Distrito">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Soat" HeaderText="soat" Visible="False">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="RevTecnica" HeaderText="RevTec" Visible="False" />
                                        <asp:BoundField DataField="ImagenCarro" HeaderText="ImCarro" Visible="False" />
                                        <asp:ButtonField ButtonType="Image" HeaderText="Ver Papeles" CommandName="VerPape" ImageUrl="~/images/iconfinder_photos-r_86352 (1).png">
                                        <HeaderStyle ForeColor="White" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                    <SortedDescendingHeaderStyle BackColor="#820000" />
                                </asp:GridView>
                                <table style="width:100%;">
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>

                                                    <div class="auto-style3">
                                                        <h3>SOAT</h3>
                                                        <img class="image-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((Byte[])DataBinder.Eval(Container.DataItem,"Soat")) %>" /><br />
                                                        <h3>REVISION TENICA</h3>
                                                        <img class="image-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((Byte[])DataBinder.Eval(Container.DataItem,"revTecnica")) %>" /><br />
                                                        <h3>FOTO DEL CARRO</h3>
                                                        <img class="image-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((Byte[])DataBinder.Eval(Container.DataItem,"fotoCarro")) %>" />
         
                                                        <br />
                                                    </div>

                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </td>
                                        
                                    </tr>
                                    
                                </table>

                                <tr>
                            <td>
                                <div id="fb-root"></div>
                                <script async defer crossorigin="anonymous" src="https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v3.2"></script>
                                <div class="fb-comments" data-href="http://190.233.254.125:8080/verDetalleMovi.aspx" data-numposts="5" data-include-parent="true"></div>

                            </td>
                        </tr>
                            </td>
                            
                        </tr>
                        
                    </table>
        
                                      
                </td>
                
            </tr>
        </table>
    </p>

</asp:Content>
