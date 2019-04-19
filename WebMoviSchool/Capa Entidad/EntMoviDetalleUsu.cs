using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class EntMoviDetalleUsu
    {

        int _idMovilidad;

        public int IdMovilidad { get { return _idMovilidad; } set { _idMovilidad = value; } }

        string _nombreChofer;

        public string NombreChofer { get { return _nombreChofer; } set { _nombreChofer = value; } }

        string _NroDocumento;

        public string NroDocumento { get { return _NroDocumento; } set { _NroDocumento = value; } }

        string _placa;

        public string Placa { get { return _placa; } set { _placa = value; } }

        int _capacidad;

        public int Capacidad { get { return _capacidad; } set { _capacidad = value; } }

        string _desColegio;

        public string DesColegio { get { return _desColegio; } set { _desColegio = value; } }

        string _desDistrito;

        public string DesDistrito { get { return _desDistrito; } set { _desDistrito = value; } }

        string _soat;

        public string Soat { get { return _soat; } set { _soat = value; } }

        string _revTecnica;

        public string RevTecnica { get { return _revTecnica; } set { _revTecnica = value; } }

        string _ImagenCarro;

        public string ImagenCarro { get { return _ImagenCarro; } set { _ImagenCarro = value; } }


    }
}
