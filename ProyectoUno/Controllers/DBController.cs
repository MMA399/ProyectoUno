using System;
using ProyectoUno.Models;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.Mvc;

namespace ProyectoUno.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult Index()
        {
            //Database
            ProUnoDBEntities1 db = new ProUnoDBEntities1();

            var listUsuarios = db.Colaboradors.ToList();


            return new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = listUsuarios
            };

        }
    }
}