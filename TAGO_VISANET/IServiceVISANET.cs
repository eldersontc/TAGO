using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TAGO_VISANET
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceVISANET" in both code and config file together.
    [ServiceContract]
    public interface IServiceVISANET
    {
        [OperationContract]
        int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion);
    }
}
