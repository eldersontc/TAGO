using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAGO_Servicios.Dominio
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}