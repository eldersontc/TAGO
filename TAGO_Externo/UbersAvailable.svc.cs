using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TAGO_Externo.Dominio;
using TAGO_Externo.Errores;
using TAGO_Externo.Persistencia;

namespace TAGO_Externo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UbersAvailable" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UbersAvailable.svc o UbersAvailable.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UbersAvailable : IUbersAvailable
    {
        private UberDAO uberAvailableDA = new UberDAO();

        public List<UberAvailable> ListTaxiUberAvailable(string OLatitud, string OLongitud, string DLatitud, string DLongitud)
        {
            if (uberAvailableDA.ListTaxiUberAvailable(OLatitud, OLongitud, DLatitud, DLongitud) == null)
            {
                throw new FaultException<NotFoundException>(
                  new NotFoundException()
                  {
                      ErrorCode = "105",
                      ErrorDescription = "No existen taxis disponibles"
                  },
                  new FaultReason("Error en el proceso de listar taxis"));
            }
            return uberAvailableDA.ListTaxiUberAvailable(OLatitud, OLongitud, DLatitud, DLongitud);
        }
        public UberAvailable GetUberAvailable(string placa)
        {
            return uberAvailableDA.GetUberAvailable(placa);
        }
    }
}
