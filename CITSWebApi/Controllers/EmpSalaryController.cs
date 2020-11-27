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
    public class EmpSalaryController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/EmpSalary
        public IQueryable<tb_EmpSalary> Gettb_EmpSalary()
        {
            return db.tb_EmpSalary;
        }

        // GET: api/EmpSalary/5
        [ResponseType(typeof(tb_EmpSalary))]
        public IHttpActionResult Gettb_EmpSalary(int id)
        {
            tb_EmpSalary tb_EmpSalary = db.tb_EmpSalary.Find(id);
            if (tb_EmpSalary == null)
            {
                return NotFound();
            }

            return Ok(tb_EmpSalary);
        }

        // PUT: api/EmpSalary/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_EmpSalary(int id, tb_EmpSalary tb_EmpSalary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_EmpSalary.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_EmpSalary).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmpSalaryExists(id))
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

        // POST: api/EmpSalary
        [ResponseType(typeof(tb_EmpSalary))]
        public IHttpActionResult Posttb_EmpSalary(tb_EmpSalary tb_EmpSalary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_EmpSalary.Add(tb_EmpSalary);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_EmpSalary.ID }, tb_EmpSalary);
        }

        // DELETE: api/EmpSalary/5
        [ResponseType(typeof(tb_EmpSalary))]
        public IHttpActionResult Deletetb_EmpSalary(int id)
        {
            tb_EmpSalary tb_EmpSalary = db.tb_EmpSalary.Find(id);
            if (tb_EmpSalary == null)
            {
                return NotFound();
            }

            db.tb_EmpSalary.Remove(tb_EmpSalary);
            db.SaveChanges();

            return Ok(tb_EmpSalary);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmpSalaryExists(int id)
        {
            return db.tb_EmpSalary.Count(e => e.ID == id) > 0;
        }
    }
}