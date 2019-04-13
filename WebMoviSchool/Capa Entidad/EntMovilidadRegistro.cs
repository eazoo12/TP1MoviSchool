using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntMovilidadRegistro
    {
        string _nombreChofer;

        public string NombreChofer { get { return _nombreChofer; } set { _nombreChofer = value; } }

        int _idtipodocumento;

        public int Idtipodocumento { get { return _idtipodocumento; } set { _idtipodocumento = value; } }

        string _nroDocumento;

        public string NroDocumento { get { return _nroDocumento; } set { _nroDocumento = value; } }

        string _telefono;

        public string Telefono { get { return _telefono; } set { _telefono = value; } }

        int _idColegio;

        public int idColegio { get { return _idColegio; } set { _idColegio = value; } }

        Byte[] _soat;

        public Byte[] Soat { get { return _soat; } set { _soat = value; } }

        string _placa;

        public string Placa { get { return _placa; } set { _placa = value; } }

        Byte[] _revTecnica;

        public Byte[] RevTecnica { get { return _revTecnica; } set { _revTecnica = value; } }

        string _marca;

        public string Marca { get { return _marca; } set { _marca = value; } }

        string _modelo;

        public string Modelo { get { return _modelo; } set { _modelo = value; } }

        string _color;

        public string Color { get { return _color; } set { _color = value; } }

        int _capacidad;

        public int Capacidad { get { return _capacidad; } set { _capacidad = value; } }

        Byte[] _fotoCarro;

        public Byte[] FotoCarro { get { return _fotoCarro; } set { _fotoCarro = value; } }

        int _papelRegla;

        public int PapelRegla { get { return _papelRegla; } set { _papelRegla = value; } }

        string _dni;

        public string Dni { get { return _dni; } set { _dni = value; } }
                                  
              
    }
}
