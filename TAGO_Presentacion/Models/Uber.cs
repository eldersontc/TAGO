using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class Uber
    {
        public string UPlaca { get; set; }
        
        public string UMarcaAuto { get; set; }
        
        public string UColorAuto { get; set; }
        
        public int UTiempoLlegada { get; set; }
        
        public decimal UMontoACobrar { get; set; }
        
        public int UTiempoViaje { get; set; }
        
        public string ULatitudOrigen { get; set; }
        
        public string ULongitudOrigen { get; set; }
        
        public string ULatitudDestino { get; set; }
        
        public string ULongitudDestino { get; set; }
    }
}