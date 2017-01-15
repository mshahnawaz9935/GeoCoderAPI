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
using GeoCoder1.Models;

namespace GeoCoder1.Controllers
{
    public class TownlandsController : ApiController
    {
        private GeoCoderContext db = new GeoCoderContext();

        // GET: api/Townlands
        public IQueryable<Townlands> GetTownlands()
        {
            return db.Townlands;
        }

        // GET: api/Townlands/5
        [ResponseType(typeof(Townlands))]
        public IHttpActionResult GetTownlands(long id)
        {
            Townlands townlands = db.Townlands.Find(id);
            if (townlands == null)
            {
                return NotFound();
            }

            return Ok(townlands);
        }

        // PUT: api/Townlands/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTownlands(long id, Townlands townlands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != townlands.id)
            {
                return BadRequest();
            }

            db.Entry(townlands).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TownlandsExists(id))
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

        // POST: api/Townlands
        [ResponseType(typeof(Townlands))]
        public IHttpActionResult PostTownlands(Townlands townlands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Townlands.Add(townlands);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = townlands.id }, townlands);
        }

        // DELETE: api/Townlands/5
        [ResponseType(typeof(Townlands))]
        public IHttpActionResult DeleteTownlands(long id)
        {
            Townlands townlands = db.Townlands.Find(id);
            if (townlands == null)
            {
                return NotFound();
            }

            db.Townlands.Remove(townlands);
            db.SaveChanges();

            return Ok(townlands);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TownlandsExists(long id)
        {
            return db.Townlands.Count(e => e.id == id) > 0;
        }
    }
}