using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;
using System.Data;

namespace WebMoviSchool
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        negUsuario oNegUsuario = new negUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                DataTable dt = oNegUsuario.SEL_TIPODOC();
                cboTipDoc.DataSource = dt;
                cboTipDoc.DataValueField = "id";
                cboTipDoc.DataTextField = "nom";
                cboTipDoc.DataBind();

            }

            if (!IsPostBack)
            {

                DataTable dt1 = oNegUsuario.SEL_PAIS();
                cboPais.DataSource = dt1;
                cboPais.DataValueField = "id";
                cboPais.DataTextField = "nom";
                cboPais.DataBind();

            }

            if (!IsPostBack)
            {

                DataTable dt2 = oNegUsuario.SEL_TIPOUSUARIO();
                cboTipoUsuario.DataSource = dt2;
                cboTipoUsuario.DataValueField = "id";
                cboTipoUsuario.DataTextField = "nom";
                cboTipoUsuario.DataBind();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (cboDistrito.SelectedValue != "" && txtNombre.Text != "" && txtNro.Text !="" && txtCorreoElec.Text != "" && txtPass.Text !="" && txtRepass.Text != "") { 
            EntUsuario oEntUsuario = new EntUsuario();

            oEntUsuario.Nombre = txtNombre.Text;
            oEntUsuario.Apellido = txtApellido.Text;
            oEntUsuario.Celular = txtNrocelular.Text;
            oEntUsuario.TipoDocumento = Convert.ToInt16(cboTipDoc.SelectedValue);
            oEntUsuario.NroDocumento = txtNro.Text;
            oEntUsuario.Direccion = txtDireccion.Text;
            oEntUsuario.CorreoElec = txtCorreoElec.Text;
            oEntUsuario.FehaNacimi = Convert.ToDateTime(txtdtp.Text);
            oEntUsuario.Genero = cboGenero.Text;
            oEntUsuario.Iddistrito = Convert.ToInt16(cboDistrito.SelectedValue);
           
            oEntUsuario.Usuario = txtUsuario.Text;
            oEntUsuario.Password = txtPass.Text;
            oEntUsuario.TipoUsuario = Convert.ToInt16(cboTipoUsuario.SelectedValue);


            oNegUsuario.INS_USUARIO(oEntUsuario, 1);
            }

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

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codDepa = Convert.ToInt16(cboDepartamento.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DISTRITO(codDepa);
            cboDistrito.DataSource = dt;
            cboDistrito.DataValueField = "id";
            cboDistrito.DataTextField = "nom";
            cboDistrito.DataBind();
        }

        protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codPais = Convert.ToInt16(cboPais.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DEPARTAMENTO(codPais);
            cboDepartamento.DataSource = dt;
            cboDepartamento.DataValueField = "id";
            cboDepartamento.DataTextField = "nom";
            cboDepartamento.DataBind();
        }
    }
}