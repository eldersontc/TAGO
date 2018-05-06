using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TAGO_Presentacion.Controllers
{
    public class BaseController : Controller
    {
        public void AsignarCliente(ClienteService.Cliente cliente)
        {
            Session["cliente"] = cliente;
        }

        public void AsignarReserva(ReservaService.Reserva reserva)
        {
            Session["reserva"] = reserva;
        }

        public ClienteService.Cliente ObtenerCliente()
        {
            return (ClienteService.Cliente)Session["cliente"];
        }

        public ReservaService.Reserva ObtenerReserva()
        {
            return (ReservaService.Reserva)Session["reserva"];
        }

        public bool SessionExpirada()
        {
            return Session["cliente"] == null;
        }

        public ActionResult RetornarLogin()
        {
            return RedirectToAction("Login", "Auth");
        }
    }
}