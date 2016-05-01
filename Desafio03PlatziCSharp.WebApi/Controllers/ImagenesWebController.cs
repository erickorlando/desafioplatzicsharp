using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Desafio03PlatziCSharp.WebApi.Models;

namespace Desafio03PlatziCSharp.WebApi.Controllers
{
    public class ImagenesWebController : Controller
    {
        private Desafio03PlatziCSharpWebApiContext db = new Desafio03PlatziCSharpWebApiContext();

        // GET: ImagenesWeb
        public ActionResult Index()
        {
            return View(db.Imagenes.ToList());
        }

        // GET: ImagenesWeb/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagen imagen = db.Imagenes.Find(id);
            if (imagen == null)
            {
                return HttpNotFound();
            }
            return View(imagen);
        }

        // GET: ImagenesWeb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImagenesWeb/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Formato,Ancho,Alto,Nombre,Path")] Imagen imagen)
        {
            if (ModelState.IsValid)
            {
                db.Imagenes.Add(imagen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(imagen);
        }

        // GET: ImagenesWeb/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagen imagen = db.Imagenes.Find(id);
            if (imagen == null)
            {
                return HttpNotFound();
            }
            return View(imagen);
        }

        // POST: ImagenesWeb/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Formato,Ancho,Alto,Nombre,Path")] Imagen imagen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imagen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(imagen);
        }

        // GET: ImagenesWeb/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagen imagen = db.Imagenes.Find(id);
            if (imagen == null)
            {
                return HttpNotFound();
            }
            return View(imagen);
        }

        // POST: ImagenesWeb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Imagen imagen = db.Imagenes.Find(id);
            db.Imagenes.Remove(imagen);
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
