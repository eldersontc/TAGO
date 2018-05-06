using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAGO_Presentacion.Models
{
    public class ReservaModel
    {
        [Required]
        public string Origen { get; set; }
        [Required]
        public string Destino { get; set; }
        [Required]
        public string Conductor { get; set; }
        [Required]
        public string AutoModelo { get; set; }
        [Required]
        public string AutoPlaca { get; set; }
        [Required]
        public decimal Precio { get; set; }

        public ClienteService.Tarjeta[] Tarjetas { get; set; }

        public string TarjetaSeleccionada { get; set; }
    }
}