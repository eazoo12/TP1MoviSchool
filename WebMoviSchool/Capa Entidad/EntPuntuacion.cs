using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntPuntuacion
    {
        int _promedio;

        public int promedio { get { return _promedio; } set { _promedio = value; } }

        int _codUsurio;

        public int codUsurio { get { return _codUsurio; } set { _codUsurio = value; } }
    }
}
