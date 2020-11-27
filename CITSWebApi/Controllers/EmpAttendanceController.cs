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
    public class EmpAttendanceController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/EmpAttendance
        public IQueryable<tb_EmpAttendance> Gettb_EmpAttendance()
        {
            return db.tb_EmpAttendance;
        }

        // GET: api/EmpAttendance/5
        [ResponseType(typeof(tb_EmpAttendance))]
        public IHttpActionResult Gettb_EmpAttendance(int id)
        {
            tb_EmpAttendance tb_EmpAttendance = db.tb_EmpAttendance.Find(id);
            if (tb_EmpAttendance == null)
            {
                return NotFound();
            }

            return Ok(tb_EmpAttendance);
        }

        // PUT: api/EmpAttendance/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_EmpAttendance(int id, tb_EmpAttendance tb_EmpAttendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_EmpAttendance.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_EmpAttendance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmpAttendanceExists(id))
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

        // POST: api/EmpAttendance
        [ResponseType(typeof(tb_EmpAttendance))]
        public IHttpActionResult Posttb_EmpAttendance(tb_EmpAttendance tb_EmpAttendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_EmpAttendance.Add(tb_EmpAttendance);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_EmpAttendance.ID }, tb_EmpAttendance);
        }

        // DELETE: api/EmpAttendance/5
        [ResponseType(typeof(tb_EmpAttendance))]
        public IHttpActionResult Deletetb_EmpAttendance(int id)
        {
            tb_EmpAttendance tb_EmpAttendance = db.tb_EmpAttendance.Find(id);
            if (tb_EmpAttendance == null)
            {
                return NotFound();
            }

            db.tb_EmpAttendance.Remove(tb_EmpAttendance);
            db.SaveChanges();

            return Ok(tb_EmpAttendance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmpAttendanceExists(int id)
        {
            return db.tb_EmpAttendance.Count(e => e.ID == id) > 0;
        }
    }
}