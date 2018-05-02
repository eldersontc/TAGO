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
        [DataMember(IsRequired = true)]
        public string Numero { get; set; }
        [DataMember(IsRequired = true)]
        public string Vencimiento { get; set; }
        [DataMember(IsRequired = true)]
        public string CodigoVerificacion { get; set; }
        [DataMember(IsRequired = true)]
        public string Nombre { get; set; }
        [DataMember(IsRequired = true)]
        public string Apellido { get; set; }
        [DataMember(IsRequired = true)]
        public string CorreoElectronico { get; set; }
        [DataMember]
        public decimal ImporteOperacion { get; set; }

    }
}