using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoUno.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Registro colaboradores";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Acerca de la autoría de este trabajo";

            return View();
        }
    }
}