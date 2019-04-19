<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="WebMoviSchool.RecuperarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Si deseas restablecer tu contraseña, ingresa la dirección de correo registrada.<asp:TextBox ID="txtCorreo" runat="server" Width="338px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar correo" OnClick="btnEnviar_Click" />
        <br />
    </p>
</asp:Content>
