using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using Capa_Negocio;

namespace WebMoviSchool
{
    public partial class RegistrarPromociones : System.Web.UI.Page
    {

        negMovilidad obNegociMovilida = new negMovilidad();
        string promociones;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((string)Session["ID_TIPOUSU"]) == "5")
            {
                promociones = obNegociMovilida.SEL_PROMOCIONES_COD(Session["DNI"].ToString());

                if(promociones == "0")
                {
                    lblPromociones.Visible = true;
                    lblPromociones.Text = promociones;
                }
                else
                {
                    lblPromociones.Visible = false;
                }
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            if (((string)Session["ID_TIPOUSU"]) == "5" && promociones != "0")
            {
                obNegociMovilida.INS_PROMOCION(txtPromocio.Text, Session["DNI"].ToString(), 1);

                txtPromocio.Text = "";

                
            }
            



        }
    }
}