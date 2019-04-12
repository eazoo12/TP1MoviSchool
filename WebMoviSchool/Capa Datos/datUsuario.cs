using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Capa_Entidad;

namespace Capa_Datos
{
    public class datUsuario
    {


        public void INS_USUARIO(EntUsuario oEntUsuario, int opc)
        {
            try
            {
                using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
                {

                    using (SqlCommand cmd = new SqlCommand("INS_USUARIO", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = oEntUsuario.Nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 100).Value = oEntUsuario.Apellido;
                        cmd.Parameters.Add("@celular", SqlDbType.VarChar,20).Value = oEntUsuario.Celular;
                        cmd.Parameters.Add("@idtipodocumento", SqlDbType.Int).Value = oEntUsuario.TipoDocumento;
                        cmd.Parameters.Add("@nroDocumento", SqlDbType.VarChar, 20).Value = oEntUsuario.NroDocumento;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = oEntUsuario.Direccion;
                        cmd.Parameters.Add("@correoElec", SqlDbType.VarChar, 200).Value = oEntUsuario.CorreoElec;
                        cmd.Parameters.Add("@fechaNaci", SqlDbType.DateTime).Value = oEntUsuario.FehaNacimi;
                        cmd.Parameters.Add("@genero", SqlDbType.VarChar, 10).Value = oEntUsuario.Genero;
                        cmd.Parameters.Add("@iddistrito", SqlDbType.Int).Value = oEntUsuario.Iddistrito;
                       
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 200).Value = oEntUsuario.Usuario;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar, 200).Value = oEntUsuario.Password;
                        cmd.Parameters.Add("@idtipoUsuario", SqlDbType.Int).Value = oEntUsuario.TipoUsuario;

                        cmd.Parameters.Add("@opc", SqlDbType.VarChar, 100).Value = opc;
                       

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


        public DataTable SEL_TIPODOC()
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_TIPODOC", conex))
                    {
                        conex.Open();

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

        public DataTable SEL_PAIS()
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_PAIS", conex))
                    {
                        conex.Open();

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
        

        public DataTable SEL_DEPARTAMENTO(int codPais)
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_DEPARTAMENTO", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@codPais", SqlDbType.Int).Value = codPais;

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
        
        public DataTable SEL_DISTRITO(int codDepa)
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_DISTRITO", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@codDepa", SqlDbType.Int).Value = codDepa;

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
        
        public DataTable SEL_TIPOUSUARIO()
        {
            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (var da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand("SEL_TIPOUSUARIO", conex))
                    {
                        conex.Open();
                      

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

        public void LOGUEO_USUARIO(EntUsuario oEntUsuario)
        {
            try
            {
                using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
                {
                    using (SqlCommand cmd = new SqlCommand("LOGUEO_USUARIO", conex))
                    {
                        conex.Open();
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 200).Value = oEntUsuario.Usuario;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar, 200).Value = oEntUsuario.Password;

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



        public List<EntUsuario> login(string usuario, string pass)
        {

            List<EntUsuario> oListR = new List<EntUsuario>();

            using (SqlConnection conex = new SqlConnection(datConexion.cad_con))
            {
                using (SqlCommand cmd = new SqlCommand("LOGINN", conex))
                {
                    conex.Open();
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = pass;


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        int colidtipoUsuario = dr.GetOrdinal("idtipoUsuario");
                        int colnroDocumento = dr.GetOrdinal("nroDocumento");
                        //int colCodArea = dr.GetOrdinal("codArea");


                        int colCant = dr.FieldCount;
                        object[] values = new object[colCant];
                        EntUsuario oEntUsu = null;

                        while (dr.Read())
                        {
                            oEntUsu = new EntUsuario();
                            dr.GetValues(values);

                            oEntUsu.TipoUsuario = Convert.ToInt16(values[colidtipoUsuario]);
                            oEntUsu.NroDocumento = Convert.ToString(values[colnroDocumento]);
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
