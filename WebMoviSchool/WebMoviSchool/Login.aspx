<%@ Page Title="" Language="C#" MasterPageFile="~/PruebaMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebMoviSchool.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="legend">Login Here</h3>
							<div class="input">
								<span class="fa fa-envelope-o" aria-hidden="true"></span>
								<%--<input type="email" placeholder="Email" name="email" required />--%>
                                <asp:TextBox ID="txtUsuario" type="email" placeholder="Email" runat="server"></asp:TextBox>
							</div>
							<div class="input">
								<span class="fa fa-key" aria-hidden="true"></span>
								<%--<input type="password" placeholder="Password" name="password" required />--%>
                                <asp:TextBox ID="txtContraseña" placeholder="Password" type="password" runat="server" MaxLength="8"></asp:TextBox>
							</div>
							<%--<button type="submit" class="btn submit">Login</button>--%>
                             <asp:Button ID="Button1" CssClass="btn submit" runat="server" Text="Ingregar" OnClick="btnIngresar_Click" />
	                         <asp:Button ID="btnCancelar" CssClass="btn submit" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
										
                             <a href="RecuperarContraseña.aspx" class="bottom-text-w3ls">Forgot Password?</a>


    
</asp:Content>
