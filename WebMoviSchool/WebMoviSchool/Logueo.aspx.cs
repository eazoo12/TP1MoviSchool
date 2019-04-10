using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;

namespace WebMoviSchool
{
    public partial class Logueo : System.Web.UI.Page
    {
        String tipPersona;
        negUsuario oNegUsuario = new negUsuario();
        EntUsuario usuar = new EntUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((string)Session["ID_TIPOUSU"]) == "4")
            {
                Response.Redirect("IndexPadre.aspx");
            }  else if (((string)Session["ID_TIPOUSU"]) == "5")
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
                }
                else
                {
                    tipPersona = Convert.ToString(login[0].TipoUsuario);
                }
                Session["ID_TIPOUSU"] = tipPersona;
                if (tipPersona== "4")
                {
                   
                    Response.Redirect("IndexPadre.aspx", false);
                }
                else if(tipPersona == "5")
                {
                    Response.Redirect("IndexMovilidad.aspx", false);
                }
                
            }

        }

        protected void btnOlvido_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarContraseña.aspx");
        }
    }
}