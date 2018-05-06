using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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

        private List<CandidatoModel> candidatosUber(string lato, string lngo, string latd, string lngd)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/UbersAvailable.svc/UbersAvailable/{0}/{1}/{2}/{3}",lato, lngo, latd, lngd);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            List<Uber> ubers = js.Deserialize<List<Uber>>(tramaJson);
            List<CandidatoModel> candidatos = new List<CandidatoModel>();
            foreach(var item in ubers)
            {
                candidatos.Add(new CandidatoModel {
                    Proveedor = "UBER",
                    PlacaVehiculo = item.UPlaca,
                    Precio = item.UMontoACobrar,
                    Distancia = item.UTiempoViaje
                });
            }
            return candidatos;
        }

        private List<CandidatoModel> candidatosCabify(string lato, string lngo, string latd, string lngd)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/CabifyDisponibles.svc/CabifyDisponibles/{0}/{1}/{2}/{3}", lato, lngo, latd, lngd);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            List<Cabify> cabifys = js.Deserialize<List<Cabify>>(tramaJson);
            List<CandidatoModel> candidatos = new List<CandidatoModel>();
            foreach (var item in cabifys)
            {
                candidatos.Add(new CandidatoModel
                {
                    Proveedor = "CABIFY",
                    PlacaVehiculo = item.AutoPlaca,
                    Precio = item.Monto,
                    Distancia = item.TiempoViaje
                });
            }
            return candidatos;
        }

        private CandidatoModel candidatoUber(string placa)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/UbersAvailable.svc/UbersAvailable/{0}", placa);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            Uber uber = js.Deserialize<Uber>(tramaJson);
            CandidatoModel candidato = new CandidatoModel
            {
                Proveedor = "UBER",
                PlacaVehiculo = uber.UPlaca,
                Precio = uber.UMontoACobrar,
                Distancia = uber.UTiempoViaje
            };
            return candidato;
        }

        private CandidatoModel candidatoCabify(string placa)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/CabifyDisponibles.svc/CabifyDisponibles/{0}", placa);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            Cabify cabify = js.Deserialize<Cabify>(tramaJson);
            CandidatoModel candidato = new CandidatoModel
            {
                Proveedor = "CABIFY",
                PlacaVehiculo = cabify.AutoPlaca,
                Precio = cabify.Monto,
                Distancia = cabify.TiempoViaje
            };
            return candidato;
        }

        private UberDriver obtenerChoferUber(string placa)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/UberDrivers.svc/UberDrivers/{0}", placa);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            UberDriver uber = js.Deserialize<UberDriver>(tramaJson);
            return uber;
        }

        private CabifyDriver obtenerChoferCabify(string placa)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string url = string.Format("http://localhost:2133/CabifyChoferes.svc/CabifyChoferes/{0}", placa);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            CabifyDriver cabify = js.Deserialize<CabifyDriver>(tramaJson);
            return cabify;
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
            
            candidatos.AddRange(candidatosUber(arri[1], arri[2], arrf[1], arrf[2]));
            candidatos.AddRange(candidatosCabify(arri[1], arri[2], arrf[1], arrf[2]));

            return View(candidatos);
        }
        
        public ActionResult Pagar(string proveedor, string placa)
        {
            if (SessionExpirada())
                return RetornarLogin();

            ReservaService.Reserva reseva = ObtenerReserva();
            ReservaModel model = new ReservaModel();

            model.Origen = reseva.Origen;
            model.Destino = reseva.Destino;
            model.AutoPlaca = placa;

            if (proveedor == "UBER")
            {
                CandidatoModel candidato = candidatoUber(placa);
                model.Precio = candidato.Precio;

                UberDriver uber = obtenerChoferUber(placa);
                model.Conductor = uber.UNombres + ", " + uber.UApellidos;
                model.AutoModelo = uber.UModeloAuto;
                 
            } else if (proveedor == "CABIFY")
            {
                CandidatoModel candidato = candidatoCabify(placa);
                model.Precio = candidato.Precio;

                CabifyDriver cabify = obtenerChoferCabify(placa);
                model.Conductor = cabify.nombres + ", " + cabify.apellidos;
                model.AutoModelo = cabify.automodelo;
            }

            //AsignarReserva(reseva);

            ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
            ClienteService.Tarjeta[] tarjetas = proxy.ListarTarjetaxCliente(ObtenerCliente().DNI);

            model.Tarjetas = tarjetas;

            return View(model);
        }

        [HttpPost]
        public ActionResult Pagar(ReservaModel model)
        {
            return View();
        }

        public ActionResult Tarjeta()
        {
            return View();
        }
    }
}