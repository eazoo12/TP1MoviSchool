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
                       // cmd.Parameters.Add("@idtipodocumento", SqlDbType.Int).Value = oEntUsuario.TipoUsuario;
                        cmd.Parameters.Add("@nroDocumento", SqlDbType.VarChar, 20).Value = oEntUsuario.NroDocumento;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = oEntUsuario.Direccion;
                        cmd.Parameters.Add("@correoElec", SqlDbType.VarChar, 200).Value = oEntUsuario.CorreoElec;
                        cmd.Parameters.Add("@fechaNaci", SqlDbType.DateTime).Value = oEntUsuario.FehaNacimi;
                        cmd.Parameters.Add("@genero", SqlDbType.VarChar, 10).Value = oEntUsuario.Genero;
                        //cmd.Parameters.Add("@idpais", SqlDbType.Int).Value = oEntUsuario.Pais;
                        //cmd.Parameters.Add("@iddepartamento", SqlDbType.Int).Value = oEntUsuario.Departamento;
                        //cmd.Parameters.Add("@idDistrito", SqlDbType.Int).Value = oEntUsuario.Distrito;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 200).Value = oEntUsuario.Usuario;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar, 200).Value = oEntUsuario.Password;
                       // cmd.Parameters.Add("@idtipoUsuario", SqlDbType.Int).Value = oEntUsuario.TipoDocumento;

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


    }
}
