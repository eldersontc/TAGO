using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_Externo.Dominio
{
    [DataContract]
    public class UberDriver
    {
        [DataMember]
        public int UPlaca { get; set; }

        [DataMember]
        public string UNombres { get; set; }

        [DataMember]
        public string UApellidos { get; set; }

        [DataMember]
        public int UCelular { get; set; }

        [DataMember]
        public string UModeloAuto { get; set; }

        [DataMember]
        public int UReputacion { get; set; }

        [DataMember]
        public DateTime UFechaIngreso { get; set; }
    }
}
