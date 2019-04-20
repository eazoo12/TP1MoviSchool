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

        public List<EntBMovilidadUs> SEL_MOVILIDAD_USUARIO(string bus, int idDistrito, string nomColegio, int TipoBu)
        {
            return datOMovilidad.SEL_MOVILIDAD_USUARIO(bus, idDistrito, nomColegio, TipoBu);
        }

        public List<EntUsuario> SEL_NRO_CORREO(string nroDocument, string correo)
        {
            return datOMovilidad.SEL_NRO_CORREO(nroDocument, correo);
        }


        public List<EntMovilidad> SEL_USUARIOPANEL_CONSUL(string Codigo)
        {
            return datOMovilidad.SEL_USUARIOPANEL_CONSUL(Codigo);
        }

        public List<EntMoviDetalleUsu> SEL_MOVI_DETA(string bus, string iddistrito, string nomColegio)
        {
            return datOMovilidad.SEL_MOVI_DETA(bus, iddistrito, nomColegio);
        }


        public List<EntMoviDetalleUsu> SEL_IMAGEN_DETA(string codigoMovi)
        {
            return datOMovilidad.SEL_IMAGEN_DETA(codigoMovi);
        }


    }
}
