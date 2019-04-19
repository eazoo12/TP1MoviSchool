using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMoviSchool
{
    public partial class verDetalleMovi : System.Web.UI.Page
    {
        negMovilidad negOMovilidad = new negMovilidad();
        negUsuario negUsuarios = new negUsuario();
        EntMovilidad usuar = new EntMovilidad();

        protected void Page_Load(object sender, EventArgs e)
        {

            List<EntMovilidad> login = new List<EntMovilidad>();

            if (Session["COD_USUARIO_DE"] != null)
            {
                login = negOMovilidad.SEL_USUARIOPANEL_CONSUL(Session["COD_USUARIO_DE"].ToString());

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
                    lblNombreApe.Text = login[0].NombreAp;
                    Celular.Text = login[0].Celular;
                    lblCorreo.Text = login[0].CorreoElec;

                    dgvDeRegistroChofe.DataSource = negOMovilidad.SEL_MOVI_DETA(Session["COD_USUARIO_DE"].ToString());
                    dgvDeRegistroChofe.DataBind();

                    
                }




            }
            else
            {
                Response.Write("Seleccione una Movilidad y Ingrese a Consultar Movilidad");
            }

            

            

        }
    }
}