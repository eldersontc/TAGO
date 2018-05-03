using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_Externo.Dominio
{
    [DataContract]
    public class CabifyDisponible
    {
        [DataMember(IsRequired = false)]
        public string AutoPlaca { get; set; }

        [DataMember]
        public TimeSpan TiempoLlegada { get; set; }

        [DataMember]
        public TimeSpan TiempoViaje { get; set; }

        [DataMember]
        public string Monto { get; set; }

    }
}