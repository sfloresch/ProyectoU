using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Photo = "http://www.uai.cl/galeria-de-imagenes/image.raw?format=raw&type=orig&id=7290";
            return View();
        }

        public ActionResult Asistencia()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MisDatos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}