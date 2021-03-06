using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_Externo.Dominio
{
    [DataContract]
    public class UberAvailable
    {
        [DataMember]
        public string UPlaca { get; set; }

        [DataMember]
        public string UMarcaAuto { get; set; }

        [DataMember]
        public string UColorAuto { get; set; }

        [DataMember]
        public int UTiempoLlegada { get; set; }

        [DataMember]
        public decimal UMontoACobrar { get; set; }

        [DataMember]
        public int UTiempoViaje { get; set; }

        [DataMember]
        public string ULatitudOrigen { get; set; }

        [DataMember]
        public string ULongitudOrigen { get; set; }

        [DataMember]
        public string ULatitudDestino { get; set; }

        [DataMember]
        public string ULongitudDestino { get; set; }
    }
}
