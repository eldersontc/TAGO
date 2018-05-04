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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UberDrivers" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UberDrivers.svc o UberDrivers.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UberDrivers : IUberDrivers
    {
        private UberDriverDA uberDA = new UberDriverDA();

        public List<UberDriver> ListTaxiUber(string OLatitud, string OLongitud, string DLatitud, string DLongitud)
        {
            if (uberDA.ListTaxiUber(OLatitud, OLongitud, DLatitud, DLongitud) == null)
            {
                throw new FaultException<NotFoundException>(
                  new NotFoundException()
                  {
                      ErrorCode = "105",
                      ErrorDescription = "No existen taxis disponibles"
                  },
                  new FaultReason("Error en el proceso de listar taxis"));
            }
            return uberDA.ListTaxiUber(OLatitud, OLongitud, DLatitud, DLongitud);
        }
        public UberDriver GetUberDriver(string placa)
        {
            return uberDA.GetUberDriver(placa);
        }
    }
}
