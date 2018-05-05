using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_Servicios.Dominio;
using TAGO_Servicios.Utilitarios;

namespace TAGO_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReservaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReservaService
    {
        [FaultContract(typeof(AdministradorExcepciones))]
        [OperationContract]
        Reserva RegistrarReserva(Reserva entidad);

        [FaultContract(typeof(AdministradorExcepciones))]
        [OperationContract]
        Reserva CancelarReserva(Reserva entidad);
    }
}
