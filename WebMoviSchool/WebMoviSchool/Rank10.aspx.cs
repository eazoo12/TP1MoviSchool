using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using System.Data.SqlClient;
using System.Data;

namespace WebMoviSchool
{
    public partial class Rank10 : System.Web.UI.Page
    {
        negMovilidad negOMovilidad = new negMovilidad();

        protected void Page_Load(object sender, EventArgs e)
        {

            ConsultaImagen();

        }


        public void ConsultaImagen()
        {
            string cad_con = @"Server=DESKTOP-SIE6522;Database=MoviSchool; Integrated Security=True;";
            SqlConnection conexionSql = new SqlConnection(cad_con);
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "select DISTINCT TOP (10) AVG(p.puntaje) as promedio,u.apellido+ ' ' + u.nombre  as nom_ape,u.celular from TB_PUNTUACION  p inner join TB_USUARIO u on p.codUsurio=u.codUsurio group by p.codUsurio,u.celular,u.nombre,u.apellido order by 1 desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSql;
            conexionSql.Open();

            DataTable TextoComentario = new DataTable();
            TextoComentario.Load(cmd.ExecuteReader());

            Repeater1.DataSource = TextoComentario;
            Repeater1.DataBind();
            conexionSql.Close();



        }
    }
}