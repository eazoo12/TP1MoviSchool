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
                        cmd.Parameters.Add("@idColegio", SqlDbType.Int).Value = oEntUsuario.idColegio;
                        cmd.Parameters.Add("@Soat", SqlDbType.Image).Value = oEntUsuario.Soat;
                        cmd.Parameters.Add("@placa", SqlDbType.VarChar, 10).Value = oEntUsuario.Placa;
                        cmd.Parameters.Add("@revTecnica", SqlDbType.Image).Value = oEntUsuario.RevTecnica;
                        cmd.Parameters.Add("@marca", SqlDbType.VarChar, 100).Value = oEntUsuario.Marca;
                        cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 100).Value = oEntUsuario.Modelo;

                        cmd.Parameters.Add("@color", SqlDbType.VarChar, 100).Value = oEntUsuario.Color;
                        cmd.Parameters.Add("@capacidad", SqlDbType.Int).Value = oEntUsuario.Capacidad;
                        cmd.Parameters.Add("@fotoCarro", SqlDbType.Image).Value = oEntUsuario.FotoCarro;
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



        public List<EntBMovilidadUs> SEL_MOVILIDAD_USUARIO(string bus)
        {

            List<EntBMovilidadUs> oListR = new List<EntBMovilidadUs>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_MOVILIDAD_USUARIO", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = bus;



                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colcodUsurio = dr.GetOrdinal("codUsurio");
                        int colnom_ape = dr.GetOrdinal("nom_ape");
                        int colcelular = dr.GetOrdinal("celular");
                        int colcorreoElec = dr.GetOrdinal("correoElec");
                        int colcantida_choferes = dr.GetOrdinal("cantida_choferes");
                        //int colCodArea = dr.GetOrdinal("codArea");


                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntBMovilidadUs oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntBMovilidadUs();
                            dr.GetValues(values);

                            oEntUsu.CodUsurio = Convert.ToInt32(values[colcodUsurio]);
                            oEntUsu.Nom_ape = Convert.ToString(values[colnom_ape]);
                            oEntUsu.Celular = Convert.ToString(values[colcelular]);
                            oEntUsu.CorreoElec = Convert.ToString(values[colcorreoElec]);
                            oEntUsu.Cantida_choferes = Convert.ToInt32(values[colcantida_choferes]);

                            /// oEntUsu.CodArea = Convert.ToInt32(values[colCodArea]);


                            oListR.Add(oEntUsu);
                        }
                    }
                }
            }
            return oListR;

        }



        public List<EntUsuario> SEL_NRO_CORREO(string nroDocument, string correo)
        {

            List<EntUsuario> oListR = new List<EntUsuario>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_NRO_CORREO", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@nroDocumento", SqlDbType.VarChar, 20).Value = nroDocument;
                    cmd.Parameters.Add("@correo", SqlDbType.VarChar, 200).Value = correo;


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colnroDocumento = dr.GetOrdinal("nroDocumento");
                        int colcorreoElec = dr.GetOrdinal("correoElec");
                        //int colCodArea = dr.GetOrdinal("codArea");


                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntUsuario oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntUsuario();
                            dr.GetValues(values);

                            oEntUsu.NroDocumento = Convert.ToString(values[colnroDocumento]);
                            oEntUsu.CorreoElec = Convert.ToString(values[colcorreoElec]);
                            /// oEntUsu.CodArea = Convert.ToInt32(values[colCodArea]);


                            oListR.Add(oEntUsu);
                        }
                    }
                }
            }
            return oListR;

        }




        public List<EntMovilidad> SEL_USUARIOPANEL_CONSUL(string Codigo)
        {

            List<EntMovilidad> oListR = new List<EntMovilidad>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_USUARIOPANEL_CONSUL", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@codUsuario", SqlDbType.Int).Value = Codigo;



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




        public List<EntMoviDetalleUsu> SEL_MOVI_DETA(string bus)
        {

            List<EntMoviDetalleUsu> oListR = new List<EntMoviDetalleUsu>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_MOVI_DETA", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@codUsuario", SqlDbType.Int).Value = bus;



                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colidMovilidad = dr.GetOrdinal("idMovilidad");
                        int colNombreChofer = dr.GetOrdinal("NombreChofer");
                        int colNroDocumento = dr.GetOrdinal("NroDocumento");
                        int colplaca = dr.GetOrdinal("placa");
                        int colcapacidad = dr.GetOrdinal("capacidad");
                        int coldesColegio = dr.GetOrdinal("desColegio");
                        int coldesDistrito = dr.GetOrdinal("desDistrito");
                      
                        
                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntMoviDetalleUsu oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntMoviDetalleUsu();
                            dr.GetValues(values);

                            oEntUsu.IdMovilidad = Convert.ToInt32(values[colidMovilidad]);
                            oEntUsu.NombreChofer = Convert.ToString(values[colNombreChofer]);
                            oEntUsu.NroDocumento = Convert.ToString(values[colNroDocumento]);
                            oEntUsu.Placa = Convert.ToString(values[colplaca]);
                            oEntUsu.Capacidad = Convert.ToInt32(values[colcapacidad]);
                            oEntUsu.DesColegio = Convert.ToString(values[coldesColegio]);
                            oEntUsu.DesDistrito = Convert.ToString(values[coldesDistrito]);

                            /// oEntUsu.CodArea = Convert.ToInt32(values[colCodArea]);


                            oListR.Add(oEntUsu);
                        }
                    }
                }
            }
            return oListR;

        }



        public List<EntMoviDetalleUsu> SEL_IMAGEN_DETA(string codigoMovi)
        {

            List<EntMoviDetalleUsu> oListR = new List<EntMoviDetalleUsu>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("SEL_IMAGEN_DETA", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@idMovilidad", SqlDbType.Int).Value = codigoMovi;



                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colidMovilidad = dr.GetOrdinal("idMovilidad");
                        int colSoat = dr.GetOrdinal("Soat");
                        int colrevTecnica = dr.GetOrdinal("revTecnica");
                        int colfotoCarro = dr.GetOrdinal("fotoCarro");


                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntMoviDetalleUsu oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntMoviDetalleUsu();
                            dr.GetValues(values);

                            oEntUsu.IdMovilidad = Convert.ToInt32(values[colidMovilidad]);
                            oEntUsu.Soat = Convert.ToString(values[colSoat]);
                            oEntUsu.RevTecnica = Convert.ToString(values[colrevTecnica]);
                            oEntUsu.ImagenCarro = Convert.ToString(values[colfotoCarro]);
                            

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
