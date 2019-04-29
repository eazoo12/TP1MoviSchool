using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntMovilidad
    {

        string _nombreAp;

        public string NombreAp { get { return _nombreAp; } set { _nombreAp = value; } }

        string _celular;

        public string Celular { get { return _celular; } set { _celular = value; } }

        string _correoElec;

        public string CorreoElec { get { return _correoElec; } set { _correoElec = value; } }


        string _direccion;

        public string Direccion { get { return _direccion; } set { _direccion = value; } }


    }
}
