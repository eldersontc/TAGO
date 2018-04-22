using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_Servicios.Dominio
{
    [DataContract]
    public class Reserva
    {
        [DataMember]
        public int IdReserva { get; set; }
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public string FechaRecojoCliente { get; set; }
        [DataMember]
        public string Origen { get; set; }
        [DataMember]
        public string Destino { get; set; }
        [DataMember]
        public decimal Importe { get; set; }
        [DataMember]
        public int IdEstadoReserva { get; set; }
        [DataMember]
        public string FechaRegistroReserva { get; set; }

        [DataMember]
        public string Placa { get; set; }
    }
}