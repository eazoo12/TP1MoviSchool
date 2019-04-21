using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntComentarioRegistro
    {
        string _desComentario;

        public string DesComentario { get { return _desComentario; } set { _desComentario = value; } }

        int _codUsurio;

        public int CodUsurio { get { return _codUsurio; } set { _codUsurio = value; } }

        string _codPadre;

        public string NroDocumento { get { return _codPadre; } set { _codPadre = value; } }

    }
}
