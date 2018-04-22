using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TAGO_Pruebas
{
    [TestClass]
    public class ClienteUnitTest
    {
        [TestMethod]
        public void TestRegistroClienteOK()
        {
            ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
            ClienteService.Cliente cliente = proxy.RegistrarCliente(new ClienteService.Cliente
            {
                Nombres = "Elderson",
                Apellidos = "Taboada",
                Celular = "990015452",
                Email = "etaboada@outlook.com",
                Password = "123456"
            });
            Assert.AreEqual("Elderson", cliente.Nombres);
            Assert.AreEqual("Taboada", cliente.Apellidos);
            Assert.AreEqual("990015452", cliente.Celular);
            Assert.AreEqual("etaboada@outlook.com", cliente.Email);
            Assert.AreEqual("123456", cliente.Password);
        }

        [TestMethod]
        public void TestModificarClienteOK()
        {
            ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
            ClienteService.Cliente cliente = proxy.ModificarCliente(new ClienteService.Cliente
            {
                Codigo = 1,
                Nombres = "Elderson Augusto",
                Apellidos = "Taboada Chavez",
                Celular = "990015452",
                Email = "etaboada@outlook.com",
                Password = "123456"
            });
            Assert.AreEqual("Elderson Augusto", cliente.Nombres);
            Assert.AreEqual("Taboada Chavez", cliente.Apellidos);
            Assert.AreEqual("990015452", cliente.Celular);
            Assert.AreEqual("etaboada@outlook.com", cliente.Email);
            Assert.AreEqual("123456", cliente.Password);
        }

        [TestMethod]
        public void TestConsultarClienteOK()
        {
            ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
            ClienteService.Cliente cliente = proxy.ConsultarCliente("etaboada@outlook.com");
            Assert.AreEqual("Elderson Augusto", cliente.Nombres);
            Assert.AreEqual("Taboada Chavez", cliente.Apellidos);
            Assert.AreEqual("990015452", cliente.Celular);
            Assert.AreEqual("etaboada@outlook.com", cliente.Email);
            Assert.AreEqual("123456", cliente.Password);
        }
    }
}
