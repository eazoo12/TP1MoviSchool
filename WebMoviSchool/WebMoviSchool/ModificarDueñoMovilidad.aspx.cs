using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;
using System.Data;
using System.IO;
using System.Configuration;
using System.Drawing;

namespace WebMoviSchool
{
    public partial class ModificarMovilidad : System.Web.UI.Page
    {        
        negMovilidad negOMovilidad = new negMovilidad();
        negUsuario negUsuarios = new negUsuario();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["DNI"] != null)
                {                   
                    cargar_Cabecera();
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
        }

        public void cargar_Cabecera()
        {
            List<EntMovilidad> login = new List<EntMovilidad>();
            login = negOMovilidad.SEL_USUARIOPANEL(Session["DNI"].ToString());
            
            if (login.Count == 0)
            {

            }
            else
            {

                lblNombreApe.Text = login[0].NombreAp;
                txtCelular.Text = login[0].Celular;
                txtCorreo.Text = login[0].CorreoElec;
                txtDireccion.Text = login[0].Direccion;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {          
            string codigo1 = Session["DNI"].ToString();
            int codigo = Int32.Parse(codigo1);
            
            string celular = txtCelular.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;

            negUsuarios.UPD_MOVILIDAD(codigo, celular, correo, direccion);

            Response.Write("<script>alert('Se guardaron los cambios')</script>");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexMovilidad.aspx");
        }
    }
}