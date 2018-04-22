using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_Servicios.Dominio;

namespace TAGO_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClienteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente RegistrarCliente(Cliente cliente);

        [OperationContract]
        Cliente ModificarCliente(Cliente cliente);

        [OperationContract]
        Cliente ConsultarCliente(string Email);

        [OperationContract]
        Tarjeta RegistrarTarjeta(Tarjeta tarjeta);

        [OperationContract]
        Tarjeta ModificarTarjeta(Tarjeta tarjeta);

        [OperationContract]
        int EliminarTarjeta(int codigo);
    }
}
