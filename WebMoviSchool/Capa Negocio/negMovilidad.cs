using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class negMovilidad
    {
        datMovilidad datOMovilidad = new datMovilidad(); 

        public List<EntMovilidad> SEL_USUARIOPANEL(string dni)
        {
            return datOMovilidad.SEL_USUARIOPANEL(dni);

        }


        public DataTable SEL_COLEGIO(int iddistrito)
        {
            return datOMovilidad.SEL_COLEGIO(iddistrito);
        }

        public void INS_MOVILIDAD(EntMovilidadRegistro oEntUsuario, int opc)
        {
            datOMovilidad.INS_MOVILIDAD(oEntUsuario, opc);
        }


        }
}
