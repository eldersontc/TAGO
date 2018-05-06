using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class CabifyDriver
    {
        public string codigo { get; set; }
        
        public string nombres { get; set; }
        
        public string apellidos { get; set; }
        
        public string celular { get; set; }
        
        public int reputacion { get; set; }
        
        public DateTime fecharegistro { get; set; }
        
        public string autoplaca { get; set; }
        
        public string automarca { get; set; }
        
        public string automodelo { get; set; }
    }
}