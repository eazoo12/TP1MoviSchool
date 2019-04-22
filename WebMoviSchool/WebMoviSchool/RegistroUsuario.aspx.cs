using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;
using System.Data;
//using System.Windows.Forms;

namespace WebMoviSchool
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        negUsuario oNegUsuario = new negUsuario();
        negMovilidad oNegMovilidad = new negMovilidad();
        EntUsuario usuar = new EntUsuario();
        int encontro;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((string)Session["ID_TIPOUSU"]) == "4")
            {
                Response.Redirect("IndexPadre.aspx");
            }


            if (!IsPostBack)
            {

                DataTable dt = oNegUsuario.SEL_TIPODOC();
                cboTipDoc.DataSource = dt;
                cboTipDoc.DataValueField = "id";
                cboTipDoc.DataTextField = "nom";
                cboTipDoc.DataBind();
                cboTipDoc.Items.Insert(0, new ListItem("--Seleccione un Tipo Doc--", "0"));

            }

            if (!IsPostBack)
            {

                DataTable dt1 = oNegUsuario.SEL_PAIS();
                cboPais.DataSource = dt1;
                cboPais.DataValueField = "id";
                cboPais.DataTextField = "nom";
                cboPais.DataBind();
                cboPais.Items.Insert(0, new ListItem("--Seleccione un Pais--", "0"));

            }

            if (!IsPostBack)
            {

                DataTable dt2 = oNegUsuario.SEL_TIPOUSUARIO();
                cboTipoUsuario.DataSource = dt2;
                cboTipoUsuario.DataValueField = "id";
                cboTipoUsuario.DataTextField = "nom";
                cboTipoUsuario.DataBind();
                cboTipoUsuario.Items.Insert(0, new ListItem("--Seleccione un Tipo de Documento--", "0"));

            }

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(lblNroVa.Text == "OK" && lblCorreo.Text == "OK")
            {
                          
                if (cboDistrito.SelectedValue != "" && txtNombre.Text != "" && txtNro.Text !="" && txtCorreoElec.Text != "" && txtPass.Text !="" && txtRepass.Text != ""
                    && txtRepass.Text == txtPass.Text)
                { 
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
                    //MessageBox.Show("Registro exitoso");
                Response.Write("<script>alert('Registro exitoso !!!!')</script>");

               // Response.Redirect("RegistroUsuario.aspx");

                Response.Write("<script>alert('Registro exitoso !!!!')</script>");

                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                    txtNrocelular.Text = string.Empty;
                    txtCorreoElec.Text = string.Empty;
                    txtNro.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtPass.Text = string.Empty;
                    txtRepass.Text = string.Empty;

                }
                else
                {
                    //MessageBox.Show("Complete todos los campos");
                    Response.Write("<script>alert('Complete todos los campos !!!!')</script>");
                }
            }

        }

        //protected void lnkpickdate_Click(object sender, EventArgs e)
        //{
        //    datepicker.Visible = true;
        //}

        //protected void datepicker_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtdtp.Text = datepicker.SelectedDate.ToShortDateString();
        //    datepicker.Visible = false;
        //}

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codDepa = Convert.ToInt16(cboDepartamento.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DISTRITO(codDepa);
            cboDistrito.DataSource = dt;
            cboDistrito.DataValueField = "id";
            cboDistrito.DataTextField = "nom";
            cboDistrito.DataBind();
            cboDistrito.Items.Insert(0, new ListItem("--Seleccione un Distrito--", "0"));
        }

        protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codPais = Convert.ToInt16(cboPais.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DEPARTAMENTO(codPais);
            cboDepartamento.DataSource = dt;
            cboDepartamento.DataValueField = "id";
            cboDepartamento.DataTextField = "nom";
            cboDepartamento.DataBind();
            cboDepartamento.Items.Insert(0, new ListItem("--Seleccione un Departamento--", "0"));

        }

        public void ValidacionNro_CoreUni()
        {
            
                List<EntUsuario> login = new List<EntUsuario>();

                 

                login = oNegMovilidad.SEL_NRO_CORREO(txtNro.Text, txtCorreoElec.Text);
                if(login.Count == 0)
                {
                    encontro = 0;
                }
                

                if ((login.Count == 0 ||  txtNro.Text != login[0].NroDocumento))
                {
                            if ((login.Count == 0 && encontro == 0) || ((login.Count == 1 && encontro == 0)))
                            {
                                lblNroVa.Text = "OK";
                            }
                             
                            
                       
                }
                if ((login.Count == 0 || txtCorreoElec.Text != login[0].CorreoElec))
                {
                            if ((login.Count == 0 && encontro == 0) || ((login.Count == 1 && encontro == 0)))
                            {
                                lblCorreo.Text = "OK";
                            }

                
                }
                if (login.Count == 1)
                {

                    if (txtNro.Text != "" && txtNro.Text == login[0].NroDocumento)
                    {
                        usuar.NroDocumento = login[0].NroDocumento;
                        
                        lblNroVa.Text = "El Nro " + usuar.NroDocumento + " Ya existe";
                    }
                    if (txtCorreoElec.Text != "" && txtCorreoElec.Text == login[0].CorreoElec)
                    {
                         usuar.CorreoElec = login[0].CorreoElec;
                         lblCorreo.Text= "El correo " + usuar.CorreoElec + " Ya existe";
                     }

                }

                
           

            
        }

        protected void txtNro_TextChanged(object sender, EventArgs e)
        {

            ValidacionNro_CoreUni();



        }

        protected void txtCorreoElec_TextChanged(object sender, EventArgs e)
        {
            ValidacionNro_CoreUni();
            txtUsuario.Text = txtCorreoElec.Text.Trim();
        }

        protected void cboTipDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(cboTipDoc.SelectedValue) == 2)
            {
                txtNro.MaxLength =8;
            }else if (Convert.ToInt16(cboTipDoc.SelectedValue) == 3)
            {
                txtNro.MaxLength = 12;
            }

        }

        protected void cboTipDoc_TextChanged(object sender, EventArgs e)
        {
            txtNro.Text = "";
        }
    }
}