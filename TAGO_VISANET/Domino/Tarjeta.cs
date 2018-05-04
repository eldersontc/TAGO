using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_VISANET.Domino
{
    [DataContract]
    public class Tarjeta
    {
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Vencimiento { get; set; }
        [DataMember]
        public string CodigoVerificacion { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string CorreoElectronico { get; set; }
        [DataMember]
        public decimal ImporteSaldo { get; set; }
    }
}