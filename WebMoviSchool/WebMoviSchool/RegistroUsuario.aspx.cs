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
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        negUsuario oNegUsuario = new negUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntUsuario oEntUsuario = new EntUsuario();

            oEntUsuario.Nombre = txtNombre.Text;
            oEntUsuario.Apellido = txtApellido.Text;
            oEntUsuario.Celular = txtNrocelular.Text;
            //oEntUsuario.TipoDocumento = Convert.ToInt16(cboTipDoc.Text) ;
            oEntUsuario.NroDocumento = txtNro.Text;
            oEntUsuario.Direccion = txtDireccion.Text;
            oEntUsuario.CorreoElec = txtCorreoElec.Text;
            oEntUsuario.FehaNacimi = Convert.ToDateTime(txtdtp.Text);
            oEntUsuario.Genero = cboGenero.Text;
            //oEntUsuario.Pais = Convert.ToInt16(cboPais.Text);
            //oEntUsuario.Departamento = Convert.ToInt16(cboDepartamento.Text);
            //oEntUsuario.Distrito = Convert.ToInt16(cboDistrito.Text);
            oEntUsuario.Usuario = txtUsuario.Text;
            oEntUsuario.Password = txtPass.Text;
            //oEntUsuario.TipoUsuario = Convert.ToInt16(cboTipoUsuario.Text);


            oNegUsuario.INS_USUARIO(oEntUsuario, 1);


        }

        protected void lnkpickdate_Click(object sender, EventArgs e)
        {
            datepicker.Visible = true;
        }

        protected void datepicker_SelectionChanged(object sender, EventArgs e)
        {
            txtdtp.Text = datepicker.SelectedDate.ToShortDateString();
            datepicker.Visible = false;
        }
    }
}