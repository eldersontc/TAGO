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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICabifyChoferes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICabifyChoferes
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CabifyChoferes/{Codigo}", ResponseFormat = WebMessageFormat.Json)]
        CabifyChofer ObtenerCabifyChofer(string Codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CabifyChoferes", ResponseFormat = WebMessageFormat.Json)]
        List<CabifyChofer> ListarCabifyChoferes();
    }
}
