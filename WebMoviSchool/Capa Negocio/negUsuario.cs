using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Datos;

namespace Capa_Negocio
{
    public class negUsuario
    {

        datUsuario objDatUsaurio = new datUsuario();

        public void INS_USUARIO(EntUsuario oEntUsuario, int opc)
        {
            objDatUsaurio.INS_USUARIO(oEntUsuario, opc);
        }
    }
}
