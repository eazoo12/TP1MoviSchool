<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ConsultaMovilidad.aspx.cs" Inherits="WebMoviSchool.ConsultaMovilidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="222px"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="dgvMovilidaUsu" runat="server" CellPadding="4" class="auto-style3" AutoGenerateColumns="False" Width="893px" ForeColor="#333333" GridLines="None" OnRowCommand="dgvMovilidaUsu_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="CodUsurio" HeaderText="Cod. Usuario" >
                        <ControlStyle Font-Names="Arial Black" ForeColor="#003300" />
                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Nom_ape" HeaderText="Nombre Completo" >
                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Celular" HeaderText="Celular" >
                        <FooterStyle ForeColor="White" />
                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CorreoElec" HeaderText="Mail" >
                        <FooterStyle ForeColor="White" />
                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Cantidad Choferes" DataField="Cantida_choferes" >
                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Image" CommandName="Ver" HeaderText="Ver" ImageUrl="~/images/iconfinder_1-03_511564.png">
                        <HeaderStyle ForeColor="White" />
                        </asp:ButtonField>
                    </Columns>
                    <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle ForeColor="#333333" BackColor="#FFFBD6" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
