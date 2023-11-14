using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoUno.Models;

namespace ProyectoUno.Controllers
{
    public class DevolucionController : Controller
    {
        // GET: Devolucion
        public ActionResult IndexDevolucion()
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {
                return View(context.Devolucions.ToList());
            }
        }

        // GET: Devolucion/Details/5
        public ActionResult DetailsDevolucion(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Devolucions.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // GET: Devolucion/Create
        public ActionResult CreateDevolucion()
        {
            return View();
        }

        // POST: Devolucion/Create
        [HttpPost]
        public ActionResult CreateDevolucion(Devolucion devolucion)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Devolucions.Add(devolucion);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexDevolucion");
            }
            catch
            {
                return View();
            }
        }

        // GET: Devolucion/Edit/5
        public ActionResult EditDevolucion(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Devolucions.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Devolucion/Edit/5
        [HttpPost]
        public ActionResult EditDevolucion(int id, Devolucion devolucion)
        {
            try
            {
                // TODO: Add update logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Entry(devolucion).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }


                return RedirectToAction("IndexDevolucion");
            }
            catch
            {
                return View();
            }
        }

        // GET: Devolucion/Delete/5
        public ActionResult DeleteDevolucion(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Devolucions.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Devolucion/Delete/5
        [HttpPost]
        public ActionResult DeleteDevolucion(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {

                    Devolucion devolucion = context.Devolucions.Where(x => x.Cedula == id).FirstOrDefault();
                    context.Devolucions.Remove(devolucion);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexDevolucion");
            }
            catch
            {
                return View();
            }
        }
    }
}
