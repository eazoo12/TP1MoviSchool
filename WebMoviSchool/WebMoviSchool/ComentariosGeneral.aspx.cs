using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMoviSchool
{
    public partial class ComentariosGeneral : System.Web.UI.Page
    {
        negMovilidad negOMovilidad = new negMovilidad();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["COD_USUARIO_DE"] != null)
            {
                ConsultaImagen(Session["COD_USUARIO_DE"].ToString());

                List<EntMovilidad> login = new List<EntMovilidad>();

                login = negOMovilidad.SEL_USUARIOPANEL_CONSUL(Session["COD_USUARIO_DE"].ToString());

                if (login.Count == 0)
                {
                    // tipPersona = "0";

                }
                else
                {
                   
                    lblNombreApe.Text = login[0].NombreAp;
                    Celular.Text = login[0].Celular;
                    lblCorreo.Text = login[0].CorreoElec;
   
                }
                



            }
            else
            {
                Response.Write("Consulte la Movilidad Antes");
            }

            if (((string)Session["ID_TIPOUSU"]) == "4")
            {
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
            }
                
        }

        public void ConsultaImagen(string cod)
        {
            string cad_con = @"Server=DESKTOP-SIE6522;Database=MoviSchool; Integrated Security=True;";
            SqlConnection conexionSql = new SqlConnection(cad_con);
            SqlCommand cmd = new SqlCommand();

            
            cmd.CommandText = "select c.idComentario,c.desComentario , up.nombre+' '+up.apellido as NombrePadre from TB_COMENTARIO c inner join TB_USUARIO  up on c.codPadre = up.codUsurio  where c.codUsurio=" + cod + " order by (1) desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSql;
            conexionSql.Open();

            DataTable TextoComentario = new DataTable();
            TextoComentario.Load(cmd.ExecuteReader());

            Repeater1.DataSource = TextoComentario;
            Repeater1.DataBind();
            conexionSql.Close();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntComentarioRegistro entoComentario = new EntComentarioRegistro();

            if(txtComentario.Text != "")
            {
                entoComentario.DesComentario = txtComentario.Text;
                entoComentario.CodUsurio = Convert.ToInt32(Session["COD_USUARIO_DE"].ToString());
                entoComentario.NroDocumento = Session["DNI"].ToString();

                negOMovilidad.INS_COMENTARIO(entoComentario,1);

                Response.Write("Comentario Ingresado");

                Response.Redirect("ComentariosGeneral.aspx");

            }
            else
            {
                Response.Write("Ingresa el comentario");
            }
        }
    }
}