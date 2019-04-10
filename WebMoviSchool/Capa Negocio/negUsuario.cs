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

    }
}
