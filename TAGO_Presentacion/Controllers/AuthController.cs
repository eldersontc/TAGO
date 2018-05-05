using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAGO_Presentacion.Models;

namespace TAGO_Presentacion.Controllers
{
    public class AuthController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
                ClienteService.Cliente cliente = proxy.ConsultarClientexEmail(model.Email);
                if (cliente != null && cliente.Password.Equals(model.Password))
                {
                    AsignarCliente(cliente);
                    return RedirectToAction("Mapa", "Manage");
                }
                ModelState.AddModelError("", "El nombre de usuario o la contraseña especificados son incorrectos.");
            }
            return View(model);
        }

        public ActionResult Registro()
        {
            ViewBag.exito = false;
            return View();
        }

        [HttpPost]
        public ActionResult Registro(RegistroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ClienteService.ClienteServiceClient proxy = new ClienteService.ClienteServiceClient();
                    ClienteService.Cliente cliente = proxy.RegistrarCliente(new ClienteService.Cliente
                    {
                        DNI = model.DNI,
                        Nombres = model.Nombres,
                        Apellidos = model.Apellidos,
                        Celular = model.Celular,
                        Email = model.Email,
                        Password = model.Password
                    });
                    ViewBag.exito = true;
                    return View(model);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            ViewBag.exito = false;
            return View(model);
        }
    }
}