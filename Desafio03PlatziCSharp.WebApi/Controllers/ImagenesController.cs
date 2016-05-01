using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Desafio03PlatziCSharp.WebApi.Models;

namespace Desafio03PlatziCSharp.WebApi.Controllers
{
    public class ImagenesController : ApiController
    {
        private Desafio03PlatziCSharpWebApiContext db = new Desafio03PlatziCSharpWebApiContext();

        // GET: api/Imagenes
        public IQueryable<Imagen> GetImagens()
        {
            return db.Imagenes;
        }

        // GET: api/Imagenes/5
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult GetImagen(int id)
        {
            Imagen imagen = db.Imagenes.Find(id);
            if (imagen == null)
            {
                return NotFound();
            }

            return Ok(imagen);
        }

        // PUT: api/Imagenes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImagen(int id, Imagen imagen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imagen.Id)
            {
                return BadRequest();
            }

            db.Entry(imagen).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagenExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Imagenes
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult PostImagen(Imagen imagen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imagenes.Add(imagen);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imagen.Id }, imagen);
        }

        // DELETE: api/Imagenes/5
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult DeleteImagen(int id)
        {
            Imagen imagen = db.Imagenes.Find(id);
            if (imagen == null)
            {
                return NotFound();
            }

            db.Imagenes.Remove(imagen);
            db.SaveChanges();

            return Ok(imagen);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImagenExists(int id)
        {
            return db.Imagenes.Count(e => e.Id == id) > 0;
        }
    }
}