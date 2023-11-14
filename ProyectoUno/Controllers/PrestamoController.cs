using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoUno.Models;

namespace ProyectoUno.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        public ActionResult IndexPrestamo()
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {
                return View(context.Prestamoes.ToList());
            }
        }

        // GET: Prestamo/Details/5
        public ActionResult DetailsPrestamo(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Prestamoes.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // GET: Prestamo/Create
        public ActionResult CreatePrestamo()
        {
            return View();
        }

        // POST: Prestamo/Create
        [HttpPost]
        public ActionResult CreatePrestamo(Prestamo prestamo)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Prestamoes.Add(prestamo);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexPrestamo");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prestamo/Edit/5
        public ActionResult EditPrestamo(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Prestamoes.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Prestamo/Edit/5
        [HttpPost]
        public ActionResult EditPrestamo(int id, Prestamo prestamo)
        {
            try
            {
                // TODO: Add update logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {
                    context.Entry(prestamo).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }


                return RedirectToAction("IndexPrestamo");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prestamo/Delete/5
        public ActionResult DeletePrestamo(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Prestamoes.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Prestamo/Delete/5
        [HttpPost]
        public ActionResult DeletePrestamo(int id, FormCollection collectio)
        {
            try
            {
                // TODO: Add delete logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
                {

                    Prestamo prestamo = context.Prestamoes.Where(x => x.Cedula == id).FirstOrDefault();
                    context.Prestamoes.Remove(prestamo);
                    context.SaveChanges();

                }

                return RedirectToAction("IndexPrestamo");
            }
            catch
            {
                return View();
            }
        }
    }
}
