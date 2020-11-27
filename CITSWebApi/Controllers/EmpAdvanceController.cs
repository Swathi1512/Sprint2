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
    public class EmpAdvanceController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/EmpAdvance
        public IQueryable<tb_EmpAdvance> Gettb_EmpAdvance()
        {
            return db.tb_EmpAdvance;
        }

        // GET: api/EmpAdvance/5
        [ResponseType(typeof(tb_EmpAdvance))]
        public IHttpActionResult Gettb_EmpAdvance(int id)
        {
            tb_EmpAdvance tb_EmpAdvance = db.tb_EmpAdvance.Find(id);
            if (tb_EmpAdvance == null)
            {
                return NotFound();
            }

            return Ok(tb_EmpAdvance);
        }

        // PUT: api/EmpAdvance/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_EmpAdvance(int id, tb_EmpAdvance tb_EmpAdvance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_EmpAdvance.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_EmpAdvance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmpAdvanceExists(id))
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

        // POST: api/EmpAdvance
        [ResponseType(typeof(tb_EmpAdvance))]
        public IHttpActionResult Posttb_EmpAdvance(tb_EmpAdvance tb_EmpAdvance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_EmpAdvance.Add(tb_EmpAdvance);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_EmpAdvance.ID }, tb_EmpAdvance);
        }

        // DELETE: api/EmpAdvance/5
        [ResponseType(typeof(tb_EmpAdvance))]
        public IHttpActionResult Deletetb_EmpAdvance(int id)
        {
            tb_EmpAdvance tb_EmpAdvance = db.tb_EmpAdvance.Find(id);
            if (tb_EmpAdvance == null)
            {
                return NotFound();
            }

            db.tb_EmpAdvance.Remove(tb_EmpAdvance);
            db.SaveChanges();

            return Ok(tb_EmpAdvance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmpAdvanceExists(int id)
        {
            return db.tb_EmpAdvance.Count(e => e.ID == id) > 0;
        }
    }
}