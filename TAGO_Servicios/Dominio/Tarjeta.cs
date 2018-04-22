using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Servicios.Dominio
{
    public class Tarjeta
    {
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public string FechaVencimiento { get; set; }
        public string CVV { get; set; }
    }
}