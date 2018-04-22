using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TAGO_Presentacion.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Mapa()
        {
            //ViewBag.NombreCliente = ((ClienteService.Cliente)Session["clienteLogueado"]).Nombres;
            return View();
        }

        public ActionResult Elegir(string origen, string destino)
        {
            //ViewBag.NombreCliente = ((ClienteService.Cliente)Session["clienteLogueado"]).Nombres;
            return View();
        }
    }
}