using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntUsuario
    {
        string _nombre;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        string _apellido;

        public string Apellido { get { return _apellido; } set { _apellido = value; } }

        string _celular;

        public string Celular { get { return _celular; } set { _celular = value; } }

        int _tipoDocumento;

        public int TipoDocumento { get { return _tipoDocumento; } set { _tipoDocumento = value; } }

        string _nroDocumento;

        public string NroDocumento { get { return _nroDocumento; } set { _nroDocumento = value; } }

        string _direccion;

        public string Direccion { get { return _direccion; } set { _direccion = value; } }

        string _correoElec;

        public string CorreoElec { get { return _correoElec; } set { _correoElec = value; } }

        DateTime _fehaNacimi;

        public DateTime FehaNacimi { get { return _fehaNacimi; } set { _fehaNacimi = value; } }

        string _genero;

        public string Genero { get { return _genero; } set { _genero = value; } }

        int _iddistrito;

        public int Iddistrito { get { return _iddistrito; } set { _iddistrito = value; } }

       

        string _usuario;

        public string Usuario { get { return _usuario; } set { _usuario = value; } }

        string _password;

        public string Password { get { return _password; } set { _password = value; } }

        int _tipoUsuario;

        public int TipoUsuario { get { return _tipoUsuario; } set { _tipoUsuario = value; } }


    }
}
