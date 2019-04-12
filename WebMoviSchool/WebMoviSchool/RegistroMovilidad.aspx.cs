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
    public partial class RegistroMovilidad : System.Web.UI.Page
    {
        negMovilidad negOMovilidad = new negMovilidad();
        EntMovilidad usuar = new EntMovilidad();
        //String dniCOd;
        public void cargar_Cabecera()
        {
            
                List<EntMovilidad> login = new List<EntMovilidad>();

                //usuar.NombreAp = lblNombreApe.Text;
                //usuar.Celular = Celular.Text;
                //usuar.CorreoElec = lblCorreo.Text;
                
                login = negOMovilidad.SEL_USUARIOPANEL(Session["DNI"].ToString());

                if (login.Count == 0)
                {
                   // tipPersona = "0";
                }
                else
                {
                    //tipPersona = Convert.ToString(login[0].TipoUsuario);
                //usuar.NombreAp = lblNombreApe.Text;
                //usuar.Celular = Celular.Text;
                //usuar.CorreoElec = lblCorreo.Text;
                 lblNombreApe.Text= login[0].NombreAp ;
                 Celular.Text= login[0].Celular ;
                 lblCorreo.Text= login[0].CorreoElec;
                }
            //Session["ID_TIPOUSU"] = tipPersona;
            //    if (tipPersona == "4")
            //    {

            //        Response.Redirect("IndexPadre.aspx", false);
            //    }
            //    else if (tipPersona == "5")
            //    {
            //        Response.Redirect("IndexMovilidad.aspx", false);
            //    }

    }

        protected void Page_Load(object sender, EventArgs e)
        {
            //dniCOd = "47266222";
            if (Session["DNI"] != null)
            {
                cargar_Cabecera();
            }else
            {
               // Response.Write("<script>window.alert('Debes ingresar tu usuario antes')");
            }
            
        }
    }
}