using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TAGO_Externo.Dominio;
using TAGO_Externo.Errores;

namespace TAGO_Externo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUbersAvailable" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUbersAvailable
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UbersAvailable/{OLatitud, OLongitud, DLatitud, DLongitud}", ResponseFormat = WebMessageFormat.Json)]
        List<UberAvailable> ListTaxiUberAvailable(string OLatitud, string OLongitud, string DLatitud, string DLongitud);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UbersAvailable/{placa}", ResponseFormat = WebMessageFormat.Json)]
        UberAvailable GetUberAvailable(string placa);
    }
}
