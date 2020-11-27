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
    public class EmpAppraisalController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/EmpAppraisal
        public IQueryable<tb_EmpAppraisal> Gettb_EmpAppraisal()
        {
            return db.tb_EmpAppraisal;
        }

        // GET: api/EmpAppraisal/5
        [ResponseType(typeof(tb_EmpAppraisal))]
        public IHttpActionResult Gettb_EmpAppraisal(int id)
        {
            tb_EmpAppraisal tb_EmpAppraisal = db.tb_EmpAppraisal.Find(id);
            if (tb_EmpAppraisal == null)
            {
                return NotFound();
            }

            return Ok(tb_EmpAppraisal);
        }

        // PUT: api/EmpAppraisal/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_EmpAppraisal(int id, tb_EmpAppraisal tb_EmpAppraisal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_EmpAppraisal.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_EmpAppraisal).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmpAppraisalExists(id))
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

        // POST: api/EmpAppraisal
        [ResponseType(typeof(tb_EmpAppraisal))]
        public IHttpActionResult Posttb_EmpAppraisal(tb_EmpAppraisal tb_EmpAppraisal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_EmpAppraisal.Add(tb_EmpAppraisal);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_EmpAppraisal.ID }, tb_EmpAppraisal);
        }

        // DELETE: api/EmpAppraisal/5
        [ResponseType(typeof(tb_EmpAppraisal))]
        public IHttpActionResult Deletetb_EmpAppraisal(int id)
        {
            tb_EmpAppraisal tb_EmpAppraisal = db.tb_EmpAppraisal.Find(id);
            if (tb_EmpAppraisal == null)
            {
                return NotFound();
            }

            db.tb_EmpAppraisal.Remove(tb_EmpAppraisal);
            db.SaveChanges();

            return Ok(tb_EmpAppraisal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmpAppraisalExists(int id)
        {
            return db.tb_EmpAppraisal.Count(e => e.ID == id) > 0;
        }
    }
}