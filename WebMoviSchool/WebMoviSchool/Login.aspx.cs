﻿using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMoviSchool
{
    public partial class Login : System.Web.UI.Page
    {
        String tipPersona;
        String dniP;
        negUsuario oNegUsuario = new negUsuario();
        EntUsuario usuar = new EntUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((string)Session["ID_TIPOUSU"]) == "4")
            {
                Response.Redirect("IndexPadre.aspx");
            }
            else if (((string)Session["ID_TIPOUSU"]) == "5")
            {
                Response.Redirect("IndexMovilidad.aspx");
            }
            else
            {

            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                List<EntUsuario> login = new List<EntUsuario>();

                usuar.Usuario = txtUsuario.Text;
                usuar.Password = txtContraseña.Text;

                login = oNegUsuario.login(usuar.Usuario, usuar.Password);

                if (login.Count == 0)
                {
                    tipPersona = "0";
                    dniP = "0";

                    ///
                    Response.Write("<script>alert('Usuarios y Clave incorrecto !!!!')</script>");
                }
                else
                {
                    tipPersona = Convert.ToString(login[0].TipoUsuario);
                    dniP = Convert.ToString(login[0].NroDocumento);


                }
                Session["ID_TIPOUSU"] = tipPersona;
                Session["DNI"] = dniP;
                if (tipPersona == "4")
                {

                    Response.Redirect("IndexPadre.aspx", false);
                }
                else if (tipPersona == "5")
                {
                    Response.Redirect("IndexMovilidad.aspx", false);
                }

            }
            else
            {
                ///MessageBox.Show("Ingrese un usuario y password");
                Response.Write("<script>alert('Ingrese un usuario y password !!!!')</script>");
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            
        }
    }
}