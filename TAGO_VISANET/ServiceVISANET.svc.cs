using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_VISANET.Domino;
using TAGO_VISANET.Errores;
using TAGO_VISANET.Persistencia;

namespace TAGO_VISANET
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceVISANET" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceVISANET.svc or ServiceVISANET.svc.cs at the Solution Explorer and start debugging.
    public class ServiceVISANET : IServiceVISANET
    {
        public Tarjeta obtenerTarjeta(string Numero)
        {
            return new TarjetaDAO(new Tarjeta() { Numero = Numero }).Seleccionar();
        }

        public int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion)
        {
            Tarjeta objTarjeta = this.obtenerTarjeta(Numero);
            if (string.IsNullOrEmpty(Numero))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "001",
                    Descripcion = "Número de tarjeta incorrecto."
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(objTarjeta.Numero))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "001",
                    Descripcion = "Número de tarjeta incorrecto."
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (ImporteOperacion <= 0)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "007",
                    Descripcion = "Importe incorrecto"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (objTarjeta.ImporteSaldo < ImporteOperacion)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "001",
                    Descripcion = "Saldo insuficiente"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Vencimiento) || objTarjeta.Vencimiento != Vencimiento)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "002",
                    Descripcion = "datos de la fecha vencimiento de la tarjeta son incorrectos"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(CodigoVerificacion) || objTarjeta.CodigoVerificacion != CodigoVerificacion)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "003",
                    Descripcion = "El código de verificación(CVV) es inválido"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Nombre) || objTarjeta.Nombre != Nombre)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "004",
                    Descripcion = "El Nombre es incorrecto"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Apellido) || objTarjeta.Apellido != Apellido)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "005",
                    Descripcion = "El Apellido es incorrecto"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(CorreoElectronico))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "006",
                    Descripcion = "Correco electrónico necesario"
                }, new FaultReason("Error al registrar el pago."));
            }
            OperacionesTarjeta objOperacion = new OperacionesTarjeta();
            objOperacion.Numero = Numero;
            objOperacion.ImporteOperacion = ImporteOperacion;
            OperacionesTarjetaDAO objDAO = new OperacionesTarjetaDAO(objOperacion);
            try
            {
                int result = objDAO.Insertar();
                return result;
            }
            catch (Exception ex)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "Aplicación",
                    Descripcion = ex.Message.ToString()
                }, new FaultReason("Error al registrar el pago."));
            }
        }
    }
}
