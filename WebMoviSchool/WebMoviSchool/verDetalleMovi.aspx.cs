using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
       
        string soatCade,ReveTecCade, fotoAutoCade;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ID_TIPOUSU"] != null)
            {
                btnComentar.Visible = true;
                btnVeComentario.Visible = false;
                //Response.Redirect("IndexPadre.aspx");
            }
            else if(Session["ID_TIPOUSU"] == null)
            {
                btnComentar.Visible = false;
                btnVeComentario.Visible = true;
                //Response.Redirect("index.aspx");
            }


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

                    dgvDeRegistroChofe.DataSource = negOMovilidad.SEL_MOVI_DETA(Session["COD_USUARIO_DE"].ToString(), Session["ID_DISTRITO_DETA"].ToString(), Session["ID_COLEGIO_DETA"].ToString());
                    dgvDeRegistroChofe.DataBind();

                    
                }




            }
            else
            {
                Response.Write("Seleccione una Movilidad y Ingrese a Consultar Movilidad");
            }

            

            

        }

        protected void btnVeComentario_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComentariosGeneral.aspx");
        }

        protected void btnComentar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComentariosGeneral.aspx");
        }

        public void ConsultaImagen(string cod)
        {
             string cad_con = @"Server=DESKTOP-SIE6522;Database=MoviSchool; Integrated Security=True;";
             SqlConnection conexionSql = new SqlConnection(cad_con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select idMovilidad," +
                "Soat,revTecnica,fotoCarro" +
                " from TB_MOVILIDAD where idMovilidad="+ cod;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSql;
            conexionSql.Open();

            DataTable ImagenesBD = new DataTable();
            ImagenesBD.Load(cmd.ExecuteReader());

            Repeater1.DataSource = ImagenesBD;
            Repeater1.DataBind();
            conexionSql.Close();



        }

        protected void dgvDeRegistroChofe_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "VerPape")
            {
                List<EntMoviDetalleUsu> DetMoviIma = new List<EntMoviDetalleUsu>();

                int index = Convert.ToInt32(e.CommandArgument);
                string codUsuario = dgvDeRegistroChofe.Rows[index].Cells[0].Text;

                DetMoviIma = negOMovilidad.SEL_IMAGEN_DETA(codUsuario);

                //Bitmap ImagenOriginalBinaria = new Bitmap();


                if(DetMoviIma[0].Soat != "0")
                {
                     
                    if (DetMoviIma.Count == 0)
                    {

                    }
                    else
                    {
                        soatCade = Convert.ToString(DetMoviIma[0].Soat);
                        ReveTecCade = Convert.ToString(DetMoviIma[0].RevTecnica);
                        fotoAutoCade = Convert.ToString(DetMoviIma[0].ImagenCarro);

                        ConsultaImagen(codUsuario);




                    }


                }
                else
                {
                    ///MessageBox.Show("Ingrese un usuario y password");
                    Response.Write("<script>alert('Ingrese un usuario y password !!!!')</script>");
                }





            }
        }

    }
}