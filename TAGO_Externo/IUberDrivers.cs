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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUberDrivers" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUberDrivers
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UberDrivers", ResponseFormat = WebMessageFormat.Json)]
        List<UberDriver> ListTaxiUber();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "UberDrivers/{placa}", ResponseFormat = WebMessageFormat.Json)]
        UberDriver GetUberDriver(string placa);
    }
}
