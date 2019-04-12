using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Capa_Entidad;

namespace Capa_Datos
{
    public class datMovilidad
    {

        public List<EntMovilidad> SEL_USUARIOPANEL(string dni)
        {

            List<EntMovilidad> oListR = new List<EntMovilidad>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_USUARIOPANEL", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
                   


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colnombreAp = dr.GetOrdinal("nombreAp");
                        int colcelular = dr.GetOrdinal("celular");
                        int colcorreoElec = dr.GetOrdinal("correoElec");
                        //int colCodArea = dr.GetOrdinal("codArea");


                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntMovilidad oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntMovilidad();
                            dr.GetValues(values);

                            oEntUsu.NombreAp = Convert.ToString(values[colnombreAp]);
                            oEntUsu.Celular = Convert.ToString(values[colcelular]);
                            oEntUsu.CorreoElec = Convert.ToString(values[colcorreoElec]);
                            /// oEntUsu.CodArea = Convert.ToInt32(values[colCodArea]);


                            oListR.Add(oEntUsu);
                        }
                    }
                }
            }
            return oListR;

        }


    }
}
