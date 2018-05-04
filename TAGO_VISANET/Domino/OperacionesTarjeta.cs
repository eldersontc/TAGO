using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_VISANET.Domino
{
    [DataContract]
    public class OperacionesTarjeta
    {
        [DataMember]
        public int IdOperacion { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public decimal ImporteOperacion { get; set; }
    }
}