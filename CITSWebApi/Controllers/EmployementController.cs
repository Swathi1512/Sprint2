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
using CITSWebApi.Models;

namespace CITSWebApi.Controllers
{
    public class EmployementController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/Employement
        public IQueryable<tb_Employement> Gettb_Employement()
        {
            return db.tb_Employement;
        }

        // GET: api/Employement/5
        [ResponseType(typeof(tb_Employement))]
        public IHttpActionResult Gettb_Employement(int id)
        {
            tb_Employement tb_Employement = db.tb_Employement.Find(id);
            if (tb_Employement == null)
            {
                return NotFound();
            }

            return Ok(tb_Employement);
        }

        // PUT: api/Employement/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_Employement(int id, tb_Employement tb_Employement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_Employement.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_Employement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmployementExists(id))
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

        // POST: api/Employement
        [ResponseType(typeof(tb_Employement))]
        public IHttpActionResult Posttb_Employement(tb_Employement tb_Employement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_Employement.Add(tb_Employement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_Employement.ID }, tb_Employement);
        }

        // DELETE: api/Employement/5
        [ResponseType(typeof(tb_Employement))]
        public IHttpActionResult Deletetb_Employement(int id)
        {
            tb_Employement tb_Employement = db.tb_Employement.Find(id);
            if (tb_Employement == null)
            {
                return NotFound();
            }

            db.tb_Employement.Remove(tb_Employement);
            db.SaveChanges();

            return Ok(tb_Employement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmployementExists(int id)
        {
            return db.tb_Employement.Count(e => e.ID == id) > 0;
        }
    }
}