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
            ViewBag.PhotoMotivacion = "http://www.healthyfithappy.es/s/cc_images/cache_34481916.jpg";
            return View();
        }

        public ActionResult Rutinas()
        {
            ViewBag.Message = "Rutinas.";

            return View();
        }

        public ActionResult Progreso()
        {
            ViewBag.Message = "Progreso.";

            return View();
        }

        public ActionResult MisDatos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Desafio()
        {
            ViewBag.Message = "Desafiaaame.";

            return View();
        }

        public ActionResult Asistencia()
        {
            ViewBag.Message = "ATRASADOOOO COTEEE.";

            return View();
        }      
       

    }
}