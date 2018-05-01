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
        public int registrarPagoVISANET(string Numero, string Vencimiento, string CodigoVerificacion, string Nombre, string Apellido, string CorreoElectronico, decimal ImporteOperacion)
        {
            if (string.IsNullOrEmpty(Numero))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "001",
                    Descripcion = "Número de tarjeta incorrecto."
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Vencimiento))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "002",
                    Descripcion = "Ingresar datos del vencimiento de la tarjeta(mm/yy)"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(CodigoVerificacion))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "003",
                    Descripcion = "Ingresar el código de verificación(CVV)"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Nombre))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "004",
                    Descripcion = "El Nombre es necesario"
                }, new FaultReason("Error al registrar el pago."));
            }
            else if (string.IsNullOrEmpty(Apellido))
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "005",
                    Descripcion = "El Apellido necesario"
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
            else if (ImporteOperacion <= 0)
            {
                throw new FaultException<AdministradorExcepciones>(new AdministradorExcepciones()
                {
                    Codigo = "007",
                    Descripcion = "Importe incorrecto"
                }, new FaultReason("Error al registrar el pago."));
            }
            OperacionesTarjeta objOperacion = new OperacionesTarjeta();
            objOperacion.Numero = Numero;
            objOperacion.Vencimiento = Vencimiento;
            objOperacion.CodigoVerificacion = CodigoVerificacion;
            objOperacion.Nombre = Nombre;
            objOperacion.Apellido = Apellido;
            objOperacion.CorreoElectronico = CorreoElectronico;
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
