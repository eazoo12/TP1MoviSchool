<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ConsultaMovilidad.aspx.cs" Inherits="WebMoviSchool.ConsultaMovilidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="222px"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="dgvMovilidaUsu" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" class="auto-style3" AutoGenerateColumns="False" Width="885px">
                    <Columns>
                        <asp:BoundField DataField="CodUsurio" HeaderText="Cod. Usuario" >
                        <ControlStyle Font-Names="Arial Black" ForeColor="#003300" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Nom_ape" HeaderText="Nombre Completo" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="CorreoElec" HeaderText="Mail" />
                        <asp:BoundField HeaderText="Cantidad Choferes" DataField="Cantida_choferes" />
                        <asp:ImageField HeaderText="Ver">
                        </asp:ImageField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
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
