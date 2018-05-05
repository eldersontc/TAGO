using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TAGO_Presentacion.Models;

namespace TAGO_Presentacion.Controllers
{
    public class ManageController : BaseController
    {
        public ActionResult Mapa()
        {
            if (SessionExpirada())
                return RetornarLogin();

            ViewBag.NombreCliente = ObtenerCliente().Nombres;
            return View();
        }

        public ActionResult Elegir(string o, string d)
        {
            if (SessionExpirada())
                return RetornarLogin();

            ViewBag.NombreCliente = ObtenerCliente().Nombres;

            string i = Encoding.UTF8.GetString(Convert.FromBase64String(o));
            string f = Encoding.UTF8.GetString(Convert.FromBase64String(d));
            string[] arri = i.Split('|');
            string[] arrf = f.Split('|');
            ViewBag.Origen = arri[0];
            ViewBag.Destino = arrf[0];
            
            //Se gudarla las ubicaciones en la sesion.
            AsignarReserva(new ReservaService.Reserva
            {
                Origen = arri[0],
                Destino = arrf[0],
            });

            List<CandidatoModel> candidatos = new List<CandidatoModel>();
            candidatos.Add(new CandidatoModel {
                Proveedor = "UBER",
                Conductor = "ELDERSON TABOADA",
                MarcaVehiculo = "TOYOTA",
                PlacaVehiculo = "ABC-123",
                Distancia = 30,
                Precio = 15
            });
            candidatos.Add(new CandidatoModel
            {
                Proveedor = "CABIFY",
                Conductor = "JUAN SANCHEZ",
                MarcaVehiculo = "KIA",
                PlacaVehiculo = "DEF-456",
                Distancia = 20,
                Precio = 20
            });
            return View(candidatos);
        }
        
        public ActionResult Pagar(string proveedor, string placa)
        {
            if (SessionExpirada())
                return RetornarLogin();

            ReservaService.Reserva reseva = ObtenerReserva();
            reseva.Placa = placa;
            
            AsignarReserva(reseva);

            ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
            ClienteService.Tarjeta[] tarjetas = proxy.ListarTarjetaxCliente(ObtenerCliente().DNI);
            return View(tarjetas);
        }
    }
}