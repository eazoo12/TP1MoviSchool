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


        public DataTable SEL_COLEGIO(int iddistrito)
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_COLEGIO", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@iddistrito", SqlDbType.Int).Value = iddistrito;

                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        var dt = new DataTable();
                        da.Fill(dt);
                        conex.Close();
                        return dt;
                    }
                }
            }
        }


        public void INS_MOVILIDAD(EntMovilidadRegistro oEntUsuario, int opc)
        {
            try
            {
                using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
                {

                    using (SqlCommand cmd = new SqlCommand("INS_MOVILIDAD", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@nombreChofer", SqlDbType.VarChar, 100).Value = oEntUsuario.NombreChofer;
                        cmd.Parameters.Add("@idtipodocumento", SqlDbType.Int).Value = oEntUsuario.Idtipodocumento;
                        cmd.Parameters.Add("@nroDocumento", SqlDbType.VarChar, 20).Value = oEntUsuario.NroDocumento;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar,15).Value = oEntUsuario.Telefono;
                        cmd.Parameters.Add("@iddistrito", SqlDbType.Int).Value = oEntUsuario.Iddistrito;
                        cmd.Parameters.Add("@Soat", SqlDbType.VarBinary).Value = oEntUsuario.Soat;
                        cmd.Parameters.Add("@placa", SqlDbType.VarChar, 10).Value = oEntUsuario.Placa;
                        cmd.Parameters.Add("@revTecnica", SqlDbType.VarBinary).Value = oEntUsuario.RevTecnica;
                        cmd.Parameters.Add("@marca", SqlDbType.VarChar, 100).Value = oEntUsuario.Marca;
                        cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 100).Value = oEntUsuario.Modelo;

                        cmd.Parameters.Add("@color", SqlDbType.VarChar, 100).Value = oEntUsuario.Color;
                        cmd.Parameters.Add("@capacidad", SqlDbType.Int).Value = oEntUsuario.Capacidad;
                        cmd.Parameters.Add("@fotoCarro", SqlDbType.VarBinary).Value = oEntUsuario.FotoCarro;
                        cmd.Parameters.Add("@papelRegla", SqlDbType.Int).Value = oEntUsuario.PapelRegla;
                        cmd.Parameters.Add("@dni", SqlDbType.VarChar,20).Value = oEntUsuario.Dni;


                        cmd.Parameters.Add("@opc", SqlDbType.Int).Value = opc;


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        conex.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }





    }
}
