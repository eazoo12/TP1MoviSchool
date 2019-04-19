using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;

namespace WebMoviSchool
{
    public partial class ConsultaMovilidad : System.Web.UI.Page
    {
        negMovilidad negOmovilidad = new negMovilidad();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dgvMovilidaUsu.DataSource = negOmovilidad.SEL_MOVILIDAD_USUARIO(txtNombre.Text);
            dgvMovilidaUsu.DataBind();
        }

        protected void dgvMovilidaUsu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Ver")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string codUsuario = dgvMovilidaUsu.Rows[index].Cells[0].Text;

               
                    Session["COD_USUARIO_DE"] = codUsuario;
              
                

                Response.Redirect("verDetalleMovi.aspx");
            }
        }
    }
}