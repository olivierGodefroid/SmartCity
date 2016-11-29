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
using Model;

namespace WebApi.Controllers
{
    public class TypeInfrastructuresController : ApiController
    {
        private Context db = new Context();

        // GET: api/TypeInfrastructures
        public IEnumerable<TypeInfrastructure> GetTypeInfrastructures()
        {
            return db.TypeInfrastructures.ToList();
        }

        // GET: api/TypeInfrastructures/5
        [ResponseType(typeof(TypeInfrastructure))]
        public IHttpActionResult GetTypeInfrastructure(long id)
        {
            TypeInfrastructure typeInfrastructure = db.TypeInfrastructures.Find(id);
            if (typeInfrastructure == null)
            {
                return NotFound();
            }

            return Ok(typeInfrastructure);
        }

        // PUT: api/TypeInfrastructures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTypeInfrastructure(long id, TypeInfrastructure typeInfrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeInfrastructure.IdTypeInfrastructure)
            {
                return BadRequest();
            }

            db.Entry(typeInfrastructure).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeInfrastructureExists(id))
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

        // POST: api/TypeInfrastructures
        [ResponseType(typeof(TypeInfrastructure))]
        public IHttpActionResult PostTypeInfrastructure(TypeInfrastructure typeInfrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TypeInfrastructures.Add(typeInfrastructure);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = typeInfrastructure.IdTypeInfrastructure }, typeInfrastructure);
        }

        // DELETE: api/TypeInfrastructures/5
        [ResponseType(typeof(TypeInfrastructure))]
        public IHttpActionResult DeleteTypeInfrastructure(long id)
        {
            TypeInfrastructure typeInfrastructure = db.TypeInfrastructures.Find(id);
            if (typeInfrastructure == null)
            {
                return NotFound();
            }

            db.TypeInfrastructures.Remove(typeInfrastructure);
            db.SaveChanges();

            return Ok(typeInfrastructure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeInfrastructureExists(long id)
        {
            return db.TypeInfrastructures.Count(e => e.IdTypeInfrastructure == id) > 0;
        }
    }
}