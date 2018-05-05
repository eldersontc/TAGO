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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClienteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClienteService.svc o ClienteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClienteService : IClienteService
    {
        ClienteDA clienteDA = new ClienteDA();
        TarjetaDA tarjetaDA = new TarjetaDA();

        public Dominio.Cliente RegistrarCliente(Dominio.Cliente cliente)
        {
            return clienteDA.Crear(cliente);
        }

        public Dominio.Cliente ModificarCliente(Dominio.Cliente cliente)
        {
            return clienteDA.Modificar(cliente);
        }

        public Dominio.Cliente ConsultarClientexEmail(string Email)
        {
            return clienteDA.ObtenerxEmail(Email);
        }

        public Tarjeta RegistrarTarjeta(Tarjeta tarjeta)
        {
            return tarjetaDA.Crear(tarjeta);
        }

        public Tarjeta ModificarTarjeta(Tarjeta tarjeta)
        {
            return tarjetaDA.Modificar(tarjeta);
        }

        public int EliminarTarjeta(string numero)
        {
            return tarjetaDA.Eliminar(numero);
        }

        public List<Tarjeta> ListarTarjetaxCliente(string DNI)
        {
            return tarjetaDA.ListarxCliente(DNI);
        }
    }
}