using System;
using System.Collections.Generic;
using System.Data;
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
        negUsuario oNegUsuario = new negUsuario();
        string distritoid;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

                DataTable dt1 = oNegUsuario.SEL_PAIS();
                cboPais.DataSource = dt1;
                cboPais.DataValueField = "id";
                cboPais.DataTextField = "nom";
                cboPais.DataBind();
                cboPais.Items.Insert(0, new ListItem("--Ingrese un Pais--", "0"));

            }

            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "" && cboDistrito.Text == "" && txtColegio.Text== "") || (txtNombre.Text == "" && cboDistrito.SelectedValue == "0" && txtColegio.Text == "") ||
                (txtNombre.Text != "" && cboDistrito.SelectedValue == "0" && txtColegio.Text == "") )
            {
                Session["ID_DISTRITO_DETA"] = 0;
                Session["ID_COLEGIO_DETA"] = "";

                dgvMovilidaUsu.DataSource = negOmovilidad.SEL_MOVILIDAD_USUARIO(txtNombre.Text,0,"",1);
                dgvMovilidaUsu.DataBind();
            }
            else if ((txtNombre.Text != "" && cboDistrito.SelectedValue != "0" && txtColegio.Text != "") || (txtNombre.Text == "" && cboDistrito.SelectedValue != "0" && txtColegio.Text != "") 
               || (txtNombre.Text != "" && cboDistrito.SelectedValue != "0" && txtColegio.Text == "") || (txtNombre.Text == "" && cboDistrito.SelectedValue == "0" && txtColegio.Text != "") ||
               (txtNombre.Text == "" && cboDistrito.SelectedValue != "0" && txtColegio.Text == ""))
            {
                if (cboDistrito.SelectedValue == "0" || cboDistrito.Text == "")
                {
                    distritoid = "0";
                }
                else
                {
                    distritoid = cboDistrito.SelectedValue;
                }
                Session["ID_DISTRITO_DETA"] = distritoid;
                Session["ID_COLEGIO_DETA"] = txtColegio.Text;

                dgvMovilidaUsu.DataSource = negOmovilidad.SEL_MOVILIDAD_USUARIO(txtNombre.Text, Convert.ToInt32(distritoid),txtColegio.Text, 2);
                dgvMovilidaUsu.DataBind();
            }

            
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

        protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codPais = Convert.ToInt16(cboPais.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DEPARTAMENTO(codPais);
            cboDepartamento.DataSource = dt;
            cboDepartamento.DataValueField = "id";
            cboDepartamento.DataTextField = "nom";
            cboDepartamento.DataBind();
            cboDepartamento.Items.Insert(0, new ListItem("--Ingrese un Departamento--", "0"));

        }

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codDepa = Convert.ToInt16(cboDepartamento.SelectedValue);
            DataTable dt = oNegUsuario.SEL_DISTRITO(codDepa);
            cboDistrito.DataSource = dt;
            cboDistrito.DataValueField = "id";
            cboDistrito.DataTextField = "nom";
            cboDistrito.DataBind();
            cboDistrito.Items.Insert(0, new ListItem("--Ingrese un Distrito--", "0"));
        }


    }
}