using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class UberDriver
    {
        public int UPlaca { get; set; }
        
        public string UNombres { get; set; }
        
        public string UApellidos { get; set; }
        
        public int UCelular { get; set; }
        
        public string UModeloAuto { get; set; }
        
        public int UReputacion { get; set; }
        
        public DateTime UFechaIngreso { get; set; }
    }
}