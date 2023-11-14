using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoUno.Models;

namespace ProyectoUno.Controllers
{
    public class HerramientaController : Controller
    {
        // GET: Herramienta
        public ActionResult IndexHerramienta()
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {
                return View(context.Herramientas.ToList());
            }
        }

        // GET: Herramienta/Details/5
        public ActionResult DetailsHerramienta(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Herramientas.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // GET: Herramienta/Create
        public ActionResult CreateHerramienta()
        {
            return View();
        }

        // POST: Herramienta/Create
        [HttpPost]
        public ActionResult CreateHerramienta(Herramienta herramienta)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Herramientas.Add(herramienta);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexHerramienta");
            }
            catch
            {
                return View();
            }
        }

        // GET: Herramienta/Edit/5
        public ActionResult EditHerramienta(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Herramientas.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // POST: Herramienta/Edit/5
        [HttpPost]
        public ActionResult EditHerramienta(int id, Herramienta herramienta)
        {
            try
            {
                // TODO: Add update logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Entry(herramienta).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }


                return RedirectToAction("IndexHerramienta");
            }
            catch
            {
                return View();
            }
        }

        // GET: Herramienta/Delete/5
        public ActionResult DeleteHerramienta(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Herramientas.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // POST: Herramienta/Delete/5
        [HttpPost]
        public ActionResult DeleteHerramienta(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {

                    Herramienta herramienta = context.Herramientas.Where(x => x.Codigo == id).FirstOrDefault();
                    context.Herramientas.Remove(herramienta);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexHerramienta");
            }
            catch
            {
                return View();
            }
        }
    }
}
