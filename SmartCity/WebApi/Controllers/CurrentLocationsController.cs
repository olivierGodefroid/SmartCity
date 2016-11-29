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
    public class CurrentLocationsController : ApiController
    {
        private Context db = new Context();

        // GET: api/CurrentLocations
        public IEnumerable<CurrentLocation> GetCurrentLocations()
        {
            return db.CurrentLocations.ToList();
        }

        // GET: api/CurrentLocations/5
        [ResponseType(typeof(CurrentLocation))]
        public IHttpActionResult GetCurrentLocation(long id)
        {
            CurrentLocation currentLocation = db.CurrentLocations.Find(id);
            if (currentLocation == null)
            {
                return NotFound();
            }

            return Ok(currentLocation);
        }

        // PUT: api/CurrentLocations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCurrentLocation(long id, CurrentLocation currentLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currentLocation.IdCurrentLocation)
            {
                return BadRequest();
            }

            db.Entry(currentLocation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrentLocationExists(id))
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

        // POST: api/CurrentLocations
        [ResponseType(typeof(CurrentLocation))]
        public IHttpActionResult PostCurrentLocation(CurrentLocation currentLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CurrentLocations.Add(currentLocation);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CurrentLocationExists(currentLocation.IdCurrentLocation))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = currentLocation.IdCurrentLocation }, currentLocation);
        }

        // DELETE: api/CurrentLocations/5
        [ResponseType(typeof(CurrentLocation))]
        public IHttpActionResult DeleteCurrentLocation(long id)
        {
            CurrentLocation currentLocation = db.CurrentLocations.Find(id);
            if (currentLocation == null)
            {
                return NotFound();
            }

            db.CurrentLocations.Remove(currentLocation);
            db.SaveChanges();

            return Ok(currentLocation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrentLocationExists(long id)
        {
            return db.CurrentLocations.Count(e => e.IdCurrentLocation == id) > 0;
        }
    }
}