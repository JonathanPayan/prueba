using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biblioteca1.Models;

namespace Biblioteca1.Controllers
{
    public class LIBROController : Controller
    {
        private GESTION_BIBLIOTECAEntities db = new GESTION_BIBLIOTECAEntities();

        // GET: LIBRO
        public ActionResult Index()
        {
            return View(db.LIBRO.ToList());
        }

        // GET: LIBRO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // GET: LIBRO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LIBRO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NOMBRE,AUTOR,GENERO")] LIBRO lIBRO)
        {
            if (ModelState.IsValid)
            {
                db.LIBRO.Add(lIBRO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lIBRO);
        }

        // GET: LIBRO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // POST: LIBRO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NOMBRE,AUTOR,GENERO")] LIBRO lIBRO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lIBRO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lIBRO);
        }

        // GET: LIBRO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // POST: LIBRO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LIBRO lIBRO = db.LIBRO.Find(id);
            db.LIBRO.Remove(lIBRO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
