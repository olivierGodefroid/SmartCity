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
    public class CategoryInfrastructuresController : ApiController
    {
        private Context db = new Context();

        // GET: api/CategoryInfrastructures
        public IEnumerable<CategoryInfrastructure> GetCategoryInfrastructures()
        {
            return db.CategoryInfrastructures.ToList();
        }

        // GET: api/CategoryInfrastructures/5
        [ResponseType(typeof(CategoryInfrastructure))]
        public IHttpActionResult GetCategoryInfrastructure(long id)
        {
            CategoryInfrastructure categoryInfrastructure = db.CategoryInfrastructures.Find(id);
            if (categoryInfrastructure == null)
            {
                return NotFound();
            }

            return Ok(categoryInfrastructure);
        }

        // PUT: api/CategoryInfrastructures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategoryInfrastructure(long id, CategoryInfrastructure categoryInfrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoryInfrastructure.IdCategoryInfrastructure)
            {
                return BadRequest();
            }

            db.Entry(categoryInfrastructure).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryInfrastructureExists(id))
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

        // POST: api/CategoryInfrastructures
        [ResponseType(typeof(CategoryInfrastructure))]
        public IHttpActionResult PostCategoryInfrastructure(CategoryInfrastructure categoryInfrastructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CategoryInfrastructures.Add(categoryInfrastructure);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = categoryInfrastructure.IdCategoryInfrastructure }, categoryInfrastructure);
        }

        // DELETE: api/CategoryInfrastructures/5
        [ResponseType(typeof(CategoryInfrastructure))]
        public IHttpActionResult DeleteCategoryInfrastructure(long id)
        {
            CategoryInfrastructure categoryInfrastructure = db.CategoryInfrastructures.Find(id);
            if (categoryInfrastructure == null)
            {
                return NotFound();
            }

            db.CategoryInfrastructures.Remove(categoryInfrastructure);
            db.SaveChanges();

            return Ok(categoryInfrastructure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategoryInfrastructureExists(long id)
        {
            return db.CategoryInfrastructures.Count(e => e.IdCategoryInfrastructure == id) > 0;
        }
    }
}