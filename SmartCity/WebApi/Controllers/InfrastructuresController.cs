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
    public class InfrastructuresController : ApiController
    {
        private Context db = new Context();

        // GET: api/Infrastructures
        public IEnumerable<Infrastructure> GetInfrastructures()
        {
            return db.Infrastructures.ToList();
        }

        // GET: api/Infrastructures/5
        [ResponseType(typeof(Infrastructure))]
        public IHttpActionResult GetInfrastructure(long id)
        {
            Infrastructure infrastructure = db.Infrastructures.Find(id);
            if (infrastructure == null)
            {
                return NotFound();
            }

            return Ok(infrastructure);
        }

        // PUT: api/Infrastructures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInfrastructure(long id, Infrastructure infrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != infrastructure.IdInfrastructure)
            {
                return BadRequest();
            }

            db.Entry(infrastructure).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfrastructureExists(id))
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

        // POST: api/Infrastructures
        [ResponseType(typeof(Infrastructure))]
        public IHttpActionResult PostInfrastructure(Infrastructure infrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Infrastructures.Add(infrastructure);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = infrastructure.IdInfrastructure }, infrastructure);
        }

        // DELETE: api/Infrastructures/5
        [ResponseType(typeof(Infrastructure))]
        public IHttpActionResult DeleteInfrastructure(long id)
        {
            Infrastructure infrastructure = db.Infrastructures.Find(id);
            if (infrastructure == null)
            {
                return NotFound();
            }

            db.Infrastructures.Remove(infrastructure);
            db.SaveChanges();

            return Ok(infrastructure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InfrastructureExists(long id)
        {
            return db.Infrastructures.Count(e => e.IdInfrastructure == id) > 0;
        }
    }
}