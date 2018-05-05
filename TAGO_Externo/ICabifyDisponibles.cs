using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_Externo.Persistencia;
using TAGO_Externo.Dominio;
using System.ServiceModel.Web;


namespace TAGO_Externo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICabifyDisponibles" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICabifyDisponibles
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CabifyDisponibles/{AutoPlaca}", ResponseFormat = WebMessageFormat.Json)]
        CabifyDisponible ObtenerCabifyDisponible(string AutoPlaca);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CabifyDisponibles", ResponseFormat = WebMessageFormat.Json)]
        List<CabifyDisponible> ListarCabifyDisponibles(string OLatitud, string OLongitud, string DLatitud, string DLongitud);


    }
}
