using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntBMovilidadUs
    {
        int _codUsurio;

        public int CodUsurio { get { return _codUsurio; } set { _codUsurio = value; } }

        string _nom_ape;

        public string Nom_ape { get { return _nom_ape; } set { _nom_ape = value; } }

        string _celular;

        public string Celular { get { return _celular; } set { _celular = value; } }

        string _correoElec;

        public string CorreoElec { get { return _correoElec; } set { _correoElec = value; } }

        int _cantida_choferes;

        public int Cantida_choferes { get { return _cantida_choferes; } set { _cantida_choferes = value; } }


    }
}
