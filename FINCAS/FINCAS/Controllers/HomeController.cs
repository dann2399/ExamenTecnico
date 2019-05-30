using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FINCAS.Models;
using FINCAS.FincasServices;

namespace FINCAS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fincas()
        {
            ViewData["Message"] = "LISTADO DE FINCAS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosFincas();

            return View(model);
        }

        public IActionResult CrearFinca(Persona_Asociada persona)
        {
            Console.WriteLine("ok");
            return View();
        }

        public IActionResult Personas_Asoc()
        {
            ViewData["Message"] = "LISTADO DE PERSONAS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosPersonas();
            
            //fincasServices.InsertarDatosFRM(6, "Pablo", "Leon tabares", "primo", 1, "NO");
            //fincasServices.InsertarDatosFRM(7, "Brenda", "Leon tabares", "yerna", 2, "NO");

            return View(model);
            
        }

        public IActionResult Empleados()
        {
            ViewData["Message"] = "LISTADO DE EMPLEADOS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosTrabajadores();

            return View(model);
        }

        public IActionResult Veredas()
        {
            ViewData["Message"] = "LISTADO DE VEREDAS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosVereda();

            return View(model);
        }

        public IActionResult Muni()
        {
            ViewData["Message"] = "LISTADO DE MUNICIPIOS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosMunicipio();

            return View(model);
        }

        public IActionResult Depart()
        {
            ViewData["Message"] = "LISTADO DE DEPARTAMETOS";

            var fincasServices = new FincaServices();
            var model = fincasServices.ObtenerDatosDepart();

            return View(model);
        }

        public IActionResult EditFinca()
        {
            ViewData["Message"] = "LISTADO DE DEPARTAMETOS";
            
            return View();
        }





        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
