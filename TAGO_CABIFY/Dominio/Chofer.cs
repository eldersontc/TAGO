using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TAGO_CABIFY.Dominio
{
    [DataContract]
    public class Chofer
    {
        [DataMember(IsRequired = false)]
        public string nombres { get; set; }

        [DataMember(IsRequired = false)]
        public string apellidos { get; set; }

        [DataMember(IsRequired = false)]
        public string celular { get; set; }

        [DataMember]
        public string ModeloAuto { get; set; }

        [DataMember]
        public int reputacion { get; set; }

        [DataMember]
        public DateTime FechaRegistro { get; set; }

    }
}