using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class CandidatoModel
    {
        public string Proveedor { get; set; }
        public string Conductor { get; set; }
        public string PlacaVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int Precio { get; set; }
        public int Distancia { get; set; }
    }
}