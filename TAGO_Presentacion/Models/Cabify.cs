using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class Cabify
    {
        public string AutoPlaca { get; set; }
        
        public int TiempoLlegada { get; set; }
        
        public int TiempoViaje { get; set; }
        
        public decimal Monto { get; set; }
        
        public string OLatitud { get; set; }
        
        public string OLongitud { get; set; }
        
        public string DLatitud { get; set; }
        
        public string DLongitud { get; set; }
    }
}