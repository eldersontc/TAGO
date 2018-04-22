using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_Servicios.Dominio;
using TAGO_Servicios.Persistencia;

namespace TAGO_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReservaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReservaService.svc o ReservaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReservaService : IReservaService
    {
        ReservaDA entidadDA = new ReservaDA();
        public Reserva CancelarReserva(Reserva entidad)
        {
            return null;
        }

        public Reserva RegistrarReserva(Reserva entidad)
        {
            return entidadDA.Crear(entidad);
        }
    }
}
