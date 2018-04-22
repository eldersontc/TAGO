using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Servicios.Dominio
{
    public class Tarjeta
    {
        public string Cliente { get; set; }
        public string Numero { get; set; }
        public string FechaVencimiento { get; set; }
        public string CVV { get; set; }
    }
}