using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace TAGO_Externo.Dominio
{
    [DataContract]
    public class CabifyChofer
    {
        [DataMember(IsRequired = false)]
        public string codigo { get; set; }

        [DataMember(IsRequired = false)]
        public string nombres { get; set; }

        [DataMember(IsRequired = false)]
        public string apellidos { get; set; }

        [DataMember(IsRequired = false)]
        public string celular { get; set; }

        [DataMember]
        public int reputacion { get; set; }

        [DataMember]
        public DateTime fecharegistro { get; set; }

        [DataMember(IsRequired = false)]
        public string autoplaca { get; set; }

        [DataMember]
        public string automarca { get; set; }

        [DataMember]
        public string automodelo { get; set; }

    }
}