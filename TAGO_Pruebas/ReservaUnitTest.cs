using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TAGO_Pruebas
{
    [TestClass]
    public class ReservaUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReservaService.ReservaServiceClient proxy = new ReservaService.ReservaServiceClient();
            ReservaService.Reserva entidad = proxy.RegistrarReserva(new ReservaService.Reserva
            {
                IdCliente = 10,
                FechaRecojoCliente = "22/04/2018",
                Origen = "Lima",
                Destino = "UPC, Villa",
                Importe = 10.20M,
                IdEstadoReserva=1,
                FechaRegistroReserva = "22/04/2018",
                Placa= "XQ-8208"
            });
            Assert.AreEqual(10, entidad.IdCliente);
            //Assert.AreEqual("22/04/2018", entidad.FechaRecojoCliente);
            Assert.AreEqual("Lima", entidad.Origen);
            Assert.AreEqual("UPC, Villa", entidad.Destino);
            //Assert.AreEqual(10.20, entidad.Importe);
            Assert.AreEqual(1, entidad.IdEstadoReserva);
            //Assert.AreEqual("22/04/2018", entidad.FechaRegistroReserva);
            Assert.AreEqual("XQ-8208", entidad.Placa);
        }
    }
}
