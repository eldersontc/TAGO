﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TAGO_Presentacion.Models;

namespace TAGO_Presentacion.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Mapa()
        {
            //ViewBag.NombreCliente = ((ClienteService.Cliente)Session["clienteLogueado"]).Nombres;
            return View();
        }

        public ActionResult Elegir(string o, string d)
        {
            string i = Encoding.UTF8.GetString(Convert.FromBase64String(o));
            string f = Encoding.UTF8.GetString(Convert.FromBase64String(d));
            string[] arri = i.Split('|');
            string[] arrf = f.Split('|');
            ViewBag.PO = arri[0];
            ViewBag.PD = arrf[0];
            //ViewBag.NombreCliente = ((ClienteService.Cliente)Session["clienteLogueado"]).Nombres;
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
            
            return View();
        }
    }
}