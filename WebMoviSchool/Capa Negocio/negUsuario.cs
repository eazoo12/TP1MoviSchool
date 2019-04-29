using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class negUsuario
    {

        datUsuario objDatUsaurio = new datUsuario();

        public void INS_USUARIO(EntUsuario oEntUsuario, int opc)
        {
            objDatUsaurio.INS_USUARIO(oEntUsuario, opc);
        }

        public DataTable SEL_TIPODOC()
        {
            return objDatUsaurio.SEL_TIPODOC();
        }

        public DataTable SEL_PAIS()
        {
            return objDatUsaurio.SEL_PAIS();
        }

        public DataTable SEL_DEPARTAMENTO(int codPais)
        {
            return objDatUsaurio.SEL_DEPARTAMENTO(codPais);
        }

        public DataTable SEL_DISTRITO(int codDepa)
        {
            return objDatUsaurio.SEL_DISTRITO(codDepa);
        }

        public DataTable SEL_TIPOUSUARIO()
        {
            return objDatUsaurio.SEL_TIPOUSUARIO();
        }

        public void LOGUEO_USUARIO(EntUsuario oEntUsuario)
        {
            objDatUsaurio.LOGUEO_USUARIO(oEntUsuario);
        }

        public List<EntUsuario> login(string usuario, string pass)
        {
            return objDatUsaurio.login(usuario, pass);
        }

        public List<EntUsuario> SEL_CORR_CONTRA(string correo)
        {
            return objDatUsaurio.SEL_CORR_CONTRA(correo);
        }

        public void UPD_CAMB_PW(int codUsuario, String pass)
        {
            objDatUsaurio.UPD_CAMB_PW(codUsuario, pass);
        }

        public void UPD_MOVILIDAD(int codUsuario, String telefono, String correo, String direccion)
        {
            objDatUsaurio.UPD_MOVILIDAD(codUsuario, telefono, correo, direccion);
        }

        public List<EntUsuario> SEL_USUARIO_PANEL2(string dni)
        {
            return objDatUsaurio.SEL_USUARIOPANEL2(dni);
        }

        public void UPD_PADRE(int codUsuario, String telefono, String correo, String direccion)
        {
            objDatUsaurio.UPD_PADRE(codUsuario, telefono, correo, direccion);
        }

    }
}
