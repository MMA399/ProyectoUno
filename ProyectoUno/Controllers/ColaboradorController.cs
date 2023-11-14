using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoUno.Models;

namespace ProyectoUno.Controllers
{
    public class ColaboradorController : Controller
    {
        // GET: Colaborador
        public ActionResult IndexColaborador()
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1()) {
                return View(context.Colaboradors.ToList());
            }   
        }

        // GET: Colaborador/Details/5
        public ActionResult DetailsColaborador(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Colaboradors.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // GET: Colaborador/Create
        public ActionResult CreateColaborador()
        {
            return View();
        }

        // POST: Colaborador/Create
        [HttpPost]
        public ActionResult CreateColaborador(Colaborador colaborador)
        {
            try
            {
                // TODO: Add insert logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1()) {
                    context.Colaboradors.Add(colaborador);
                    context.SaveChanges();

                }

                    return RedirectToAction("IndexColaborador");
            }
            catch
            {
                return View();
            }
        }

        // GET: Colaborador/Edit/5
        public ActionResult EditColaborador(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Colaboradors.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Colaborador/Edit/5
        [HttpPost]
        public ActionResult EditColaborador(int id, Colaborador colaborador)
        {
            try
            {
                // TODO: Add update logic here

                using (ProUnoDBEntities1 context = new ProUnoDBEntities1()) {
                    context.Entry(colaborador).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }

                    return RedirectToAction("IndexColaborador");
            }
            catch
            {
                return View();
            }
        }

        // GET: Colaborador/Delete/5
        public ActionResult DeleteColaborador(int id)
        {
            using (ProUnoDBEntities1 context = new ProUnoDBEntities1())
            {

                return View(context.Colaboradors.Where(x => x.Cedula == id).FirstOrDefault());
            }
        }

        // POST: Colaborador/Delete/5
        [HttpPost]
        public ActionResult DeleteColaborador(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (ProUnoDBEntities1 context = new ProUnoDBEntities1()) {

                    Colaborador colaborador = context.Colaboradors.Where(x => x.Cedula == id).FirstOrDefault();
                    context.Colaboradors.Remove(colaborador);
                    context.SaveChanges();

                }

                    return RedirectToAction("IndexColaborador");
            }
            catch
            {
                return View();
            }
        }
    }
}
