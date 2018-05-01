using System.Runtime.Serialization;

namespace TAGO_VISANET.Errores
{
    [DataContract]
    public class AdministradorExcepciones
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}